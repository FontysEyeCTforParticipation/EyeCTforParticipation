using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCTforParticipation.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            passwordLoginControl.Login += new EventHandler(onLogin);
            rfidLoginControl.Login += new EventHandler(onLogin);
        }

        private void onLogin(object sender, EventArgs e)
        {
            MessageBox.Show("Logged in");
            Close();
        }

        private void btPasswordLogin_Click(object sender, EventArgs e)
        {
            views.CurrentView = PasswordLoginView;
        }

        private void btRFIDLogin_Click(object sender, EventArgs e)
        {
            views.CurrentView = RFIDLoginView;
        }

        private void btForgotPassword_Click(object sender, EventArgs e)
        {
            views.CurrentView = ForgotPasswordView;
            btBack.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            views.CurrentView = PasswordLoginView;
            btBack.Hide();
        }
    }
}
