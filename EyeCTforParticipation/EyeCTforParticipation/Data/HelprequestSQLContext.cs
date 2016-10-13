using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Data
{
    public class HelprequestSQLContext : IHelprequestContext
    {
        public List<HelprequestModel> Search()
        {
            List<HelprequestModel> results = new List<HelprequestModel>();

            HelprequestModel result = new HelprequestModel();
            result.Title = "Example help request";
            UserModel user = new HelpseekerModel();
            user.Name = "John Doe";
            result.User = user;
            result.Date = DateTime.Now;
            result.Location = "Eindhoven";
            result.Distance = 5;

            for(int x = 0; x < 10; x++)
            {
                results.Add(result);
            }

            return results;
            //throw new NotImplementedException();
        }

        public List<HelprequestModel> Search(string keywords)
        {
            throw new NotImplementedException();
        }

        public List<HelprequestModel> Search(string postalCode, int distance)
        {
            throw new NotImplementedException();
        }

        public List<HelprequestModel> Search(string keywords, string postalCode, int distance)
        {
            throw new NotImplementedException();
        }
    }
}
