using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCTforParticipation.Controls
{
    class ChatButtonControl : Button
    {

        private Image backgroundImage = Properties.Resources.message;        

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int dpi = (int)CreateGraphics().DpiX / 96;
            Rectangle rc = new Rectangle(this.Padding.Right + 2 * dpi, this.Padding.Bottom + 2 * dpi, 19 * dpi, 19 * dpi);
            e.Graphics.DrawImage(backgroundImage, rc);
        }
    }
}
