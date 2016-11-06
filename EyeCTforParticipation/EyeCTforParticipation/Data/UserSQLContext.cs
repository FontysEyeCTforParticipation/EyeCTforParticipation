﻿using System;
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
                             FROM User 
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
                             FROM User 
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

        public void Register(UserModel user, bool approved)
        {
            string query = @"INSERT INTO User 
                             (Role, Email, Name, Password, Birthdate, Approved) 
                             VALUES(@Role, @Email, @Password, @Birthdate, @Approved);";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Role", user.Role);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Birthdate", user.Birthdate);
                cmd.Parameters.AddWithValue("@Approved", approved);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
