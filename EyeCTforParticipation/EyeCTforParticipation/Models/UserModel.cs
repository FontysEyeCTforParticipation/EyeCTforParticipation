using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation.Models
{
    public abstract class UserModel
    {
        string name;
        string email;
        string password;
        int rfid;
        DateTime birthdate;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public int RFID
        {
            get
            {
                return rfid;
            }
            set
            {
                rfid = value;
            }
        }

        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }
            set
            {
                birthdate = value;
            }
        }
    }
}
