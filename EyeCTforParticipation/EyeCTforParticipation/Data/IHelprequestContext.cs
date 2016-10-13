using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Data
{
    public interface IHelprequestContext
    {
        List<HelprequestModel> Search();
        List<HelprequestModel> Search(string keywords);
        List<HelprequestModel> Search(string postalCode, int distance);
        List<HelprequestModel> Search(string keywords, string postalCode, int distance);
    }
}
