﻿namespace EyeCTforParticipation.Controls
{
    partial class RegisterControl
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
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmailWrapper = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPasswordWrapper = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btRegisterWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btRegister = new System.Windows.Forms.Button();
            this.lbEmailRepeat = new System.Windows.Forms.Label();
            this.tbEmailRepeatWrapper = new System.Windows.Forms.Panel();
            this.tbEmailRepeat = new System.Windows.Forms.TextBox();
            this.tbPasswordRepeatWrapper = new System.Windows.Forms.Panel();
            this.tbPasswordRepeat = new System.Windows.Forms.TextBox();
            this.lbPasswordRepeat = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbNameWrapper = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbRoleWrapper = new System.Windows.Forms.Panel();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbPasswordMismatch = new System.Windows.Forms.Label();
            this.lbEmailMismatch = new System.Windows.Forms.Label();
            this.lbBirthdate = new System.Windows.Forms.Label();
            this.dtBirthdateWrapper = new System.Windows.Forms.Panel();
            this.dtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lbAvatar = new System.Windows.Forms.Label();
            this.avatarWrapper = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btAvatarRemove = new System.Windows.Forms.Button();
            this.btAvatar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.volunteerWrapper = new System.Windows.Forms.Panel();
            this.cbCarWrapper = new System.Windows.Forms.Panel();
            this.cbCar = new System.Windows.Forms.CheckBox();
            this.lbCar = new System.Windows.Forms.Label();
            this.cbDriversLicenseWrapper = new System.Windows.Forms.Panel();
            this.cbDriversLicense = new System.Windows.Forms.CheckBox();
            this.lbDriversLicense = new System.Windows.Forms.Label();
            this.tbLocationWrapper = new System.Windows.Forms.Panel();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.horizontalSeperatorControl1 = new EyeCTforParticipation.Controls.HorizontalSeperatorControl();
            this.tbEmailWrapper.SuspendLayout();
            this.tbPasswordWrapper.SuspendLayout();
            this.btRegisterWrapper.SuspendLayout();
            this.tbEmailRepeatWrapper.SuspendLayout();
            this.tbPasswordRepeatWrapper.SuspendLayout();
            this.tbNameWrapper.SuspendLayout();
            this.cbRoleWrapper.SuspendLayout();
            this.dtBirthdateWrapper.SuspendLayout();
            this.avatarWrapper.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.volunteerWrapper.SuspendLayout();
            this.cbCarWrapper.SuspendLayout();
            this.cbDriversLicenseWrapper.SuspendLayout();
            this.tbLocationWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbEmail.Location = new System.Drawing.Point(0, 145);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbEmail.Size = new System.Drawing.Size(189, 83);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "E-mail";
            // 
            // tbEmailWrapper
            // 
            this.tbEmailWrapper.AutoSize = true;
            this.tbEmailWrapper.Controls.Add(this.tbEmail);
            this.tbEmailWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbEmailWrapper.Location = new System.Drawing.Point(0, 228);
            this.tbEmailWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbEmailWrapper.Name = "tbEmailWrapper";
            this.tbEmailWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 19);
            this.tbEmailWrapper.Size = new System.Drawing.Size(720, 62);
            this.tbEmailWrapper.TabIndex = 6;
            // 
            // tbEmail
            // 
            this.tbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(40, 0);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(640, 43);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPassword.Location = new System.Drawing.Point(0, 518);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbPassword.Size = new System.Drawing.Size(280, 83);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Wachtwoord";
            // 
            // tbPasswordWrapper
            // 
            this.tbPasswordWrapper.AutoSize = true;
            this.tbPasswordWrapper.Controls.Add(this.tbPassword);
            this.tbPasswordWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPasswordWrapper.Location = new System.Drawing.Point(0, 601);
            this.tbPasswordWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbPasswordWrapper.Name = "tbPasswordWrapper";
            this.tbPasswordWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 19);
            this.tbPasswordWrapper.Size = new System.Drawing.Size(720, 62);
            this.tbPasswordWrapper.TabIndex = 8;
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(40, 0);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(640, 43);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // btRegisterWrapper
            // 
            this.btRegisterWrapper.AutoSize = true;
            this.btRegisterWrapper.Controls.Add(this.btRegister);
            this.btRegisterWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.btRegisterWrapper.Location = new System.Drawing.Point(0, 2088);
            this.btRegisterWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btRegisterWrapper.Name = "btRegisterWrapper";
            this.btRegisterWrapper.Padding = new System.Windows.Forms.Padding(40, 31, 40, 40);
            this.btRegisterWrapper.Size = new System.Drawing.Size(720, 138);
            this.btRegisterWrapper.TabIndex = 9;
            // 
            // btRegister
            // 
            this.btRegister.AutoSize = true;
            this.btRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btRegister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btRegister.FlatAppearance.BorderSize = 0;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btRegister.Location = new System.Drawing.Point(40, 31);
            this.btRegister.Margin = new System.Windows.Forms.Padding(0);
            this.btRegister.Name = "btRegister";
            this.btRegister.Padding = new System.Windows.Forms.Padding(10);
            this.btRegister.Size = new System.Drawing.Size(223, 67);
            this.btRegister.TabIndex = 3;
            this.btRegister.Text = "REGISTREREN";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // lbEmailRepeat
            // 
            this.lbEmailRepeat.AutoSize = true;
            this.lbEmailRepeat.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEmailRepeat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailRepeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbEmailRepeat.Location = new System.Drawing.Point(0, 290);
            this.lbEmailRepeat.Margin = new System.Windows.Forms.Padding(0);
            this.lbEmailRepeat.Name = "lbEmailRepeat";
            this.lbEmailRepeat.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbEmailRepeat.Size = new System.Drawing.Size(321, 83);
            this.lbEmailRepeat.TabIndex = 10;
            this.lbEmailRepeat.Text = "E-mail herhalen";
            // 
            // tbEmailRepeatWrapper
            // 
            this.tbEmailRepeatWrapper.AutoSize = true;
            this.tbEmailRepeatWrapper.Controls.Add(this.tbEmailRepeat);
            this.tbEmailRepeatWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbEmailRepeatWrapper.Location = new System.Drawing.Point(0, 373);
            this.tbEmailRepeatWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbEmailRepeatWrapper.Name = "tbEmailRepeatWrapper";
            this.tbEmailRepeatWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 19);
            this.tbEmailRepeatWrapper.Size = new System.Drawing.Size(720, 62);
            this.tbEmailRepeatWrapper.TabIndex = 11;
            // 
            // tbEmailRepeat
            // 
            this.tbEmailRepeat.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbEmailRepeat.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailRepeat.Location = new System.Drawing.Point(40, 0);
            this.tbEmailRepeat.Margin = new System.Windows.Forms.Padding(0);
            this.tbEmailRepeat.Name = "tbEmailRepeat";
            this.tbEmailRepeat.Size = new System.Drawing.Size(640, 43);
            this.tbEmailRepeat.TabIndex = 1;
            this.tbEmailRepeat.TextChanged += new System.EventHandler(this.tbEmailRepeat_TextChanged);
            // 
            // tbPasswordRepeatWrapper
            // 
            this.tbPasswordRepeatWrapper.AutoSize = true;
            this.tbPasswordRepeatWrapper.Controls.Add(this.tbPasswordRepeat);
            this.tbPasswordRepeatWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPasswordRepeatWrapper.Location = new System.Drawing.Point(0, 746);
            this.tbPasswordRepeatWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbPasswordRepeatWrapper.Name = "tbPasswordRepeatWrapper";
            this.tbPasswordRepeatWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 19);
            this.tbPasswordRepeatWrapper.Size = new System.Drawing.Size(720, 62);
            this.tbPasswordRepeatWrapper.TabIndex = 12;
            // 
            // tbPasswordRepeat
            // 
            this.tbPasswordRepeat.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPasswordRepeat.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordRepeat.Location = new System.Drawing.Point(40, 0);
            this.tbPasswordRepeat.Margin = new System.Windows.Forms.Padding(0);
            this.tbPasswordRepeat.Name = "tbPasswordRepeat";
            this.tbPasswordRepeat.PasswordChar = '*';
            this.tbPasswordRepeat.Size = new System.Drawing.Size(640, 43);
            this.tbPasswordRepeat.TabIndex = 2;
            this.tbPasswordRepeat.TextChanged += new System.EventHandler(this.tbPasswordRepeat_TextChanged);
            // 
            // lbPasswordRepeat
            // 
            this.lbPasswordRepeat.AutoSize = true;
            this.lbPasswordRepeat.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPasswordRepeat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordRepeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPasswordRepeat.Location = new System.Drawing.Point(0, 663);
            this.lbPasswordRepeat.Margin = new System.Windows.Forms.Padding(0);
            this.lbPasswordRepeat.Name = "lbPasswordRepeat";
            this.lbPasswordRepeat.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbPasswordRepeat.Size = new System.Drawing.Size(412, 83);
            this.lbPasswordRepeat.TabIndex = 13;
            this.lbPasswordRepeat.Text = "Wachtwoord herhalen";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbName.Size = new System.Drawing.Size(184, 83);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "Naam";
            // 
            // tbNameWrapper
            // 
            this.tbNameWrapper.AutoSize = true;
            this.tbNameWrapper.Controls.Add(this.tbName);
            this.tbNameWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNameWrapper.Location = new System.Drawing.Point(0, 83);
            this.tbNameWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbNameWrapper.Name = "tbNameWrapper";
            this.tbNameWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 19);
            this.tbNameWrapper.Size = new System.Drawing.Size(720, 62);
            this.tbNameWrapper.TabIndex = 15;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(40, 0);
            this.tbName.Margin = new System.Windows.Forms.Padding(0);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(640, 43);
            this.tbName.TabIndex = 1;
            // 
            // cbRoleWrapper
            // 
            this.cbRoleWrapper.AutoSize = true;
            this.cbRoleWrapper.Controls.Add(this.cbRole);
            this.cbRoleWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbRoleWrapper.Location = new System.Drawing.Point(0, 1532);
            this.cbRoleWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.cbRoleWrapper.Name = "cbRoleWrapper";
            this.cbRoleWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 40);
            this.cbRoleWrapper.Size = new System.Drawing.Size(720, 85);
            this.cbRoleWrapper.TabIndex = 9;
            // 
            // cbRole
            // 
            this.cbRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(40, 0);
            this.cbRole.Margin = new System.Windows.Forms.Padding(0);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(640, 45);
            this.cbRole.TabIndex = 16;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbRole.Location = new System.Drawing.Point(0, 1449);
            this.lbRole.Margin = new System.Windows.Forms.Padding(0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbRole.Size = new System.Drawing.Size(288, 83);
            this.lbRole.TabIndex = 16;
            this.lbRole.Text = "Account type";
            // 
            // lbPasswordMismatch
            // 
            this.lbPasswordMismatch.AutoSize = true;
            this.lbPasswordMismatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPasswordMismatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordMismatch.ForeColor = System.Drawing.Color.Firebrick;
            this.lbPasswordMismatch.Location = new System.Drawing.Point(0, 808);
            this.lbPasswordMismatch.Margin = new System.Windows.Forms.Padding(0);
            this.lbPasswordMismatch.Name = "lbPasswordMismatch";
            this.lbPasswordMismatch.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbPasswordMismatch.Size = new System.Drawing.Size(608, 83);
            this.lbPasswordMismatch.TabIndex = 17;
            this.lbPasswordMismatch.Text = "Wachtwoorden komen niet overeen";
            this.lbPasswordMismatch.Visible = false;
            // 
            // lbEmailMismatch
            // 
            this.lbEmailMismatch.AutoSize = true;
            this.lbEmailMismatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEmailMismatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailMismatch.ForeColor = System.Drawing.Color.Firebrick;
            this.lbEmailMismatch.Location = new System.Drawing.Point(0, 435);
            this.lbEmailMismatch.Margin = new System.Windows.Forms.Padding(0);
            this.lbEmailMismatch.Name = "lbEmailMismatch";
            this.lbEmailMismatch.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbEmailMismatch.Size = new System.Drawing.Size(617, 83);
            this.lbEmailMismatch.TabIndex = 18;
            this.lbEmailMismatch.Text = "E-mail adressen komen niet overeen";
            this.lbEmailMismatch.Visible = false;
            // 
            // lbBirthdate
            // 
            this.lbBirthdate.AutoSize = true;
            this.lbBirthdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBirthdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbBirthdate.Location = new System.Drawing.Point(0, 891);
            this.lbBirthdate.Margin = new System.Windows.Forms.Padding(0);
            this.lbBirthdate.Name = "lbBirthdate";
            this.lbBirthdate.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbBirthdate.Size = new System.Drawing.Size(327, 83);
            this.lbBirthdate.TabIndex = 19;
            this.lbBirthdate.Text = "Geboortedatum";
            // 
            // dtBirthdateWrapper
            // 
            this.dtBirthdateWrapper.AutoSize = true;
            this.dtBirthdateWrapper.Controls.Add(this.dtBirthdate);
            this.dtBirthdateWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtBirthdateWrapper.Location = new System.Drawing.Point(0, 974);
            this.dtBirthdateWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.dtBirthdateWrapper.Name = "dtBirthdateWrapper";
            this.dtBirthdateWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 19);
            this.dtBirthdateWrapper.Size = new System.Drawing.Size(720, 62);
            this.dtBirthdateWrapper.TabIndex = 20;
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.CustomFormat = "d MMM yyyy";
            this.dtBirthdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtBirthdate.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirthdate.Location = new System.Drawing.Point(40, 0);
            this.dtBirthdate.Margin = new System.Windows.Forms.Padding(0);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(640, 43);
            this.dtBirthdate.TabIndex = 3;
            this.dtBirthdate.ValueChanged += new System.EventHandler(this.dtBirthdate_ValueChanged);
            // 
            // lbAvatar
            // 
            this.lbAvatar.AutoSize = true;
            this.lbAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAvatar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbAvatar.Location = new System.Drawing.Point(0, 1036);
            this.lbAvatar.Margin = new System.Windows.Forms.Padding(0);
            this.lbAvatar.Name = "lbAvatar";
            this.lbAvatar.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbAvatar.Size = new System.Drawing.Size(165, 83);
            this.lbAvatar.TabIndex = 22;
            this.lbAvatar.Text = "Foto";
            // 
            // avatarWrapper
            // 
            this.avatarWrapper.AutoSize = true;
            this.avatarWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.avatarWrapper.Controls.Add(this.flowLayoutPanel1);
            this.avatarWrapper.Controls.Add(this.panel1);
            this.avatarWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.avatarWrapper.Location = new System.Drawing.Point(0, 1119);
            this.avatarWrapper.Name = "avatarWrapper";
            this.avatarWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 19);
            this.avatarWrapper.Size = new System.Drawing.Size(720, 330);
            this.avatarWrapper.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btAvatarRemove);
            this.flowLayoutPanel1.Controls.Add(this.btAvatar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 244);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(640, 67);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // btAvatarRemove
            // 
            this.btAvatarRemove.AutoSize = true;
            this.btAvatarRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAvatarRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAvatarRemove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAvatarRemove.FlatAppearance.BorderSize = 0;
            this.btAvatarRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAvatarRemove.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAvatarRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAvatarRemove.Location = new System.Drawing.Point(0, 0);
            this.btAvatarRemove.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btAvatarRemove.Name = "btAvatarRemove";
            this.btAvatarRemove.Padding = new System.Windows.Forms.Padding(10);
            this.btAvatarRemove.Size = new System.Drawing.Size(232, 67);
            this.btAvatarRemove.TabIndex = 4;
            this.btAvatarRemove.Text = "VERWIJDEREN";
            this.btAvatarRemove.UseVisualStyleBackColor = false;
            this.btAvatarRemove.Visible = false;
            this.btAvatarRemove.Click += new System.EventHandler(this.btAvatarRemove_Click);
            // 
            // btAvatar
            // 
            this.btAvatar.AutoSize = true;
            this.btAvatar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAvatar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAvatar.FlatAppearance.BorderSize = 0;
            this.btAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAvatar.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAvatar.Location = new System.Drawing.Point(252, 0);
            this.btAvatar.Margin = new System.Windows.Forms.Padding(0);
            this.btAvatar.Name = "btAvatar";
            this.btAvatar.Padding = new System.Windows.Forms.Padding(10);
            this.btAvatar.Size = new System.Drawing.Size(185, 67);
            this.btAvatar.TabIndex = 3;
            this.btAvatar.Text = "BLADEREN";
            this.btAvatar.UseVisualStyleBackColor = false;
            this.btAvatar.Click += new System.EventHandler(this.btAvatar_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pbAvatar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(40, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 19);
            this.panel1.Size = new System.Drawing.Size(640, 244);
            this.panel1.TabIndex = 6;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(0, 0);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(0);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(225, 225);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 5;
            this.pbAvatar.TabStop = false;
            this.pbAvatar.Visible = false;
            // 
            // volunteerWrapper
            // 
            this.volunteerWrapper.BackColor = System.Drawing.Color.White;
            this.volunteerWrapper.Controls.Add(this.cbCarWrapper);
            this.volunteerWrapper.Controls.Add(this.lbCar);
            this.volunteerWrapper.Controls.Add(this.cbDriversLicenseWrapper);
            this.volunteerWrapper.Controls.Add(this.lbDriversLicense);
            this.volunteerWrapper.Controls.Add(this.tbLocationWrapper);
            this.volunteerWrapper.Controls.Add(this.lbLocation);
            this.volunteerWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.volunteerWrapper.Location = new System.Drawing.Point(0, 1617);
            this.volunteerWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.volunteerWrapper.MinimumSize = new System.Drawing.Size(300, 300);
            this.volunteerWrapper.Name = "volunteerWrapper";
            this.volunteerWrapper.Size = new System.Drawing.Size(720, 470);
            this.volunteerWrapper.TabIndex = 3;
            // 
            // cbCarWrapper
            // 
            this.cbCarWrapper.AutoSize = true;
            this.cbCarWrapper.Controls.Add(this.cbCar);
            this.cbCarWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCarWrapper.Location = new System.Drawing.Point(0, 401);
            this.cbCarWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.cbCarWrapper.Name = "cbCarWrapper";
            this.cbCarWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 40);
            this.cbCarWrapper.Size = new System.Drawing.Size(720, 69);
            this.cbCarWrapper.TabIndex = 13;
            // 
            // cbCar
            // 
            this.cbCar.AutoSize = true;
            this.cbCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCar.Location = new System.Drawing.Point(40, 0);
            this.cbCar.Margin = new System.Windows.Forms.Padding(0);
            this.cbCar.Name = "cbCar";
            this.cbCar.Size = new System.Drawing.Size(640, 29);
            this.cbCar.TabIndex = 3;
            this.cbCar.Text = "Ik heb beschikking tot een auto";
            this.cbCar.UseVisualStyleBackColor = true;
            // 
            // lbCar
            // 
            this.lbCar.AutoSize = true;
            this.lbCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCar.Location = new System.Drawing.Point(0, 318);
            this.lbCar.Margin = new System.Windows.Forms.Padding(0);
            this.lbCar.Name = "lbCar";
            this.lbCar.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbCar.Size = new System.Drawing.Size(169, 83);
            this.lbCar.TabIndex = 24;
            this.lbCar.Text = "Auto";
            // 
            // cbDriversLicenseWrapper
            // 
            this.cbDriversLicenseWrapper.AutoSize = true;
            this.cbDriversLicenseWrapper.Controls.Add(this.cbDriversLicense);
            this.cbDriversLicenseWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDriversLicenseWrapper.Location = new System.Drawing.Point(0, 249);
            this.cbDriversLicenseWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.cbDriversLicenseWrapper.Name = "cbDriversLicenseWrapper";
            this.cbDriversLicenseWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 40);
            this.cbDriversLicenseWrapper.Size = new System.Drawing.Size(720, 69);
            this.cbDriversLicenseWrapper.TabIndex = 14;
            // 
            // cbDriversLicense
            // 
            this.cbDriversLicense.AutoSize = true;
            this.cbDriversLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDriversLicense.Location = new System.Drawing.Point(40, 0);
            this.cbDriversLicense.Margin = new System.Windows.Forms.Padding(0);
            this.cbDriversLicense.Name = "cbDriversLicense";
            this.cbDriversLicense.Size = new System.Drawing.Size(640, 29);
            this.cbDriversLicense.TabIndex = 3;
            this.cbDriversLicense.Text = "Ik heb een rijbewijs";
            this.cbDriversLicense.UseVisualStyleBackColor = true;
            // 
            // lbDriversLicense
            // 
            this.lbDriversLicense.AutoSize = true;
            this.lbDriversLicense.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDriversLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDriversLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbDriversLicense.Location = new System.Drawing.Point(0, 166);
            this.lbDriversLicense.Margin = new System.Windows.Forms.Padding(0);
            this.lbDriversLicense.Name = "lbDriversLicense";
            this.lbDriversLicense.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbDriversLicense.Size = new System.Drawing.Size(224, 83);
            this.lbDriversLicense.TabIndex = 25;
            this.lbDriversLicense.Text = "Rijbewijs";
            // 
            // tbLocationWrapper
            // 
            this.tbLocationWrapper.AutoSize = true;
            this.tbLocationWrapper.Controls.Add(this.tbLocation);
            this.tbLocationWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLocationWrapper.Location = new System.Drawing.Point(0, 83);
            this.tbLocationWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbLocationWrapper.Name = "tbLocationWrapper";
            this.tbLocationWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 40);
            this.tbLocationWrapper.Size = new System.Drawing.Size(720, 83);
            this.tbLocationWrapper.TabIndex = 15;
            // 
            // tbLocation
            // 
            this.tbLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLocation.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocation.Location = new System.Drawing.Point(40, 0);
            this.tbLocation.Margin = new System.Windows.Forms.Padding(0);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(640, 43);
            this.tbLocation.TabIndex = 3;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbLocation.Location = new System.Drawing.Point(0, 0);
            this.lbLocation.Margin = new System.Windows.Forms.Padding(0);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Padding = new System.Windows.Forms.Padding(40, 19, 40, 19);
            this.lbLocation.Size = new System.Drawing.Size(182, 83);
            this.lbLocation.TabIndex = 23;
            this.lbLocation.Text = "Adres";
            // 
            // horizontalSeperatorControl1
            // 
            this.horizontalSeperatorControl1.AutoSize = true;
            this.horizontalSeperatorControl1.BackColor = System.Drawing.Color.Silver;
            this.horizontalSeperatorControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.horizontalSeperatorControl1.Location = new System.Drawing.Point(0, 2087);
            this.horizontalSeperatorControl1.Margin = new System.Windows.Forms.Padding(0);
            this.horizontalSeperatorControl1.Name = "horizontalSeperatorControl1";
            this.horizontalSeperatorControl1.Size = new System.Drawing.Size(720, 1);
            this.horizontalSeperatorControl1.TabIndex = 23;
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btRegisterWrapper);
            this.Controls.Add(this.horizontalSeperatorControl1);
            this.Controls.Add(this.volunteerWrapper);
            this.Controls.Add(this.cbRoleWrapper);
            this.Controls.Add(this.lbRole);
            this.Controls.Add(this.avatarWrapper);
            this.Controls.Add(this.lbAvatar);
            this.Controls.Add(this.dtBirthdateWrapper);
            this.Controls.Add(this.lbBirthdate);
            this.Controls.Add(this.lbPasswordMismatch);
            this.Controls.Add(this.tbPasswordRepeatWrapper);
            this.Controls.Add(this.lbPasswordRepeat);
            this.Controls.Add(this.tbPasswordWrapper);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbEmailMismatch);
            this.Controls.Add(this.tbEmailRepeatWrapper);
            this.Controls.Add(this.lbEmailRepeat);
            this.Controls.Add(this.tbEmailWrapper);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbNameWrapper);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(720, 0);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(720, 2226);
            this.tbEmailWrapper.ResumeLayout(false);
            this.tbEmailWrapper.PerformLayout();
            this.tbPasswordWrapper.ResumeLayout(false);
            this.tbPasswordWrapper.PerformLayout();
            this.btRegisterWrapper.ResumeLayout(false);
            this.btRegisterWrapper.PerformLayout();
            this.tbEmailRepeatWrapper.ResumeLayout(false);
            this.tbEmailRepeatWrapper.PerformLayout();
            this.tbPasswordRepeatWrapper.ResumeLayout(false);
            this.tbPasswordRepeatWrapper.PerformLayout();
            this.tbNameWrapper.ResumeLayout(false);
            this.tbNameWrapper.PerformLayout();
            this.cbRoleWrapper.ResumeLayout(false);
            this.dtBirthdateWrapper.ResumeLayout(false);
            this.avatarWrapper.ResumeLayout(false);
            this.avatarWrapper.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.volunteerWrapper.ResumeLayout(false);
            this.volunteerWrapper.PerformLayout();
            this.cbCarWrapper.ResumeLayout(false);
            this.cbCarWrapper.PerformLayout();
            this.cbDriversLicenseWrapper.ResumeLayout(false);
            this.cbDriversLicenseWrapper.PerformLayout();
            this.tbLocationWrapper.ResumeLayout(false);
            this.tbLocationWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Panel tbEmailWrapper;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Panel tbPasswordWrapper;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.FlowLayoutPanel btRegisterWrapper;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Label lbEmailRepeat;
        private System.Windows.Forms.Panel tbEmailRepeatWrapper;
        private System.Windows.Forms.TextBox tbEmailRepeat;
        private System.Windows.Forms.Panel tbPasswordRepeatWrapper;
        private System.Windows.Forms.TextBox tbPasswordRepeat;
        private System.Windows.Forms.Label lbPasswordRepeat;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel tbNameWrapper;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel cbRoleWrapper;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbPasswordMismatch;
        private System.Windows.Forms.Label lbEmailMismatch;
        private System.Windows.Forms.Label lbBirthdate;
        private System.Windows.Forms.Panel dtBirthdateWrapper;
        private System.Windows.Forms.DateTimePicker dtBirthdate;
        private System.Windows.Forms.Label lbAvatar;
        private System.Windows.Forms.Panel avatarWrapper;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btAvatar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Button btAvatarRemove;
        private HorizontalSeperatorControl horizontalSeperatorControl1;
        private System.Windows.Forms.Panel volunteerWrapper;
        private System.Windows.Forms.Panel cbCarWrapper;
        private System.Windows.Forms.CheckBox cbCar;
        private System.Windows.Forms.Label lbCar;
        private System.Windows.Forms.Panel cbDriversLicenseWrapper;
        private System.Windows.Forms.CheckBox cbDriversLicense;
        private System.Windows.Forms.Label lbDriversLicense;
        private System.Windows.Forms.Panel tbLocationWrapper;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label lbLocation;
    }
}
