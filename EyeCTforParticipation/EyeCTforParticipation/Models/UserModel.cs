using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation
{
    public abstract class UserModel
    {
        //fields
        private string name;
        private string email;
        private string password;
        private int rfid;
        private DateTime dateofbirth;

        //property accessors
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

        public DateTime DateOfBirth
        {
            get
            {
                return dateofbirth;
            }
            set
            {
                dateofbirth = value;
            }
        }
    }
}
