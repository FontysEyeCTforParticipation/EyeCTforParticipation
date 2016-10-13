using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation.Data
{
    public interface IUserContext
    {
        UserModel Login(string rfid);
        UserModel Login(string email, string password);
    }
}
