﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCTforParticipation.Controls
{
    public partial class ForgotPasswordControl : UserControl
    {
        public ForgotPasswordControl()
        {
            InitializeComponent();
        }

        public event EventHandler Send;
    }
}