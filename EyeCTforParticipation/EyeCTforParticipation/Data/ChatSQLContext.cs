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
