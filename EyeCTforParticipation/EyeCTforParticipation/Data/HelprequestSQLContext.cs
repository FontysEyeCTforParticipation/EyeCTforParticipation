using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using EyeCTforParticipation.Models;
using System.Windows.Forms;

namespace EyeCTforParticipation.Data
{
    public class HelpRequestSQLContext : IHelpRequestContext
    {
        public List<HelpRequestModel> Search()  // no idea if this is correct
        {
            List<HelpRequestModel> result = new List<HelpRequestModel>();
            string query = "SELECT Id, HelpSeekerUserId, Title, Content, Date, Address, Location.Lat, Location.Long, Urgency, Closed"
                         + "FROM HelpRequest"
                         + "WHERE Closed = '0'";   
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new HelpRequestModel
                        {
                            Id = reader.GetInt32(0),
                            HelpSeeker = new UserModel //With this I only fill in the Id of the User. 
                            {
                                Id = reader.GetInt32(1)
                            },
                            Title = reader.GetString(2),
                            Content = reader.GetString(3),
                            Date = reader.GetDateTime(4),
                            Address = reader.GetString(5),
                            Location = new System.Device.Location.GeoCoordinate(reader.GetDouble(6), reader.GetDouble(7)),
                            Urgency = (HelpRequestUrgency)reader.GetInt32(8),
                            Closed = reader.GetBoolean(9)
                        });
                    }
                    return result;
                }
            }
        }

        public List<HelpRequestModel> Search(string keywords)  //Keyword is in the Title or in the Content
        {
            List<HelpRequestModel> result = new List<HelpRequestModel>();
            string query = "SELECT Id, HelpSeekerUserId, Title, Content, Date, Address, Location.Lat, Location.Long, Urgency, Closed"
                        + "FROM HelpRequest"
                        + "WHERE Closed = 'false' AND Title LIKE %@keywords%"
                        + "OR Clodes = 'false' AND Content LIKE %@keywords%";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Keywords", keywords);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new HelpRequestModel
                        {
                            Id = reader.GetInt32(0),
                            HelpSeeker = new UserModel //With this I only fill in the Id of the User. 
                            {
                                Id = reader.GetInt32(1)
                            },
                            Title = reader.GetString(2),
                            Content = reader.GetString(3),
                            Date = reader.GetDateTime(4),
                            Address = reader.GetString(5),
                            Location = new System.Device.Location.GeoCoordinate(reader.GetDouble(6), reader.GetDouble(7)),
                            Urgency = (HelpRequestUrgency)reader.GetInt32(8),
                            Closed = reader.GetBoolean(9)
                        });
                    }
                    return result;
                }
            }
        }

        public List<HelpRequestModel> Search(string postalCode, int distance)
        {
            List<HelpRequestModel> result = new List<HelpRequestModel>();
            string query = "SELECT Id, HelpSeekerUserId, Title, Content, Date, Address, Location.Lat, Location.Long, Urgency, Closed"
                         + "FROM HelpRequest"
                         + "WHERE Closed = 'false'";  //We only want helprequests that are open right? 
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {

            }
            return result;
        }

        public List<HelpRequestModel> Search(string keywords, string postalCode, int distance)
        {
            throw new NotImplementedException();
        }

        public HelpRequestModel Get(int id)
        {
            string query = "SELECT HelpSeekerUserId, Title, Content, Date, Address, Location.Lat, Location.Long, Urgency, Closed "
                         + "FROM HelpRequest "
                         + "WHERE Id = @Id";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        return new HelpRequestModel
                        {
                            Id = id,
                            HelpSeeker = new UserModel
                            {
                                Id = reader.GetInt32(0)
                            },
                            Title = reader.GetString(1),
                            Content = reader.GetString(2),
                            Date = reader.GetDateTime(3),
                            Address = reader.GetString(4),
                            Location = new System.Device.Location.GeoCoordinate(reader.GetDouble(5), reader.GetDouble(6)),
                            Urgency = (HelpRequestUrgency)reader.GetInt32(7),
                            Closed = reader.GetBoolean(8)
                        };
                    }
                    return null;
                }
            }
        }

        public int Create(HelpRequestModel helpRequest)
        {
            string query = "INSERT INTO HelpRequest "
                         + "(HelpSeekerUserId, Title, Content, Date, Address, Location, Urgency) "
                         + "VALUES (@HelpSeekerUserId, @Title, @Content, GETDATE(), @Address, geography::STPointFromText(@Location, 4326), @Urgency);"
                         + "SELECT SCOPE_IDENTITY();";
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
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void Update(HelpRequestModel helpRequest)
        {
            string query = "UPDATE HelpRequest "
                         + "SET Title = @Title, Content = @Content, Address = @Address, Location = geography::STPointFromText(@Location, 4326), Urgency = @Urgency "
                         + "WHERE Id = @Id;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", helpRequest.Id);
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
            string query = "DELETE FROM Application "
                         + "WHERE HelpRequestId = @Id;"

                         //Delete messages related to the help request
                         + "DELETE FROM Message "
                         + "WHERE ApplicationId IN ("
                            + "SELECT Id "
                            + "FROM Application "
                            + "WHERE HelpRequestId = @Id"
                         + ");"

                         //Delete help request
                         + "DELETE FROM HelpRequest "
                         + "WHERE Id = @Id;";
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
            string query = "UPDATE HelpRequest "
                         + "SET Closed = 1 "
                         + "WHERE Id = @Id AND HelpSeekerUserId = @HelpSeekerUserId;";
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
            string query = "UPDATE HelpRequest "
                         + "SET Closed = 0 "
                         + "WHERE Id = @Id AND HelpSeekerUserId = @HelpSeekerUserId;";
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
            string query = "INSERT INTO Application "
                         + "(HelpRequestId, VolunteerId, Status, Date) "
                         + "VALUES (@Id, @VolunteerId, @Status, GETDATE());"
                         + "SELECT SCOPE_IDENTITY();";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@VolunteerId", volunteerId);
                cmd.Parameters.AddWithValue("@Status", (int)ApplicationStatus.NONE);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void CancelApplication(int id, int volunteerId)
        {
            string query = "UPDATE Application "
                         + "SET Status = @Status "
                         + "WHERE Id = @Id AND VolunteerId = @VolunteerId;";
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
            string query = "UPDATE Application "
                         + "SET Status = @Status "
                         + "WHERE Id = @Id AND Id IN ("
                             + "SELECT Application.Id "
                             + "FROM Application "
                             + "JOIN HelpRequest ON Application.HelpRequestId = HelpRequest.Id "
                             + "WHERE HelpRequest.HelpSeekerUserId = @HelpSeekerUserId"
                         + ");";
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
            string query = "SELECT Application.Id, HelpRequest.Id, HelpRequest.Title, HelpRequest.Urgency, HelpRequest.Closed, Application.Status, Application.Date "
                         + "FROM Application "
                         + "JOIN HelpRequest ON Application.HelpRequestId = HelpRequest.Id "
                         + "WHERE Application.VolunteerId = @VolunteerId";
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
                    return applications;
                }
            }
        }

        public List<ApplicationModel> GetApplications(int id, int helpSeekerId)
        {
            string query = "SELECT Application.Id, User.Id, User.Name, User.Birthdate, Volunteer.About, Volunteer.DriversLicense, Volunteer.Car, Application.Status, Application.Date "
                         + "FROM Application "
                         + "JOIN Volunteer ON Application.VolunteerId = Volunteer.Id "
                         + "JOIN User ON Application.VolunteerId = User.Id "
                         + "JOIN HelpRequest ON Application.HelpRequestId = HelpRequest.Id "
                         + "WHERE Application.HelpRequestId = @Id AND HelpRequest.HelpSeekerUserId = @HelpSeekerUserId";
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
                    return applications;
                }
            }
        }

        public void InterviewApplication(int id, int helpSeekerId)
        {
            string query = "UPDATE Application "
                         + "SET Status = @Status "
                         + "WHERE Id = @Id AND Id IN ("
                             + "SELECT Application.Id "
                             + "FROM Application "
                             + "JOIN HelpRequest ON Application.HelpRequestId = HelpRequest.Id "
                             + "WHERE HelpRequest.HelpSeekerUserId = @HelpSeekerUserId"
                         + ");";
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
            string query = "UPDATE Application "
                         + "SET Status = @Status "
                         + "WHERE Id = @Id AND Id IN ("
                             + "SELECT Application.Id "
                             + "FROM Application "
                             + "JOIN HelpRequest ON Application.HelpRequestId = HelpRequest.Id "
                             + "WHERE HelpRequest.HelpSeekerUserId = @HelpSeekerUserId"
                         + ");";
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
