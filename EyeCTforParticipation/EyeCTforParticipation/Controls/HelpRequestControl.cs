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
using EyeCTforParticipation.Forms;
using EyeCTforParticipation.Data;

namespace EyeCTforParticipation.Controls
{
    public partial class HelpRequestControl : UserControl
    {
        public EventHandler Back;
        public EventHandler Apply;

        HelpRequestRepository helpRequestRepository = new HelpRequestRepository(new HelpRequestMemoryContext());

        public HelpRequestControl()
        {
            InitializeComponent();
        }

        HelpRequestModel helpRequest;
        
        public HelpRequestControl(HelpRequestModel helpRequest) : this()
        {
            this.helpRequest = helpRequest;
            setContent();

            switch (Session.User.Role)
            {
                case UserRole.HelpSeeker:
                    btApplicationsWrapper.Show();
                    btEditWrapper.Show();
                    break;
                case UserRole.Volunteer:
                    btApplyWrapper.Show();
                    break;
                case UserRole.AidWorker:
                    btApplicationsWrapper.Show();
                    break;
            }
        }

        private void setContent()
        {
            lbTitle.Text = helpRequest.Title;
            lbName.Text = helpRequest.HelpSeeker.Name;
            lbDate.Text = helpRequest.Date.ToString("dd-MM-yyyy");
            lbLocation.Text = helpRequest.Address;
            lbDistance.Text = helpRequest.Distance.ToString() + " km";
            lbContent.Text = helpRequest.Content;
            lbUrgencyLowWrapper.Hide();
            lbUrgencyNormalWrapper.Hide();
            lbUrgencyCrititcalWrapper.Hide();
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

        private void HelpRequestControl_SizeChanged(object sender, EventArgs e)
        {
            lbContent.MaximumSize = new Size(this.Width, 0);
        }

        private void HelpRequestControl_Load(object sender, EventArgs e)
        {
            lbContent.MaximumSize = new Size(this.Width, 0);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            if(Back != null)
            {
                Back(this, EventArgs.Empty);
            }
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            if(Apply != null)
            {
                Apply(this, EventArgs.Empty);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            HelpRequestEditForm editForm = new HelpRequestEditForm(helpRequest);
            editForm.FormClosed += EditForm_FormClosed;
            editForm.ShowDialog();
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            helpRequest = helpRequestRepository.Get(helpRequest.Id);
            setContent();
        }
    }
}
