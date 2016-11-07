using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCTforParticipation.Logic;
using EyeCTforParticipation.Data;
using EyeCTforParticipation.Models;

namespace EyeCTforParticipation.Controls
{
    public partial class PasswordLoginControl : UserControl
    {
        UserRepository userRepository = new UserRepository(new UserMemoryContext());

        public PasswordLoginControl()
        {
            InitializeComponent();
        }

        public event EventHandler Login;

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text.Length > 0 && tbPassword.Text.Length > 0)
            {
                Session.User = userRepository.Login(tbEmail.Text, tbPassword.Text);
                if (Session.User != null)
                {
                    if (Login != null)
                    {
                        Login(this, EventArgs.Empty);
                    }
                }
            } else
            {
                MessageBox.Show("E-mail en wachtwoord zijn vereist.");
            }
        }
    }
}
