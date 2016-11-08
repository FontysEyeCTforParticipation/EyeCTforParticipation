using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace EyeCTforParticipation.Data
{
    class UserSQLContext : IUserContext
    {
        public UserModel Login(string rfid)
        {
            UserModel result = null;
            string query = @"SELECT Id, Role, Name, Approved 
                             FROM [User] 
                             WHERE RFID = @RFID;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@RFID", rfid);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = new UserModel
                        {
                            Id = reader.GetInt32(0),
                            Role = (UserRole)reader.GetInt32(1),
                            Name = reader.GetString(2),
                            Approved = reader.GetBoolean(3)
                        };
                    }
                }
            }
            return result;
        }

        public UserModel LoginPassword(string email)
        {
            UserModel result = null;
            string query = @"SELECT Id, Role, Name, Password, Approved 
                             FROM [User] 
                             WHERE Email = @Email;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Email", email);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result = new UserModel
                        {
                            Id = reader.GetInt32(0),
                            Role = (UserRole)reader.GetInt32(1),
                            Name = reader.GetString(2),
                            Password = reader.GetString(3),
                            Approved = reader.GetBoolean(4)
                        };
                    }
                }
            }
            return result;
        }

        public int Register(UserModel user, bool approved)
        {
            int id;
            string query = @"INSERT INTO [User] 
                             (Role, Email, Name, Password, Birthdate, Approved) 
                             VALUES(@Role, @Email, @Name, @Password, @Birthdate, @Approved); 
                             SELECT SCOPE_IDENTITY();";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Role", (int)user.Role);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Birthdate", user.Birthdate);
                cmd.Parameters.AddWithValue("@Approved", true);
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return id;
        }

        public void ApproveRegistration(int userId)
        {
            string query = @"UPDATE [User]
                            SET Approved = 1
                            WHERE Id = @Id;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", userId);
                cmd.ExecuteNonQuery();
            }
        }
        public void Edit(UserModel user)
        {
            //(Email, Name, Password, Birthdate, Approved)
            string query = @"UPDATE [User] 
                             SET Email = @Email, Name = @Name, Password = @Password, Approved = @Approved 
                             WHERE Id = @Id;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", user.Id);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Approved", user.Approved);
                cmd.ExecuteNonQuery();
            }
        }
        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }
        public void AddHelpSeeker(int helpSeekerId, int aidWorkerId)
        {
            string query = @"INSERT INTO [HelpSeekerAidWorker] 
                             (HelpSeekerUserId, AidWorkerUserId, Approved) 
                             VALUES(@helpSeekerId, @aidWorkerId, 0);";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@helpSeekerId", helpSeekerId);
                cmd.Parameters.AddWithValue("@AidWorkerUserId", aidWorkerId);
            }
        }
        public void RemoveHelpSeeker(int helpSeekerId, int aidWorkerId)
        {
            string query = @"DELETE FROM [HelpSeekerAidWorker] 
                             WHERE HelpSeekerUserId = @helpSeekerId AND AidWorkerUserId = @aidWorkerId;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@helpSeekerId", Convert.ToString(helpSeekerId));
                cmd.Parameters.AddWithValue("@AidWorkerId", Convert.ToString(aidWorkerId));
                cmd.ExecuteNonQuery();
            }
        }
        public void ChangeApproveAidWorker(int helpSeekerId, int aidWorkerID, bool approved)
        {
            int approvedAsInt;
            if (approved)
            {
                approvedAsInt = 1;
            }
            else
            {
                approvedAsInt = 0;
            }
            string query = @"UPDATE [HelpSeekerAidWorker] 
                             SET Approved = @Approved 
                             WHERE HelpSeekerUserId = @helpSeekerId AND AidWorkerUserId = @aidWorkerId;";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@helpSeekerId", Convert.ToString(helpSeekerId));
                cmd.Parameters.AddWithValue("@AidWorkerId", Convert.ToString(aidWorkerID));
                cmd.Parameters.AddWithValue("@Approved", Convert.ToString(approvedAsInt));
                cmd.ExecuteNonQuery();
            }
        }
        public List<UserModel> GetHelpSeekers(int aidWorkerId)
        {
            List<UserModel> results = null;
            string query = @"SELECT [User].Id, [User].Name
                             FROM [User]
                             WHERE User.ID IN (
                                SELECT HelpSeekerUserId
                                FROM [HelpSeekerAidWorker]
                                WHERE AidWorkerUserID = @aidWorkerId
                             );";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@aidWorkerID", Convert.ToString(aidWorkerId));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new UserModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                        });
                    }
                }
            }
            return results;
        }

        public List<UserModel> GetAidWorkers(int helpSeekerId)
        {
            List<UserModel> results = null;
            string query = @"SELECT [User].Id, [User].Name
                             FROM [User] 
                             WHERE User.ID IN (
                                SELECT AidWorkerUserId
                                FROM [HelpSeekerAidWorker]
                                WHERE HelpSeekerUser = @helpSeekerId
                             );";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@helpSeekerId", Convert.ToString(helpSeekerId));
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new UserModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                        });
                    }
                }
            }
            return results;
        }
    }
}
