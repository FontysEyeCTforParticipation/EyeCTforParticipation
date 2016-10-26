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
        public List<HelpRequestModel> Search()
        {
            throw new NotImplementedException();
        }

        public List<HelpRequestModel> Search(string keywords)
        {
            throw new NotImplementedException();
        }

        public List<HelpRequestModel> Search(string postalCode, int distance)
        {
            throw new NotImplementedException();
        }

        public List<HelpRequestModel> Search(string keywords, string postalCode, int distance)
        {
            throw new NotImplementedException();
        }

        public void Create(HelpRequestModel helpRequest)
        {
            string query = "INSERT INTO HelpRequest "
                         + "(HelpSeekerUserId, Title, Content, Date, Address, Location, Urgency) "
                         + "VALUES (@HelpSeekerUserId, @Title, @Content, @Date, @Address, geography::STPointFromText(@Location, 4326), @Urgency)";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@HelpSeekerUserId", helpRequest.HelpSeeker.Id);
                    cmd.Parameters.AddWithValue("@Title", helpRequest.Title);
                    cmd.Parameters.AddWithValue("@Content", helpRequest.Content);
                    cmd.Parameters.AddWithValue("@Date", helpRequest.Date);
                    cmd.Parameters.AddWithValue("@Address", helpRequest.Address);
                    cmd.Parameters.AddWithValue("@Location", "POINT(" + helpRequest.Location.Latitude + " " + helpRequest.Location.Longitude + ")");
                    cmd.Parameters.AddWithValue("@Urgency", (int)helpRequest.Urgency);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
