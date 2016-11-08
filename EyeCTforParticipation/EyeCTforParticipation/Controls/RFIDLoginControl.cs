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

namespace EyeCTforParticipation.Controls
{
    public partial class RFIDLoginControl : UserControl
    {
        public RFIDLoginControl()
        {
            InitializeComponent();
            CustomFonts.ChangeFonts(Controls, CustomFonts.Families.Roboto);
        }

        public event EventHandler Login;
    }
}
