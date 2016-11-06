using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCTforParticipation.Controls;
using EyeCTforParticipation.Models;
using EyeCTforParticipation.Logic;
using EyeCTforParticipation.Data;

namespace EyeCTforParticipation.Forms
{
    public partial class MainForm : Form
    {
        HelpRequestRepository helpRequestRepository = new HelpRequestRepository(new HelpRequestMemoryContext());

        public MainForm()
        {
            InitializeComponent();
            header.Login += header_Login;
            header.Logout += header_Logout;
        }

        private void searchControl_Search(object sender, EventArgs e)
        {
            getSearchResults(search.Results);
        }

        private void getSearchResults(List<HelpRequestModel> results)
        {
            resultsWrapper.Controls.Clear();
            foreach (HelpRequestModel result in results)
            {
                HelpRequestDetailControl resultControl = new HelpRequestDetailControl(result);
                resultControl.Dock = DockStyle.Top;
                resultControl.Click += ResultControl_Click;
                resultsWrapper.Controls.Add(new HorizontalSeperatorControl());
                resultsWrapper.Controls.Add(resultControl);
            }
        }

        private void ResultControl_Click(object sender, EventArgs e)
        {
            HelpRequestDetailControl resultControl = (HelpRequestDetailControl)sender;
            helpRequest = new HelpRequestControl(helpRequestRepository.Get(resultControl.Id));
        }

        private void getHelpRequests(List<HelpRequestModel> helpRequests)
        {
            helpRequestsWrapper.Controls.Clear();
            foreach (HelpRequestModel helpRequest in helpRequests)
            {
                HelpRequestDetailControl helpRequestControl = new HelpRequestDetailControl(helpRequest);
                helpRequestControl.Dock = DockStyle.Top;
                helpRequestControl.Click += HelpRequestControl_Click;
                helpRequestsWrapper.Controls.Add(new HorizontalSeperatorControl());
                helpRequestsWrapper.Controls.Add(helpRequestControl);
            }
        }

        private void HelpRequestControl_Click(object sender, EventArgs e)
        {
            HelpRequestDetailControl helpRequestControl = (HelpRequestDetailControl)sender;
            helpRequestView.Controls.Clear();
            HelpRequestControl helpRequest = new HelpRequestControl(helpRequestRepository.Get(helpRequestControl.Id));
            helpRequest.Back += helpRequest_Back;
            helpRequest.Dock = DockStyle.Fill;
            helpRequestView.Controls.Add(helpRequest);
            views.CurrentView = helpRequestView;
        }

        private void helpRequest_Back(object sender, EventArgs e)
        {
            switch (Session.User.Role)
            {
                case UserRole.HelpSeeker:
                    views.CurrentView = helpRequestsManageView;
                    getHelpRequests(helpRequestRepository.GetFromHelpSeeker(Session.User.Id));
                    break;
                case UserRole.Volunteer:
                    views.CurrentView = searchView;
                    break;
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            views.CurrentView = startView;
        }

        private void header_Login(object sender, EventArgs e)
        {
            switch (Session.User.Role)
            {
                case UserRole.HelpSeeker:
                    views.CurrentView = helpSeekerView;
                    break;

            }
        }

        private void header_Logout(object sender, EventArgs e)
        {
            views.CurrentView = startView;
        }

        private void btHelpRequestsManage_Click(object sender, EventArgs e)
        {
            views.CurrentView = helpRequestsManageView;
            getHelpRequests(helpRequestRepository.GetFromHelpSeeker(Session.User.Id));
        }

        private void btHelpRequestsBack_Click(object sender, EventArgs e)
        {
            views.CurrentView = helpSeekerView;
        }

        private void btHelpRequestCreate_Click(object sender, EventArgs e)
        {
            HelpRequestEditForm helpRequestEditForm = new HelpRequestEditForm();
            helpRequestEditForm.FormClosed += HelpRequestEditForm_FormClosed;
            helpRequestEditForm.ShowDialog();
        }

        private void HelpRequestEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            getHelpRequests(helpRequestRepository.GetFromHelpSeeker(Session.User.Id));
        }
    }
}
