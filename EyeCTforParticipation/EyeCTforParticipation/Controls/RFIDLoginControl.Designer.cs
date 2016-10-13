namespace EyeCTforParticipation.Controls
{
    partial class RFIDLoginControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.pbInstructions.TabIndex = 2;
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
            this.lbInstructions.TabIndex = 13;
            this.lbInstructions.Text = "Hou de pas bij de scanner om in te loggen";
            this.lbInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RFIDLoginControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbInstructions);
            this.Controls.Add(this.pbInstructions);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(740, 0);
            this.Name = "RFIDLoginControl2";
            this.Size = new System.Drawing.Size(740, 463);
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInstructions;
        private System.Windows.Forms.Label lbInstructions;
    }
}
