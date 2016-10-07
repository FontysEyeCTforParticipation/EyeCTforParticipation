using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation
{
    class ChatModel
    {
        //fields
        private string title;
        private List<MessageModel> messages;

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

        public List<MessageModel> Messages
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
        public ChatModel(string title)
        {
            Title = title;
        }
    }
}
