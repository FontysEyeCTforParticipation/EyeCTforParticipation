using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation.Data
{
    public class HelprequestSQLContext : IHelprequestContext

    {
        public List<HelprequestModel> Search(string zoekterm)
        {
            List<HelprequestModel> searchList = new List<HelprequestModel>();
            //todo
            return searchList;
        }

        public List<HelprequestModel> Search(string postcode, double afstand)
        {
            throw new NotImplementedException();
        }

        public List<HelprequestModel> Search(string zoekterm, string postcode, double afstand)
        {
            throw new NotImplementedException();
        }
    }
}
