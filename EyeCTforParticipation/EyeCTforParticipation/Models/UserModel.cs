using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation
{
    abstract class UserModel
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

        //constructor
        public UserModel(string name, string email, string password, int rfid, DateTime dateOfBirth)
        {
            Name = name;
            Email = email;
            Password = password;
            RFID = rfid;
            DateOfBirth = dateOfBirth;
        }
    }
}
