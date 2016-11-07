namespace EyeCTforParticipation.Controls
{
    partial class HelpRequestEditControl
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
            this.lbUrgency = new System.Windows.Forms.Label();
            this.lbTitleRequired = new System.Windows.Forms.Label();
            this.cbUrgency = new System.Windows.Forms.ComboBox();
            this.cbUrgencyWrapper = new System.Windows.Forms.Panel();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbTitleWrapper = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbAddressWrapper = new System.Windows.Forms.Panel();
            this.lbAddress = new System.Windows.Forms.Label();
            this.tbContentWrapper = new System.Windows.Forms.Panel();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.lbContent = new System.Windows.Forms.Label();
            this.btSaveWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btSave = new System.Windows.Forms.Button();
            this.lbContentRequired = new System.Windows.Forms.Label();
            this.horizontalSeperatorControl = new EyeCTforParticipation.Controls.HorizontalSeperatorControl();
            this.cbUrgencyWrapper.SuspendLayout();
            this.tbTitleWrapper.SuspendLayout();
            this.tbAddressWrapper.SuspendLayout();
            this.tbContentWrapper.SuspendLayout();
            this.btSaveWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUrgency
            // 
            this.lbUrgency.AutoSize = true;
            this.lbUrgency.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbUrgency.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUrgency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUrgency.Location = new System.Drawing.Point(0, 228);
            this.lbUrgency.Margin = new System.Windows.Forms.Padding(0);
            this.lbUrgency.Name = "lbUrgency";
            this.lbUrgency.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbUrgency.Size = new System.Drawing.Size(223, 83);
            this.lbUrgency.TabIndex = 33;
            this.lbUrgency.Text = "Urgentie";
            // 
            // lbTitleRequired
            // 
            this.lbTitleRequired.AutoSize = true;
            this.lbTitleRequired.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitleRequired.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleRequired.ForeColor = System.Drawing.Color.Firebrick;
            this.lbTitleRequired.Location = new System.Drawing.Point(0, 145);
            this.lbTitleRequired.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitleRequired.Name = "lbTitleRequired";
            this.lbTitleRequired.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbTitleRequired.Size = new System.Drawing.Size(323, 83);
            this.lbTitleRequired.TabIndex = 34;
            this.lbTitleRequired.Text = "Titel is verplicht";
            this.lbTitleRequired.Visible = false;
            // 
            // cbUrgency
            // 
            this.cbUrgency.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbUrgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUrgency.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUrgency.FormattingEnabled = true;
            this.cbUrgency.Location = new System.Drawing.Point(40, 0);
            this.cbUrgency.Margin = new System.Windows.Forms.Padding(0);
            this.cbUrgency.Name = "cbUrgency";
            this.cbUrgency.Size = new System.Drawing.Size(640, 45);
            this.cbUrgency.TabIndex = 16;
            // 
            // cbUrgencyWrapper
            // 
            this.cbUrgencyWrapper.AutoSize = true;
            this.cbUrgencyWrapper.Controls.Add(this.cbUrgency);
            this.cbUrgencyWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbUrgencyWrapper.Location = new System.Drawing.Point(0, 311);
            this.cbUrgencyWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.cbUrgencyWrapper.Name = "cbUrgencyWrapper";
            this.cbUrgencyWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 19);
            this.cbUrgencyWrapper.Size = new System.Drawing.Size(720, 64);
            this.cbUrgencyWrapper.TabIndex = 25;
            // 
            // tbTitle
            // 
            this.tbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTitle.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(40, 0);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(640, 43);
            this.tbTitle.TabIndex = 2;
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // tbTitleWrapper
            // 
            this.tbTitleWrapper.AutoSize = true;
            this.tbTitleWrapper.Controls.Add(this.tbTitle);
            this.tbTitleWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbTitleWrapper.Location = new System.Drawing.Point(0, 83);
            this.tbTitleWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbTitleWrapper.Name = "tbTitleWrapper";
            this.tbTitleWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 19);
            this.tbTitleWrapper.Size = new System.Drawing.Size(720, 62);
            this.tbTitleWrapper.TabIndex = 24;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbTitle.Size = new System.Drawing.Size(161, 83);
            this.lbTitle.TabIndex = 23;
            this.lbTitle.Text = "Titel";
            // 
            // tbAddress
            // 
            this.tbAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(40, 0);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(0);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(640, 43);
            this.tbAddress.TabIndex = 1;
            // 
            // tbAddressWrapper
            // 
            this.tbAddressWrapper.AutoSize = true;
            this.tbAddressWrapper.Controls.Add(this.tbAddress);
            this.tbAddressWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbAddressWrapper.Location = new System.Drawing.Point(0, 458);
            this.tbAddressWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbAddressWrapper.Name = "tbAddressWrapper";
            this.tbAddressWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 19);
            this.tbAddressWrapper.Size = new System.Drawing.Size(720, 62);
            this.tbAddressWrapper.TabIndex = 22;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbAddress.Location = new System.Drawing.Point(0, 375);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbAddress.Size = new System.Drawing.Size(215, 83);
            this.lbAddress.TabIndex = 21;
            this.lbAddress.Text = "Address";
            // 
            // tbContentWrapper
            // 
            this.tbContentWrapper.AutoSize = true;
            this.tbContentWrapper.Controls.Add(this.tbContent);
            this.tbContentWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContentWrapper.Location = new System.Drawing.Point(0, 603);
            this.tbContentWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbContentWrapper.Name = "tbContentWrapper";
            this.tbContentWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 40);
            this.tbContentWrapper.Size = new System.Drawing.Size(720, 40);
            this.tbContentWrapper.TabIndex = 35;
            // 
            // tbContent
            // 
            this.tbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbContent.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContent.Location = new System.Drawing.Point(40, 0);
            this.tbContent.Margin = new System.Windows.Forms.Padding(0);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContent.Size = new System.Drawing.Size(640, 0);
            this.tbContent.TabIndex = 1;
            this.tbContent.TextChanged += new System.EventHandler(this.tbContent_TextChanged);
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbContent.Location = new System.Drawing.Point(0, 520);
            this.lbContent.Margin = new System.Windows.Forms.Padding(0);
            this.lbContent.Name = "lbContent";
            this.lbContent.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbContent.Size = new System.Drawing.Size(201, 83);
            this.lbContent.TabIndex = 36;
            this.lbContent.Text = "Inhoud";
            // 
            // btSaveWrapper
            // 
            this.btSaveWrapper.AutoSize = true;
            this.btSaveWrapper.Controls.Add(this.btSave);
            this.btSaveWrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btSaveWrapper.Location = new System.Drawing.Point(0, 727);
            this.btSaveWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btSaveWrapper.Name = "btSaveWrapper";
            this.btSaveWrapper.Padding = new System.Windows.Forms.Padding(40, 30, 40, 40);
            this.btSaveWrapper.Size = new System.Drawing.Size(720, 137);
            this.btSaveWrapper.TabIndex = 37;
            // 
            // btSave
            // 
            this.btSave.AutoSize = true;
            this.btSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSave.Location = new System.Drawing.Point(40, 30);
            this.btSave.Margin = new System.Windows.Forms.Padding(0);
            this.btSave.Name = "btSave";
            this.btSave.Padding = new System.Windows.Forms.Padding(10);
            this.btSave.Size = new System.Drawing.Size(169, 67);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "OPSLAAN";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbContentRequired
            // 
            this.lbContentRequired.AutoSize = true;
            this.lbContentRequired.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbContentRequired.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContentRequired.ForeColor = System.Drawing.Color.Firebrick;
            this.lbContentRequired.Location = new System.Drawing.Point(0, 643);
            this.lbContentRequired.Margin = new System.Windows.Forms.Padding(0);
            this.lbContentRequired.Name = "lbContentRequired";
            this.lbContentRequired.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbContentRequired.Size = new System.Drawing.Size(363, 83);
            this.lbContentRequired.TabIndex = 38;
            this.lbContentRequired.Text = "Inhoud is verplicht";
            this.lbContentRequired.Visible = false;
            // 
            // horizontalSeperatorControl
            // 
            this.horizontalSeperatorControl.AutoSize = true;
            this.horizontalSeperatorControl.BackColor = System.Drawing.Color.Silver;
            this.horizontalSeperatorControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.horizontalSeperatorControl.Location = new System.Drawing.Point(0, 726);
            this.horizontalSeperatorControl.Margin = new System.Windows.Forms.Padding(0);
            this.horizontalSeperatorControl.Name = "horizontalSeperatorControl";
            this.horizontalSeperatorControl.Size = new System.Drawing.Size(720, 1);
            this.horizontalSeperatorControl.TabIndex = 39;
            // 
            // HelpRequestEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbContentWrapper);
            this.Controls.Add(this.lbContentRequired);
            this.Controls.Add(this.horizontalSeperatorControl);
            this.Controls.Add(this.btSaveWrapper);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.tbAddressWrapper);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.cbUrgencyWrapper);
            this.Controls.Add(this.lbUrgency);
            this.Controls.Add(this.lbTitleRequired);
            this.Controls.Add(this.tbTitleWrapper);
            this.Controls.Add(this.lbTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(720, 0);
            this.Name = "HelpRequestEditControl";
            this.Size = new System.Drawing.Size(720, 864);
            this.cbUrgencyWrapper.ResumeLayout(false);
            this.tbTitleWrapper.ResumeLayout(false);
            this.tbTitleWrapper.PerformLayout();
            this.tbAddressWrapper.ResumeLayout(false);
            this.tbAddressWrapper.PerformLayout();
            this.tbContentWrapper.ResumeLayout(false);
            this.tbContentWrapper.PerformLayout();
            this.btSaveWrapper.ResumeLayout(false);
            this.btSaveWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbUrgency;
        private System.Windows.Forms.Label lbTitleRequired;
        private System.Windows.Forms.ComboBox cbUrgency;
        private System.Windows.Forms.Panel cbUrgencyWrapper;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Panel tbTitleWrapper;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Panel tbAddressWrapper;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Panel tbContentWrapper;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.FlowLayoutPanel btSaveWrapper;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbContentRequired;
        private HorizontalSeperatorControl horizontalSeperatorControl;
    }
}
