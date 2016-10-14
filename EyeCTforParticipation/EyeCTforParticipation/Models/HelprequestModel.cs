using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation.Models
{
    public class HelpRequestModel
    {
        string title;
        UserModel user;
        DateTime date;
        string location;
        int distance;
        int urgency;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public UserModel User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

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

        public int Distance
        {
            get
            {
                return distance;
            }

            set
            {
                distance = value;
            }
        }

        public int Urgency
        {
            get
            {
                return urgency;
            }

            set
            {
                urgency = value;
            }
        }
    }
}
