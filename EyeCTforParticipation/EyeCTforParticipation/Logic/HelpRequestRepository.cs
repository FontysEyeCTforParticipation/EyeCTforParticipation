using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Data;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Logic
{
    public class HelprequestRepository
    {
        IHelprequestContext context;

        public HelprequestRepository(IHelprequestContext context)
        {
            this.context = context;
        }

        public List<HelprequestModel> Search()
        {
            return context.Search();
        }

        public List<HelprequestModel> Search(string keywords)
        {
            return context.Search(keywords);
        }

        public List<HelprequestModel> Search(string keywords, string postalCode, int distance)
        {
            return context.Search(keywords, postalCode, distance);
        }

        public List<HelprequestModel> Search(string postalCode, int distance)
        {
            return context.Search(postalCode, distance);
        }
    }
}
