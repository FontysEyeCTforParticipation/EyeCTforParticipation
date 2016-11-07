namespace EyeCTforParticipation.Controls
{
    partial class ApplicationControl
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
            this.lbTitleNameWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.titleWrapper = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCancelledWrapper = new System.Windows.Forms.Panel();
            this.lbCancelled = new System.Windows.Forms.Label();
            this.lbInterviewWrapper = new System.Windows.Forms.Panel();
            this.lbInterview = new System.Windows.Forms.Label();
            this.lbApprovedWrapper = new System.Windows.Forms.Panel();
            this.lbApproved = new System.Windows.Forms.Label();
            this.lbTitleNameWrapper.SuspendLayout();
            this.titleWrapper.SuspendLayout();
            this.lbCancelledWrapper.SuspendLayout();
            this.lbInterviewWrapper.SuspendLayout();
            this.lbApprovedWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitleNameWrapper
            // 
            this.lbTitleNameWrapper.AutoSize = true;
            this.lbTitleNameWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lbTitleNameWrapper.BackColor = System.Drawing.Color.Transparent;
            this.lbTitleNameWrapper.Controls.Add(this.titleWrapper);
            this.lbTitleNameWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitleNameWrapper.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lbTitleNameWrapper.Location = new System.Drawing.Point(0, 0);
            this.lbTitleNameWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitleNameWrapper.Name = "lbTitleNameWrapper";
            this.lbTitleNameWrapper.Size = new System.Drawing.Size(813, 85);
            this.lbTitleNameWrapper.TabIndex = 6;
            // 
            // titleWrapper
            // 
            this.titleWrapper.AutoSize = true;
            this.titleWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleWrapper.Controls.Add(this.lbName);
            this.titleWrapper.Controls.Add(this.lbCancelledWrapper);
            this.titleWrapper.Controls.Add(this.lbInterviewWrapper);
            this.titleWrapper.Controls.Add(this.lbApprovedWrapper);
            this.titleWrapper.Location = new System.Drawing.Point(0, 0);
            this.titleWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.titleWrapper.MinimumSize = new System.Drawing.Size(0, 85);
            this.titleWrapper.Name = "titleWrapper";
            this.titleWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.titleWrapper.Size = new System.Drawing.Size(813, 85);
            this.titleWrapper.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbName.Location = new System.Drawing.Point(600, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(0, 30, 60, 10);
            this.lbName.Size = new System.Drawing.Size(213, 85);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "John Doe";
            // 
            // lbCancelledWrapper
            // 
            this.lbCancelledWrapper.AutoSize = true;
            this.lbCancelledWrapper.Controls.Add(this.lbCancelled);
            this.lbCancelledWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCancelledWrapper.Location = new System.Drawing.Point(468, 0);
            this.lbCancelledWrapper.Name = "lbCancelledWrapper";
            this.lbCancelledWrapper.Padding = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.lbCancelledWrapper.Size = new System.Drawing.Size(132, 85);
            this.lbCancelledWrapper.TabIndex = 7;
            this.lbCancelledWrapper.Visible = false;
            // 
            // lbCancelled
            // 
            this.lbCancelled.AutoSize = true;
            this.lbCancelled.BackColor = System.Drawing.Color.Gray;
            this.lbCancelled.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCancelled.ForeColor = System.Drawing.Color.White;
            this.lbCancelled.Location = new System.Drawing.Point(0, 34);
            this.lbCancelled.Name = "lbCancelled";
            this.lbCancelled.Padding = new System.Windows.Forms.Padding(5);
            this.lbCancelled.Size = new System.Drawing.Size(129, 40);
            this.lbCancelled.TabIndex = 4;
            this.lbCancelled.Text = "AFGEMELD";
            // 
            // lbInterviewWrapper
            // 
            this.lbInterviewWrapper.AutoSize = true;
            this.lbInterviewWrapper.Controls.Add(this.lbInterview);
            this.lbInterviewWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbInterviewWrapper.Location = new System.Drawing.Point(216, 0);
            this.lbInterviewWrapper.Name = "lbInterviewWrapper";
            this.lbInterviewWrapper.Padding = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.lbInterviewWrapper.Size = new System.Drawing.Size(252, 85);
            this.lbInterviewWrapper.TabIndex = 6;
            this.lbInterviewWrapper.Visible = false;
            // 
            // lbInterview
            // 
            this.lbInterview.AutoSize = true;
            this.lbInterview.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbInterview.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInterview.ForeColor = System.Drawing.Color.White;
            this.lbInterview.Location = new System.Drawing.Point(0, 34);
            this.lbInterview.Name = "lbInterview";
            this.lbInterview.Padding = new System.Windows.Forms.Padding(5);
            this.lbInterview.Size = new System.Drawing.Size(249, 40);
            this.lbInterview.TabIndex = 4;
            this.lbInterview.Text = "KENNISMAKINGS CHAT";
            // 
            // lbApprovedWrapper
            // 
            this.lbApprovedWrapper.AutoSize = true;
            this.lbApprovedWrapper.Controls.Add(this.lbApproved);
            this.lbApprovedWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbApprovedWrapper.Location = new System.Drawing.Point(40, 0);
            this.lbApprovedWrapper.Name = "lbApprovedWrapper";
            this.lbApprovedWrapper.Padding = new System.Windows.Forms.Padding(0, 34, 0, 0);
            this.lbApprovedWrapper.Size = new System.Drawing.Size(176, 85);
            this.lbApprovedWrapper.TabIndex = 5;
            this.lbApprovedWrapper.Visible = false;
            // 
            // lbApproved
            // 
            this.lbApproved.AutoSize = true;
            this.lbApproved.BackColor = System.Drawing.Color.LightGreen;
            this.lbApproved.Font = new System.Drawing.Font("Segoe UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApproved.ForeColor = System.Drawing.Color.Black;
            this.lbApproved.Location = new System.Drawing.Point(0, 34);
            this.lbApproved.Name = "lbApproved";
            this.lbApproved.Padding = new System.Windows.Forms.Padding(5);
            this.lbApproved.Size = new System.Drawing.Size(173, 40);
            this.lbApproved.TabIndex = 4;
            this.lbApproved.Text = "GOEDGEKEURD";
            // 
            // ApplicationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbTitleNameWrapper);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ApplicationControl";
            this.Size = new System.Drawing.Size(813, 85);
            this.lbTitleNameWrapper.ResumeLayout(false);
            this.lbTitleNameWrapper.PerformLayout();
            this.titleWrapper.ResumeLayout(false);
            this.titleWrapper.PerformLayout();
            this.lbCancelledWrapper.ResumeLayout(false);
            this.lbCancelledWrapper.PerformLayout();
            this.lbInterviewWrapper.ResumeLayout(false);
            this.lbInterviewWrapper.PerformLayout();
            this.lbApprovedWrapper.ResumeLayout(false);
            this.lbApprovedWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel lbTitleNameWrapper;
        private System.Windows.Forms.Panel titleWrapper;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel lbCancelledWrapper;
        private System.Windows.Forms.Label lbCancelled;
        private System.Windows.Forms.Panel lbInterviewWrapper;
        private System.Windows.Forms.Label lbInterview;
        private System.Windows.Forms.Panel lbApprovedWrapper;
        private System.Windows.Forms.Label lbApproved;
    }
}
