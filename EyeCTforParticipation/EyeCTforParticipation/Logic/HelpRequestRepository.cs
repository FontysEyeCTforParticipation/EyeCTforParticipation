using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Data;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Logic
{
    public class HelpRequestRepository
    {
        IHelpRequestContext context;

        public HelpRequestRepository(IHelpRequestContext context)
        {
            this.context = context;
        }

        public List<HelpRequestModel> Search()
        {
            return context.Search();
        }

        public List<HelpRequestModel> Search(string keywords)
        {
            return context.Search(keywords);
        }

        public List<HelpRequestModel> Search(string postalCode, int distance)
        {
            return context.Search(postalCode, distance);
        }

        public List<HelpRequestModel> Search(string keywords, string postalCode, int distance)
        {
            return context.Search(keywords, postalCode, distance);
        }
    }
}
