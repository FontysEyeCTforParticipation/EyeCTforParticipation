using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Data
{
    public class HelpRequestSQLContext : IHelpRequestContext
    {
        public List<HelpRequestModel> Search()
        {
            List<HelpRequestModel> results = new List<HelpRequestModel>();

            HelpRequestModel result = new HelpRequestModel
            {
                Id = 4543,
                Title = "Example help request",
                HelpSeeker = new UserModel
                {
                    Id = 234,
                    Name = "John Doe"
                },
                Date = DateTime.Now,
                Location = "Eindhoven",
                Distance = 5
            };

            for(int x = 0; x < 10; x++)
            {
                results.Add(result);
            }

            return results;
            //throw new NotImplementedException();
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
    }
}
