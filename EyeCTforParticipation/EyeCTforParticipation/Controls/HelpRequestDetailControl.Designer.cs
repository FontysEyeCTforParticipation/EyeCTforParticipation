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
            this.titleWrapper = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbUrgencyCrititcalWrapper = new System.Windows.Forms.Panel();
            this.lbUrgencyCritical = new System.Windows.Forms.Label();
            this.lbUrgencyNormalWrapper = new System.Windows.Forms.Panel();
            this.lbUrgencyNormal = new System.Windows.Forms.Label();
            this.lbUrgencyLowWrapper = new System.Windows.Forms.Panel();
            this.lbUrgencyLow = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbDistance = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbLocationWrapper = new System.Windows.Forms.Panel();
            this.lbTitleNameWrapper.SuspendLayout();
            this.titleWrapper.SuspendLayout();
            this.lbUrgencyCrititcalWrapper.SuspendLayout();
            this.lbUrgencyNormalWrapper.SuspendLayout();
            this.lbUrgencyLowWrapper.SuspendLayout();
            this.lbLocationWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitleNameWrapper
            // 
            this.lbTitleNameWrapper.AutoSize = true;
            this.lbTitleNameWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lbTitleNameWrapper.BackColor = System.Drawing.Color.Transparent;
            this.lbTitleNameWrapper.Controls.Add(this.titleWrapper);
            this.lbTitleNameWrapper.Controls.Add(this.lbName);
            this.lbTitleNameWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitleNameWrapper.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lbTitleNameWrapper.Location = new System.Drawing.Point(0, 0);
            this.lbTitleNameWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitleNameWrapper.Name = "lbTitleNameWrapper";
            this.lbTitleNameWrapper.Size = new System.Drawing.Size(596, 170);
            this.lbTitleNameWrapper.TabIndex = 5;
            // 
            // titleWrapper
            // 
            this.titleWrapper.AutoSize = true;
            this.titleWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleWrapper.Controls.Add(this.lbTitle);
            this.titleWrapper.Controls.Add(this.lbUrgencyCrititcalWrapper);
            this.titleWrapper.Controls.Add(this.lbUrgencyNormalWrapper);
            this.titleWrapper.Controls.Add(this.lbUrgencyLowWrapper);
            this.titleWrapper.Location = new System.Drawing.Point(0, 0);
            this.titleWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.titleWrapper.MinimumSize = new System.Drawing.Size(0, 85);
            this.titleWrapper.Name = "titleWrapper";
            this.titleWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.titleWrapper.Size = new System.Drawing.Size(596, 85);
            this.titleWrapper.TabIndex = 5;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTitle.Location = new System.Drawing.Point(455, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new System.Windows.Forms.Padding(0, 30, 60, 10);
            this.lbTitle.Size = new System.Drawing.Size(141, 85);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Titel";
            // 
            // lbUrgencyCrititcalWrapper
            // 
            this.lbUrgencyCrititcalWrapper.AutoSize = true;
            this.lbUrgencyCrititcalWrapper.Controls.Add(this.lbUrgencyCritical);
            this.lbUrgencyCrititcalWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbUrgencyCrititcalWrapper.Location = new System.Drawing.Point(294, 0);
            this.lbUrgencyCrititcalWrapper.Name = "lbUrgencyCrititcalWrapper";
            this.lbUrgencyCrititcalWrapper.Padding = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.lbUrgencyCrititcalWrapper.Size = new System.Drawing.Size(161, 85);
            this.lbUrgencyCrititcalWrapper.TabIndex = 7;
            this.lbUrgencyCrititcalWrapper.Visible = false;
            // 
            // lbUrgencyCritical
            // 
            this.lbUrgencyCritical.AutoSize = true;
            this.lbUrgencyCritical.BackColor = System.Drawing.Color.Red;
            this.lbUrgencyCritical.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUrgencyCritical.ForeColor = System.Drawing.Color.White;
            this.lbUrgencyCritical.Location = new System.Drawing.Point(0, 34);
            this.lbUrgencyCritical.Name = "lbUrgencyCritical";
            this.lbUrgencyCritical.Padding = new System.Windows.Forms.Padding(5);
            this.lbUrgencyCritical.Size = new System.Drawing.Size(158, 40);
            this.lbUrgencyCritical.TabIndex = 4;
            this.lbUrgencyCritical.Text = "ZEER URGENT";
            // 
            // lbUrgencyNormalWrapper
            // 
            this.lbUrgencyNormalWrapper.AutoSize = true;
            this.lbUrgencyNormalWrapper.Controls.Add(this.lbUrgencyNormal);
            this.lbUrgencyNormalWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbUrgencyNormalWrapper.Location = new System.Drawing.Point(186, 0);
            this.lbUrgencyNormalWrapper.Name = "lbUrgencyNormalWrapper";
            this.lbUrgencyNormalWrapper.Padding = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.lbUrgencyNormalWrapper.Size = new System.Drawing.Size(108, 85);
            this.lbUrgencyNormalWrapper.TabIndex = 6;
            this.lbUrgencyNormalWrapper.Visible = false;
            // 
            // lbUrgencyNormal
            // 
            this.lbUrgencyNormal.AutoSize = true;
            this.lbUrgencyNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbUrgencyNormal.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUrgencyNormal.ForeColor = System.Drawing.Color.White;
            this.lbUrgencyNormal.Location = new System.Drawing.Point(0, 34);
            this.lbUrgencyNormal.Name = "lbUrgencyNormal";
            this.lbUrgencyNormal.Padding = new System.Windows.Forms.Padding(5);
            this.lbUrgencyNormal.Size = new System.Drawing.Size(105, 40);
            this.lbUrgencyNormal.TabIndex = 4;
            this.lbUrgencyNormal.Text = "URGENT";
            // 
            // lbUrgencyLowWrapper
            // 
            this.lbUrgencyLowWrapper.AutoSize = true;
            this.lbUrgencyLowWrapper.Controls.Add(this.lbUrgencyLow);
            this.lbUrgencyLowWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbUrgencyLowWrapper.Location = new System.Drawing.Point(40, 0);
            this.lbUrgencyLowWrapper.Name = "lbUrgencyLowWrapper";
            this.lbUrgencyLowWrapper.Padding = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.lbUrgencyLowWrapper.Size = new System.Drawing.Size(146, 85);
            this.lbUrgencyLowWrapper.TabIndex = 5;
            this.lbUrgencyLowWrapper.Visible = false;
            // 
            // lbUrgencyLow
            // 
            this.lbUrgencyLow.AutoSize = true;
            this.lbUrgencyLow.BackColor = System.Drawing.Color.Yellow;
            this.lbUrgencyLow.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUrgencyLow.ForeColor = System.Drawing.Color.Black;
            this.lbUrgencyLow.Location = new System.Drawing.Point(0, 34);
            this.lbUrgencyLow.Name = "lbUrgencyLow";
            this.lbUrgencyLow.Padding = new System.Windows.Forms.Padding(5);
            this.lbUrgencyLow.Size = new System.Drawing.Size(143, 40);
            this.lbUrgencyLow.TabIndex = 4;
            this.lbUrgencyLow.Text = "BELANGRIJK";
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
            this.lbLocation.AutoEllipsis = true;
            this.lbLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbLocation.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbLocation.Location = new System.Drawing.Point(0, 60);
            this.lbLocation.Margin = new System.Windows.Forms.Padding(0);
            this.lbLocation.MaximumSize = new System.Drawing.Size(360, 80);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.lbLocation.Size = new System.Drawing.Size(360, 80);
            this.lbLocation.TabIndex = 5;
            this.lbLocation.Text = "Eindhoven";
            this.lbLocation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbDistance
            // 
            this.lbDistance.BackColor = System.Drawing.Color.Transparent;
            this.lbDistance.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbDistance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbDistance.Location = new System.Drawing.Point(1256, 0);
            this.lbDistance.Margin = new System.Windows.Forms.Padding(0);
            this.lbDistance.Name = "lbDistance";
            this.lbDistance.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
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
            this.lbDate.Location = new System.Drawing.Point(596, 0);
            this.lbDate.Margin = new System.Windows.Forms.Padding(0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Padding = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.lbDate.Size = new System.Drawing.Size(300, 170);
            this.lbDate.TabIndex = 10;
            this.lbDate.Text = "10-10-2016";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLocationWrapper
            // 
            this.lbLocationWrapper.AutoSize = true;
            this.lbLocationWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lbLocationWrapper.Controls.Add(this.lbLocation);
            this.lbLocationWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbLocationWrapper.Location = new System.Drawing.Point(896, 0);
            this.lbLocationWrapper.Name = "lbLocationWrapper";
            this.lbLocationWrapper.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.lbLocationWrapper.Size = new System.Drawing.Size(360, 170);
            this.lbLocationWrapper.TabIndex = 11;
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
            this.Controls.Add(this.lbLocationWrapper);
            this.Controls.Add(this.lbDistance);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HelpRequestDetailControl";
            this.Size = new System.Drawing.Size(1426, 170);
            this.lbTitleNameWrapper.ResumeLayout(false);
            this.lbTitleNameWrapper.PerformLayout();
            this.titleWrapper.ResumeLayout(false);
            this.titleWrapper.PerformLayout();
            this.lbUrgencyCrititcalWrapper.ResumeLayout(false);
            this.lbUrgencyCrititcalWrapper.PerformLayout();
            this.lbUrgencyNormalWrapper.ResumeLayout(false);
            this.lbUrgencyNormalWrapper.PerformLayout();
            this.lbUrgencyLowWrapper.ResumeLayout(false);
            this.lbUrgencyLowWrapper.PerformLayout();
            this.lbLocationWrapper.ResumeLayout(false);
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
        private System.Windows.Forms.Panel lbLocationWrapper;
        private System.Windows.Forms.Panel titleWrapper;
        private System.Windows.Forms.Panel lbUrgencyCrititcalWrapper;
        private System.Windows.Forms.Label lbUrgencyCritical;
        private System.Windows.Forms.Panel lbUrgencyNormalWrapper;
        private System.Windows.Forms.Label lbUrgencyNormal;
        private System.Windows.Forms.Panel lbUrgencyLowWrapper;
        private System.Windows.Forms.Label lbUrgencyLow;
    }
}
