namespace EyeCTforParticipation.Forms
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
            this.titleWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btBack = new System.Windows.Forms.Button();
            this.views = new EyeCTforParticipation.Controls.ViewControl();
            this.RFIDLoginView = new System.Windows.Forms.TabPage();
            this.btPasswordLoginWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btPasswordLogin = new System.Windows.Forms.Button();
            this.rfidLoginControl = new EyeCTforParticipation.Controls.RFIDLoginControl();
            this.PasswordLoginView = new System.Windows.Forms.TabPage();
            this.btRFIDLoginWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btRFIDLogin = new System.Windows.Forms.Button();
            this.btForgotPasswordWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btForgotPassword = new System.Windows.Forms.Button();
            this.passwordLoginControl = new EyeCTforParticipation.Controls.PasswordLoginControl();
            this.ForgotPasswordView = new System.Windows.Forms.TabPage();
            this.forgotPasswordControl = new EyeCTforParticipation.Controls.ForgotPasswordControl();
            this.titleWrapper.SuspendLayout();
            this.views.SuspendLayout();
            this.RFIDLoginView.SuspendLayout();
            this.btPasswordLoginWrapper.SuspendLayout();
            this.PasswordLoginView.SuspendLayout();
            this.btRFIDLoginWrapper.SuspendLayout();
            this.btForgotPasswordWrapper.SuspendLayout();
            this.ForgotPasswordView.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(120, 40);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.MaximumSize = new System.Drawing.Size(200, 100);
            this.lbTitle.MinimumSize = new System.Drawing.Size(100, 100);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(200, 100);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Login";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleWrapper
            // 
            this.titleWrapper.AutoSize = true;
            this.titleWrapper.Controls.Add(this.btBack);
            this.titleWrapper.Controls.Add(this.lbTitle);
            this.titleWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleWrapper.Location = new System.Drawing.Point(0, 0);
            this.titleWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.titleWrapper.Name = "titleWrapper";
            this.titleWrapper.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.titleWrapper.Size = new System.Drawing.Size(714, 180);
            this.titleWrapper.TabIndex = 11;
            // 
            // btBack
            // 
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
            this.btBack.Size = new System.Drawing.Size(80, 100);
            this.btBack.TabIndex = 9;
            this.btBack.Text = "❮";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Visible = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // views
            // 
            this.views.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.views.Controls.Add(this.RFIDLoginView);
            this.views.Controls.Add(this.PasswordLoginView);
            this.views.Controls.Add(this.ForgotPasswordView);
            this.views.CurrentView = this.ForgotPasswordView;
            this.views.Dock = System.Windows.Forms.DockStyle.Fill;
            this.views.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.views.ItemSize = new System.Drawing.Size(0, 1);
            this.views.Location = new System.Drawing.Point(0, 180);
            this.views.Margin = new System.Windows.Forms.Padding(0);
            this.views.Name = "views";
            this.views.Padding = new System.Drawing.Point(0, 0);
            this.views.SelectedIndex = 0;
            this.views.Size = new System.Drawing.Size(714, 669);
            this.views.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.views.TabIndex = 12;
            // 
            // RFIDLoginView
            // 
            this.RFIDLoginView.BackColor = System.Drawing.Color.White;
            this.RFIDLoginView.Controls.Add(this.btPasswordLoginWrapper);
            this.RFIDLoginView.Controls.Add(this.rfidLoginControl);
            this.RFIDLoginView.Location = new System.Drawing.Point(0, 0);
            this.RFIDLoginView.Margin = new System.Windows.Forms.Padding(0);
            this.RFIDLoginView.Name = "RFIDLoginView";
            this.RFIDLoginView.Size = new System.Drawing.Size(714, 669);
            this.RFIDLoginView.TabIndex = 0;
            this.RFIDLoginView.Text = "tabPage1";
            // 
            // btPasswordLoginWrapper
            // 
            this.btPasswordLoginWrapper.AutoSize = true;
            this.btPasswordLoginWrapper.Controls.Add(this.btPasswordLogin);
            this.btPasswordLoginWrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btPasswordLoginWrapper.Location = new System.Drawing.Point(0, 527);
            this.btPasswordLoginWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btPasswordLoginWrapper.Name = "btPasswordLoginWrapper";
            this.btPasswordLoginWrapper.Padding = new System.Windows.Forms.Padding(40);
            this.btPasswordLoginWrapper.Size = new System.Drawing.Size(714, 142);
            this.btPasswordLoginWrapper.TabIndex = 12;
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
            // rfidLoginControl
            // 
            this.rfidLoginControl.AutoSize = true;
            this.rfidLoginControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rfidLoginControl.BackColor = System.Drawing.Color.White;
            this.rfidLoginControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rfidLoginControl.Location = new System.Drawing.Point(0, 0);
            this.rfidLoginControl.Margin = new System.Windows.Forms.Padding(0);
            this.rfidLoginControl.MinimumSize = new System.Drawing.Size(720, 0);
            this.rfidLoginControl.Name = "rfidLoginControl";
            this.rfidLoginControl.Size = new System.Drawing.Size(720, 669);
            this.rfidLoginControl.TabIndex = 0;
            // 
            // PasswordLoginView
            // 
            this.PasswordLoginView.BackColor = System.Drawing.Color.White;
            this.PasswordLoginView.Controls.Add(this.btRFIDLoginWrapper);
            this.PasswordLoginView.Controls.Add(this.btForgotPasswordWrapper);
            this.PasswordLoginView.Controls.Add(this.passwordLoginControl);
            this.PasswordLoginView.Location = new System.Drawing.Point(0, 0);
            this.PasswordLoginView.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordLoginView.Name = "PasswordLoginView";
            this.PasswordLoginView.Size = new System.Drawing.Size(714, 669);
            this.PasswordLoginView.TabIndex = 1;
            this.PasswordLoginView.Text = "tabPage2";
            // 
            // btRFIDLoginWrapper
            // 
            this.btRFIDLoginWrapper.AutoSize = true;
            this.btRFIDLoginWrapper.Controls.Add(this.btRFIDLogin);
            this.btRFIDLoginWrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btRFIDLoginWrapper.Location = new System.Drawing.Point(0, 425);
            this.btRFIDLoginWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btRFIDLoginWrapper.Name = "btRFIDLoginWrapper";
            this.btRFIDLoginWrapper.Padding = new System.Windows.Forms.Padding(40, 40, 40, 20);
            this.btRFIDLoginWrapper.Size = new System.Drawing.Size(714, 122);
            this.btRFIDLoginWrapper.TabIndex = 10;
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
            this.btRFIDLogin.Size = new System.Drawing.Size(232, 62);
            this.btRFIDLogin.TabIndex = 4;
            this.btRFIDLogin.Text = "Inloggen met pas";
            this.btRFIDLogin.UseVisualStyleBackColor = false;
            this.btRFIDLogin.Click += new System.EventHandler(this.btRFIDLogin_Click);
            // 
            // btForgotPasswordWrapper
            // 
            this.btForgotPasswordWrapper.AutoSize = true;
            this.btForgotPasswordWrapper.Controls.Add(this.btForgotPassword);
            this.btForgotPasswordWrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btForgotPasswordWrapper.Location = new System.Drawing.Point(0, 547);
            this.btForgotPasswordWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btForgotPasswordWrapper.Name = "btForgotPasswordWrapper";
            this.btForgotPasswordWrapper.Padding = new System.Windows.Forms.Padding(40, 20, 40, 40);
            this.btForgotPasswordWrapper.Size = new System.Drawing.Size(714, 122);
            this.btForgotPasswordWrapper.TabIndex = 9;
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
            this.btForgotPassword.Location = new System.Drawing.Point(40, 20);
            this.btForgotPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btForgotPassword.Name = "btForgotPassword";
            this.btForgotPassword.Padding = new System.Windows.Forms.Padding(10);
            this.btForgotPassword.Size = new System.Drawing.Size(291, 62);
            this.btForgotPassword.TabIndex = 5;
            this.btForgotPassword.Text = "Wachtwoord vergeten?";
            this.btForgotPassword.UseVisualStyleBackColor = false;
            this.btForgotPassword.Click += new System.EventHandler(this.btForgotPassword_Click);
            // 
            // passwordLoginControl
            // 
            this.passwordLoginControl.AutoSize = true;
            this.passwordLoginControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.passwordLoginControl.BackColor = System.Drawing.Color.White;
            this.passwordLoginControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordLoginControl.Location = new System.Drawing.Point(0, 0);
            this.passwordLoginControl.Margin = new System.Windows.Forms.Padding(0);
            this.passwordLoginControl.MinimumSize = new System.Drawing.Size(720, 0);
            this.passwordLoginControl.Name = "passwordLoginControl";
            this.passwordLoginControl.Size = new System.Drawing.Size(720, 669);
            this.passwordLoginControl.TabIndex = 0;
            this.passwordLoginControl.User = null;
            // 
            // ForgotPasswordView
            // 
            this.ForgotPasswordView.BackColor = System.Drawing.Color.White;
            this.ForgotPasswordView.Controls.Add(this.forgotPasswordControl);
            this.ForgotPasswordView.Location = new System.Drawing.Point(0, 0);
            this.ForgotPasswordView.Margin = new System.Windows.Forms.Padding(0);
            this.ForgotPasswordView.Name = "ForgotPasswordView";
            this.ForgotPasswordView.Size = new System.Drawing.Size(714, 669);
            this.ForgotPasswordView.TabIndex = 2;
            this.ForgotPasswordView.Text = "tabPage1";
            // 
            // forgotPasswordControl
            // 
            this.forgotPasswordControl.AutoSize = true;
            this.forgotPasswordControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.forgotPasswordControl.BackColor = System.Drawing.Color.White;
            this.forgotPasswordControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forgotPasswordControl.Location = new System.Drawing.Point(0, 0);
            this.forgotPasswordControl.Margin = new System.Windows.Forms.Padding(0);
            this.forgotPasswordControl.MinimumSize = new System.Drawing.Size(700, 0);
            this.forgotPasswordControl.Name = "forgotPasswordControl";
            this.forgotPasswordControl.Size = new System.Drawing.Size(714, 669);
            this.forgotPasswordControl.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 849);
            this.Controls.Add(this.views);
            this.Controls.Add(this.titleWrapper);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(740, 920);
            this.MinimumSize = new System.Drawing.Size(740, 920);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.titleWrapper.ResumeLayout(false);
            this.views.ResumeLayout(false);
            this.RFIDLoginView.ResumeLayout(false);
            this.RFIDLoginView.PerformLayout();
            this.btPasswordLoginWrapper.ResumeLayout(false);
            this.btPasswordLoginWrapper.PerformLayout();
            this.PasswordLoginView.ResumeLayout(false);
            this.PasswordLoginView.PerformLayout();
            this.btRFIDLoginWrapper.ResumeLayout(false);
            this.btRFIDLoginWrapper.PerformLayout();
            this.btForgotPasswordWrapper.ResumeLayout(false);
            this.btForgotPasswordWrapper.PerformLayout();
            this.ForgotPasswordView.ResumeLayout(false);
            this.ForgotPasswordView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.FlowLayoutPanel titleWrapper;
        private System.Windows.Forms.TabPage PasswordLoginView;
        private System.Windows.Forms.TabPage RFIDLoginView;
        private Controls.ViewControl views;
        private System.Windows.Forms.TabPage ForgotPasswordView;
        private System.Windows.Forms.Button btBack;
        private Controls.PasswordLoginControl passwordLoginControl;
        private Controls.RFIDLoginControl rfidLoginControl;
        private Controls.ForgotPasswordControl forgotPasswordControl;
        private System.Windows.Forms.FlowLayoutPanel btPasswordLoginWrapper;
        private System.Windows.Forms.Button btPasswordLogin;
        private System.Windows.Forms.FlowLayoutPanel btForgotPasswordWrapper;
        private System.Windows.Forms.Button btForgotPassword;
        private System.Windows.Forms.FlowLayoutPanel btRFIDLoginWrapper;
        private System.Windows.Forms.Button btRFIDLogin;
    }
}

