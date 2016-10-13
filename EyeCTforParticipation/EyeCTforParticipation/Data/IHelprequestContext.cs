using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation.Data
{
    public interface IHelprequestContext
    {
        List<HelprequestModel> Search(string zoekterm);
        List<HelprequestModel> Search(string zoekterm, string postcode, double afstand);
        List<HelprequestModel> Search(string postcode, double afstand);
    }
}
