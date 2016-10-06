using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation
{
    class Volunteer : User
    {
        //fields
        private string location;
        private bool driverslicense;
        private bool car;
        private bool availability;

        //property accessors
        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public bool DriversLicense
        {
            get
            {
                return driverslicense;
            }
            set
            {
                driverslicense = value;
            }
        }

        public bool Car
        {
            get
            {
                return car;
            }
            set
            {
                car = value;
            }
        }
        public bool Availability
        {
            get
            {
                return availability;
            }
            set
            {
                availability = value;
            }
        }

        //constructor
        public Volunteer(string name, string email, string password, int rfid, DateTime dateOfBirth, string location, bool driversLicense, bool car, bool availability) : base(name, email, password, rfid, dateOfBirth)
        {
            Location = location;
            DriversLicense = driversLicense;
            Car = car;
            Availability = availability;
        }
    }
}
