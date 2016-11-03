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

namespace EyeCTforParticipation.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            helpRequest.Back += helpRequest_Back;
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
            views.CurrentView = resultView;
        }

        private void helpRequest_Back(object sender, EventArgs e)
        {
            views.CurrentView = searchView;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            views.CurrentView = searchView;
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            views.CurrentView = startView;
        }
    }
}
