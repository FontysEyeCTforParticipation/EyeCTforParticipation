using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Data
{
    class ChatMemoryContext : IChatContext
    {
        public void Clear(int chatId)
        {
            throw new NotImplementedException();
        }

        public ChatModel Get(int chatId)
        {
            throw new NotImplementedException();
        }

        public List<ChatModel> List(int userId)
        {
            throw new NotImplementedException();
        }

        public List<ChatModel> ListAsAidWorkerUser(int userId)
        {
            throw new NotImplementedException();
        }

        public List<ChatModel> ListAsHelpSeeker(int userId)
        {
            throw new NotImplementedException();
        }

        public List<ChatModel> ListAsVolunteer(int userId)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(MessageModel message)
        {
            throw new NotImplementedException();
        }
    }
}
