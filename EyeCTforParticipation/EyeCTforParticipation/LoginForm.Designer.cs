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
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPasswordWrapper = new System.Windows.Forms.Panel();
            this.tbEmailWrapper = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbPasswordWrapper.SuspendLayout();
            this.tbEmailWrapper.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new System.Windows.Forms.Padding(40);
            this.lbTitle.Size = new System.Drawing.Size(240, 151);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Login";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbEmail.Location = new System.Drawing.Point(0, 151);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.lbEmail.Size = new System.Drawing.Size(189, 85);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "E-mail";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPassword.Location = new System.Drawing.Point(0, 299);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.lbPassword.Size = new System.Drawing.Size(280, 85);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Wachtwoord";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(40, 0);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(594, 43);
            this.tbPassword.TabIndex = 3;
            // 
            // tbPasswordWrapper
            // 
            this.tbPasswordWrapper.AutoSize = true;
            this.tbPasswordWrapper.Controls.Add(this.tbPassword);
            this.tbPasswordWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPasswordWrapper.Location = new System.Drawing.Point(0, 384);
            this.tbPasswordWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbPasswordWrapper.Name = "tbPasswordWrapper";
            this.tbPasswordWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 20);
            this.tbPasswordWrapper.Size = new System.Drawing.Size(674, 63);
            this.tbPasswordWrapper.TabIndex = 4;
            // 
            // tbEmailWrapper
            // 
            this.tbEmailWrapper.AutoSize = true;
            this.tbEmailWrapper.Controls.Add(this.tbEmail);
            this.tbEmailWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbEmailWrapper.Location = new System.Drawing.Point(0, 236);
            this.tbEmailWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbEmailWrapper.Name = "tbEmailWrapper";
            this.tbEmailWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 20);
            this.tbEmailWrapper.Size = new System.Drawing.Size(674, 63);
            this.tbEmailWrapper.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(40, 0);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(594, 43);
            this.tbEmail.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(40, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10);
            this.button1.Size = new System.Drawing.Size(127, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 447);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(40, 30, 40, 20);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(674, 117);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 710);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tbPasswordWrapper);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbEmailWrapper);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbTitle);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.tbPasswordWrapper.ResumeLayout(false);
            this.tbPasswordWrapper.PerformLayout();
            this.tbEmailWrapper.ResumeLayout(false);
            this.tbEmailWrapper.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

