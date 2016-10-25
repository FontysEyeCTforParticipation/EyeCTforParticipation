using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Data;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Logic
{
    public class ChatRepository
    {
        IChatContext context;

        public ChatRepository(IChatContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Get a list of chats.
        /// </summary>
        /// <param name="userId">
        /// The id of the user that requests the list of chats.
        /// </param>
        /// <returns>
        /// A list of chats for the specific user id.
        /// </returns>
        /// <remarks>
        /// List is based on ChatModel objects with HelpRequestApplication.Id as Id, HelpRequest.Title as Title and HelpRequestApplication.Status as Status.
        /// Different user roles get different lists.
        /// </remarks>
        public List<ChatModel> Get(int userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a chat with a list of messages.
        /// </summary>
        /// <param name="chatId">
        /// The id of the chat.
        /// </param>
        /// <param name="userId">
        /// The id of the user that requests the chat.
        /// </param>
        /// <returns>
        /// A chat with a list of messages.
        /// </returns>
        /// <remarks>
        /// The ChatModel object has HelpRequestApplication.Id as Id, HelpRequest.Title as Title, HelpRequestApplication.Status as Status.
        /// </remarks>
        public ChatModel Get(int chatId, int userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove all messages from the chat.
        /// </summary>
        /// <param name="chatId">
        /// The id of the chat.
        /// </param>
        public void Empty(int chatId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Send a chat message.
        /// </summary>
        /// <param name="message">
        /// The message to be sent.
        /// </param>
        public void SendMessage(MessageModel message)
        {
            throw new NotImplementedException();
        }
    }
}
