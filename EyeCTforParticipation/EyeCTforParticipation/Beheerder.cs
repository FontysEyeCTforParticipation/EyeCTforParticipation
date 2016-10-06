using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation
{
    class Admin : User
    {
        //constructor
        public Admin(string Name, string Email, string Password, int RFID, DateTime DateOfBirth) : base(Name, Email, Password, RFID, DateOfBirth)
        {

        }
    }
}
