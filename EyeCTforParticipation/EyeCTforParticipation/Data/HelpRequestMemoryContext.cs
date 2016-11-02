using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;
using System.Device.Location;

namespace EyeCTforParticipation.Data
{
    class HelpRequestMemoryContext : IHelpRequestContext
    {
        public List<HelpRequestModel> Search(SearchOrder order)
        {
            var results = from helpRequest in MemoryContext.Tables.HelpRequest
                          orderby
                            order == SearchOrder.DATE_ASC ? helpRequest.Date : default(DateTime),
                            order == SearchOrder.DATE_DESC ? helpRequest.Date : default(DateTime) descending
                          select new HelpRequestModel
                          {
                              Title = helpRequest.Title,
                              Date = helpRequest.Date,
                              Address = helpRequest.Address,
                              Urgency = helpRequest.Urgency
                          };
            return results.ToList();
        }
        
        public List<HelpRequestModel> Search(string keywords, SearchOrder order)
        {
            var results = from helpRequest in MemoryContext.Tables.HelpRequest
                          let matches = MemoryContext.Functions.KeywordMatches(helpRequest.Title + helpRequest.Content, keywords, ' ')
                          where matches > 0
                          orderby
                            order == SearchOrder.DATE_ASC ? helpRequest.Date : default(DateTime),
                            order == SearchOrder.DATE_DESC ? helpRequest.Date : default(DateTime) descending,
                            order == SearchOrder.RELEVANCE_ASC ? matches : 0,
                            order == SearchOrder.RELEVANCE_DESC ? matches : 0 descending
                          select new HelpRequestModel
                          {
                              Title = helpRequest.Title,
                              Date = helpRequest.Date,
                              Address = helpRequest.Address,
                              Urgency = helpRequest.Urgency
                          };
            return results.ToList();
        }

        public List<HelpRequestModel> Search(GeoCoordinate location, int distance, SearchOrder order)
        {
            var results = from helpRequest in MemoryContext.Tables.HelpRequest
                          let getDistance = helpRequest.Location.GetDistanceTo(location)
                          where getDistance <= distance
                          orderby
                            order == SearchOrder.DATE_ASC ? helpRequest.Date : default(DateTime),
                            order == SearchOrder.DATE_DESC ? helpRequest.Date : default(DateTime) descending,
                            order == SearchOrder.DISTANCE_ASC ? getDistance : 0,
                            order == SearchOrder.DISTANCE_DESC ? getDistance : 0 descending
                          select new HelpRequestModel
                          {
                              Title = helpRequest.Title,
                              Date = helpRequest.Date,
                              Address = helpRequest.Address,
                              Urgency = helpRequest.Urgency,
                              Distance = getDistance
                          };
            return results.ToList();
        }

        public List<HelpRequestModel> Search(string keywords, GeoCoordinate location, int distance, SearchOrder order)
        {
            var results = from helpRequest in MemoryContext.Tables.HelpRequest
                          let matches = MemoryContext.Functions.KeywordMatches(helpRequest.Title + helpRequest.Content, keywords, ' ')
                          let getDistance = helpRequest.Location.GetDistanceTo(location)
                          where getDistance <= distance && matches > 0
                          orderby
                            order == SearchOrder.DATE_ASC ? helpRequest.Date : default(DateTime),
                            order == SearchOrder.DATE_DESC ? helpRequest.Date : default(DateTime) descending,
                            order == SearchOrder.DISTANCE_ASC ? getDistance : 0,
                            order == SearchOrder.DISTANCE_DESC ? getDistance : 0 descending,
                            order == SearchOrder.RELEVANCE_ASC ? matches : 0,
                            order == SearchOrder.RELEVANCE_DESC ? matches : 0 descending
                          select new HelpRequestModel
                          {
                              Title = helpRequest.Title,
                              Date = helpRequest.Date,
                              Address = helpRequest.Address,
                              Urgency = helpRequest.Urgency,
                              Distance = getDistance
                          };
            return results.ToList();
        }

        public HelpRequestModel Get(int id)
        {

            var result = from helpRequest in MemoryContext.Tables.HelpRequest
                         where helpRequest.Id == id
                         select new HelpRequestModel
                         {
                            Title = helpRequest.Title,
                            Content = helpRequest.Content,
                            Date = helpRequest.Date,
                            Address = helpRequest.Address,
                            Urgency = helpRequest.Urgency,
                            Closed = helpRequest.Closed
                         };
            return result.Count() > 0 ? result.First() : null;
        }

        public int Create(HelpRequestModel helpRequest)
        {
            helpRequest.Id = MemoryContext.Tables.HelpRequest.Max(x => x.Id) + 1;
            MemoryContext.Tables.HelpRequest.Add(helpRequest);
            return helpRequest.Id;
        }

        public void Update(HelpRequestModel updatedHelpRequest)
        {
            var results = from helpRequest in MemoryContext.Tables.HelpRequest
                          where helpRequest.Id == updatedHelpRequest.Id && helpRequest.HelpSeeker.Id == updatedHelpRequest.HelpSeeker.Id
                          select helpRequest;
            if(results.Count() == 1)
            {
                HelpRequestModel result = results.ElementAt(0);
                result.Title = updatedHelpRequest.Title;
                result.Content = updatedHelpRequest.Content;
                result.Address = updatedHelpRequest.Address;
                result.Urgency = updatedHelpRequest.Urgency;
            }
        }

        public void Delete(int id)
        {
            var applicationResults = from application in MemoryContext.Tables.Application
                                     where application.HelpRequest.Id == id
                                     select application;
            for(int x = 0; x < applicationResults.Count(); x++)
            {
                MemoryContext.Tables.Application.Remove(applicationResults.ElementAt(x));
            }

            var messageResults = from message in MemoryContext.Tables.Message
                                 where MemoryContext.Tables.Application.Any(x => x.HelpRequest.Id == id)
                                 select message;
            for (int x = 0; x < messageResults.Count(); x++)
            {
                MemoryContext.Tables.Message.Remove(messageResults.ElementAt(x));
            }

            var results = from helpRequest in MemoryContext.Tables.HelpRequest
                          where helpRequest.Id == id
                          select helpRequest;
            if(results.Count() == 1)
            {
                MemoryContext.Tables.HelpRequest.Remove(results.ElementAt(0));
            }
        }

        public void Close(int id, int helpSeekerId)
        {
            var results = from helpRequest in MemoryContext.Tables.HelpRequest
                         where helpRequest.Id == id && helpRequest.HelpSeeker.Id == helpSeekerId
                         select helpRequest;
            if (results.Count() == 1)
            {
                results.ElementAt(0).Closed = true;
            }
        }

        public void Open(int id, int helpSeekerId)
        {
            var results = from helpRequest in MemoryContext.Tables.HelpRequest
                          where helpRequest.Id == id && helpRequest.HelpSeeker.Id == helpSeekerId
                          select helpRequest;
            if (results.Count() == 1)
            {
                results.ElementAt(0).Closed = false;
            }
        }

        public int Apply(int id, int volunteerId)
        {
            ApplicationModel application = new ApplicationModel
            {
                Id = MemoryContext.Tables.Application.Max(x => x.Id) + 1,
                Volunteer = new VolunteerModel
                {
                    Id = volunteerId
                },
                Status = ApplicationStatus.NONE,
                Date = DateTime.Now
            };
            MemoryContext.Tables.Application.Add(application);
            return application.Id;
        }

        public void CancelApplication(int id, int volunteerId)
        {
            var results = from application in MemoryContext.Tables.Application
                          where application.Id == id && application.Volunteer.Id == volunteerId
                          select application;
            if (results.Count() == 1)
            {
                results.ElementAt(0).Status = ApplicationStatus.CANCELLED;
            }
        }

        public void CancelApplicationAsHelpSeeker(int id, int userId)
        {
            var results = from application in MemoryContext.Tables.Application
                          join helpRequest in MemoryContext.Tables.HelpRequest on application.HelpRequest.Id equals helpRequest.Id
                          where application.Id == id && helpRequest.HelpSeeker.Id == userId
                          select application;
            if (results.Count() == 1)
            {
                results.ElementAt(0).Status = ApplicationStatus.CANCELLED;
            }
        }

        public List<ApplicationModel> GetApplications(int volunteerId)
        {
            var results = from application in MemoryContext.Tables.Application
                          join helpRequest in MemoryContext.Tables.HelpRequest on application.HelpRequest.Id equals helpRequest.Id
                          where application.Volunteer.Id == volunteerId
                          select new ApplicationModel
                          {
                              Id = application.Id,
                              HelpRequest = new HelpRequestModel
                              {
                                  Id = helpRequest.Id,
                                  Title = helpRequest.Title,
                                  Urgency = helpRequest.Urgency,
                                  Closed = helpRequest.Closed
                              },
                              Status = application.Status,
                              Date = application.Date
                          };
            return results.ToList();
        }

        public List<ApplicationModel> GetApplications(int id, int helpSeekerId)
        {
            var results = from application in MemoryContext.Tables.Application
                          join volunteer in MemoryContext.Tables.Volunteer on application.Volunteer.Id equals volunteer.Id
                          join user in MemoryContext.Tables.User on application.Volunteer.Id equals user.Id
                          join helpRequest in MemoryContext.Tables.HelpRequest on application.HelpRequest.Id equals helpRequest.Id
                          where application.HelpRequest.Id == id && helpRequest.HelpSeeker.Id == helpSeekerId
                          select new ApplicationModel
                          {
                              Id = application.Id,
                              Volunteer = new VolunteerModel
                              {
                                  Id = volunteer.Id,
                                  Name = user.Name,
                                  Birthdate = user.Birthdate,
                                  About = volunteer.About,
                                  DriversLicense = volunteer.DriversLicense,
                                  Car = volunteer.Car
                              },
                              Status = application.Status,
                              Date = application.Date
                          };
            return results.ToList();
        }

        public void InterviewApplication(int id, int helpSeekerId)
        {
            var results = from application in MemoryContext.Tables.Application
                          join helpRequest in MemoryContext.Tables.HelpRequest on application.HelpRequest.Id equals helpRequest.Id
                          where application.Id == id && helpRequest.HelpSeeker.Id == helpSeekerId
                          select application;
            if(results.Count() == 1)
            {
                results.ElementAt(0).Status = ApplicationStatus.INTERVIEW;
            }
        }

        public void ApproveApplication(int id, int helpSeekerId)
        {
            var results = from application in MemoryContext.Tables.Application
                          join helpRequest in MemoryContext.Tables.HelpRequest on application.HelpRequest.Id equals helpRequest.Id
                          where application.Id == id && helpRequest.HelpSeeker.Id == helpSeekerId
                          select application;
            if (results.Count() == 1)
            {
                results.ElementAt(0).Status = ApplicationStatus.APPROVED;
            }
        }
    }
}
