using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Data;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Logic
{
    public class HelpRequestRepository
    {
        IHelpRequestContext context;

        public HelpRequestRepository(IHelpRequestContext context)
        {
            this.context = context;
        }
        
        /// <summary>
        /// Get a list of helprequests.
        /// </summary>
        /// <returns>
        /// A list of of help requests.
        /// </returns>
        public List<HelpRequestModel> Search()
        {
            return context.Search();
        }

        /// <summary>
        /// Get a list of help requests.
        /// </summary>
        /// <param name="keywords">
        /// Keywords included in search results, keywords are seperated by whitespace.
        /// </param>
        /// <param name="orderByRelevance">
        /// Order results by relevance or date.
        /// </param>
        /// <returns>
        /// A list of help requests.
        /// </returns>
        public List<HelpRequestModel> Search(string keywords, bool orderByRelevance = false)
        {
            // Maximum keywords length is 200
            keywords = keywords.Length > 200 ? keywords.Substring(0, 200) : keywords;

            if(orderByRelevance)
            {
                return context.SearchByRelevance(keywords);
            }
            return context.Search(keywords);
        }

        /// <summary>
        /// Get a list of help requests.
        /// </summary>
        /// <param name="postalCode">
        /// The postal code used as the center of the search area.
        /// </param>
        /// <param name="distance">
        /// The distance used as the radius of the search area.
        /// </param>
        /// <returns>
        /// A list of help requests.
        /// </returns>
        public List<HelpRequestModel> Search(string postalCode, int distance)
        {
            return context.Search(postalCode, distance);
        }

        /// <summary>
        /// Get a list of help requests.
        /// </summary>
        /// <param name="keywords">
        /// Keywords included in search results, keywords are seperated by whitespace.
        /// </param>
        /// <param name="postalCode">
        /// The postal code used as the center of the search area.
        /// </param>
        /// <param name="distance">
        /// The distance used as the radius of the search area.
        /// </param>
        /// <param name="orderByRelevance">
        /// Order results by relevance or date.
        /// </param>
        /// <returns>
        /// A list of help requests.
        /// </returns>
        public List<HelpRequestModel> Search(string keywords, string postalCode, int distance, bool orderByRelevance = false)
        {
            // Maximum keywords length is 200
            keywords = keywords.Length > 200 ? keywords.Substring(0, 200) : keywords;

            if (orderByRelevance)
            {
                return context.SearchByRelevance(keywords, postalCode, distance);
            }
            return context.Search(keywords, postalCode, distance);
        }

        /// <summary>
        /// Get a specific help request.
        /// </summary>
        /// <param name="id">
        /// The id of the help request.
        /// </param>
        /// <returns>
        /// A help request.
        /// </returns>
        public HelpRequestModel Get(int id)
        {
            return context.Get(id);
        }

        /// <summary>
        /// Create a new help request for a specific help seeker if the id is 0.
        /// Else if a help request already exists with the same id, the existing help request will be updated.
        /// </summary>
        /// <param name="helpRequest">
        /// The new or updated help request.
        /// </param>
        /// <returns>
        /// The created or updated help request.
        /// </returns>
        public HelpRequestModel Save(HelpRequestModel helpRequest)
        {
            if (helpRequest.Id == 0)
            {
                helpRequest.Id = context.Create(helpRequest);
            } else
            {
                context.Update(helpRequest);
            }
            return helpRequest;
        }

        /// <summary>
        /// Remove a help request.
        /// </summary>
        /// <param name="id">
        /// The id of the help request to be deleted.
        /// </param>
        /// <remarks>
        /// Messages and applications related to the help request will be deleted too!
        /// </remarks>
        public void Delete(int id)
        {
            context.Delete(id);
        }

        /// <summary>
        /// Close the help request.
        /// The help seeker and volunteer won't be able to continue sending each other messages.
        /// </summary>
        /// <param name="id">
        /// The id of the help request.
        /// </param>
        /// <param name="helpSeekerId">
        /// The id of the help seeker.
        /// </param>
        public void Close(int id, int helpSeekerId)
        {
            context.Close(id, helpSeekerId);
        }

        /// <summary>
        /// Reopen a previously closed help request.
        /// </summary>
        /// <param name="id">
        /// The id of the help request.
        /// </param>
        /// <param name="helpSeekerId">
        /// The id of the help seeker that created the help request.
        /// </param>
        public void Open(int id, int helpSeekerId)
        {
            context.Open(id, helpSeekerId);
        }

        /// <summary>
        /// Apply to a help request as volunteer.
        /// </summary>
        /// <param name="helpRequestId">
        /// The id of the help request the volunteer wants to apply to.
        /// </param>
        /// <param name="volunteerId">
        /// The id of the volunteer that wants to apply.
        /// </param>
        /// <returns>
        /// The application.
        /// </returns>
        public ApplicationModel Apply(int id, int volunteerId)
        {
            return new ApplicationModel
            {
                Id = context.Apply(id, volunteerId),
                HelpRequest = new HelpRequestModel
                {
                    Id = id
                },
                Volunteer = new VolunteerModel
                {
                    Id = volunteerId
                },
                Status = ApplicationStatus.NONE,
                Date = DateTime.Now
            };
        }

        /// <summary>
        /// Cancel the application to a help request.
        /// </summary>
        /// <param name="id">
        /// The id of the application.
        /// </param>
        /// <param name="user">
        /// The user that wants to cancel the application.
        /// The application will only be cancelled if the user is an:
        ///     - Volunteer
        ///         Created the application.
        ///     - Help seeker:
        ///         Created the help request that was applied to.
        /// </param>
        public void CancelApplication(int id, UserModel user)
        {
            switch (user.Role)
            {
                case UserRole.Volunteer:
                    context.CancelApplication(id, user.Id);
                    break;
                case UserRole.HelpSeeker:
                    context.CancelApplicationAsHelpSeeker(id, user.Id);
                    break;
            }
        }

        /// <summary>
        /// Get a list of applications a volunteer made.
        /// </summary>
        /// <param name="volunteerId">
        /// The id of the volunteer.
        /// </param>
        /// <returns>
        /// A list of applications for help requests by the volunteer
        /// </returns>
        public List<ApplicationModel> GetApplications(int volunteerId)
        {
            return context.GetApplications(volunteerId);
        }

        /// <summary>
        /// Get a list of applications for a specific help request.
        /// </summary>
        /// <param name="id">
        /// The id of the help request.
        /// </param>
        /// <param name="helpSeekerId">
        /// The id of the help seeker.
        /// </param>
        /// <returns>
        /// A list of applications for the help request created by the help seeker.
        /// </returns>
        public List<ApplicationModel> GetApplications(int id, int helpSeekerId)
        {
            return context.GetApplications(id, helpSeekerId);
        }

        /// <summary>
        /// Let the volunteer that applied know you're interested.
        /// The help seeker and volunteer will be able to send each other messages in a interview chat.
        /// (Dutch: kennismakingsgesprek)
        /// </summary>
        /// <param name="id">
        /// The id of the application.
        /// </param>
        /// <param name="helpSeekerId">
        /// The id of the help seeker that created the help request that was applied to.
        /// </param>
        public void InterviewApplication(int id, int helpSeekerId)
        {
            context.InterviewApplication(id, helpSeekerId);
        }

        /// <summary>
        /// Approve the volunteer as final choice for the help request.
        /// The help seeker and volunteer will be able to continue sending each other messages in a chat that was previously the interview chat.
        /// </summary>
        /// <param name="applicationId">
        /// The id of the application.
        /// </param>
        /// <param name="helpSeekerId">
        /// The id of the help seeker that created the help request that was applied to.
        /// </param>
        /// <remarks>
        /// A volunteer cannot be approved if there hasn't been a interview chat.
        /// </remarks>
        public void ApproveApplication(int id, int helpSeekerId)
        {
            context.ApproveApplication(id, helpSeekerId);
        }
    }
}
