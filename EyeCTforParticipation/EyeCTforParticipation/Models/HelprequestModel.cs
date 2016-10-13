using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation
{
    public class HelprequestModel
    {
        //fields
        private string title;
        private string content;
        private DateTime date;
        private string location;
        private int urgency;

        //property accessors
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

        //constructor
     //   public HelprequestModel(string title, string content, DateTime date, string location, int urgency)
      //  {
      //      Title = title;
     //       Content = content;
     //       Date = date;
     //       Location = location;
     //       Urgency = urgency;
        }
    }
}
