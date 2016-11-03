using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation.Models
{
    class MemoryContext
    {
        public class Tables
        {
            static public List<HelpRequestModel> HelpRequest = new List<HelpRequestModel>();
            static public List<ApplicationModel> Application = new List<ApplicationModel>();
            static public List<MessageModel> Message = new List<MessageModel>();
            static public List<VolunteerModel> Volunteer = new List<VolunteerModel>();
            static public List<UserModel> User = new List<UserModel>();
        }
        public class Functions
        {
            static public int KeywordMatches(string text, string keywords, char seperator)
            {
                int matches = 0;
                foreach(string keyword in keywords.Split(seperator))
                {
                    //ToUpper is used to match case insensitive
                    if (text.ToUpper().Contains(keyword.ToUpper()))
                    {
                        matches++;
                    }
                }
                return matches;
            }
        }
    }
}
