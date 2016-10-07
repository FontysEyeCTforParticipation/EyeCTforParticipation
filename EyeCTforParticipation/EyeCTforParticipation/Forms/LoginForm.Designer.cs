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
            this.titleWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btTitle = new System.Windows.Forms.Button();
            this.views = new EyeCTforParticipation.ViewControl();
            this.RFIDLoginView = new System.Windows.Forms.TabPage();
            this.btPasswordLoginWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btPasswordLogin = new System.Windows.Forms.Button();
            this.lbInstructions = new System.Windows.Forms.Label();
            this.pbInstructions = new System.Windows.Forms.PictureBox();
            this.PasswordLoginView = new System.Windows.Forms.TabPage();
            this.btRFIDLoginWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btRFIDLogin = new System.Windows.Forms.Button();
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
            this.ForgotPasswordView = new System.Windows.Forms.TabPage();
            this.btForgotWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btForgot = new System.Windows.Forms.Button();
            this.tbForgotEmailWrapper = new System.Windows.Forms.Panel();
            this.tbForgotEmail = new System.Windows.Forms.TextBox();
            this.lbForgotEmail = new System.Windows.Forms.Label();
            this.lbForgotInstructions = new System.Windows.Forms.Label();
            this.titleWrapper.SuspendLayout();
            this.views.SuspendLayout();
            this.RFIDLoginView.SuspendLayout();
            this.btPasswordLoginWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructions)).BeginInit();
            this.PasswordLoginView.SuspendLayout();
            this.btRFIDLoginWrapper.SuspendLayout();
            this.btForgotPasswordWrapper.SuspendLayout();
            this.btLoginWrapper.SuspendLayout();
            this.tbPasswordWrapper.SuspendLayout();
            this.tbEmailWrapper.SuspendLayout();
            this.ForgotPasswordView.SuspendLayout();
            this.btForgotWrapper.SuspendLayout();
            this.tbForgotEmailWrapper.SuspendLayout();
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
            this.titleWrapper.Controls.Add(this.btTitle);
            this.titleWrapper.Controls.Add(this.lbTitle);
            this.titleWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleWrapper.Location = new System.Drawing.Point(0, 0);
            this.titleWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.titleWrapper.Name = "titleWrapper";
            this.titleWrapper.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.titleWrapper.Size = new System.Drawing.Size(715, 180);
            this.titleWrapper.TabIndex = 11;
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
            this.btTitle.Visible = false;
            this.btTitle.Click += new System.EventHandler(this.btTitle_Click);
            // 
            // views
            // 
            this.views.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.views.Controls.Add(this.RFIDLoginView);
            this.views.Controls.Add(this.PasswordLoginView);
            this.views.Controls.Add(this.ForgotPasswordView);
            this.views.CurrentView = this.RFIDLoginView;
            this.views.Dock = System.Windows.Forms.DockStyle.Fill;
            this.views.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.views.ItemSize = new System.Drawing.Size(0, 1);
            this.views.Location = new System.Drawing.Point(0, 180);
            this.views.Name = "views";
            this.views.SelectedIndex = 0;
            this.views.Size = new System.Drawing.Size(715, 685);
            this.views.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.views.TabIndex = 12;
            // 
            // RFIDLoginView
            // 
            this.RFIDLoginView.BackColor = System.Drawing.Color.White;
            this.RFIDLoginView.Controls.Add(this.btPasswordLoginWrapper);
            this.RFIDLoginView.Controls.Add(this.lbInstructions);
            this.RFIDLoginView.Controls.Add(this.pbInstructions);
            this.RFIDLoginView.Location = new System.Drawing.Point(0, 0);
            this.RFIDLoginView.Margin = new System.Windows.Forms.Padding(0);
            this.RFIDLoginView.Name = "RFIDLoginView";
            this.RFIDLoginView.Size = new System.Drawing.Size(715, 685);
            this.RFIDLoginView.TabIndex = 0;
            this.RFIDLoginView.Text = "tabPage1";
            // 
            // btPasswordLoginWrapper
            // 
            this.btPasswordLoginWrapper.AutoSize = true;
            this.btPasswordLoginWrapper.Controls.Add(this.btPasswordLogin);
            this.btPasswordLoginWrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btPasswordLoginWrapper.Location = new System.Drawing.Point(0, 543);
            this.btPasswordLoginWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btPasswordLoginWrapper.Name = "btPasswordLoginWrapper";
            this.btPasswordLoginWrapper.Padding = new System.Windows.Forms.Padding(40);
            this.btPasswordLoginWrapper.Size = new System.Drawing.Size(715, 142);
            this.btPasswordLoginWrapper.TabIndex = 10;
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
            // lbInstructions
            // 
            this.lbInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInstructions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstructions.ForeColor = System.Drawing.Color.Gray;
            this.lbInstructions.Location = new System.Drawing.Point(0, 378);
            this.lbInstructions.Margin = new System.Windows.Forms.Padding(0);
            this.lbInstructions.Name = "lbInstructions";
            this.lbInstructions.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.lbInstructions.Size = new System.Drawing.Size(715, 85);
            this.lbInstructions.TabIndex = 2;
            this.lbInstructions.Text = "Hou de pas bij de scanner om in te loggen";
            this.lbInstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbInstructions
            // 
            this.pbInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbInstructions.Image = global::EyeCTforParticipation.Properties.Resources.chip_card;
            this.pbInstructions.Location = new System.Drawing.Point(0, 0);
            this.pbInstructions.Margin = new System.Windows.Forms.Padding(0);
            this.pbInstructions.Name = "pbInstructions";
            this.pbInstructions.Size = new System.Drawing.Size(715, 378);
            this.pbInstructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInstructions.TabIndex = 0;
            this.pbInstructions.TabStop = false;
            // 
            // PasswordLoginView
            // 
            this.PasswordLoginView.BackColor = System.Drawing.Color.White;
            this.PasswordLoginView.Controls.Add(this.btRFIDLoginWrapper);
            this.PasswordLoginView.Controls.Add(this.btForgotPasswordWrapper);
            this.PasswordLoginView.Controls.Add(this.btLoginWrapper);
            this.PasswordLoginView.Controls.Add(this.tbPasswordWrapper);
            this.PasswordLoginView.Controls.Add(this.lbPassword);
            this.PasswordLoginView.Controls.Add(this.tbEmailWrapper);
            this.PasswordLoginView.Controls.Add(this.lbEmail);
            this.PasswordLoginView.Location = new System.Drawing.Point(0, 0);
            this.PasswordLoginView.Margin = new System.Windows.Forms.Padding(0);
            this.PasswordLoginView.Name = "PasswordLoginView";
            this.PasswordLoginView.Size = new System.Drawing.Size(715, 685);
            this.PasswordLoginView.TabIndex = 1;
            this.PasswordLoginView.Text = "tabPage2";
            // 
            // btRFIDLoginWrapper
            // 
            this.btRFIDLoginWrapper.AutoSize = true;
            this.btRFIDLoginWrapper.Controls.Add(this.btRFIDLogin);
            this.btRFIDLoginWrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btRFIDLoginWrapper.Location = new System.Drawing.Point(0, 441);
            this.btRFIDLoginWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btRFIDLoginWrapper.Name = "btRFIDLoginWrapper";
            this.btRFIDLoginWrapper.Padding = new System.Windows.Forms.Padding(40, 40, 40, 20);
            this.btRFIDLoginWrapper.Size = new System.Drawing.Size(715, 122);
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
            this.btRFIDLogin.Size = new System.Drawing.Size(232, 62);
            this.btRFIDLogin.TabIndex = 6;
            this.btRFIDLogin.Text = "Inloggen met pas";
            this.btRFIDLogin.UseVisualStyleBackColor = false;
            this.btRFIDLogin.Click += new System.EventHandler(this.btRFIDLogin_Click);
            // 
            // btForgotPasswordWrapper
            // 
            this.btForgotPasswordWrapper.AutoSize = true;
            this.btForgotPasswordWrapper.Controls.Add(this.btForgotPassword);
            this.btForgotPasswordWrapper.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btForgotPasswordWrapper.Location = new System.Drawing.Point(0, 563);
            this.btForgotPasswordWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btForgotPasswordWrapper.Name = "btForgotPasswordWrapper";
            this.btForgotPasswordWrapper.Padding = new System.Windows.Forms.Padding(40, 20, 40, 40);
            this.btForgotPasswordWrapper.Size = new System.Drawing.Size(715, 122);
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
            this.btForgotPassword.Location = new System.Drawing.Point(40, 20);
            this.btForgotPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btForgotPassword.Name = "btForgotPassword";
            this.btForgotPassword.Padding = new System.Windows.Forms.Padding(10);
            this.btForgotPassword.Size = new System.Drawing.Size(291, 62);
            this.btForgotPassword.TabIndex = 6;
            this.btForgotPassword.Text = "Wachtwoord vergeten?";
            this.btForgotPassword.UseVisualStyleBackColor = false;
            this.btForgotPassword.Click += new System.EventHandler(this.btForgotPassword_Click);
            // 
            // btLoginWrapper
            // 
            this.btLoginWrapper.AutoSize = true;
            this.btLoginWrapper.Controls.Add(this.btLogin);
            this.btLoginWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.btLoginWrapper.Location = new System.Drawing.Point(0, 296);
            this.btLoginWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btLoginWrapper.Name = "btLoginWrapper";
            this.btLoginWrapper.Padding = new System.Windows.Forms.Padding(40, 30, 40, 20);
            this.btLoginWrapper.Size = new System.Drawing.Size(715, 117);
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
            this.tbPasswordWrapper.Location = new System.Drawing.Point(0, 233);
            this.tbPasswordWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbPasswordWrapper.Name = "tbPasswordWrapper";
            this.tbPasswordWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 20);
            this.tbPasswordWrapper.Size = new System.Drawing.Size(715, 63);
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
            this.tbPassword.Size = new System.Drawing.Size(635, 43);
            this.tbPassword.TabIndex = 3;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPassword.Location = new System.Drawing.Point(0, 148);
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
            this.tbEmailWrapper.Location = new System.Drawing.Point(0, 85);
            this.tbEmailWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbEmailWrapper.Name = "tbEmailWrapper";
            this.tbEmailWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 20);
            this.tbEmailWrapper.Size = new System.Drawing.Size(715, 63);
            this.tbEmailWrapper.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(40, 0);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(635, 43);
            this.tbEmail.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbEmail.Location = new System.Drawing.Point(0, 0);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.lbEmail.Size = new System.Drawing.Size(189, 85);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "E-mail";
            // 
            // ForgotPasswordView
            // 
            this.ForgotPasswordView.BackColor = System.Drawing.Color.White;
            this.ForgotPasswordView.Controls.Add(this.btForgotWrapper);
            this.ForgotPasswordView.Controls.Add(this.tbForgotEmailWrapper);
            this.ForgotPasswordView.Controls.Add(this.lbForgotEmail);
            this.ForgotPasswordView.Controls.Add(this.lbForgotInstructions);
            this.ForgotPasswordView.Location = new System.Drawing.Point(0, 0);
            this.ForgotPasswordView.Margin = new System.Windows.Forms.Padding(0);
            this.ForgotPasswordView.Name = "ForgotPasswordView";
            this.ForgotPasswordView.Size = new System.Drawing.Size(715, 685);
            this.ForgotPasswordView.TabIndex = 2;
            this.ForgotPasswordView.Text = "tabPage1";
            // 
            // btForgotWrapper
            // 
            this.btForgotWrapper.AutoSize = true;
            this.btForgotWrapper.Controls.Add(this.btForgot);
            this.btForgotWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.btForgotWrapper.Location = new System.Drawing.Point(0, 278);
            this.btForgotWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btForgotWrapper.Name = "btForgotWrapper";
            this.btForgotWrapper.Padding = new System.Windows.Forms.Padding(40, 30, 40, 20);
            this.btForgotWrapper.Size = new System.Drawing.Size(715, 117);
            this.btForgotWrapper.TabIndex = 8;
            // 
            // btForgot
            // 
            this.btForgot.AutoSize = true;
            this.btForgot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btForgot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btForgot.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btForgot.FlatAppearance.BorderSize = 0;
            this.btForgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btForgot.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btForgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btForgot.Location = new System.Drawing.Point(40, 30);
            this.btForgot.Margin = new System.Windows.Forms.Padding(0);
            this.btForgot.Name = "btForgot";
            this.btForgot.Padding = new System.Windows.Forms.Padding(10);
            this.btForgot.Size = new System.Drawing.Size(196, 67);
            this.btForgot.TabIndex = 6;
            this.btForgot.Text = "VERSTUREN";
            this.btForgot.UseVisualStyleBackColor = false;
            // 
            // tbForgotEmailWrapper
            // 
            this.tbForgotEmailWrapper.AutoSize = true;
            this.tbForgotEmailWrapper.Controls.Add(this.tbForgotEmail);
            this.tbForgotEmailWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbForgotEmailWrapper.Location = new System.Drawing.Point(0, 215);
            this.tbForgotEmailWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbForgotEmailWrapper.Name = "tbForgotEmailWrapper";
            this.tbForgotEmailWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 20);
            this.tbForgotEmailWrapper.Size = new System.Drawing.Size(715, 63);
            this.tbForgotEmailWrapper.TabIndex = 6;
            // 
            // tbForgotEmail
            // 
            this.tbForgotEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbForgotEmail.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbForgotEmail.Location = new System.Drawing.Point(40, 0);
            this.tbForgotEmail.Margin = new System.Windows.Forms.Padding(0);
            this.tbForgotEmail.Name = "tbForgotEmail";
            this.tbForgotEmail.Size = new System.Drawing.Size(635, 43);
            this.tbForgotEmail.TabIndex = 3;
            // 
            // lbForgotEmail
            // 
            this.lbForgotEmail.AutoSize = true;
            this.lbForgotEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbForgotEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbForgotEmail.Location = new System.Drawing.Point(0, 130);
            this.lbForgotEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lbForgotEmail.Name = "lbForgotEmail";
            this.lbForgotEmail.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.lbForgotEmail.Size = new System.Drawing.Size(189, 85);
            this.lbForgotEmail.TabIndex = 7;
            this.lbForgotEmail.Text = "E-mail";
            // 
            // lbForgotInstructions
            // 
            this.lbForgotInstructions.AutoSize = true;
            this.lbForgotInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbForgotInstructions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgotInstructions.ForeColor = System.Drawing.Color.Gray;
            this.lbForgotInstructions.Location = new System.Drawing.Point(0, 0);
            this.lbForgotInstructions.Margin = new System.Windows.Forms.Padding(0);
            this.lbForgotInstructions.MaximumSize = new System.Drawing.Size(715, 0);
            this.lbForgotInstructions.Name = "lbForgotInstructions";
            this.lbForgotInstructions.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.lbForgotInstructions.Size = new System.Drawing.Size(713, 130);
            this.lbForgotInstructions.TabIndex = 9;
            this.lbForgotInstructions.Text = "We sturen je een e-mail met een link om je wachtwoord opnieuw in te stellen.";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 865);
            this.Controls.Add(this.views);
            this.Controls.Add(this.titleWrapper);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(741, 936);
            this.MinimumSize = new System.Drawing.Size(741, 936);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.titleWrapper.ResumeLayout(false);
            this.views.ResumeLayout(false);
            this.RFIDLoginView.ResumeLayout(false);
            this.RFIDLoginView.PerformLayout();
            this.btPasswordLoginWrapper.ResumeLayout(false);
            this.btPasswordLoginWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructions)).EndInit();
            this.PasswordLoginView.ResumeLayout(false);
            this.PasswordLoginView.PerformLayout();
            this.btRFIDLoginWrapper.ResumeLayout(false);
            this.btRFIDLoginWrapper.PerformLayout();
            this.btForgotPasswordWrapper.ResumeLayout(false);
            this.btForgotPasswordWrapper.PerformLayout();
            this.btLoginWrapper.ResumeLayout(false);
            this.btLoginWrapper.PerformLayout();
            this.tbPasswordWrapper.ResumeLayout(false);
            this.tbPasswordWrapper.PerformLayout();
            this.tbEmailWrapper.ResumeLayout(false);
            this.tbEmailWrapper.PerformLayout();
            this.ForgotPasswordView.ResumeLayout(false);
            this.ForgotPasswordView.PerformLayout();
            this.btForgotWrapper.ResumeLayout(false);
            this.btForgotWrapper.PerformLayout();
            this.tbForgotEmailWrapper.ResumeLayout(false);
            this.tbForgotEmailWrapper.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel titleWrapper;
        private System.Windows.Forms.TabPage PasswordLoginView;
        private System.Windows.Forms.TabPage RFIDLoginView;
        private ViewControl views;
        private System.Windows.Forms.FlowLayoutPanel btRFIDLoginWrapper;
        private System.Windows.Forms.Button btRFIDLogin;
        private System.Windows.Forms.PictureBox pbInstructions;
        private System.Windows.Forms.Label lbInstructions;
        private System.Windows.Forms.FlowLayoutPanel btPasswordLoginWrapper;
        private System.Windows.Forms.Button btPasswordLogin;
        private System.Windows.Forms.TabPage ForgotPasswordView;
        private System.Windows.Forms.Panel tbForgotEmailWrapper;
        private System.Windows.Forms.TextBox tbForgotEmail;
        private System.Windows.Forms.Label lbForgotEmail;
        private System.Windows.Forms.Button btTitle;
        private System.Windows.Forms.FlowLayoutPanel btForgotWrapper;
        private System.Windows.Forms.Button btForgot;
        private System.Windows.Forms.Label lbForgotInstructions;
    }
}

