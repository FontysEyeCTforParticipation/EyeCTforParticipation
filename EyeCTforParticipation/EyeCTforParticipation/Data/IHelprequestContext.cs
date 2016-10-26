using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Data
{
    public interface IHelpRequestContext
    {
        List<HelpRequestModel> Search();
        List<HelpRequestModel> Search(string keywords);
        List<HelpRequestModel> Search(string postalCode, int distance);
        List<HelpRequestModel> Search(string keywords, string postalCode, int distance);
        void Create(HelpRequestModel helpRequest);
    }
}
