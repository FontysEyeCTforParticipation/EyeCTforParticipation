namespace EyeCTforParticipation
{
    partial class LoginForm
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btTitle = new System.Windows.Forms.Button();
            this.titleWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.views = new CustomControls.Views();
            this.LoginView = new System.Windows.Forms.TabPage();
            this.btForgotPasswordWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btForgotPassword = new System.Windows.Forms.Button();
            this.btLoginWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbPasswordWrapper = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbEmailWrapper = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.RFIDLoginView = new System.Windows.Forms.TabPage();
            this.btRFIDLoginWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btRFIDLogin = new System.Windows.Forms.Button();
            this.titleWrapper.SuspendLayout();
            this.views.SuspendLayout();
            this.LoginView.SuspendLayout();
            this.btForgotPasswordWrapper.SuspendLayout();
            this.btLoginWrapper.SuspendLayout();
            this.tbPasswordWrapper.SuspendLayout();
            this.tbEmailWrapper.SuspendLayout();
            this.btRFIDLoginWrapper.SuspendLayout();
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
            this.titleWrapper.Size = new System.Drawing.Size(725, 180);
            this.titleWrapper.TabIndex = 11;
            // 
            // views
            // 
            this.views.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.views.Controls.Add(this.LoginView);
            this.views.Controls.Add(this.RFIDLoginView);
            this.views.CurrentView = this.LoginView;
            this.views.Dock = System.Windows.Forms.DockStyle.Fill;
            this.views.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.views.ItemSize = new System.Drawing.Size(0, 1);
            this.views.Location = new System.Drawing.Point(0, 180);
            this.views.Name = "views";
            this.views.SelectedIndex = 0;
            this.views.Size = new System.Drawing.Size(725, 728);
            this.views.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.views.TabIndex = 12;
            // 
            // LoginView
            // 
            this.LoginView.BackColor = System.Drawing.Color.White;
            this.LoginView.Controls.Add(this.btRFIDLoginWrapper);
            this.LoginView.Controls.Add(this.btForgotPasswordWrapper);
            this.LoginView.Controls.Add(this.btLoginWrapper);
            this.LoginView.Controls.Add(this.tbPasswordWrapper);
            this.LoginView.Controls.Add(this.lbPassword);
            this.LoginView.Controls.Add(this.tbEmailWrapper);
            this.LoginView.Controls.Add(this.lbEmail);
            this.LoginView.Location = new System.Drawing.Point(0, 0);
            this.LoginView.Name = "LoginView";
            this.LoginView.Padding = new System.Windows.Forms.Padding(3);
            this.LoginView.Size = new System.Drawing.Size(725, 728);
            this.LoginView.TabIndex = 1;
            this.LoginView.Text = "tabPage2";
            // 
            // btForgotPasswordWrapper
            // 
            this.btForgotPasswordWrapper.AutoSize = true;
            this.btForgotPasswordWrapper.Controls.Add(this.btForgotPassword);
            this.btForgotPasswordWrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btForgotPasswordWrapper.Location = new System.Drawing.Point(3, 583);
            this.btForgotPasswordWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btForgotPasswordWrapper.Name = "btForgotPasswordWrapper";
            this.btForgotPasswordWrapper.Padding = new System.Windows.Forms.Padding(40);
            this.btForgotPasswordWrapper.Size = new System.Drawing.Size(719, 142);
            this.btForgotPasswordWrapper.TabIndex = 8;
            // 
            // btForgotPassword
            // 
            this.btForgotPassword.AutoSize = true;
            this.btForgotPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.btForgotPassword.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btForgotPassword.FlatAppearance.BorderSize = 0;
            this.btForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btForgotPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btForgotPassword.Location = new System.Drawing.Point(40, 40);
            this.btForgotPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btForgotPassword.Name = "btForgotPassword";
            this.btForgotPassword.Padding = new System.Windows.Forms.Padding(10);
            this.btForgotPassword.Size = new System.Drawing.Size(291, 62);
            this.btForgotPassword.TabIndex = 6;
            this.btForgotPassword.Text = "Wachtwoord vergeten?";
            this.btForgotPassword.UseVisualStyleBackColor = false;
            // 
            // btLoginWrapper
            // 
            this.btLoginWrapper.AutoSize = true;
            this.btLoginWrapper.Controls.Add(this.btLogin);
            this.btLoginWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.btLoginWrapper.Location = new System.Drawing.Point(3, 299);
            this.btLoginWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btLoginWrapper.Name = "btLoginWrapper";
            this.btLoginWrapper.Padding = new System.Windows.Forms.Padding(40, 30, 40, 20);
            this.btLoginWrapper.Size = new System.Drawing.Size(719, 117);
            this.btLoginWrapper.TabIndex = 7;
            // 
            // btLogin
            // 
            this.btLogin.AutoSize = true;
            this.btLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btLogin.Location = new System.Drawing.Point(40, 30);
            this.btLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btLogin.Name = "btLogin";
            this.btLogin.Padding = new System.Windows.Forms.Padding(10);
            this.btLogin.Size = new System.Drawing.Size(127, 67);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "LOGIN";
            this.btLogin.UseVisualStyleBackColor = false;
            // 
            // tbPasswordWrapper
            // 
            this.tbPasswordWrapper.AutoSize = true;
            this.tbPasswordWrapper.Controls.Add(this.tbPassword);
            this.tbPasswordWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPasswordWrapper.Location = new System.Drawing.Point(3, 236);
            this.tbPasswordWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbPasswordWrapper.Name = "tbPasswordWrapper";
            this.tbPasswordWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 20);
            this.tbPasswordWrapper.Size = new System.Drawing.Size(719, 63);
            this.tbPasswordWrapper.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(40, 0);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(639, 43);
            this.tbPassword.TabIndex = 3;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPassword.Location = new System.Drawing.Point(3, 151);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.lbPassword.Size = new System.Drawing.Size(280, 85);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Wachtwoord";
            // 
            // tbEmailWrapper
            // 
            this.tbEmailWrapper.AutoSize = true;
            this.tbEmailWrapper.Controls.Add(this.tbEmail);
            this.tbEmailWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbEmailWrapper.Location = new System.Drawing.Point(3, 88);
            this.tbEmailWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbEmailWrapper.Name = "tbEmailWrapper";
            this.tbEmailWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 20);
            this.tbEmailWrapper.Size = new System.Drawing.Size(719, 63);
            this.tbEmailWrapper.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(40, 0);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(639, 43);
            this.tbEmail.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbEmail.Location = new System.Drawing.Point(3, 3);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.lbEmail.Size = new System.Drawing.Size(189, 85);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "E-mail";
            // 
            // RFIDLoginView
            // 
            this.RFIDLoginView.Location = new System.Drawing.Point(0, 0);
            this.RFIDLoginView.Name = "RFIDLoginView";
            this.RFIDLoginView.Padding = new System.Windows.Forms.Padding(3);
            this.RFIDLoginView.Size = new System.Drawing.Size(717, 665);
            this.RFIDLoginView.TabIndex = 0;
            this.RFIDLoginView.Text = "tabPage1";
            this.RFIDLoginView.UseVisualStyleBackColor = true;
            // 
            // btRFIDLoginWrapper
            // 
            this.btRFIDLoginWrapper.AutoSize = true;
            this.btRFIDLoginWrapper.Controls.Add(this.btRFIDLogin);
            this.btRFIDLoginWrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btRFIDLoginWrapper.Location = new System.Drawing.Point(3, 441);
            this.btRFIDLoginWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btRFIDLoginWrapper.Name = "btRFIDLoginWrapper";
            this.btRFIDLoginWrapper.Padding = new System.Windows.Forms.Padding(40);
            this.btRFIDLoginWrapper.Size = new System.Drawing.Size(719, 142);
            this.btRFIDLoginWrapper.TabIndex = 9;
            // 
            // btRFIDLogin
            // 
            this.btRFIDLogin.AutoSize = true;
            this.btRFIDLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRFIDLogin.BackColor = System.Drawing.Color.Transparent;
            this.btRFIDLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btRFIDLogin.FlatAppearance.BorderSize = 0;
            this.btRFIDLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRFIDLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRFIDLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btRFIDLogin.Location = new System.Drawing.Point(40, 40);
            this.btRFIDLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btRFIDLogin.Name = "btRFIDLogin";
            this.btRFIDLogin.Padding = new System.Windows.Forms.Padding(10);
            this.btRFIDLogin.Size = new System.Drawing.Size(291, 62);
            this.btRFIDLogin.TabIndex = 6;
            this.btRFIDLogin.Text = "Wachtwoord vergeten?";
            this.btRFIDLogin.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 908);
            this.Controls.Add(this.views);
            this.Controls.Add(this.titleWrapper);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.titleWrapper.ResumeLayout(false);
            this.views.ResumeLayout(false);
            this.LoginView.ResumeLayout(false);
            this.LoginView.PerformLayout();
            this.btForgotPasswordWrapper.ResumeLayout(false);
            this.btForgotPasswordWrapper.PerformLayout();
            this.btLoginWrapper.ResumeLayout(false);
            this.btLoginWrapper.PerformLayout();
            this.tbPasswordWrapper.ResumeLayout(false);
            this.tbPasswordWrapper.PerformLayout();
            this.tbEmailWrapper.ResumeLayout(false);
            this.tbEmailWrapper.PerformLayout();
            this.btRFIDLoginWrapper.ResumeLayout(false);
            this.btRFIDLoginWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Panel tbPasswordWrapper;
        private System.Windows.Forms.Panel tbEmailWrapper;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.FlowLayoutPanel btLoginWrapper;
        private System.Windows.Forms.FlowLayoutPanel btForgotPasswordWrapper;
        private System.Windows.Forms.Button btForgotPassword;
        private System.Windows.Forms.Button btTitle;
        private System.Windows.Forms.FlowLayoutPanel titleWrapper;
        private System.Windows.Forms.TabPage LoginView;
        private System.Windows.Forms.TabPage RFIDLoginView;
        private CustomControls.Views views;
        private System.Windows.Forms.FlowLayoutPanel btRFIDLoginWrapper;
        private System.Windows.Forms.Button btRFIDLogin;
    }
}

