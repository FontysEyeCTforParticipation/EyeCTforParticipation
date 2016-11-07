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
            string query = @"DELETE Id, UserId, ApplicationId, Message.Content, Message.Date 
                             FROM Messege 
                             Where ApplicationId = @ApplicationId;";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ApplicationId", chatId);
                cmd.ExecuteNonQuery();
            }
        }

        public ChatModel Get(int chatid)
        {
            ChatModel result = null;
            string query = @"SELECT HelpRequest.Title as Title, Application.Status as Status, Messege.Id, Message.UserId, Message.Content, Message.Date  
                             FROM Message 
                             JOIN Application ON Application.Id = Message.ApplicationId 
                             JOIN HelpRequest ON HelpRequest.Id = Application.HelpRequestId  
                             Where Message.ApplicationId = @ApplicationId 
                             ORDER BY Message.Date DESC;";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ApplicationId", chatid);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (result == null)
                        {
                            result = (new ChatModel
                            {
                                Id = chatid,
                                Title = reader.GetString(0),
                                Status = (ApplicationStatus)reader.GetInt32(1),
                                Messages = new List<MessageModel>()
                            });
                        }
                        result.Messages.Add(new MessageModel
                        {
                            Id = reader.GetInt32(2),
                            User = new UserModel
                            {
                                Id = reader.GetInt32(3)
                            },
                            Chat = new ChatModel
                            {
                                Id = chatid
                            },
                            Content = reader.GetString(4),
                            Date = reader.GetDateTime(5)
                        });
                    }
                }
            }
            return result;
        }

        public List<ChatModel> List(int userId)
        {
            List<ChatModel> result = null;
            string query = @"SELECT Application.Id as Id, HelpRequest.Title as Title, Application.Status as Status 
                             FROM Application 
                             JOIN HelpRequest ON HelpRequest.Id = Application.HelpRequestId;"; 
                             
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new ChatModel
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Status = (ApplicationStatus)reader.GetInt32(2)
                        });
                    }
                }
            }
            return result;
        }

        public List<ChatModel> ListAsAidWorkerUser(int userId)
        {
            List<ChatModel> result = null;
            string query = @"SELECT Application.Id as Id, HelpRequest.Title as Title, Application.Status as Status 
                             FROM Application 
                             JOIN HelpRequest ON HelpRequest.Id = Application.HelpRequestId;
                             JOIN HelpSeekerAidWorker ON HelpRequest.HelpSeekerUserId = HelpSeekerAidWorker.HelpSeekerUserId 
                             Where AidWorkerUserId = @AidWorkerUserId;";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@AidWorkerUserId", userId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new ChatModel
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Status = (ApplicationStatus)reader.GetInt32(2)
                        });
                    }
                }
            }
            return result;
        }

        public List<ChatModel> ListAsHelpSeeker(int userId)
        {
            List<ChatModel> result = null;
            string query = @"SELECT Application.Id as Id, HelpRequest.Title as Title, Application.Status as Status 
                             FROM Application 
                             JOIN HelpRequest ON HelpRequest.Id = Application.HelpRequestId 
                             Where HelpSeekerUserId = @HelpSeekerUserId;";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", userId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new ChatModel
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Status = (ApplicationStatus)reader.GetInt32(2)
                        });
                    }
                }
            }
            return result;
        }

        public List<ChatModel> ListAsVolunteer(int userId)
        {
            List<ChatModel> result = null;
            string query = @"SELECT Application.Id as Id, HelpRequest.Title as Title, Application.Status as Status 
                             FROM Application 
                             JOIN HelpRequest ON HelpRequest.Id = Application.HelpRequestId 
                             Where VolunteerId = @VolunteerId;";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@VolunteerId", userId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new ChatModel
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Status = (ApplicationStatus)reader.GetInt32(2)
                        });
                    }
                }
            }
            return result;
        }

        public void SendMessage(MessageModel message)
        {
            throw new NotImplementedException();
        }
    }
}
