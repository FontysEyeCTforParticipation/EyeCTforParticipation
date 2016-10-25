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
        UserModel helpSeeker;
        List<UserModel> users;
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

        public List<UserModel> Users
        {
            get
            {
                return users;
            }

            set
            {
                users = value;
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
