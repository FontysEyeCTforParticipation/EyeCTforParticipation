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

namespace EyeCTforParticipation.Controls
{
    public partial class HelpRequestDetailControl : UserControl
    {
        public HelpRequestDetailControl()
        {
            InitializeComponent();
            WireAllControls(this);
        }
        public HelpRequestDetailControl(HelpRequestModel helpRequest) : this()
        {
            lbTitle.Text = helpRequest.Title;
            lbName.Text = helpRequest.HelpSeeker.Name;
            lbDate.Text = helpRequest.Date.ToString("dd-MM-yyy");
            lbLocation.Text = helpRequest.Address;
            lbDistance.Text = helpRequest.Distance.ToString() + " km";
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
