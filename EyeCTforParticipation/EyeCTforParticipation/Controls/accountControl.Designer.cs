namespace EyeCTforParticipation.Controls
{
    partial class AccountControl
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
            this.btLoginWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btLogin = new System.Windows.Forms.Button();
            this.btRegisterWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btRegister = new System.Windows.Forms.Button();
            this.seperator = new EyeCTforParticipation.Controls.HorizontalSeperatorControl();
            this.userWrapper.SuspendLayout();
            this.btLoginWrapper.SuspendLayout();
            this.btRegisterWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // userWrapper
            // 
            this.userWrapper.AutoSize = true;
            this.userWrapper.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userWrapper.Controls.Add(this.btLoginWrapper);
            this.userWrapper.Controls.Add(this.btRegisterWrapper);
            this.userWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.userWrapper.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.userWrapper.Location = new System.Drawing.Point(0, 0);
            this.userWrapper.Name = "userWrapper";
            this.userWrapper.Size = new System.Drawing.Size(920, 147);
            this.userWrapper.TabIndex = 2;
            // 
            // btLoginWrapper
            // 
            this.btLoginWrapper.AutoSize = true;
            this.btLoginWrapper.Controls.Add(this.btLogin);
            this.btLoginWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.btLoginWrapper.Location = new System.Drawing.Point(659, 0);
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
            this.btLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btLogin.Location = new System.Drawing.Point(40, 40);
            this.btLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btLogin.Name = "btLogin";
            this.btLogin.Padding = new System.Windows.Forms.Padding(10);
            this.btLogin.Size = new System.Drawing.Size(181, 67);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "INLOGGEN";
            this.btLogin.UseVisualStyleBackColor = false;
            // 
            // btRegisterWrapper
            // 
            this.btRegisterWrapper.AutoSize = true;
            this.btRegisterWrapper.Controls.Add(this.btRegister);
            this.btRegisterWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.btRegisterWrapper.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegisterWrapper.Location = new System.Drawing.Point(494, 0);
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
            this.btRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // 
            // seperator
            // 
            this.seperator.AutoSize = true;
            this.seperator.BackColor = System.Drawing.Color.Silver;
            this.seperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.seperator.Location = new System.Drawing.Point(0, 147);
            this.seperator.Margin = new System.Windows.Forms.Padding(0);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(920, 1);
            this.seperator.TabIndex = 21;
            // 
            // AccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.seperator);
            this.Controls.Add(this.userWrapper);
            this.MinimumSize = new System.Drawing.Size(920, 0);
            this.Name = "AccountControl";
            this.Size = new System.Drawing.Size(920, 148);
            this.userWrapper.ResumeLayout(false);
            this.userWrapper.PerformLayout();
            this.btLoginWrapper.ResumeLayout(false);
            this.btLoginWrapper.PerformLayout();
            this.btRegisterWrapper.ResumeLayout(false);
            this.btRegisterWrapper.PerformLayout();
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
    }
}
