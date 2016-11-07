using System;
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
                    return "Date ASC";
                case SearchOrder.DATE_DESC:
                    return "Date DESC";
                case SearchOrder.DISTANCE_ASC:
                    return "Distance ASC";
                case SearchOrder.DISTANCE_DESC:
                    return "Distance DESC";
                case SearchOrder.RELEVANCE_ASC:
                    return "Matches ASC";
                case SearchOrder.RELEVANCE_DESC:
                default:
                    return "Matches DESC";
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
            string query = @"SELECT [HelpRequest].Id, [HelpRequest].Title, [HelpRequest].Date, [HelpRequest].Address, [HelpRequest].Urgency, [dbo].KeywordMatches([HelpRequest].Title + [HelpRequest].Content, @Keywords, ' ') AS Matches, [User].Name 
                             FROM [HelpRequest] 
                             JOIN [User] ON [HelpRequest].HelpSeekerUserId = [User].Id 
                             WHERE [HelpRequest].Closed = 0 AND Matches > 0 
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
                                Name = reader.GetString(5)
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
            string query = @"SELECT [HelpRequest].Id, Title, Date, Address, Urgency, Location.STDistance(geography::STPointFromText(@Location, 4326)) AS Distance, [User].Name 
                            FROM [HelpRequest] 
                            JOIN [User] ON [HelpRequest].HelpSeekerUserId = [User].Id 
                            WHERE [HelpRequest].Closed = 0 AND (Distance <= @Distance OR @Distance = 0) 
                            ORDER BY " + orderString(order);
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Location", "POINT(" + location.Latitude + " " + location.Longitude + ")");
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
            string query = @"SELECT [HelpRequest].Id, Title, Date, Address, Urgency, [dbo].KeywordMatches(Title + Content, @Keywords, ' ') AS Matches, Location.STDistance(geography::STPointFromText(@Location, 4326)) AS Distance, [User].Name 
                             FROM [HelpRequest] 
                             JOIN [User] ON [HelpRequest].HelpSeekerUserId = [User].Id 
                             WHERE [HelpRequest].Closed = 0 AND Matches > 0 AND (Distance <= @Distance OR @Distance = 0) 
                             ORDER BY " + orderString(order);
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Keywords", keywords);
                cmd.Parameters.AddWithValue("@Location", "POINT(" + location.Latitude + " " + location.Longitude + ")");
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
                             WHERE Id = @Id";
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
            List<HelpRequestModel> results = null;
            string query = @"SELECT [HelpRequest].Id, [HelpRequest].HelpSeekerUserId, [User].Name, [HelpRequest].Title, [HelpRequest].Content, [HelpRequest].Date, [HelpRequest].Address, [HelpRequest].Urgency, [HelpRequest].Closed 
                             FROM [HelpRequest] 
                             JOIN [User] ON [HelpRequest].HelpSeekerUserId = [User].Id 
                             WHERE HelpSeekerUserId = @HelpSeekerUserId;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", userId);
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
                            Closed = reader.GetBoolean(8)
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
                             (HelpSeekerUserId, Title, Content, Date, Address, Location, Urgency) 
                             VALUES (@HelpSeekerUserId, @Title, @Content, GETDATE(), @Address, geography::STPointFromText(@Location, 4326), @Urgency);
                             SELECT SCOPE_IDENTITY();";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", helpRequest.HelpSeeker.Id);
                cmd.Parameters.AddWithValue("@Title", helpRequest.Title);
                cmd.Parameters.AddWithValue("@Content", helpRequest.Content);
                cmd.Parameters.AddWithValue("@Address", helpRequest.Address);
                cmd.Parameters.AddWithValue("@Location", "POINT(" + helpRequest.Location.Latitude + " " + helpRequest.Location.Longitude + ")");
                cmd.Parameters.AddWithValue("@Urgency", (int)helpRequest.Urgency);
                id = (int)cmd.ExecuteScalar();
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
                cmd.Parameters.AddWithValue("@Location", "POINT(" + helpRequest.Location.Latitude + " " + helpRequest.Location.Longitude + ")");
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

        public int Apply(int id, int volunteerId)
        {
            int applicationId;
            string query = @"INSERT INTO [Application] 
                             (HelpRequestId, VolunteerId, Status, Date) 
                             VALUES (@Id, @VolunteerId, @Status, GETDATE());
                             SELECT SCOPE_IDENTITY();";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@VolunteerId", volunteerId);
                cmd.Parameters.AddWithValue("@Status", (int)ApplicationStatus.NONE);
                applicationId = (int)cmd.ExecuteScalar();
            }
            return applicationId;
        }

        public void CancelApplication(int id, int volunteerId)
        {
            string query = @"UPDATE [Application] 
                             SET Status = @Status 
                             WHERE Id = @Id AND VolunteerId = @VolunteerId;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Status", ApplicationStatus.CANCELLED);
                cmd.Parameters.AddWithValue("@VolunteerId", volunteerId);
                cmd.ExecuteNonQuery();
            }
        }

        public void CancelApplicationAsHelpSeeker(int id, int userId)
        {
            string query = @"UPDATE [Application] 
                             SET Status = @Status 
                             WHERE Id = @Id AND Id IN (
                                SELECT [Application].Id 
                                FROM [Application] 
                                JOIN [HelpRequest] ON [Application].HelpRequestId = HelpRequest.Id 
                                WHERE [HelpRequest].HelpSeekerUserId = @HelpSeekerUserId
                             );";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Status", ApplicationStatus.CANCELLED);
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", userId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<ApplicationModel> GetApplications(int volunteerId)
        {
            string query = @"SELECT [Application].Id, [HelpRequest].Id, [HelpRequest].Title, [HelpRequest].Urgency, [HelpRequest].Closed, [Application].Status, [Application].Date 
                             FROM [Application] 
                             JOIN [HelpRequest] ON [Application].HelpRequestId = [HelpRequest].Id 
                             WHERE [Application].VolunteerId = @VolunteerId";
            List<ApplicationModel> applications = new List<ApplicationModel>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@VolunteerId", volunteerId);
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
            string query = @"SELECT [Application].Id, [User].Id, [User].Name, [User].Birthdate, [Volunteer].About, [Volunteer].DriversLicense, [Volunteer].Car, [Application].Status, [Application].Date 
                             FROM [Application] 
                             JOIN [Volunteer] ON [Application].VolunteerId = Volunteer.Id 
                             JOIN [User] ON [Application].VolunteerId = [User].Id 
                             JOIN [HelpRequest] ON [Application].HelpRequestId = [HelpRequest].Id 
                             WHERE [Application].HelpRequestId = @Id AND [HelpRequest].HelpSeekerUserId = @HelpSeekerUserId";
            List<ApplicationModel> applications = new List<ApplicationModel>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", helpSeekerId);
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
                                About = reader.GetString(4),
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

        public void InterviewApplication(int id, int helpSeekerId)
        {
            string query = @"UPDATE [Application] 
                             SET Status = @Status 
                             WHERE Id = @Id AND Id IN (
                                SELECT [Application].Id 
                                FROM [Application] 
                                JOIN [HelpRequest] ON [Application].HelpRequestId = [HelpRequest].Id 
                                WHERE [HelpRequest].HelpSeekerUserId = @HelpSeekerUserId
                             );";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Status", ApplicationStatus.INTERVIEW);
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", helpSeekerId);
                cmd.ExecuteNonQuery();
            }
        }

        public void ApproveApplication(int id, int helpSeekerId)
        {
            string query = @"UPDATE [Application] 
                             SET Status = @Status 
                             WHERE Id = @Id AND Id IN (
                                SELECT [Application].Id 
                                FROM [Application] 
                                JOIN [HelpRequest] ON [Application].HelpRequestId = [HelpRequest].Id 
                                WHERE [HelpRequest].HelpSeekerUserId = @HelpSeekerUserId
                             );";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Status", ApplicationStatus.APPROVED);
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", helpSeekerId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
