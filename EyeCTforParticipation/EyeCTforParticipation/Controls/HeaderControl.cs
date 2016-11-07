using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCTforParticipation.Forms;
using EyeCTforParticipation.Logic;

namespace EyeCTforParticipation.Controls
{
    public partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            InitializeComponent();
        }

        public EventHandler Login;
        public EventHandler Register;
        public EventHandler Logout;

        bool loggedIn;

        public bool LoggedIn
        {
            get
            {
                return loggedIn;
            }
            set
            {
                loggedIn = value;
                if(loggedIn == true)
                {
                    setLogin();
                }
                else
                {
                    setLogout();
                }
            }
        }

        private void setLogin()
        {
            btLoginWrapper.Hide();
            btRegisterWrapper.Hide();
            btLogoutWrapper.Show();
            btChatWrapper.Show();
        }

        private void setLogout()
        {
            btLoginWrapper.Show();
            btRegisterWrapper.Show();
            btLogoutWrapper.Hide();
            btChatWrapper.Hide();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Login += LoginForm_Login;
            loginForm.ShowDialog();
        }

        private void LoginForm_Login(object sender, EventArgs e)
        {
            setLogin();
            if(Login != null)
            {
                Login(this, EventArgs.Empty);
            }
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.FormClosed += RegisterForm_FormClosed;
            registerForm.ShowDialog();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Register != null)
            {
                Register(null, EventArgs.Empty);
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            setLogout();
            Session.User = null;
            if(Logout != null)
            {
                Logout(null, EventArgs.Empty);
            }
        }

        private void btChat_Click(object sender, EventArgs e)
        {
            //Open chat form
        }
    }
}
