namespace EyeCTforParticipation.Controls
{
    partial class HeaderControl
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
            this.userWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btLogoutWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btLogout = new System.Windows.Forms.Button();
            this.btLoginWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btLogin = new System.Windows.Forms.Button();
            this.btRegisterWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btRegister = new System.Windows.Forms.Button();
            this.btChatWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btChat = new EyeCTforParticipation.Controls.ChatButtonControl();
            this.seperator = new EyeCTforParticipation.Controls.HorizontalSeperatorControl();
            this.userWrapper.SuspendLayout();
            this.btLogoutWrapper.SuspendLayout();
            this.btLoginWrapper.SuspendLayout();
            this.btRegisterWrapper.SuspendLayout();
            this.btChatWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // userWrapper
            // 
            this.userWrapper.AutoSize = true;
            this.userWrapper.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userWrapper.Controls.Add(this.btLogoutWrapper);
            this.userWrapper.Controls.Add(this.btLoginWrapper);
            this.userWrapper.Controls.Add(this.btRegisterWrapper);
            this.userWrapper.Controls.Add(this.btChatWrapper);
            this.userWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.userWrapper.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.userWrapper.Location = new System.Drawing.Point(0, 0);
            this.userWrapper.Name = "userWrapper";
            this.userWrapper.Size = new System.Drawing.Size(1200, 147);
            this.userWrapper.TabIndex = 2;
            // 
            // btLogoutWrapper
            // 
            this.btLogoutWrapper.AutoSize = true;
            this.btLogoutWrapper.Controls.Add(this.btLogout);
            this.btLogoutWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.btLogoutWrapper.Location = new System.Drawing.Point(926, 0);
            this.btLogoutWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btLogoutWrapper.Name = "btLogoutWrapper";
            this.btLogoutWrapper.Padding = new System.Windows.Forms.Padding(40);
            this.btLogoutWrapper.Size = new System.Drawing.Size(274, 147);
            this.btLogoutWrapper.TabIndex = 21;
            this.btLogoutWrapper.Visible = false;
            // 
            // btLogout
            // 
            this.btLogout.AutoSize = true;
            this.btLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLogout.FlatAppearance.BorderSize = 0;
            this.btLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogout.Font = new System.Drawing.Font(Logic.CustomFonts.Roboto, 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btLogout.Location = new System.Drawing.Point(40, 40);
            this.btLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btLogout.Name = "btLogout";
            this.btLogout.Padding = new System.Windows.Forms.Padding(10);
            this.btLogout.Size = new System.Drawing.Size(194, 67);
            this.btLogout.TabIndex = 4;
            this.btLogout.Text = "UITLOGGEN";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btLoginWrapper
            // 
            this.btLoginWrapper.AutoSize = true;
            this.btLoginWrapper.Controls.Add(this.btLogin);
            this.btLoginWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.btLoginWrapper.Location = new System.Drawing.Point(665, 0);
            this.btLoginWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btLoginWrapper.Name = "btLoginWrapper";
            this.btLoginWrapper.Padding = new System.Windows.Forms.Padding(40);
            this.btLoginWrapper.Size = new System.Drawing.Size(261, 147);
            this.btLoginWrapper.TabIndex = 19;
            // 
            // btLogin
            // 
            this.btLogin.AutoSize = true;
            this.btLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font(Logic.CustomFonts.Roboto, 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btLogin.Location = new System.Drawing.Point(40, 40);
            this.btLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btLogin.Name = "btLogin";
            this.btLogin.Padding = new System.Windows.Forms.Padding(10);
            this.btLogin.Size = new System.Drawing.Size(181, 67);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "INLOGGEN";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btRegisterWrapper
            // 
            this.btRegisterWrapper.AutoSize = true;
            this.btRegisterWrapper.Controls.Add(this.btRegister);
            this.btRegisterWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.btRegisterWrapper.Font = new System.Drawing.Font(Logic.CustomFonts.Roboto, 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegisterWrapper.Location = new System.Drawing.Point(500, 0);
            this.btRegisterWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btRegisterWrapper.Name = "btRegisterWrapper";
            this.btRegisterWrapper.Padding = new System.Windows.Forms.Padding(0, 40, 0, 40);
            this.btRegisterWrapper.Size = new System.Drawing.Size(165, 147);
            this.btRegisterWrapper.TabIndex = 20;
            // 
            // btRegister
            // 
            this.btRegister.AutoSize = true;
            this.btRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRegister.BackColor = System.Drawing.Color.Transparent;
            this.btRegister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btRegister.FlatAppearance.BorderSize = 0;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.Font = new System.Drawing.Font(Logic.CustomFonts.Roboto, 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btRegister.Location = new System.Drawing.Point(0, 40);
            this.btRegister.Margin = new System.Windows.Forms.Padding(0);
            this.btRegister.MinimumSize = new System.Drawing.Size(0, 67);
            this.btRegister.Name = "btRegister";
            this.btRegister.Padding = new System.Windows.Forms.Padding(10);
            this.btRegister.Size = new System.Drawing.Size(165, 67);
            this.btRegister.TabIndex = 4;
            this.btRegister.Text = "Registreren";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btChatWrapper
            // 
            this.btChatWrapper.AutoSize = true;
            this.btChatWrapper.Controls.Add(this.btChat);
            this.btChatWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.btChatWrapper.Location = new System.Drawing.Point(298, 0);
            this.btChatWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btChatWrapper.Name = "btChatWrapper";
            this.btChatWrapper.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.btChatWrapper.Size = new System.Drawing.Size(202, 147);
            this.btChatWrapper.TabIndex = 22;
            this.btChatWrapper.Visible = false;
            // 
            // btChat
            // 
            this.btChat.AutoSize = true;
            this.btChat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btChat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btChat.FlatAppearance.BorderSize = 0;
            this.btChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChat.Font = new System.Drawing.Font(Logic.CustomFonts.Roboto, 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btChat.Location = new System.Drawing.Point(40, 40);
            this.btChat.Margin = new System.Windows.Forms.Padding(0);
            this.btChat.Name = "btChat";
            this.btChat.Padding = new System.Windows.Forms.Padding(57, 10, 10, 10);
            this.btChat.Size = new System.Drawing.Size(162, 67);
            this.btChat.TabIndex = 4;
            this.btChat.Text = "CHAT";
            this.btChat.UseVisualStyleBackColor = false;
            this.btChat.Click += new System.EventHandler(this.btChat_Click);
            // 
            // seperator
            // 
            this.seperator.AutoSize = true;
            this.seperator.BackColor = System.Drawing.Color.Silver;
            this.seperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.seperator.Location = new System.Drawing.Point(0, 147);
            this.seperator.Margin = new System.Windows.Forms.Padding(0);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(1200, 1);
            this.seperator.TabIndex = 21;
            // 
            // HeaderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.seperator);
            this.Controls.Add(this.userWrapper);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(1200, 0);
            this.Name = "HeaderControl";
            this.Size = new System.Drawing.Size(1200, 148);
            this.userWrapper.ResumeLayout(false);
            this.userWrapper.PerformLayout();
            this.btLogoutWrapper.ResumeLayout(false);
            this.btLogoutWrapper.PerformLayout();
            this.btLoginWrapper.ResumeLayout(false);
            this.btLoginWrapper.PerformLayout();
            this.btRegisterWrapper.ResumeLayout(false);
            this.btRegisterWrapper.PerformLayout();
            this.btChatWrapper.ResumeLayout(false);
            this.btChatWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel userWrapper;
        private System.Windows.Forms.FlowLayoutPanel btLoginWrapper;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.FlowLayoutPanel btRegisterWrapper;
        private System.Windows.Forms.Button btRegister;
        private HorizontalSeperatorControl seperator;
        private System.Windows.Forms.FlowLayoutPanel btLogoutWrapper;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.FlowLayoutPanel btChatWrapper;
        private ChatButtonControl btChat;
    }
}
