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
        /// <returns>
        /// A list of help requests.
        /// </returns>
        public List<HelpRequestModel> Search(string keywords)
        {
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
        /// <returns>
        /// A list of help requests.
        /// </returns>
        public List<HelpRequestModel> Search(string keywords, string postalCode, int distance)
        {
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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a new help request for a specific help seeker if the id is null.
        /// Else if a help request already exists with the same id, the existing help request will be updated.
        /// </summary>
        /// <param name="helpRequest">
        /// The new or updated help request.
        /// </param>
        /// <param name="helpSeekerId">
        /// The id of the help seeker.
        /// </param>
        public void Create(HelpRequestModel helpRequest, int helpSeekerId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove a help request.
        /// </summary>
        /// <param name="helpRequestId">
        /// The id of the help request to be deleted.
        /// </param>
        /// <param name="user">
        /// The user that wants to remove the help request.
        /// The help request will only be deleted if the user:
        ///     - Is an Admin.
        ///     - Created the help request.
        ///     - Is an Aid worker who is approved by the help seeker that created the help request.
        /// </param>
        public void Delete(int helpRequestId, UserModel user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Close the help request.
        /// The help seeker and volunteer won't be able to continue sending each other messages.
        /// </summary>
        /// <param name="applicationId">
        /// The id of the help request.
        /// </param>
        /// <param name="user">
        /// The user that wants to close the help request.
        /// The help request will only be closed if the user:
        ///     - Is an Admin.
        ///     - Created the help request.
        ///     - Is an Aid worker who is approved by the help seeker that created the help request.
        /// </param>
        /// <remarks>
        /// A help request cannot be closed if there aren't any applications.
        /// </remarks>
        public void Close(int helpRequestId, UserModel user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reopen a previously closed help request, the help request will be listed as a new help request.
        /// </summary>
        /// <param name="applicationId">
        /// The id of the help request.
        /// </param>
        /// <param name="helpSeekerId">
        /// The id of the help seeker that created the help request.
        /// </param>
        /// <remarks>
        /// A help request cannot reopened if all the applications aren't closed.
        /// </remarks>
        public void Reopen(int helpRequestId, int helpSeekerId)
        {
            throw new NotImplementedException();
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
        public void Apply(int helpRequestId, int volunteerId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cancel the application to a help request.
        /// </summary>
        /// <param name="applicationId">
        /// The id of the application.
        /// </param>
        /// <param name="user">
        /// The user that wants to cancel the application.
        /// The application will only be cancelled if the user created the application.
        /// </param>
        public void CancelApplication(int applicationId, UserModel user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a list of applications for help requests.
        /// </summary>
        /// <param name="user">
        /// The user that wants to get the applications.
        /// </param>
        /// <returns>
        /// If the user is an:
        ///     - Admin:
        ///         A list of all applications.
        ///     - Help seeker:
        ///         A list of applications for the help requests created by the help seeker.
        ///     - Aid worker:
        ///         A list of applications for the help requests created by the help seekers that approved the aid worker.
        /// </returns>
        public List<ApplicationModel> GetApplications(UserModel user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a list of applications for a specific help request.
        /// </summary>
        /// <param name="helpRequestId">
        /// The id of the help request.
        /// </param>
        /// <param name="user">
        /// The user that wants to get the applications.
        /// </param>
        /// <returns>
        /// If the user is an:
        ///     - Admin:
        ///         A list of applications for the help request.
        ///     - Help seeker:
        ///         A list of applications for the help request created by the help seeker.
        ///     - Aid worker:
        ///         A list of applications for the help request created by the help seeker that approved the aidworker.
        /// </returns>
        public List<ApplicationModel> GetApplications(int helpRequestId, UserModel user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Let the volunteer that applied know you're interested.
        /// The help seeker and volunteer will be able to send each other messages in a interview chat.
        /// (Dutch: kennismakingsgesprek)
        /// </summary>
        /// <param name="applicationId">
        /// The id of the application.
        /// </param>
        /// <param name="helpSeekerId">
        /// The id of the help seeker that created the help request that was applied to.
        /// </param>
        public void InterviewApplication(int applicationId, int helpSeekerId)
        {
            throw new NotImplementedException();
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
        public void ApproveApplication(int applicationId, int helpSeekerId)
        {
            throw new NotImplementedException();
        }
    }
}
