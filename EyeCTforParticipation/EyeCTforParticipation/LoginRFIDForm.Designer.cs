namespace EyeCTforParticipation
{
    partial class LoginRFIDForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginRFIDForm));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btPasswordLoginWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btPasswordLogin = new System.Windows.Forms.Button();
            this.btTitle = new System.Windows.Forms.Button();
            this.titleWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.pbChipCard = new System.Windows.Forms.PictureBox();
            this.btPasswordLoginWrapper.SuspendLayout();
            this.titleWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbChipCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(120, 40);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.MaximumSize = new System.Drawing.Size(200, 100);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(200, 100);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Login";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbEmail
            // 
            this.lbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Gray;
            this.lbEmail.Location = new System.Drawing.Point(0, 492);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.lbEmail.Size = new System.Drawing.Size(717, 85);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Hou de pas bij de scanner om in te loggen";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btPasswordLoginWrapper
            // 
            this.btPasswordLoginWrapper.AutoSize = true;
            this.btPasswordLoginWrapper.Controls.Add(this.btPasswordLogin);
            this.btPasswordLoginWrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btPasswordLoginWrapper.Location = new System.Drawing.Point(0, 703);
            this.btPasswordLoginWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btPasswordLoginWrapper.Name = "btPasswordLoginWrapper";
            this.btPasswordLoginWrapper.Padding = new System.Windows.Forms.Padding(40);
            this.btPasswordLoginWrapper.Size = new System.Drawing.Size(717, 142);
            this.btPasswordLoginWrapper.TabIndex = 8;
            // 
            // btPasswordLogin
            // 
            this.btPasswordLogin.AutoSize = true;
            this.btPasswordLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btPasswordLogin.BackColor = System.Drawing.Color.Transparent;
            this.btPasswordLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btPasswordLogin.FlatAppearance.BorderSize = 0;
            this.btPasswordLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPasswordLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPasswordLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btPasswordLogin.Location = new System.Drawing.Point(40, 40);
            this.btPasswordLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btPasswordLogin.Name = "btPasswordLogin";
            this.btPasswordLogin.Padding = new System.Windows.Forms.Padding(10);
            this.btPasswordLogin.Size = new System.Drawing.Size(434, 62);
            this.btPasswordLogin.TabIndex = 6;
            this.btPasswordLogin.Text = "Inloggen met e-mail en wachtwoord";
            this.btPasswordLogin.UseVisualStyleBackColor = false;
            this.btPasswordLogin.Click += new System.EventHandler(this.btPasswordLogin_Click);
            // 
            // btTitle
            // 
            this.btTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btTitle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btTitle.FlatAppearance.BorderSize = 0;
            this.btTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTitle.Font = new System.Drawing.Font("Arial Narrow", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btTitle.Location = new System.Drawing.Point(40, 40);
            this.btTitle.Margin = new System.Windows.Forms.Padding(0);
            this.btTitle.MinimumSize = new System.Drawing.Size(80, 100);
            this.btTitle.Name = "btTitle";
            this.btTitle.Size = new System.Drawing.Size(80, 100);
            this.btTitle.TabIndex = 9;
            this.btTitle.Text = "❮";
            this.btTitle.UseVisualStyleBackColor = true;
            // 
            // titleWrapper
            // 
            this.titleWrapper.AutoSize = true;
            this.titleWrapper.Controls.Add(this.btTitle);
            this.titleWrapper.Controls.Add(this.lbTitle);
            this.titleWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleWrapper.Location = new System.Drawing.Point(0, 0);
            this.titleWrapper.Name = "titleWrapper";
            this.titleWrapper.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.titleWrapper.Size = new System.Drawing.Size(717, 180);
            this.titleWrapper.TabIndex = 11;
            // 
            // pbChipCard
            // 
            this.pbChipCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbChipCard.BackgroundImage")));
            this.pbChipCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbChipCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbChipCard.Location = new System.Drawing.Point(0, 180);
            this.pbChipCard.Margin = new System.Windows.Forms.Padding(0);
            this.pbChipCard.Name = "pbChipCard";
            this.pbChipCard.Size = new System.Drawing.Size(717, 312);
            this.pbChipCard.TabIndex = 12;
            this.pbChipCard.TabStop = false;
            // 
            // LoginRFIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 845);
            this.Controls.Add(this.btPasswordLoginWrapper);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.pbChipCard);
            this.Controls.Add(this.titleWrapper);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoginRFIDForm";
            this.Text = "Login";
            this.btPasswordLoginWrapper.ResumeLayout(false);
            this.btPasswordLoginWrapper.PerformLayout();
            this.titleWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbChipCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.FlowLayoutPanel btPasswordLoginWrapper;
        private System.Windows.Forms.Button btPasswordLogin;
        private System.Windows.Forms.Button btTitle;
        private System.Windows.Forms.FlowLayoutPanel titleWrapper;
        private System.Windows.Forms.PictureBox pbChipCard;
    }
}

