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
        UserModel Login(string email, string password);
    }
}
