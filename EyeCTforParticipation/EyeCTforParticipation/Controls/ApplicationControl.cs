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

namespace EyeCTforParticipation.Controls
{
    public partial class ApplicationControl : UserControl
    {
        ApplicationModel application;

        public ApplicationControl()
        {
            InitializeComponent();
        }

        public ApplicationControl(ApplicationModel application) : this()
        {
            this.application = application;
            switch (application.Status)
            {
                case ApplicationStatus.APPROVED:
                    break;
            }
        }
    }
}
