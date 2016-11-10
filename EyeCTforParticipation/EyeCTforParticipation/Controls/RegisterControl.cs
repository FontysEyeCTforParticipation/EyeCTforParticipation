using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCTforParticipation.Models;
using EyeCTforParticipation.Logic;
using EyeCTforParticipation.Data;

namespace EyeCTforParticipation.Controls
{
    public partial class RegisterControl : UserControl
    {
        UserRepository userRepository = new UserRepository(new UserSQLContext());

        Bitmap image;

        public RegisterControl()
        {
            InitializeComponent();
            CustomFonts.ChangeFonts(Controls, CustomFonts.Families.Roboto);

            Dictionary<UserRole, string> cbRoleItems = new Dictionary<UserRole, string>();
            cbRoleItems.Add(UserRole.HelpSeeker, "Hulpbehoevende");
            cbRoleItems.Add(UserRole.Volunteer, "Vrijwilliger");
            cbRoleItems.Add(UserRole.AidWorker, "Hulpverlener");

            cbRole.ValueMember = "Key";
            cbRole.DisplayMember = "Value";
            cbRole.DataSource = new BindingSource(cbRoleItems, null);

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

        private void btRegister_Click(object sender, EventArgs e)
        {
            if(tbName.Text.Length == 0)
            {
                MessageBox.Show("Naam is vereist.");
                return;
            }
            if (tbEmail.Text.Length == 0)
            {
                MessageBox.Show("E-mail is vereist.");
                return;
            }
            if (tbEmail.Text != tbEmailRepeat.Text)
            {
                MessageBox.Show("E-mail adressen komen niet overeen.");
                lbEmailMismatch.Show();
                return;
            }
            if (!userRepository.emailValid(tbEmail.Text))
            {
                MessageBox.Show("Email is ongeldig.");
                return;
            }
            if (tbPassword.Text.Length == 0)
            {
                MessageBox.Show("Wachtwoord is vereist.");
                return;
            }
            if (tbPassword.Text != tbPasswordRepeat.Text)
            {
                MessageBox.Show("Wachtwoorden komen niet overeen.");
                lbPasswordMismatch.Show();
                return;
            }
            if(dtBirthdate.CustomFormat != "d MMM yyyy")
            {
                MessageBox.Show("Geboortedatum is vereist.");
                return;
            }
            UserRole role = (UserRole)cbRole.SelectedValue;
            if(role != UserRole.HelpSeeker && image == null)
            {
                MessageBox.Show("Foto is vereist.");
                return;
            }
            userRepository.Register(new RegisterModel
            {
                Name = tbName.Text,
                Role = role,
                Email = tbEmail.Text,
                Password = tbPassword.Text,
                Birthdate = dtBirthdate.Value,
                Avatar = image,
                Address = tbLocation.Text,
                DriversLicense = cbDriversLicense.Checked,
                Car = cbCar.Checked
            });
            if(role == UserRole.HelpSeeker)
            {
                userRepository.Login(tbEmail.Text, tbPassword.Text);
            }
            if (Register != null && Session.User != null)
            {
                Register(null, EventArgs.Empty);
            }
        }

        private void btAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Open foto";
            fileDialog.Filter = "Afbeeldings bestanden (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(fileDialog.FileName);

                //Crop image
                int width = image.Width;
                int height = image.Height;
                Rectangle crop;
                if (width > height)
                {
                    crop = new Rectangle(width / 2 - height / 2, 0, height, height);
                }
                else
                {
                    crop = new Rectangle(0, height / 2 - width / 2, width, width);
                }
                image = image.Clone(crop, image.PixelFormat);

                //Resize image
                image = new Bitmap(image, new Size(256, 256));

                //Set image
                pbAvatar.Image = image;
                pbAvatar.Show();
                btAvatarRemove.Show();
            }
        }

        private void btAvatarRemove_Click(object sender, EventArgs e)
        {
            btAvatarRemove.Hide();
            pbAvatar.Hide();
            image = null;
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            volunteerWrapper.Visible = (UserRole)cbRole.SelectedValue == UserRole.Volunteer;
        }
    }
}
