using System;
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
    public partial class RegisterControl : UserControl
    {
        public RegisterControl()
        {
            InitializeComponent();

            Dictionary<int, string> cbRoles = new Dictionary<int, string>();
            cbRoles.Add(1, "Hulpbehoevende");
            cbRoles.Add(2, "Vrijwilliger");
            cbRoles.Add(3, "Hulpverlener");
            cbRole.DataSource = new BindingSource(cbRoles, null);
            cbRole.DisplayMember = "Value";
            cbRole.ValueMember = "Key";

            DateTime maxBirthdate = DateTime.Now.AddYears(-18);
            dtBirthdate.Value = maxBirthdate;
            dtBirthdate.MaxDate = maxBirthdate;

            dtBirthdate.CustomFormat = " ";
        }

        public event EventHandler Register;

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            checkEmailMatch();
        }

        private void tbEmailRepeat_TextChanged(object sender, EventArgs e)
        {
            checkEmailMatch();
        }

        private void checkEmailMatch()
        {
            lbEmailMismatch.Visible = tbEmail.Text != tbEmailRepeat.Text;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            checkpasswordMatch();
        }

        private void tbPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            checkpasswordMatch();
        }

        private void checkpasswordMatch()
        {
            lbPasswordMismatch.Visible = tbPassword.Text != tbPasswordRepeat.Text;
        }

        private void dtBirthdate_ValueChanged(object sender, EventArgs e)
        {
            dtBirthdate.CustomFormat = "d MMM yyyy";
        }
    }
}
