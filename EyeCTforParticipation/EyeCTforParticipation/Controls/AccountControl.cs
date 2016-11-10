using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCTforParticipation.Data;
using EyeCTforParticipation.Logic;
using EyeCTforParticipation.Models;
using System.Diagnostics;

namespace EyeCTforParticipation.Controls
{
    public partial class AccountControl : UserControl
    {
        UserRepository userRepository = new UserRepository(new UserSQLContext());

        int id;

        public AccountControl()
        {
            InitializeComponent();
            CustomFonts.ChangeFonts(Controls, CustomFonts.Families.Roboto);
        }

        public AccountControl(UserModel user) : this()
        {
            switch (user.Role)
            {
                case UserRole.Admin:
                    lbRole.Text = "Admin";
                    break;
                case UserRole.AidWorker:
                    lbRole.Text = "Hulpverlener";
                    break;
                case UserRole.HelpSeeker:
                    lbRole.Text = "Hulpbehoevende";
                    break;
                case UserRole.Volunteer:
                    lbRole.Text = "Vrijwilliger";
                    break;
            }
            lbRequireApprovalWrapper.Visible = !user.Approved;
            btApprove.Visible = !user.Approved;
            lbName.Text = user.Name;
            lbEmail.Text = user.Email;
            id = user.Id;
        }

        private void btApprove_Click(object sender, EventArgs e)
        {
            userRepository.ApproveRegistration(id);
            lbRequireApprovalWrapper.Hide();
            btApprove.Hide();
        }

        private void lbEmail_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:" + lbEmail.Text);
        }

        private void btVOG_Click(object sender, EventArgs e)
        {
            //Show VOG
        }
    }
}
