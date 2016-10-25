using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCTforParticipation.Models
{
    public class HelpRequestApplicationModel
    {
        int id;
        HelpRequestModel helpRequest;
        VolunteerModel volunteer;
        State status;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public HelpRequestModel HelpRequest
        {
            get
            {
                return helpRequest;
            }

            set
            {
                helpRequest = value;
            }
        }

        internal VolunteerModel Volunteer
        {
            get
            {
                return volunteer;
            }

            set
            {
                volunteer = value;
            }
        }

        public State Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public enum State
        {
            NONE,
            INTERVIEW,
            APPROVED
        }
    }
}
