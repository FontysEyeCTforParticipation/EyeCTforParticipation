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
            int id;
            string query = "INSERT INTO Review"
                            + "(HelpSeekerUserId, VolunteerId, Content, Date)"
                            + "VALUES (@HelpSeekerUserId, @VolunteerId, @Content, GETDATE());"
                            + "SELECT SCOPE_IDENTITY()";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@HelpSeekerUserId", review.HelpSeeker.Id);
                cmd.Parameters.AddWithValue("@VolunteerId", review.Volunteer.Id);
                cmd.Parameters.AddWithValue("@Content", review.Content);;
                id = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return id;
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReviewModel> GetFromHelpSeeker(int id)
        {
            throw new NotImplementedException();//c
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
