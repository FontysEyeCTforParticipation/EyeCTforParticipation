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
        UserRepository userRepository = new UserRepository(new UserSQLContext());

        public PasswordLoginControl()
        {
            InitializeComponent();
        }

        public event EventHandler Login;

        private void btLogin_Click(object sender, EventArgs e)
        {
            //user = userRepository.Login("test@test.com", "secret");
            Session.User = new UserModel();
            if (Session.User != null)
            {
                //Succesvol ingelogd
                //Trigger login event
                if (Login != null)
                {
                    Login(this, EventArgs.Empty);
                }
            }
        }
    }
}
