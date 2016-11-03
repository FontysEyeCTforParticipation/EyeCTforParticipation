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
        public int create(ReviewModel review)
        {
            throw new NotImplementedException();
        }

        public void delete(int Id)
        {
            // Delete reply related to the Review                     
            string query = "DELETE FROM ReviewReply "
                         + "ReviewId = @Id;"

                         // Delete Review
                         + "DELETE FROM Review "
                         + "WHERE Id = @Id;";

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", Id);
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

        public void update(ReviewModel review)
        {
            throw new NotImplementedException();
        }
    }
}
