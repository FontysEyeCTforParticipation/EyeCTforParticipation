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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            registerControl.Register += new EventHandler(onRegister);
        }

        private void onRegister(object sender, EventArgs e)
        {
            MessageBox.Show("Registered");
            Close();
        }
    }
}
