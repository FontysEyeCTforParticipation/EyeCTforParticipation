﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCTforParticipation
{
    public partial class LoginRFIDForm : Form
    {
        public LoginRFIDForm()
        {
            InitializeComponent();
        }

        private void btPasswordLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
