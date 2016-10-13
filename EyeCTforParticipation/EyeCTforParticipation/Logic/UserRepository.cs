using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Data;

namespace EyeCTforParticipation.Logic
{
    public class UserRepository
    {
        IUserContext context;
        public UserRepository(IUserContext context)
        {
            this.context = context;
        }
        public bool SendEmail(string email)
        {
            return true; //Email is succesvol verstuurd
        }
        public UserModel Login(string rfid)
        {
            return context.Login(rfid);
        }
        public UserModel Login(string email, string password)
        {
            return context.Login(email, password);
        }
    }
}
