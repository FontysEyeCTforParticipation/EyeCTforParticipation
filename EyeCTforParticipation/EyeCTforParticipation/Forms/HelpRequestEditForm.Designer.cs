namespace EyeCTforParticipation.Forms
{
    partial class HelpRequestEditForm
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
            this.titleWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleWrapper
            // 
            this.titleWrapper.AutoSize = true;
            this.titleWrapper.BackColor = System.Drawing.Color.White;
            this.titleWrapper.Controls.Add(this.lbTitle);
            this.titleWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleWrapper.Location = new System.Drawing.Point(0, 0);
            this.titleWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.titleWrapper.Name = "titleWrapper";
            this.titleWrapper.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.titleWrapper.Size = new System.Drawing.Size(944, 180);
            this.titleWrapper.TabIndex = 13;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Font = new System.Drawing.Font(Logic.CustomFonts.Roboto, 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(40, 40);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.MinimumSize = new System.Drawing.Size(300, 100);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(300, 100);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Hulpvraag";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HelpRequestEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 1229);
            this.Controls.Add(this.titleWrapper);
            this.Name = "HelpRequestEditForm";
            this.Text = "HelpRequestEditForm";
            this.titleWrapper.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel titleWrapper;
        private System.Windows.Forms.Label lbTitle;
    }
}