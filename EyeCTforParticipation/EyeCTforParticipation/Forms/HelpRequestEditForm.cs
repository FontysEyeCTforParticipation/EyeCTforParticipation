using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCTforParticipation.Models;
using EyeCTforParticipation.Controls;

namespace EyeCTforParticipation.Forms
{
    public partial class HelpRequestEditForm : Form
    {
        public HelpRequestEditForm()
        {
            InitializeComponent();
            HelpRequestEditControl editControl = new HelpRequestEditControl();
            editControl.Close += HelpRequestEditControl_Close;
            editControl.Dock = DockStyle.Fill;
            Controls.Add(editControl);
            this.Controls.SetChildIndex(editControl, 0);
        }

        public HelpRequestEditForm(HelpRequestModel helpRequest)
        {
            InitializeComponent();
            HelpRequestEditControl editControl = new HelpRequestEditControl(helpRequest);
            editControl.Close += HelpRequestEditControl_Close;
            editControl.Dock = DockStyle.Fill;
            Controls.Add(editControl);
            this.Controls.SetChildIndex(editControl, 0);
        }

        private void HelpRequestEditControl_Close(object sender, EventArgs e)
        {
            Close();
        }
    }
}
