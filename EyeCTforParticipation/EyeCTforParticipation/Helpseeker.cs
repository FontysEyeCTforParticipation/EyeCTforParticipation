using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation
{
    class Helpseeker : User
    {
        //constructor
        public Helpseeker(string name, string email, string password, int rfid, DateTime dateOfBirth) : base(name, email, password, rfid, dateOfBirth)
        {

        }
    }
}
