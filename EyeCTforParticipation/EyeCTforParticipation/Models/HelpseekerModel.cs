using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation
{
    class HelpseekerModel : UserModel
    {
        //constructor
        public HelpseekerModel(string name, string email, string password, int rfid, DateTime dateOfBirth) : base(name, email, password, rfid, dateOfBirth)
        {

        }
    }
}
