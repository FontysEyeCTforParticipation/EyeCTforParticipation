using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Data
{
    class ChatSQLContext : IChatContext
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
