using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;
using EyeCTforParticipation.Data.MemoryContext;

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

        public List<ChatModel> List()
        {
            var results = from application in Tables.Application
                         join helpRequest in Tables.HelpRequest on application.HelpRequest.Id equals helpRequest.Id
                         select new ChatModel
                         {
                             Id = application.Id,
                             Title = helpRequest.Title,
                             Status = application.Status
                         };
            return results.ToList();
        }

        public List<ChatModel> ListAsAidWorkerUser(int userId)
        {
            var results = from application in Tables.Application
                          join helpRequest in Tables.HelpRequest on application.HelpRequest.Id equals helpRequest.Id
                          select new ChatModel
                          {
                              Id = application.Id,
                              Title = helpRequest.Title,
                              Status = application.Status
                          };
            return results.ToList();
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
