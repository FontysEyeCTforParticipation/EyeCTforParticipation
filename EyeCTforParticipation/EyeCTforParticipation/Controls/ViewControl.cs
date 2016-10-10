using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCTforParticipation.Controls
{
    class ViewControl : TabControl
    {
        public ViewControl()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.Appearance = TabAppearance.FlatButtons;
            this.ItemSize = new Size(0, 1);
            this.SizeMode = TabSizeMode.Fixed;
            this.Padding = new Point(0, 0);
            this.Margin = new Padding(0);
        }

        public TabPage CurrentView
        {
            get
            {
                return SelectedTab;
            }

            set
            {
                SelectedTab = value;
            }
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == 0x1300 + 40)
            {
                RECT rc = (RECT)m.GetLParam(typeof(RECT));
                rc.Left -= 4;
                rc.Right += 4;
                rc.Top -= 5;
                rc.Bottom += 4;
                Marshal.StructureToPtr(rc, m.LParam, true);
            }
            base.WndProc(ref m);
        }
        public struct RECT
        {
            public int Left, Top, Right, Bottom;
        }
    }
}
