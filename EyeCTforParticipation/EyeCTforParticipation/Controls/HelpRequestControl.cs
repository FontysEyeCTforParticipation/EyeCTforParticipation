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
    public partial class HelpRequestControl : UserControl
    {
        public EventHandler Back;
        public EventHandler Apply;

        public HelpRequestControl()
        {
            InitializeComponent();
        }

        private void HelpRequestControl_SizeChanged(object sender, EventArgs e)
        {
            lbContent.MaximumSize = new Size(this.Width, 0);
        }

        private void HelpRequestControl_Load(object sender, EventArgs e)
        {
            lbContent.MaximumSize = new Size(this.Width, 0);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            if(Back != null)
            {
                Back(this, EventArgs.Empty);
            }
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            if(Apply != null)
            {
                Apply(this, EventArgs.Empty);
            }
        }
    }
}
