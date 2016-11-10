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
            this.wrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.titleWrapper = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbRequireApprovalWrapper = new System.Windows.Forms.Panel();
            this.lbRequireApproval = new System.Windows.Forms.Label();
            this.lbEmailWrapper = new System.Windows.Forms.Panel();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.btWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btApprove = new System.Windows.Forms.Button();
            this.btVOG = new System.Windows.Forms.Button();
            this.btProfile = new System.Windows.Forms.Button();
            this.wrapper.SuspendLayout();
            this.titleWrapper.SuspendLayout();
            this.lbRequireApprovalWrapper.SuspendLayout();
            this.lbEmailWrapper.SuspendLayout();
            this.btWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // wrapper
            // 
            this.wrapper.AutoSize = true;
            this.wrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wrapper.BackColor = System.Drawing.Color.Transparent;
            this.wrapper.Controls.Add(this.titleWrapper);
            this.wrapper.Controls.Add(this.lbEmailWrapper);
            this.wrapper.Controls.Add(this.lbRole);
            this.wrapper.Controls.Add(this.btWrapper);
            this.wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapper.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.wrapper.Location = new System.Drawing.Point(0, 0);
            this.wrapper.Margin = new System.Windows.Forms.Padding(0);
            this.wrapper.Name = "wrapper";
            this.wrapper.Size = new System.Drawing.Size(988, 363);
            this.wrapper.TabIndex = 7;
            // 
            // titleWrapper
            // 
            this.titleWrapper.AutoSize = true;
            this.titleWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleWrapper.Controls.Add(this.lbName);
            this.titleWrapper.Controls.Add(this.lbRequireApprovalWrapper);
            this.titleWrapper.Location = new System.Drawing.Point(0, 0);
            this.titleWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.titleWrapper.MinimumSize = new System.Drawing.Size(0, 85);
            this.titleWrapper.Name = "titleWrapper";
            this.titleWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.titleWrapper.Size = new System.Drawing.Size(550, 85);
            this.titleWrapper.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbName.Location = new System.Drawing.Point(387, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(0, 30, 10, 10);
            this.lbName.Size = new System.Drawing.Size(163, 85);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "John Doe";
            // 
            // lbRequireApprovalWrapper
            // 
            this.lbRequireApprovalWrapper.AutoSize = true;
            this.lbRequireApprovalWrapper.Controls.Add(this.lbRequireApproval);
            this.lbRequireApprovalWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbRequireApprovalWrapper.Location = new System.Drawing.Point(40, 0);
            this.lbRequireApprovalWrapper.Name = "lbRequireApprovalWrapper";
            this.lbRequireApprovalWrapper.Padding = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.lbRequireApprovalWrapper.Size = new System.Drawing.Size(347, 85);
            this.lbRequireApprovalWrapper.TabIndex = 5;
            // 
            // lbRequireApproval
            // 
            this.lbRequireApproval.AutoSize = true;
            this.lbRequireApproval.BackColor = System.Drawing.Color.Yellow;
            this.lbRequireApproval.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequireApproval.ForeColor = System.Drawing.Color.Black;
            this.lbRequireApproval.Location = new System.Drawing.Point(0, 34);
            this.lbRequireApproval.Name = "lbRequireApproval";
            this.lbRequireApproval.Padding = new System.Windows.Forms.Padding(5);
            this.lbRequireApproval.Size = new System.Drawing.Size(344, 40);
            this.lbRequireApproval.TabIndex = 4;
            this.lbRequireApproval.Text = "WACHTEN OP GOEDGEKEURING";
            // 
            // lbEmailWrapper
            // 
            this.lbEmailWrapper.AutoSize = true;
            this.lbEmailWrapper.Controls.Add(this.lbEmail);
            this.lbEmailWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbEmailWrapper.Location = new System.Drawing.Point(3, 88);
            this.lbEmailWrapper.Name = "lbEmailWrapper";
            this.lbEmailWrapper.Padding = new System.Windows.Forms.Padding(40, 10, 0, 10);
            this.lbEmailWrapper.Size = new System.Drawing.Size(300, 60);
            this.lbEmailWrapper.TabIndex = 6;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.Black;
            this.lbEmail.Location = new System.Drawing.Point(40, 10);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Padding = new System.Windows.Forms.Padding(5);
            this.lbEmail.Size = new System.Drawing.Size(257, 40);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "example@example.com";
            this.lbEmail.Click += new System.EventHandler(this.lbEmail_Click);
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRole.ForeColor = System.Drawing.Color.Gray;
            this.lbRole.Location = new System.Drawing.Point(0, 151);
            this.lbRole.Margin = new System.Windows.Forms.Padding(0);
            this.lbRole.Name = "lbRole";
            this.lbRole.Padding = new System.Windows.Forms.Padding(40, 10, 60, 30);
            this.lbRole.Size = new System.Drawing.Size(268, 85);
            this.lbRole.TabIndex = 19;
            this.lbRole.Text = "Vrijwilliger";
            // 
            // btWrapper
            // 
            this.btWrapper.AutoSize = true;
            this.btWrapper.Controls.Add(this.btApprove);
            this.btWrapper.Controls.Add(this.btVOG);
            this.btWrapper.Controls.Add(this.btProfile);
            this.btWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.btWrapper.Location = new System.Drawing.Point(0, 236);
            this.btWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btWrapper.Name = "btWrapper";
            this.btWrapper.Padding = new System.Windows.Forms.Padding(40, 20, 40, 40);
            this.btWrapper.Size = new System.Drawing.Size(988, 127);
            this.btWrapper.TabIndex = 18;
            // 
            // btApprove
            // 
            this.btApprove.AutoSize = true;
            this.btApprove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btApprove.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btApprove.FlatAppearance.BorderSize = 0;
            this.btApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btApprove.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btApprove.Location = new System.Drawing.Point(40, 20);
            this.btApprove.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btApprove.Name = "btApprove";
            this.btApprove.Padding = new System.Windows.Forms.Padding(10);
            this.btApprove.Size = new System.Drawing.Size(225, 67);
            this.btApprove.TabIndex = 4;
            this.btApprove.Text = "GOEDKEUREN";
            this.btApprove.UseVisualStyleBackColor = false;
            this.btApprove.Click += new System.EventHandler(this.btApprove_Click);
            // 
            // btVOG
            // 
            this.btVOG.AutoSize = true;
            this.btVOG.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btVOG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btVOG.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btVOG.FlatAppearance.BorderSize = 0;
            this.btVOG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVOG.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVOG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btVOG.Location = new System.Drawing.Point(285, 20);
            this.btVOG.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btVOG.Name = "btVOG";
            this.btVOG.Padding = new System.Windows.Forms.Padding(10);
            this.btVOG.Size = new System.Drawing.Size(470, 67);
            this.btVOG.TabIndex = 6;
            this.btVOG.Text = "VERKLARING OMTRENT GEDRAG";
            this.btVOG.UseVisualStyleBackColor = false;
            this.btVOG.Click += new System.EventHandler(this.btVOG_Click);
            // 
            // btProfile
            // 
            this.btProfile.AutoSize = true;
            this.btProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btProfile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btProfile.FlatAppearance.BorderSize = 0;
            this.btProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProfile.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btProfile.Location = new System.Drawing.Point(775, 20);
            this.btProfile.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btProfile.Name = "btProfile";
            this.btProfile.Padding = new System.Windows.Forms.Padding(10);
            this.btProfile.Size = new System.Drawing.Size(153, 67);
            this.btProfile.TabIndex = 7;
            this.btProfile.Text = "PROFIEL";
            this.btProfile.UseVisualStyleBackColor = false;
            // 
            // AccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.wrapper);
            this.Name = "AccountControl";
            this.Size = new System.Drawing.Size(988, 363);
            this.wrapper.ResumeLayout(false);
            this.wrapper.PerformLayout();
            this.titleWrapper.ResumeLayout(false);
            this.titleWrapper.PerformLayout();
            this.lbRequireApprovalWrapper.ResumeLayout(false);
            this.lbRequireApprovalWrapper.PerformLayout();
            this.lbEmailWrapper.ResumeLayout(false);
            this.lbEmailWrapper.PerformLayout();
            this.btWrapper.ResumeLayout(false);
            this.btWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel wrapper;
        private System.Windows.Forms.Panel titleWrapper;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.FlowLayoutPanel btWrapper;
        private System.Windows.Forms.Button btApprove;
        private System.Windows.Forms.Button btVOG;
        private System.Windows.Forms.Button btProfile;
        private System.Windows.Forms.Panel lbEmailWrapper;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Panel lbRequireApprovalWrapper;
        private System.Windows.Forms.Label lbRequireApproval;
    }
}
