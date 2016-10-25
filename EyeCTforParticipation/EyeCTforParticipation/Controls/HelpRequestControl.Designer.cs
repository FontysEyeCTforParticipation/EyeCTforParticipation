namespace EyeCTforParticipation.Controls
{
    partial class HelpRequestControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpRequestControl));
            this.lbContent = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.contentWrapper = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbDistance = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.btBackWrapper = new System.Windows.Forms.Panel();
            this.btBack = new System.Windows.Forms.Button();
            this.titleWrapper = new System.Windows.Forms.Panel();
            this.horizontalSeperator = new EyeCTforParticipation.Controls.HorizontalSeperatorControl();
            this.btApplyWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btApply = new System.Windows.Forms.Button();
            this.contentWrapper.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.btBackWrapper.SuspendLayout();
            this.titleWrapper.SuspendLayout();
            this.btApplyWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbContent.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbContent.Location = new System.Drawing.Point(0, 134);
            this.lbContent.Margin = new System.Windows.Forms.Padding(0);
            this.lbContent.MaximumSize = new System.Drawing.Size(920, 0);
            this.lbContent.Name = "lbContent";
            this.lbContent.Padding = new System.Windows.Forms.Padding(40);
            this.lbContent.Size = new System.Drawing.Size(920, 820);
            this.lbContent.TabIndex = 0;
            this.lbContent.Text = resources.GetString("lbContent.Text");
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Gray;
            this.lbName.Location = new System.Drawing.Point(120, 85);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(40, 20, 0, 40);
            this.lbName.Size = new System.Drawing.Size(144, 105);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Naam";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTitle.Location = new System.Drawing.Point(120, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new System.Windows.Forms.Padding(40, 40, 0, 0);
            this.lbTitle.Size = new System.Drawing.Size(121, 85);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Titel";
            // 
            // contentWrapper
            // 
            this.contentWrapper.AutoScroll = true;
            this.contentWrapper.AutoSize = true;
            this.contentWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentWrapper.Controls.Add(this.lbContent);
            this.contentWrapper.Controls.Add(this.flowLayoutPanel1);
            this.contentWrapper.Controls.Add(this.lbDate);
            this.contentWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentWrapper.Location = new System.Drawing.Point(0, 203);
            this.contentWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(920, 954);
            this.contentWrapper.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.lbLocation);
            this.flowLayoutPanel1.Controls.Add(this.lbDistance);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(40, 20, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(920, 57);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbLocation.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.ForeColor = System.Drawing.Color.Gray;
            this.lbLocation.Location = new System.Drawing.Point(40, 20);
            this.lbLocation.Margin = new System.Windows.Forms.Padding(0);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(142, 37);
            this.lbLocation.TabIndex = 12;
            this.lbLocation.Text = "Eindhoven";
            // 
            // lbDistance
            // 
            this.lbDistance.AutoSize = true;
            this.lbDistance.BackColor = System.Drawing.Color.Transparent;
            this.lbDistance.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistance.ForeColor = System.Drawing.Color.Gray;
            this.lbDistance.Location = new System.Drawing.Point(182, 20);
            this.lbDistance.Margin = new System.Windows.Forms.Padding(0);
            this.lbDistance.Name = "lbDistance";
            this.lbDistance.Size = new System.Drawing.Size(75, 37);
            this.lbDistance.TabIndex = 13;
            this.lbDistance.Text = "5 km";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Gray;
            this.lbDate.Location = new System.Drawing.Point(0, 0);
            this.lbDate.Margin = new System.Windows.Forms.Padding(0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Padding = new System.Windows.Forms.Padding(40, 40, 0, 0);
            this.lbDate.Size = new System.Drawing.Size(199, 77);
            this.lbDate.TabIndex = 11;
            this.lbDate.Text = "10-10-2016";
            // 
            // btBackWrapper
            // 
            this.btBackWrapper.AutoSize = true;
            this.btBackWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btBackWrapper.BackColor = System.Drawing.Color.White;
            this.btBackWrapper.Controls.Add(this.btBack);
            this.btBackWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.btBackWrapper.Location = new System.Drawing.Point(0, 0);
            this.btBackWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btBackWrapper.Name = "btBackWrapper";
            this.btBackWrapper.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.btBackWrapper.Size = new System.Drawing.Size(120, 202);
            this.btBackWrapper.TabIndex = 16;
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.White;
            this.btBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Arial Narrow", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btBack.Location = new System.Drawing.Point(40, 40);
            this.btBack.Margin = new System.Windows.Forms.Padding(0);
            this.btBack.MinimumSize = new System.Drawing.Size(80, 100);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(80, 122);
            this.btBack.TabIndex = 14;
            this.btBack.Text = "❮";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // titleWrapper
            // 
            this.titleWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleWrapper.Controls.Add(this.lbName);
            this.titleWrapper.Controls.Add(this.lbTitle);
            this.titleWrapper.Controls.Add(this.btApplyWrapper);
            this.titleWrapper.Controls.Add(this.btBackWrapper);
            this.titleWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleWrapper.Location = new System.Drawing.Point(0, 0);
            this.titleWrapper.Name = "titleWrapper";
            this.titleWrapper.Size = new System.Drawing.Size(920, 202);
            this.titleWrapper.TabIndex = 16;
            // 
            // horizontalSeperator
            // 
            this.horizontalSeperator.AutoSize = true;
            this.horizontalSeperator.BackColor = System.Drawing.Color.Silver;
            this.horizontalSeperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.horizontalSeperator.Location = new System.Drawing.Point(0, 202);
            this.horizontalSeperator.Margin = new System.Windows.Forms.Padding(0);
            this.horizontalSeperator.Name = "horizontalSeperator";
            this.horizontalSeperator.Size = new System.Drawing.Size(920, 1);
            this.horizontalSeperator.TabIndex = 6;
            // 
            // btApplyWrapper
            // 
            this.btApplyWrapper.AutoSize = true;
            this.btApplyWrapper.Controls.Add(this.btApply);
            this.btApplyWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.btApplyWrapper.Location = new System.Drawing.Point(670, 0);
            this.btApplyWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btApplyWrapper.Name = "btApplyWrapper";
            this.btApplyWrapper.Padding = new System.Windows.Forms.Padding(0, 67, 40, 0);
            this.btApplyWrapper.Size = new System.Drawing.Size(250, 202);
            this.btApplyWrapper.TabIndex = 17;
            // 
            // btApply
            // 
            this.btApply.AutoSize = true;
            this.btApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btApply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btApply.FlatAppearance.BorderSize = 0;
            this.btApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btApply.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btApply.Location = new System.Drawing.Point(0, 67);
            this.btApply.Margin = new System.Windows.Forms.Padding(0);
            this.btApply.Name = "btApply";
            this.btApply.Padding = new System.Windows.Forms.Padding(10);
            this.btApply.Size = new System.Drawing.Size(210, 67);
            this.btApply.TabIndex = 4;
            this.btApply.Text = "AANMELDEN";
            this.btApply.UseVisualStyleBackColor = false;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // HelpRequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.contentWrapper);
            this.Controls.Add(this.horizontalSeperator);
            this.Controls.Add(this.titleWrapper);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HelpRequestControl";
            this.Size = new System.Drawing.Size(920, 1157);
            this.Load += new System.EventHandler(this.HelpRequestControl_Load);
            this.SizeChanged += new System.EventHandler(this.HelpRequestControl_SizeChanged);
            this.contentWrapper.ResumeLayout(false);
            this.contentWrapper.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.btBackWrapper.ResumeLayout(false);
            this.titleWrapper.ResumeLayout(false);
            this.titleWrapper.PerformLayout();
            this.btApplyWrapper.ResumeLayout(false);
            this.btApplyWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel contentWrapper;
        private HorizontalSeperatorControl horizontalSeperator;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbDistance;
        private System.Windows.Forms.Panel btBackWrapper;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel titleWrapper;
        private System.Windows.Forms.FlowLayoutPanel btApplyWrapper;
        private System.Windows.Forms.Button btApply;
    }
}
