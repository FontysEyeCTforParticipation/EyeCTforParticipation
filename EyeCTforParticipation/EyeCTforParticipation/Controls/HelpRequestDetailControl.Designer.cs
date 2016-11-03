namespace EyeCTforParticipation.Controls
{
    partial class HelpRequestDetailControl
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
            this.lbTitleNameWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbDistance = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTitleNameWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitleNameWrapper
            // 
            this.lbTitleNameWrapper.AutoSize = true;
            this.lbTitleNameWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lbTitleNameWrapper.BackColor = System.Drawing.Color.Transparent;
            this.lbTitleNameWrapper.Controls.Add(this.lbTitle);
            this.lbTitleNameWrapper.Controls.Add(this.lbName);
            this.lbTitleNameWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitleNameWrapper.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lbTitleNameWrapper.Location = new System.Drawing.Point(0, 0);
            this.lbTitleNameWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitleNameWrapper.Name = "lbTitleNameWrapper";
            this.lbTitleNameWrapper.Size = new System.Drawing.Size(204, 170);
            this.lbTitleNameWrapper.TabIndex = 5;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new System.Windows.Forms.Padding(40, 30, 60, 10);
            this.lbTitle.Size = new System.Drawing.Size(181, 85);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Titel";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Gray;
            this.lbName.Location = new System.Drawing.Point(0, 85);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(40, 10, 60, 30);
            this.lbName.Size = new System.Drawing.Size(204, 85);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Naam";
            // 
            // lbLocation
            // 
            this.lbLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbLocation.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbLocation.Location = new System.Drawing.Point(504, 0);
            this.lbLocation.Margin = new System.Windows.Forms.Padding(0);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.lbLocation.Size = new System.Drawing.Size(260, 170);
            this.lbLocation.TabIndex = 5;
            this.lbLocation.Text = "Eindhoven";
            this.lbLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDistance
            // 
            this.lbDistance.BackColor = System.Drawing.Color.Transparent;
            this.lbDistance.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbDistance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbDistance.Location = new System.Drawing.Point(764, 0);
            this.lbDistance.Margin = new System.Windows.Forms.Padding(0);
            this.lbDistance.Name = "lbDistance";
            this.lbDistance.Padding = new System.Windows.Forms.Padding(20, 0, 40, 0);
            this.lbDistance.Size = new System.Drawing.Size(170, 170);
            this.lbDistance.TabIndex = 8;
            this.lbDistance.Text = "5 km";
            this.lbDistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbDate.Location = new System.Drawing.Point(204, 0);
            this.lbDate.Margin = new System.Windows.Forms.Padding(0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Padding = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.lbDate.Size = new System.Drawing.Size(300, 170);
            this.lbDate.TabIndex = 10;
            this.lbDate.Text = "10-10-2016";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HelpRequestDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbTitleNameWrapper);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.lbDistance);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HelpRequestDetailControl";
            this.Size = new System.Drawing.Size(934, 170);
            this.lbTitleNameWrapper.ResumeLayout(false);
            this.lbTitleNameWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel lbTitleNameWrapper;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbDistance;
        private System.Windows.Forms.Label lbDate;
    }
}
