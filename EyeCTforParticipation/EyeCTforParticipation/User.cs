using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation
{
    abstract class User
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
        public User(string Name, string Email, string Password, int RFID, DateTime DateOfBirth)
        {
            Name = this.Name;
            Email = this.Email;
            Password = this.Password;
            RFID = this.RFID;
            DateOfBirth = this.DateOfBirth;
        }
    }
}
