using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Data.MemoryContext
{
    class Tables
    {
        static public List<HelpRequestModel> HelpRequest = new List<HelpRequestModel>();
        static public List<ApplicationModel> Application = new List<ApplicationModel>();
        static public List<MessageModel> Message = new List<MessageModel>();
        static public List<VolunteerModel> Volunteer = new List<VolunteerModel>();
        static public List<UserModel> User = new List<UserModel>();
    }
    class Functions
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
        static public void Clear()
        {
            Tables.HelpRequest.Clear();
            Tables.Application.Clear();
            Tables.Message.Clear();
            Tables.Volunteer.Clear();
            Tables.User.Clear();
        }
    }
}
