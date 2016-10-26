using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Device.Location;

namespace EyeCTforParticipation.Models
{
    public class HelpRequestModel
    {
        int id;
        UserModel helpSeeker;
        string title;
        string content;
        DateTime date;
        string address;
        GeoCoordinate location;
        int distance;
        HelpRequestUrgency urgency;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public UserModel HelpSeeker
        {
            get
            {
                return helpSeeker;
            }

            set
            {
                helpSeeker = value;
            }
        }

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

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
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

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public GeoCoordinate Location
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

        public HelpRequestUrgency Urgency
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
