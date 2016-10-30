using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;
using System.Device.Location;

namespace EyeCTforParticipation.Data
{
    public class HelpRequestXMLContext : IHelpRequestContext
    {
        public List<HelpRequestModel> Search()
        {
            List<HelpRequestModel> results = new List<HelpRequestModel>();
            HelpRequestModel result = new HelpRequestModel
            {
                Id = 1,
                Title = "Example help request",
                Content = "Example",
                Address = "Eindhoven",
                Date = DateTime.Now,
                Distance = 5,
                Urgency = HelpRequestUrgency.NONE
            };
            results.Add(result);

            return results;
        }

        public List<HelpRequestModel> Search(string keywords)
        {
            throw new NotImplementedException();
        }

        public List<HelpRequestModel> SearchByRelevance(string keywords)
        {
            throw new NotImplementedException();
        }

        public List<HelpRequestModel> Search(GeoCoordinate location, int distance)
        {
            throw new NotImplementedException();
        }

        public List<HelpRequestModel> Search(string keywords, GeoCoordinate location, int distance)
        {
            throw new NotImplementedException();
        }

        public List<HelpRequestModel> SearchByRelevance(string keywords, GeoCoordinate location, int distance)
        {
            throw new NotImplementedException();
        }

        public HelpRequestModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public int Create(HelpRequestModel helpRequest)
        {
            throw new NotImplementedException();
        }

        public void Update(HelpRequestModel helpRequest)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Close(int id, int helpSeekerId)
        {
            throw new NotImplementedException();
        }

        public void Open(int id, int helpSeekerId)
        {
            throw new NotImplementedException();
        }

        public int Apply(int id, int volunteerId)
        {
            throw new NotImplementedException();
        }

        public void CancelApplication(int id, int volunteerId)
        {
            throw new NotImplementedException();
        }

        public void CancelApplicationAsHelpSeeker(int id, int userId)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationModel> GetApplications(int volunteerId)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationModel> GetApplications(int id, int helpSeekerId)
        {
            throw new NotImplementedException();
        }

        public void InterviewApplication(int id, int helpSeekerId)
        {
            throw new NotImplementedException();
        }

        public void ApproveApplication(int id, int helpSeekerId)
        {
            throw new NotImplementedException();
        }
    }
}
