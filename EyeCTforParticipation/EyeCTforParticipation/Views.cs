using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    class Views : TabControl
    {
        public Views() : base()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            DrawMode = TabDrawMode.OwnerDrawFixed;
            Appearance = TabAppearance.FlatButtons;
            ItemSize = new Size(0, 1);
            SizeMode = TabSizeMode.Fixed;
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
