using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Data
{
    class UserMemoryContext : IUserContext
    {
        public UserModel Login(string rfid)
        {
            throw new NotImplementedException();
        }

        public UserModel LoginPassword(string email)
        {
            throw new NotImplementedException();
        }

        public void RegisterAidWorker(UserModel user)
        {
            throw new NotImplementedException();
        }

        public void RegisterHelpSeeker(UserModel user)
        {
            throw new NotImplementedException();
        }

        public void RegisterVolunteer(VolunteerModel volunteer)
        {
            throw new NotImplementedException();
        }
    }
}
