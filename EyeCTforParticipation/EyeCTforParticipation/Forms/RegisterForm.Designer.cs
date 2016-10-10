﻿namespace EyeCTforParticipation.Forms
{
    partial class RegisterForm
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
            this.titleWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.registerControl = new EyeCTforParticipation.Controls.RegisterControl();
            this.titleWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleWrapper
            // 
            this.titleWrapper.AutoSize = true;
            this.titleWrapper.Controls.Add(this.lbTitle);
            this.titleWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleWrapper.Location = new System.Drawing.Point(0, 0);
            this.titleWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.titleWrapper.Name = "titleWrapper";
            this.titleWrapper.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.titleWrapper.Size = new System.Drawing.Size(714, 180);
            this.titleWrapper.TabIndex = 12;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(40, 40);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.MinimumSize = new System.Drawing.Size(300, 100);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(300, 100);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Register";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // registerControl
            // 
            this.registerControl.AutoScroll = true;
            this.registerControl.BackColor = System.Drawing.Color.White;
            this.registerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerControl.Location = new System.Drawing.Point(0, 180);
            this.registerControl.Margin = new System.Windows.Forms.Padding(0);
            this.registerControl.Name = "registerControl";
            this.registerControl.Size = new System.Drawing.Size(714, 669);
            this.registerControl.TabIndex = 13;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 849);
            this.Controls.Add(this.registerControl);
            this.Controls.Add(this.titleWrapper);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(740, 920);
            this.MinimumSize = new System.Drawing.Size(740, 920);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.titleWrapper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel titleWrapper;
        private System.Windows.Forms.Label lbTitle;
        private Controls.RegisterControl registerControl;
    }
}