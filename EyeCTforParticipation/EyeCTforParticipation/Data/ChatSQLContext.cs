using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Data
{
    class ChatSQLContext : IChatContext
    {
        public ChatModel Get(int chatId)
        {
            var result = new ChatModel();
            result.Id = chatId;
            result.Messages = new List<MessageModel>();

            string query = @"
                SELECT Id, UserId, Content, Date FROM Message
            ";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Messages.Add(new MessageModel
                        {
                            Id = reader.GetInt32(0),
                            User = (new UserSQLContext()).Get(reader.GetInt32(1)), // Implement me ffs
                            Chat = result,
                            Date = reader.GetDateTime(3),
                            Content = reader.GetString(2)
                        });
                    }
                }
            }

            return result;
        }

        public List<ChatModel> List(int userid)
        {
            //branch
            // update databasemodel svp
            throw new NotImplementedException();
        }

        public void Purge(int chatId)
        {
            string query = @"DELETE FROM Message WHERE Id = " + chatId.ToString();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                // fuck if I know if this is enough
            }
        }
    }
}
