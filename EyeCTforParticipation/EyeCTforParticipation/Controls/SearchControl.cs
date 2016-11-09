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
using System.Text.RegularExpressions;

namespace EyeCTforParticipation.Controls
{
    public partial class SearchControl : UserControl
    {
        HelpRequestRepository helpRequestRepository = new HelpRequestRepository(new HelpRequestSQLContext());
        Dictionary<int, string> cbDistances;
        public event EventHandler Search;

        public string PostalCode
        {
            get
            {
                return tbPostalCode.Text;
            }
        }
        public int Distance
        {
            get
            {
                return (int)cbDistance.SelectedValue;
            }
        }
        public string Keywords
        {
            get
            {
                return tbSearch.Text;
            }
        }

        public void Clear()
        {
            tbSearch.Text = "";
            tbPostalCode.Text = "";
            cbDistance.SelectedValue = 0;
        }

        public SearchControl() { 
            InitializeComponent();
            CustomFonts.ChangeFonts(Controls, CustomFonts.Families.Roboto);

            cbDistances = new Dictionary<int, string>();
            cbDistances.Add(0, "Alle afstanden");
            cbDistances.Add(3, "< 3 km");
            cbDistances.Add(5, "< 5 km");
            cbDistances.Add(10, "< 10 km");
            cbDistances.Add(15, "< 15 km");
            cbDistances.Add(25, "< 25 km");
            cbDistances.Add(50, "< 50 km");
            cbDistances.Add(75, "< 75 km");
            cbDistance.DataSource = new BindingSource(cbDistances, null);
            cbDistance.DisplayMember = "Value";
            cbDistance.ValueMember = "Key";
        }

        private void btSearch_Click(object sender, EventArgs e)
        {            
            //Trigger search event
            if (Search != null)
            {
                Search(this, EventArgs.Empty);
            }
        }

        private void tbPostalCode_TextChanged(object sender, EventArgs e)
        {
            string postalCode = tbPostalCode.Text;
            if (postalCode.Length > 0)
            {
                int selection = tbPostalCode.SelectionStart;
                string letters = Regex.Replace(postalCode, "[^a-zA-Z]", "").ToUpper();
                if(letters.Length > 2)
                {
                    letters = letters.Substring(0, 2);
                }
                string numbers = Regex.Replace(postalCode, "[^\\d]", "");
                if (numbers.Length >= 4)
                {
                    numbers = numbers.Substring(0, 4);
                }
                else
                {
                    letters = "";
                }
                tbPostalCode.Text = numbers + letters;
                tbPostalCode.SelectionStart = selection;
            }
        }

        private void cbDistance_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(cbDistances.Select(d => d.Value).ToArray()[e.Index], new Font(CustomFonts.Families.Roboto, 10, FontStyle.Regular), new SolidBrush(Color.FromArgb(64, 64, 64)), e.Bounds);
        }
    }
}
