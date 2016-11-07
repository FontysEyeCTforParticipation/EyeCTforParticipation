using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Data
{
    public interface IUserContext
    {
        UserModel Login(string rfid);
        UserModel LoginPassword(string email);
        int Register(UserModel user, bool approved);
        void ApproveRegistration(int userId);
        void Edit(UserModel user);
        void Delete(int userId);
        void AddHelpSeeker(int helpSeekerId, int aidWorkerId);
        void RemoveHelpSeeker(int helpSeekerId, int aidWorkerId);
        void ChangeApproveAidWorker(int helpSeekerId, int aidWorkerId, bool approved);
        List<UserModel> GetHelpSeekers(int aidWorkerId);
        List<UserModel> GetAidWorkers(int HelpSeekerId);
    }
}
