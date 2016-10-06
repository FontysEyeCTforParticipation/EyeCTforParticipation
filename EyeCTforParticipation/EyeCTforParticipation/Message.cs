using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation
{
    class Message
    {
        //fields
        private string content;
        DateTime date;

        //property accessors
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

        //constructor
        public Message(string content, DateTime date)
        {
            Content = content;
            Date = date;
        }
    }
}
