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
            Rectangle rc = new Rectangle(this.Padding.Right + 8, this.Padding.Bottom + 8, 38, 38);
            e.Graphics.DrawImage(backgroundImage, rc);
        }
    }
}
