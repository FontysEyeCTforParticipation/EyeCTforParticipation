namespace EyeCTforParticipation.Controls
{
    partial class ForgotPasswordControl
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
            this.lbInstructions = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmailWrapper = new System.Windows.Forms.Panel();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btSendWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btSend = new System.Windows.Forms.Button();
            this.tbEmailWrapper.SuspendLayout();
            this.btSendWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInstructions
            // 
            this.lbInstructions.AutoSize = true;
            this.lbInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInstructions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInstructions.ForeColor = System.Drawing.Color.Gray;
            this.lbInstructions.Location = new System.Drawing.Point(0, 0);
            this.lbInstructions.Margin = new System.Windows.Forms.Padding(0);
            this.lbInstructions.MaximumSize = new System.Drawing.Size(720, 0);
            this.lbInstructions.Name = "lbInstructions";
            this.lbInstructions.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.lbInstructions.Size = new System.Drawing.Size(713, 130);
            this.lbInstructions.TabIndex = 10;
            this.lbInstructions.Text = "We sturen je een e-mail met een link om je wachtwoord opnieuw in te stellen.";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbEmail.Location = new System.Drawing.Point(0, 130);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.lbEmail.Size = new System.Drawing.Size(189, 85);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "E-mail";
            // 
            // tbEmailWrapper
            // 
            this.tbEmailWrapper.AutoSize = true;
            this.tbEmailWrapper.Controls.Add(this.tbEmail);
            this.tbEmailWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbEmailWrapper.Location = new System.Drawing.Point(0, 215);
            this.tbEmailWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbEmailWrapper.Name = "tbEmailWrapper";
            this.tbEmailWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 40, 20);
            this.tbEmailWrapper.Size = new System.Drawing.Size(700, 63);
            this.tbEmailWrapper.TabIndex = 12;
            // 
            // tbEmail
            // 
            this.tbEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(40, 0);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(0);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(620, 43);
            this.tbEmail.TabIndex = 3;
            // 
            // btSendWrapper
            // 
            this.btSendWrapper.AutoSize = true;
            this.btSendWrapper.Controls.Add(this.btSend);
            this.btSendWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSendWrapper.Location = new System.Drawing.Point(0, 278);
            this.btSendWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btSendWrapper.Name = "btSendWrapper";
            this.btSendWrapper.Padding = new System.Windows.Forms.Padding(40, 30, 40, 40);
            this.btSendWrapper.Size = new System.Drawing.Size(700, 137);
            this.btSendWrapper.TabIndex = 13;
            // 
            // btSend
            // 
            this.btSend.AutoSize = true;
            this.btSend.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSend.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSend.FlatAppearance.BorderSize = 0;
            this.btSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSend.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSend.Location = new System.Drawing.Point(40, 30);
            this.btSend.Margin = new System.Windows.Forms.Padding(0);
            this.btSend.Name = "btSend";
            this.btSend.Padding = new System.Windows.Forms.Padding(10);
            this.btSend.Size = new System.Drawing.Size(196, 67);
            this.btSend.TabIndex = 6;
            this.btSend.Text = "VERSTUREN";
            this.btSend.UseVisualStyleBackColor = false;
            // 
            // ForgotPasswordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btSendWrapper);
            this.Controls.Add(this.tbEmailWrapper);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbInstructions);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(700, 0);
            this.Name = "ForgotPasswordControl";
            this.Size = new System.Drawing.Size(700, 415);
            this.tbEmailWrapper.ResumeLayout(false);
            this.tbEmailWrapper.PerformLayout();
            this.btSendWrapper.ResumeLayout(false);
            this.btSendWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInstructions;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Panel tbEmailWrapper;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.FlowLayoutPanel btSendWrapper;
        private System.Windows.Forms.Button btSend;
    }
}
