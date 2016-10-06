using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation
{
    class Chat
    {
        //fields
        private string title;
        private List<Message> messages;

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

        public List<Message> Messages
        {
            get
            {
                return messages;
            }

            set
            {
                messages = value;
            }
        }



        //constructor
        public Chat(string title)
        {
            Title = title;
        }
    }
}
