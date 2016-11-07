using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Data
{
    interface IChatContext
    {
        List<ChatModel> List(int userid);
        ChatModel Get(int chatid);
        void Clear(int chatId);
        void SendMessage(MessageModel message);
    }
}
