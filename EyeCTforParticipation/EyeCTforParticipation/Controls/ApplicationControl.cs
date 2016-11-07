using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCTforParticipation.Data;
using EyeCTforParticipation.Logic;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Controls
{
    public partial class ApplicationControl : UserControl
    {
        ApplicationModel application;

        HelpRequestRepository helpRequestRepository = new HelpRequestRepository(new HelpRequestMemoryContext());

        public ApplicationControl()
        {
            InitializeComponent();
        }

        public ApplicationControl(ApplicationModel application) : this()
        {
            this.application = application;
            switch (application.Status)
            {
                case ApplicationStatus.APPROVED:
                    lbApprovedWrapper.Show();
                    btCancel.Show();
                    break;
                case ApplicationStatus.CANCELLED:
                    lbCancelledWrapper.Show();
                    btInterview.Show();
                    break;
                case ApplicationStatus.INTERVIEW:
                    lbInterviewWrapper.Show();
                    btApprove.Show();
                    btCancel.Show();
                    break;
                case ApplicationStatus.NONE:
                    btInterview.Show();
                    break;
            }
            lbName.Text = application.Volunteer.Name;
            lbDate.Text = application.Date.ToString("dd-MM-yyyy");
        }

        private void btInterview_Click(object sender, EventArgs e)
        {
            helpRequestRepository.InterviewApplication(application.Id, Session.User.Id);
            lbCancelledWrapper.Hide();
            lbInterviewWrapper.Show();
            btInterview.Hide();
            btApprove.Show();
            btCancel.Show();
        }

        private void btApprove_Click(object sender, EventArgs e)
        {
            helpRequestRepository.ApproveApplication(application.Id, Session.User.Id);
            lbApprovedWrapper.Show();
            lbInterviewWrapper.Hide();
            btApprove.Hide();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            helpRequestRepository.CancelApplication(application.Id, Session.User);
            lbCancelledWrapper.Show();
            lbApprovedWrapper.Hide();
            lbInterviewWrapper.Hide();
            btApprove.Hide();
            btInterview.Hide();
            btInterview.Show();
            btCancel.Hide();
        }
    }
}
