using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Data
{
    interface IUserContext
    {
        UserModel Login(string rfid);
        UserModel LoginPassword(string email);
        void Register(UserModel user, bool approved);
    }
}
