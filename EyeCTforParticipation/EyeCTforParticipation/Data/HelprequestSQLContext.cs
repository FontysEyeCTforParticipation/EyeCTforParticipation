﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using EyeCTforParticipation.Models;
using System.Device.Location;

namespace EyeCTforParticipation.Data
{
    class HelpRequestSQLContext : IHelpRequestContext
    {
        string orderString(SearchOrder order)
        {
            switch (order)
            {
                case SearchOrder.DATE_ASC:
                    return "Date DESC";
                case SearchOrder.DATE_DESC:
                    return "Date ASC";
                case SearchOrder.DISTANCE_ASC:
                    return "Distance DESC";
                case SearchOrder.DISTANCE_DESC:
                    return "Distance ASC";
                case SearchOrder.RELEVANCE_ASC:
                    return "Matches DESC";
                case SearchOrder.RELEVANCE_DESC:
                default:
                    return "Matches ASC";
            }
        }

        public List<HelpRequestModel> Search(SearchOrder order) 
        {
            List<HelpRequestModel> results = new List<HelpRequestModel>();
            string query = @"SELECT [HelpRequest].Id, [HelpRequest].Title, [HelpRequest].Date, [HelpRequest].Address, [HelpRequest].Urgency, [User].Name 
                             FROM [HelpRequest] 
                             JOIN [User] ON [HelpRequest].HelpSeekerUserId = [User].Id 
                             WHERE [HelpRequest].Closed = 0 
                             ORDER BY " + orderString(order);
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new HelpRequestModel
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Date = reader.GetDateTime(2),
                            Address = reader.GetString(3),
                            Urgency = (HelpRequestUrgency)reader.GetInt32(4),
                            HelpSeeker = new UserModel
                            {
                                Name = reader.GetString(5)
                            }
                        });
                    }
                }
            }
            return results;
        }

        public List<HelpRequestModel> Search(string keywords, SearchOrder order)
        {
            List<HelpRequestModel> results = new List<HelpRequestModel>();
            string query = @"SELECT * FROM (
                                 SELECT [HelpRequest].Id, [HelpRequest].Title, [HelpRequest].Date, [HelpRequest].Address, [HelpRequest].Urgency, [dbo].KeywordMatches(Title + Content, @Keywords, ' ') AS Matches, [User].Name 
                                 FROM [HelpRequest] 
                                 JOIN [User] ON [HelpRequest].HelpSeekerUserId = [User].Id 
                                 WHERE [HelpRequest].Closed = 0
                             ) h
                             WHERE Matches > 0
                             ORDER BY " + orderString(order);
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Keywords", keywords);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new HelpRequestModel
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Date = reader.GetDateTime(2),
                            Address = reader.GetString(3),
                            Urgency = (HelpRequestUrgency)reader.GetInt32(4),
                            HelpSeeker = new UserModel
                            {
                                Name = reader.GetString(6)
                            }
                        });
                    }
                }
            }
            return results;
        }

        public List<HelpRequestModel> Search(GeoCoordinate location, int distance, SearchOrder order)
        {
            List<HelpRequestModel> results = new List<HelpRequestModel>();
            string query = @"SELECT * FROM (
                                SELECT [HelpRequest].Id, Title, Date, Address, Urgency, Location.STDistance(geography::STPointFromText(@Location, 4326)) AS Distance, [User].Name 
                                FROM [HelpRequest] 
                                JOIN [User] ON [HelpRequest].HelpSeekerUserId = [User].Id 
                                WHERE [HelpRequest].Closed = 0
                             ) h 
                             WHERE (Distance <= @Distance * 1000 OR @Distance = 0)
                             ORDER BY " + orderString(order);
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Location", "POINT(" + location.Longitude + " " + location.Latitude + ")");
                cmd.Parameters.AddWithValue("@Distance", distance);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new HelpRequestModel
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Date = reader.GetDateTime(2),
                            Address = reader.GetString(3),
                            Urgency = (HelpRequestUrgency)reader.GetInt32(4),
                            Distance = reader.GetDouble(5),
                            HelpSeeker = new UserModel
                            {
                                Name = reader.GetString(6)
                            }
                        });
                    }
                }
            }
            return results;
        }
        
        public List<HelpRequestModel> Search(string keywords, GeoCoordinate location, int distance, SearchOrder order)
        {
            List<HelpRequestModel> results = new List<HelpRequestModel>();
            string query = @"SELECT * FROM (
                                 SELECT [HelpRequest].Id, Title, Date, Address, Urgency, [dbo].KeywordMatches(Title + Content, @Keywords, ' ') AS Matches, Location.STDistance(geography::STPointFromText(@Location, 4326)) AS Distance, [User].Name 
                                 FROM [HelpRequest] 
                                 JOIN [User] ON [HelpRequest].HelpSeekerUserId = [User].Id 
                                 WHERE [HelpRequest].Closed = 0
                             ) h
                             WHERE Matches > 0 AND (Distance <= @Distance * 1000 OR @Distance = 0)
                             ORDER BY " + orderString(order);
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Keywords", keywords);
                cmd.Parameters.AddWithValue("@Location", "POINT(" + location.Longitude + " " + location.Latitude + ")");
                cmd.Parameters.AddWithValue("@Distance", distance);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new HelpRequestModel
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            Date = reader.GetDateTime(2),
                            Address = reader.GetString(3),
                            Urgency = (HelpRequestUrgency)reader.GetInt32(4),
                            Distance = reader.GetDouble(6),
                            HelpSeeker = new UserModel
                            {
                                Name = reader.GetString(7)
                            }
                        });
                    }
                }
            }
            return results;
        }

        public HelpRequestModel Get(int id)
        {
            HelpRequestModel result = null;
            string query = @"SELECT [HelpRequest].HelpSeekerUserId, [User].Name, [HelpRequest].Title, [HelpRequest].Content, [HelpRequest].Date, [HelpRequest].Address, [HelpRequest].Urgency, [HelpRequest].Closed 
                             FROM [HelpRequest] 
                             JOIN [User] ON [HelpRequest].HelpSeekerUserId = [User].Id 
                             WHERE [HelpRequest].Id = @Id";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        result = new HelpRequestModel
                        {
                            Id = id,
                            HelpSeeker = new UserModel
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            },
                            Title = reader.GetString(2),
                            Content = reader.GetString(3),
                            Date = reader.GetDateTime(4),
                            Address = reader.GetString(5),
                            Urgency = (HelpRequestUrgency)reader.GetInt32(6),
                            Closed = reader.GetBoolean(7)
                        };
                    }
                }
            }
            return result;
        }
        
        public List<HelpRequestModel> GetFromHelpSeeker(int userId)
        {
            List<HelpRequestModel> results = new List<HelpRequestModel>();
            string query = @"SELECT [HelpRequest].Id, [HelpRequest].HelpSeekerUserId, [User].Name, [HelpRequest].Title, [HelpRequest].Content, [HelpRequest].Date, [HelpRequest].Address, [HelpRequest].Urgency, [HelpRequest].Closed, ApplicationCount
                             FROM [HelpRequest] 
                             LEFT JOIN (
                                SELECT COUNT(*) AS ApplicationCount, [Application].HelpRequestId AS HelpRequestId
                                FROM [Application] 
                                JOIN [HelpRequest] ON [Application].HelpRequestId = [HelpRequest].Id 
                                WHERE [HelpRequest].HelpSeekerUserId = @HelpSeekerUserId AND [Application].Status != @Cancelled
                                GROUP BY [Application].HelpRequestId
                             ) AS ApplicationsCount ON [HelpRequest].Id = ApplicationsCount.HelpRequestId
                             JOIN [User] ON [HelpRequest].HelpSeekerUserId = [User].Id 
                             WHERE [HelpRequest].HelpSeekerUserId = @HelpSeekerUserId;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", userId);
                cmd.Parameters.AddWithValue("@Cancelled", (int)ApplicationStatus.CANCELLED);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new HelpRequestModel
                        {
                            Id = reader.GetInt32(0),
                            HelpSeeker = new UserModel
                            {
                                Id = reader.GetInt32(1),
                                Name = reader.GetString(2)
                            },
                            Title = reader.GetString(3),
                            Content = reader.GetString(4),
                            Date = reader.GetDateTime(5),
                            Address = reader.GetString(6),
                            Urgency = (HelpRequestUrgency)reader.GetInt32(7),
                            Closed = reader.GetBoolean(8),
                            ApplicationsCount = reader.IsDBNull(9) ? 0 : reader.GetInt32(9),
                        });
                    }
                }
            }
            return results;
        }

        public int Create(HelpRequestModel helpRequest)
        {
            int id;
            string query = @"INSERT INTO [HelpRequest] 
                             (HelpSeekerUserId, Title, Content, Date, Address, Location, Urgency, Closed) 
                             VALUES (@HelpSeekerUserId, @Title, @Content, GETDATE(), @Address, geography::STPointFromText(@Location, 4326), @Urgency, 0);
                             SELECT SCOPE_IDENTITY();";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", helpRequest.HelpSeeker.Id);
                cmd.Parameters.AddWithValue("@Title", helpRequest.Title);
                cmd.Parameters.AddWithValue("@Content", helpRequest.Content);
                cmd.Parameters.AddWithValue("@Address", helpRequest.Address);
                cmd.Parameters.AddWithValue("@Location", "POINT(" + helpRequest.Location.Longitude + " " + helpRequest.Location.Latitude + ")");
                cmd.Parameters.AddWithValue("@Urgency", (int)helpRequest.Urgency);
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return id;
        }

        public void Update(HelpRequestModel helpRequest)
        {
            string query = @"UPDATE [HelpRequest] 
                             SET Title = @Title, Content = @Content, Address = @Address, Location = geography::STPointFromText(@Location, 4326), Urgency = @Urgency 
                             WHERE Id = @Id AND HelpSeekerUserId = @HelpSeekerUserId";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", helpRequest.Id);
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", helpRequest.HelpSeeker.Id);
                cmd.Parameters.AddWithValue("@Title", helpRequest.Title);
                cmd.Parameters.AddWithValue("@Content", helpRequest.Content);
                cmd.Parameters.AddWithValue("@Address", helpRequest.Address);
                cmd.Parameters.AddWithValue("@Location", "POINT(" + helpRequest.Location.Longitude + " " + helpRequest.Location.Latitude + ")");
                cmd.Parameters.AddWithValue("@Urgency", (int)helpRequest.Urgency);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {       
                           //Delete applications related to the help request
            string query = @"DELETE FROM [Application] 
                             WHERE HelpRequestId = @Id;"

                           //Delete messages related to the help request
                         + @"DELETE FROM [Message] 
                             WHERE ApplicationId IN (
                                SELECT Id 
                                FROM [Application] 
                                WHERE HelpRequestId = @Id
                             );"

                           //Delete help request
                         + @"DELETE FROM [HelpRequest] 
                             WHERE Id = @Id;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Close(int id, int helpSeekerId)
        {
            string query = @"UPDATE [HelpRequest] 
                             SET Closed = 1 
                             WHERE Id = @Id AND HelpSeekerUserId = @HelpSeekerUserId;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", helpSeekerId);
                cmd.ExecuteNonQuery();
            }
        }

        public void Open(int id, int helpSeekerId)
        {
            string query = @"UPDATE [HelpRequest] 
                             SET Closed = 0 
                             WHERE Id = @Id AND HelpSeekerUserId = @HelpSeekerUserId;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", helpSeekerId);
                cmd.ExecuteNonQuery();
            }
        }

        public void Apply(int id, int volunteerId)
        {
            string query = @"IF NOT EXISTS(
                                SELECT * 
                                FROM [Application] 
                                WHERE HelpRequestId = @HelpRequestId AND VolunteerId = @VolunteerId
                             )
                             BEGIN
                                INSERT INTO [Application] 
                                (HelpRequestId, VolunteerId, Status, Date) 
                                VALUES (@HelpRequestId, @VolunteerId, @Status, GETDATE())
                             END
                             ELSE
                             BEGIN 
                                UPDATE [Application] 
                                SET Status = @Status 
                                WHERE HelpRequestId = @HelpRequestId AND VolunteerId = @VolunteerId 
                             END;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@HelpRequestId", id);
                cmd.Parameters.AddWithValue("@VolunteerId", volunteerId);
                cmd.Parameters.AddWithValue("@Status", (int)ApplicationStatus.NONE);
                cmd.ExecuteNonQuery();
            }
        }

        public void CancelApplication(int id, int volunteerId)
        {
            string query = @"UPDATE [Application] 
                             SET Status = @Status 
                             WHERE HelpRequestId = @HelpRequestId AND VolunteerId = @VolunteerId;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@HelpRequestId", id);
                cmd.Parameters.AddWithValue("@Status", (int)ApplicationStatus.CANCELLED);
                cmd.Parameters.AddWithValue("@VolunteerId", volunteerId);
                cmd.ExecuteNonQuery();
            }
        }

        public void CancelApplicationAsHelpSeeker(int applicationId, int userId)
        {
            string query = @"UPDATE [Application] 
                             SET Status = @Status 
                             WHERE Id = @Id AND Id IN (
                                SELECT [Application].Id 
                                FROM [Application] 
                                JOIN [HelpRequest] ON [Application].HelpRequestId = HelpRequest.Id 
                                WHERE [HelpRequest].HelpSeekerUserId = @HelpSeekerUserId
                             ) AND Status != @Cancelled;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", applicationId);
                cmd.Parameters.AddWithValue("@Status", (int)ApplicationStatus.NONE);
                cmd.Parameters.AddWithValue("@Cancelled", (int)ApplicationStatus.CANCELLED);
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", userId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<ApplicationModel> GetApplications(int volunteerId)
        {
            List<ApplicationModel> applications = new List<ApplicationModel>();
            string query = @"SELECT [Application].Id, [HelpRequest].Id, [HelpRequest].Title, [HelpRequest].Urgency, [HelpRequest].Closed, [Application].Status, [Application].Date 
                             FROM [Application] 
                             JOIN [HelpRequest] ON [Application].HelpRequestId = [HelpRequest].Id 
                             WHERE [Application].VolunteerId = @VolunteerId AND [Application].Status != @Cancelled;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@VolunteerId", volunteerId);
                cmd.Parameters.AddWithValue("@Cancelled", (int)ApplicationStatus.CANCELLED);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        applications.Add(new ApplicationModel
                        {
                            Id = reader.GetInt32(0),
                            HelpRequest = new HelpRequestModel
                            {
                                Id = reader.GetInt32(1),
                                Title = reader.GetString(2),
                                Urgency = (HelpRequestUrgency)reader.GetInt32(3),
                                Closed = reader.GetBoolean(4)
                            },
                            Status = (ApplicationStatus)reader.GetInt32(5),
                            Date = reader.GetDateTime(6)
                        });
                    }
                }
            }
            return applications;
        }

        public List<ApplicationModel> GetApplications(int id, int helpSeekerId)
        {
            List<ApplicationModel> applications = new List<ApplicationModel>();
            string query = @"SELECT [Application].Id, [User].Id, [User].Name, [User].Birthdate, [Volunteer].About, [Volunteer].DriversLicense, [Volunteer].Car, [Application].Status, [Application].Date 
                             FROM [Application] 
                             JOIN [Volunteer] ON [Application].VolunteerId = Volunteer.Id 
                             JOIN [User] ON [Application].VolunteerId = [User].Id 
                             JOIN [HelpRequest] ON [Application].HelpRequestId = [HelpRequest].Id 
                             WHERE [Application].HelpRequestId = @Id AND [HelpRequest].HelpSeekerUserId = @HelpSeekerUserId AND [Application].Status != @Cancelled;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", helpSeekerId);
                cmd.Parameters.AddWithValue("@Cancelled", (int)ApplicationStatus.CANCELLED);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        applications.Add(new ApplicationModel
                        {
                            Id = reader.GetInt32(0),
                            Volunteer = new VolunteerModel
                            {
                                Id = reader.GetInt32(1),
                                Name = reader.GetString(2),
                                Birthdate = reader.GetDateTime(3),
                                About = reader.IsDBNull(4) ? null : reader.GetString(4),
                                DriversLicense = reader.GetBoolean(5),
                                Car = reader.GetBoolean(6)
                            },
                            Status = (ApplicationStatus)reader.GetInt32(7),
                            Date = reader.GetDateTime(8)
                        });
                    }
                }
            }
            return applications;
        }

        public void InterviewApplication(int applicationId, int helpSeekerId)
        {
            string query = @"UPDATE [Application] 
                             SET Status = @Status 
                             WHERE Id = @Id AND Id IN (
                                SELECT [Application].Id 
                                FROM [Application] 
                                JOIN [HelpRequest] ON [Application].HelpRequestId = [HelpRequest].Id 
                                WHERE [HelpRequest].HelpSeekerUserId = @HelpSeekerUserId
                             ) AND [Application].Status != @Cancelled;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", applicationId);
                cmd.Parameters.AddWithValue("@Status", (int)ApplicationStatus.INTERVIEW);
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", helpSeekerId);
                cmd.Parameters.AddWithValue("@Cancelled", (int)ApplicationStatus.CANCELLED);
                cmd.ExecuteNonQuery();
            }
        }

        public void ApproveApplication(int applicationId, int helpSeekerId)
        {
            string query = @"UPDATE [Application] 
                             SET Status = @Status 
                             WHERE Id = @Id AND Id IN (
                                SELECT [Application].Id 
                                FROM [Application] 
                                JOIN [HelpRequest] ON [Application].HelpRequestId = [HelpRequest].Id 
                                WHERE [HelpRequest].HelpSeekerUserId = @HelpSeekerUserId
                             ) AND [Application].Status != @Cancelled;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", applicationId);
                cmd.Parameters.AddWithValue("@Status", (int)ApplicationStatus.APPROVED);
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", helpSeekerId);
                cmd.Parameters.AddWithValue("@Cancelled", (int)ApplicationStatus.CANCELLED);
                cmd.ExecuteNonQuery();
            }
        }

        public int ApplicationsCount(int id, int helpSeekerId)
        {
            int count = 0;
            string query = @"SELECT COUNT(*)
                             FROM [Application] 
                             JOIN [HelpRequest] ON [Application].HelpRequestId = [HelpRequest].Id 
                             WHERE [Application].HelpRequestId = @Id AND [HelpRequest].HelpSeekerUserId = @HelpSeekerUserId AND [Application].Status != @Cancelled;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", helpSeekerId);
                cmd.Parameters.AddWithValue("@Cancelled", (int)ApplicationStatus.CANCELLED);
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return count;
        }

        public bool HasApplied(int id, int volunteerId)
        {
            bool applied = false;
            string query = @"SELECT CAST(COUNT(*) AS BIT)
                             FROM [Application] 
                             WHERE HelpRequestId = @Id AND VolunteerId = @VolunteerId AND Status != @Cancelled;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@VolunteerId", volunteerId);
                cmd.Parameters.AddWithValue("@Cancelled", (int)ApplicationStatus.CANCELLED);
                applied = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            return applied;
        }
    }
}
