using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;
using System.Device.Location;

namespace EyeCTforParticipation.Data
{
    public interface IHelpRequestContext
    {
        List<HelpRequestModel> Search();
        List<HelpRequestModel> Search(string keywords);
        List<HelpRequestModel> SearchByRelevance(string keywords);
        List<HelpRequestModel> Search(GeoCoordinate location, int distance);
        List<HelpRequestModel> Search(string keywords, GeoCoordinate location, int distance);
        List<HelpRequestModel> SearchByRelevance(string keywords, GeoCoordinate location, int distance);
        HelpRequestModel Get(int id);
        int Create(HelpRequestModel helpRequest);
        void Update(HelpRequestModel helpRequest);
        void Delete(int id);
        void Close(int id, int helpSeekerId);
        void Open(int id, int helpSeekerId);
        int Apply(int id, int volunteerId);
        void CancelApplication(int id, int volunteerId);
        void CancelApplicationAsHelpSeeker(int id, int userId);
        List<ApplicationModel> GetApplications(int volunteerId);
        List<ApplicationModel> GetApplications(int id, int helpSeekerId);
        void InterviewApplication(int id, int helpSeekerId);
        void ApproveApplication(int id, int helpSeekerId);
    }
}
