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

        public EventHandler Applications;

        public int Id;

        HelpRequestRepository helpRequestRepository = new HelpRequestRepository(new HelpRequestSQLContext());

        public HelpRequestControl()
        {
            InitializeComponent();
            CustomFonts.ChangeFonts(Controls, CustomFonts.Families.Roboto);
        }

        HelpRequestModel helpRequest;

        public HelpRequestControl(HelpRequestModel helpRequest) : this()
        {
            Id = helpRequest.Id;
            this.helpRequest = helpRequest;
            setContent();

            switch (Session.User.Role)
            {
                case UserRole.HelpSeeker:
                    btApplicationsWrapper.Show();
                    btEditWrapper.Show();
                    btCloseWrapper.Visible = !helpRequest.Closed;
                    btOpenWrapper.Visible = helpRequest.Closed;
                    int applicationCount = helpRequestRepository.ApplicationsCount(helpRequest.Id, Session.User.Id);
                    lbSubtitle.Text = applicationCount.ToString() + (applicationCount > 1 || applicationCount == 0 ? " Aanmeldingen" : " Aanmelding");
                    break;
                case UserRole.Volunteer:
                    bool applied = helpRequestRepository.HasApplied(helpRequest.Id, Session.User.Id);
                    btApplyWrapper.Visible = !applied;
                    btCancelWrapper.Visible = applied;
                    break;
                case UserRole.AidWorker:
                    btApplicationsWrapper.Show();
                    break;
            }
            lbCloseWrapper.Visible = helpRequest.Closed;
        }

        private void setContent()
        {
            lbTitle.Text = helpRequest.Title;
            lbSubtitle.Text = helpRequest.HelpSeeker.Name;
            lbDate.Text = helpRequest.Date.ToString("dd-MM-yyyy");
            lbLocation.Text = helpRequest.Address;
            lbDistance.Text = Math.Round(helpRequest.Distance / 1000).ToString() + " km";
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
            lbTitleWrapper.Controls.SetChildIndex(lbCloseWrapper, 5);
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
            helpRequestRepository.Apply(helpRequest.Id, Session.User.Id);
            bool applied = helpRequestRepository.HasApplied(helpRequest.Id, Session.User.Id);
            Console.Write(applied);
            btCancelWrapper.Show();
            btApplyWrapper.Hide();
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

        private void btClose_Click(object sender, EventArgs e)
        {
            helpRequestRepository.Close(helpRequest.Id, Session.User.Id);
            btCloseWrapper.Hide();
            btOpenWrapper.Show();
            lbCloseWrapper.Show();
            lbTitleWrapper.Controls.SetChildIndex(lbCloseWrapper, 3);
            titleWrapper.Controls.SetChildIndex(btOpenWrapper, 7);
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            helpRequestRepository.Open(helpRequest.Id, Session.User.Id);
            btOpenWrapper.Hide();
            btCloseWrapper.Show();
            lbCloseWrapper.Hide();
            titleWrapper.Controls.SetChildIndex(btCloseWrapper, 7);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            helpRequestRepository.CancelApplication(helpRequest.Id, Session.User);
            btCancelWrapper.Hide();
            btApplyWrapper.Show();
        }

        private void btApplications_Click(object sender, EventArgs e)
        {
            if(Applications != null)
            {
                Applications(this, EventArgs.Empty);
            }
        }
    }
}
