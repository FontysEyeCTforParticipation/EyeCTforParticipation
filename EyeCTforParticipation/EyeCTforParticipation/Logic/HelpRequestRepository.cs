using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Data;

namespace EyeCTforParticipation.Logic
{
    public class HelprequestRepository
    {
        IHelprequestContext context;

        public HelprequestRepository(IHelprequestContext context)
        {
            this.context = context;
        }

        public List<HelprequestModel> Search(string zoekterm)
        {
            return context.Search(zoekterm);
        }

        public List<HelprequestModel> Search(string zoekterm, string postcode, double afstand)
        {
            return context.Search(zoekterm, postcode, afstand);
        }

        public List<HelprequestModel> Search(string postcode, double afstand)
        {
            return context.Search(postcode, afstand);
        }
    }
}
