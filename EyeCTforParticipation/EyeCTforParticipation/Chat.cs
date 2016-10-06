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
        private List<Message> message;

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

        internal User Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }



        //constructor
        public Chat(string title, User author)
        {
            Title = title;
            Author = author;
        }
    }
}
