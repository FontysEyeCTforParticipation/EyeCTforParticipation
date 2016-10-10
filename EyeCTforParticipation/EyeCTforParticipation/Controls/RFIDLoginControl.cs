using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCTforParticipation.Controls
{
    public partial class RFIDLoginControl : UserControl
    {
        private Label lbInstructions;
        private PictureBox pbInstructions;

        public RFIDLoginControl()
        {
            InitializeComponent();
        }

        public event EventHandler Login;

        //Called when a RFID pas is scanned
        private void Scan(EventArgs e)
        {

            //Trigger login event
            if (Login != null)
            {
                Login(this, e);
            }
        }

        private void InitializeComponent()
        {
            this.pbInstructions = new System.Windows.Forms.PictureBox();
            this.lbInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructions)).BeginInit();
            this.SuspendLayout();
            // 
            // pbInstructions
            // 
            this.pbInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbInstructions.Image = global::EyeCTforParticipation.Properties.Resources.chip_card;
            this.pbInstructions.Location = new System.Drawing.Point(0, 0);
            this.pbInstructions.Margin = new System.Windows.Forms.Padding(0);
            this.pbInstructions.Name = "pbInstructions";
            this.pbInstructions.Size = new System.Drawing.Size(740, 378);
            this.pbInstructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInstructions.TabIndex = 1;
            this.pbInstructions.TabStop = false;
            // 
            // lbInstructions
            // 
            this.lbInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInstructions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstructions.ForeColor = System.Drawing.Color.Gray;
            this.lbInstructions.Location = new System.Drawing.Point(0, 378);
            this.lbInstructions.Margin = new System.Windows.Forms.Padding(0);
            this.lbInstructions.Name = "lbInstructions";
            this.lbInstructions.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.lbInstructions.Size = new System.Drawing.Size(740, 85);
            this.lbInstructions.TabIndex = 12;
            this.lbInstructions.Text = "Hou de pas bij de scanner om in te loggen";
            this.lbInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RFIDLoginControl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbInstructions);
            this.Controls.Add(this.pbInstructions);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "RFIDLoginControl";
            this.Size = new System.Drawing.Size(740, 920);
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructions)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
