using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation.Models
{
    public class ChatModel
    {
        int id;
        string title;
        HelpRequestApplicationModel.State status;
        List<MessageModel> messages;

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

        public HelpRequestApplicationModel.State Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
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
    }
}
