using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCTforParticipation.Models;
using EyeCTforParticipation.Logic;

namespace EyeCTforParticipation.Controls
{
    public partial class HelpRequestDetailControl : UserControl
    {
        public HelpRequestDetailControl()
        {
            InitializeComponent();
            CustomFonts.ChangeFonts(Controls, CustomFonts.Families.Roboto);
            WireAllControls(this);
        }

        int id;
        public int Id
        {
            get
            {
                return id;
            }
        }
        public HelpRequestDetailControl(HelpRequestModel helpRequest) : this()
        {
            id = helpRequest.Id;
            lbTitle.Text = helpRequest.Title;
            if(Session.User.Role == UserRole.Volunteer)
            {
                lbSubtitle.Text = helpRequest.HelpSeeker.Name;
            }
            else
            {
                int applicationsCount = helpRequest.ApplicationsCount;
                lbSubtitle.Text = applicationsCount.ToString() + (applicationsCount > 1 || applicationsCount == 0 ? " Aanmeldingen" : " Aanmelding");
            }
            lbDate.Text = helpRequest.Date.ToString("dd-MM-yyyy");
            lbLocation.Text = helpRequest.Address;
            lbDistance.Text = Math.Round(helpRequest.Distance / 1000).ToString() + " km";
            lbDistance.Visible = helpRequest.Distance != 0;
            lbCloseWrapper.Visible = helpRequest.Closed;
            switch (helpRequest.Urgency)
            {
                case HelpRequestUrgency.LOW:
                    lbUrgencyLowWrapper.Show();
                    break;
                case HelpRequestUrgency.NORMAL:
                    lbUrgencyNormalWrapper.Show();
                    break;
                case HelpRequestUrgency.CRITICAL:
                    lbUrgencyCrititcalWrapper.Show();
                    break;
            }
        }

        //<3 Stackoverflow
        //http://stackoverflow.com/questions/16940270/click-event-is-not-firing-when-i-click-a-control-in-dynamic-usercontrol
        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                ctl.Click += ctl_Click;
                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }

        private void ctl_Click(object sender, EventArgs e)
        {
            InvokeOnClick(this, EventArgs.Empty);
        }
    }
}
