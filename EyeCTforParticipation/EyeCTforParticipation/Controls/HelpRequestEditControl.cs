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
    public partial class HelpRequestEditControl : UserControl
    {
        HelpRequestRepository helpRequestRepository = new HelpRequestRepository(new HelpRequestMemoryContext());

        public HelpRequestEditControl()
        {
            InitializeComponent();

            Dictionary<HelpRequestUrgency, string> cbUrgencyItems = new Dictionary<HelpRequestUrgency, string>();
            cbUrgencyItems.Add(HelpRequestUrgency.NONE, "Geen");
            cbUrgencyItems.Add(HelpRequestUrgency.LOW, "Belangrijk");
            cbUrgencyItems.Add(HelpRequestUrgency.NORMAL, "Urgent");
            cbUrgencyItems.Add(HelpRequestUrgency.CRITICAL, "Zeer urgent");

            cbUrgency.ValueMember = "Key";
            cbUrgency.DisplayMember = "Value";
            cbUrgency.DataSource = new BindingSource(cbUrgencyItems, null);
        }

        HelpRequestModel helpRequest;

        public HelpRequestEditControl(HelpRequestModel helpRequest) : this()
        {
            this.helpRequest = helpRequest;
            tbTitle.Text = helpRequest.Title;
            tbAddress.Text = helpRequest.Address;
            tbContent.Text = helpRequest.Content;
            cbUrgency.SelectedValue = helpRequest.Urgency;
        }

        public EventHandler Close;

        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            lbTitleRequired.Visible = tbTitle.Text.Trim().Length == 0;
        }

        private void tbContent_TextChanged(object sender, EventArgs e)
        {
            lbContentRequired.Visible = tbContent.Text.Trim().Length == 0;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(tbTitle.Text.Trim().Length > 0)
            {
                lbTitleRequired.Show();
                if (tbContent.Text.Trim().Length > 0)
                {
                    lbContentRequired.Show();
                    if (helpRequest == null)
                    {
                        helpRequest = new HelpRequestModel
                        {
                            Title = tbTitle.Text,
                            Address = tbAddress.Text,
                            Content = tbContent.Text,
                            Urgency = (HelpRequestUrgency)cbUrgency.SelectedValue,
                            HelpSeeker = Session.User
                        };
                    }
                    else
                    {
                        helpRequest.Title = tbTitle.Text;
                        helpRequest.Address = tbAddress.Text;
                        helpRequest.Content = tbContent.Text;
                        helpRequest.Urgency = (HelpRequestUrgency)cbUrgency.SelectedValue;
                        helpRequest.HelpSeeker = Session.User;
                    }

                    helpRequestRepository.Save(helpRequest);

                    if (Close != null)
                    {
                        Close(null, EventArgs.Empty);
                    }
                }
            }
        }
    }
}
