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

        public ChatModel Get(int chatid)
        {
            throw new NotImplementedException();
        }

        public List<ChatModel> List(int userid)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(MessageModel message)
        {
            throw new NotImplementedException();
        }
    }
}
