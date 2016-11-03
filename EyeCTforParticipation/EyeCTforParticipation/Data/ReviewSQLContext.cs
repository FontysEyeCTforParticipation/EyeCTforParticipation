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
    class ReviewSQLContext : IReviewContext
    {
        public int Create(ReviewModel review)
        {
            int id;
            string query = @"INSERT INTO Review 
                             (HelpSeekerUserId, VolunteerId, Content, Date) 
                             VALUES (@HelpSeekerUserId, @VolunteerId, @Content, GETDATE()); 
                             SELECT SCOPE_IDENTITY()";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", review.HelpSeeker.Id);
                cmd.Parameters.AddWithValue("@VolunteerId", review.Volunteer.Id);
                cmd.Parameters.AddWithValue("@Content", review.Content); ;
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return id;
        }

        public void Delete(int id)
        {
            // Delete reply related to the Review                     
            string query = @"DELETE FROM ReviewReply 
                             WHERE ReviewId = @Id;"

                           // Delete Review
                         + @"DELETE FROM Review 
                             WHERE Id = @Id;";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteAsHelpSeeker(int id, int userId)
        {
            // Delete reply related to the Review                     
            string query = @"DELETE FROM ReviewReply 
                             WHERE ReviewId = @Id AND ReviewId IN ( 
                                SELECT Id 
                                FROM Review 
                                WHERE HelpSeekerUserId = @HelpSeekerUserId 
                             );"

                           // Delete Review
                         + @"DELETE FROM Review 
                             WHERE Id = @Id AND HelpSeekerUserId = @HelpSeekerUserId;";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", userId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<ReviewModel> GetFromHelpSeeker(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReviewModel> GetFromVolunteer(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(ReviewModel review)
        {
            string query = @"UPDATE Review 
                             SET Content = @Content 
                             WHERE Id = @Id AND HelpSeekerUserId = @HelpSeekerUserId;";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", review.Id);
                cmd.Parameters.AddWithValue("@Content", review.Content);
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", review.HelpSeeker.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void SaveReply(ReviewReplyModel reviewreplymodel)
        {
            string query = @"IF NOT EXISTS(
                                SELECT *
                                FROM ReviewReply
                                WHERE ReviewId = @Id
                             )
                             BEGIN
                                IF EXISTS(
                                    SELECT *
                                    FROM Review
                                    WHERE Id = @Id AND VolunteerId = @VolunteerId
                                )
                                BEGIN
                                    INSERT INTO ReviewReply (ReviewId, Content, Date)
                                    VALUES (@Id, @Content, GETDATE())
                                END
                             ELSE
                             BEGIN
                                UPDATE ReviewReply
                                SET Content = @Content 
                                WHERE ReviewId = @Id AND ReviewId IN (
                                    SELECT Id
                                    FROM Review
                                    WHERE VolunteerId = @VolunteerId
                                )
                             END";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", reviewreplymodel.Review);
                cmd.Parameters.AddWithValue("@Content", reviewreplymodel.Content);
                cmd.Parameters.AddWithValue("@VolunteerId", reviewreplymodel.Review.Volunteer.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteReply(int id)
        {
            string query = @"DELETE FROM ReviewReply 
                             WHERE ReviewId = @ReviewId;";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@ReviewId", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteReplyVolunteer(int id)
        {
            string query = @"DELETE FROM ReviewReply  
                             WHERE ReviewId = (
                             SELECT Id 
                             FROM Review 
                             WHERE VolunteerId = @VolunteerId;" ;

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@volunteerId", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
