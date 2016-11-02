﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;
using System.Device.Location;

namespace EyeCTforParticipation.Data
{
    public class HelpRequestMemoryContext : IHelpRequestContext
    {
        static List<HelpRequestModel> helpRequests = new List<HelpRequestModel>();

        public List<HelpRequestModel> Search(SearchOrder order)
        {
            List<HelpRequestModel> results = helpRequests;
            return results;
        }
        
        public List<HelpRequestModel> Search(string keywords, SearchOrder order)
        {
            throw new NotImplementedException();
        }

        public List<HelpRequestModel> Search(GeoCoordinate location, int distance, SearchOrder order)
        {
            throw new NotImplementedException();
        }

        public List<HelpRequestModel> Search(string keywords, GeoCoordinate location, int distance, SearchOrder order)
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
