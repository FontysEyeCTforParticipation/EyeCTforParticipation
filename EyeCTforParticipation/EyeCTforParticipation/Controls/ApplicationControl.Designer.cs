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
            this.wrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.titleWrapper = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCancelledWrapper = new System.Windows.Forms.Panel();
            this.lbCancelled = new System.Windows.Forms.Label();
            this.lbInterviewWrapper = new System.Windows.Forms.Panel();
            this.lbInterview = new System.Windows.Forms.Label();
            this.lbApprovedWrapper = new System.Windows.Forms.Panel();
            this.lbApproved = new System.Windows.Forms.Label();
            this.btWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btApprove = new System.Windows.Forms.Button();
            this.btInterview = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.wrapper.SuspendLayout();
            this.titleWrapper.SuspendLayout();
            this.lbCancelledWrapper.SuspendLayout();
            this.lbInterviewWrapper.SuspendLayout();
            this.lbApprovedWrapper.SuspendLayout();
            this.btWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // wrapper
            // 
            this.wrapper.AutoSize = true;
            this.wrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.wrapper.BackColor = System.Drawing.Color.Transparent;
            this.wrapper.Controls.Add(this.titleWrapper);
            this.wrapper.Controls.Add(this.lbDate);
            this.wrapper.Controls.Add(this.btWrapper);
            this.wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapper.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.wrapper.Location = new System.Drawing.Point(0, 0);
            this.wrapper.Margin = new System.Windows.Forms.Padding(0);
            this.wrapper.Name = "wrapper";
            this.wrapper.Size = new System.Drawing.Size(784, 297);
            this.wrapper.TabIndex = 6;
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
            this.titleWrapper.Size = new System.Drawing.Size(733, 85);
            this.titleWrapper.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbName.Font = new System.Drawing.Font(Logic.CustomFonts.Roboto, 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbName.Location = new System.Drawing.Point(520, 0);
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
            this.lbCancelledWrapper.Location = new System.Drawing.Point(388, 0);
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
            this.lbCancelled.Font = new System.Drawing.Font(Logic.CustomFonts.Roboto, 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lbInterviewWrapper.Size = new System.Drawing.Size(172, 85);
            this.lbInterviewWrapper.TabIndex = 6;
            this.lbInterviewWrapper.Visible = false;
            // 
            // lbInterview
            // 
            this.lbInterview.AutoSize = true;
            this.lbInterview.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbInterview.Font = new System.Drawing.Font(Logic.CustomFonts.Roboto, 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInterview.ForeColor = System.Drawing.Color.White;
            this.lbInterview.Location = new System.Drawing.Point(0, 34);
            this.lbInterview.Name = "lbInterview";
            this.lbInterview.Padding = new System.Windows.Forms.Padding(5);
            this.lbInterview.Size = new System.Drawing.Size(169, 40);
            this.lbInterview.TabIndex = 4;
            this.lbInterview.Text = "KENNISMAKEN";
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
            this.lbApproved.Font = new System.Drawing.Font(Logic.CustomFonts.Roboto, 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApproved.ForeColor = System.Drawing.Color.Black;
            this.lbApproved.Location = new System.Drawing.Point(0, 34);
            this.lbApproved.Name = "lbApproved";
            this.lbApproved.Padding = new System.Windows.Forms.Padding(5);
            this.lbApproved.Size = new System.Drawing.Size(173, 40);
            this.lbApproved.TabIndex = 4;
            this.lbApproved.Text = "GOEDGEKEURD";
            // 
            // btWrapper
            // 
            this.btWrapper.AutoSize = true;
            this.btWrapper.Controls.Add(this.btApprove);
            this.btWrapper.Controls.Add(this.btInterview);
            this.btWrapper.Controls.Add(this.btCancel);
            this.btWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.btWrapper.Location = new System.Drawing.Point(0, 170);
            this.btWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btWrapper.Name = "btWrapper";
            this.btWrapper.Padding = new System.Windows.Forms.Padding(40, 20, 40, 40);
            this.btWrapper.Size = new System.Drawing.Size(784, 127);
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
            this.btApprove.Font = new System.Drawing.Font(Logic.CustomFonts.Roboto, 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btApprove.Location = new System.Drawing.Point(40, 20);
            this.btApprove.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btApprove.Name = "btApprove";
            this.btApprove.Padding = new System.Windows.Forms.Padding(10);
            this.btApprove.Size = new System.Drawing.Size(221, 67);
            this.btApprove.TabIndex = 4;
            this.btApprove.Text = "GOEDKEUREN";
            this.btApprove.UseVisualStyleBackColor = false;
            this.btApprove.Visible = false;
            this.btApprove.Click += new System.EventHandler(this.btApprove_Click);
            // 
            // btInterview
            // 
            this.btInterview.AutoSize = true;
            this.btInterview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btInterview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btInterview.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btInterview.FlatAppearance.BorderSize = 0;
            this.btInterview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInterview.Font = new System.Drawing.Font(Logic.CustomFonts.Roboto, 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInterview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btInterview.Location = new System.Drawing.Point(281, 20);
            this.btInterview.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btInterview.Name = "btInterview";
            this.btInterview.Padding = new System.Windows.Forms.Padding(10);
            this.btInterview.Size = new System.Drawing.Size(238, 67);
            this.btInterview.TabIndex = 5;
            this.btInterview.Text = "KENNISMAKEN";
            this.btInterview.UseVisualStyleBackColor = false;
            this.btInterview.Visible = false;
            this.btInterview.Click += new System.EventHandler(this.btInterview_Click);
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font(Logic.CustomFonts.Roboto, 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCancel.Location = new System.Drawing.Point(539, 20);
            this.btCancel.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btCancel.Name = "btCancel";
            this.btCancel.Padding = new System.Windows.Forms.Padding(10);
            this.btCancel.Size = new System.Drawing.Size(185, 67);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "AFMELDEN";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Visible = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font(Logic.CustomFonts.Roboto, 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Gray;
            this.lbDate.Location = new System.Drawing.Point(0, 85);
            this.lbDate.Margin = new System.Windows.Forms.Padding(0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Padding = new System.Windows.Forms.Padding(40, 10, 60, 30);
            this.lbDate.Size = new System.Drawing.Size(282, 85);
            this.lbDate.TabIndex = 19;
            this.lbDate.Text = "10-10-2016";
            // 
            // ApplicationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.wrapper);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ApplicationControl";
            this.Size = new System.Drawing.Size(784, 297);
            this.wrapper.ResumeLayout(false);
            this.wrapper.PerformLayout();
            this.titleWrapper.ResumeLayout(false);
            this.titleWrapper.PerformLayout();
            this.lbCancelledWrapper.ResumeLayout(false);
            this.lbCancelledWrapper.PerformLayout();
            this.lbInterviewWrapper.ResumeLayout(false);
            this.lbInterviewWrapper.PerformLayout();
            this.lbApprovedWrapper.ResumeLayout(false);
            this.lbApprovedWrapper.PerformLayout();
            this.btWrapper.ResumeLayout(false);
            this.btWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel wrapper;
        private System.Windows.Forms.Panel titleWrapper;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel lbCancelledWrapper;
        private System.Windows.Forms.Label lbCancelled;
        private System.Windows.Forms.Panel lbInterviewWrapper;
        private System.Windows.Forms.Label lbInterview;
        private System.Windows.Forms.Panel lbApprovedWrapper;
        private System.Windows.Forms.Label lbApproved;
        private System.Windows.Forms.FlowLayoutPanel btWrapper;
        private System.Windows.Forms.Button btApprove;
        private System.Windows.Forms.Button btInterview;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label lbDate;
    }
}
