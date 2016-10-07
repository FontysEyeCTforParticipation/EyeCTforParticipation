using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btPasswordLogin_Click(object sender, EventArgs e)
        {
            views.CurrentView = LoginView;
        }

        private void btRFIDLogin_Click(object sender, EventArgs e)
        {
            views.CurrentView = RFIDLoginView;
        }
    }
}
