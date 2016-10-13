using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Data
{
    public class UserSQLContext : IUserContext
    {
        public UserModel Login(string rfid)
        {
            throw new NotImplementedException();
        }

        public UserModel Login(string email, string password)
        {
            //Voer sql code uit en indien gebruiker bestaat en een aidworker is:
            AidworkerModel aidworker = new AidworkerModel();
            aidworker.Email = "test@test.com";
            return aidworker;
            //Indien gebruiker niet bestaat:
            return null;
        }
    }
}
