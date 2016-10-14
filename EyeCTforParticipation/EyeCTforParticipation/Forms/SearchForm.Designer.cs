namespace EyeCTforParticipation.Forms
{
    partial class SearchForm
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
            this.btBack = new System.Windows.Forms.Button();
            this.btBackWrapper = new System.Windows.Forms.Panel();
            this.titleWrapper = new System.Windows.Forms.Panel();
            this.resultsWrapper = new System.Windows.Forms.Panel();
            this.seperator = new EyeCTforParticipation.Controls.HorizontalSeperatorControl();
            this.searchControl = new EyeCTforParticipation.Controls.SearchControl();
            this.btBackWrapper.SuspendLayout();
            this.titleWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.White;
            this.btBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Arial Narrow", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btBack.Location = new System.Drawing.Point(40, 40);
            this.btBack.Margin = new System.Windows.Forms.Padding(0);
            this.btBack.MinimumSize = new System.Drawing.Size(80, 100);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(80, 122);
            this.btBack.TabIndex = 14;
            this.btBack.Text = "❮";
            this.btBack.UseVisualStyleBackColor = false;
            // 
            // btBackWrapper
            // 
            this.btBackWrapper.AutoSize = true;
            this.btBackWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btBackWrapper.BackColor = System.Drawing.Color.White;
            this.btBackWrapper.Controls.Add(this.btBack);
            this.btBackWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.btBackWrapper.Location = new System.Drawing.Point(0, 0);
            this.btBackWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btBackWrapper.Name = "btBackWrapper";
            this.btBackWrapper.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.btBackWrapper.Size = new System.Drawing.Size(120, 202);
            this.btBackWrapper.TabIndex = 15;
            // 
            // titleWrapper
            // 
            this.titleWrapper.AutoSize = true;
            this.titleWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleWrapper.BackColor = System.Drawing.Color.White;
            this.titleWrapper.Controls.Add(this.searchControl);
            this.titleWrapper.Controls.Add(this.btBackWrapper);
            this.titleWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleWrapper.Location = new System.Drawing.Point(0, 0);
            this.titleWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.titleWrapper.Name = "titleWrapper";
            this.titleWrapper.Size = new System.Drawing.Size(1574, 202);
            this.titleWrapper.TabIndex = 14;
            // 
            // resultsWrapper
            // 
            this.resultsWrapper.AutoScroll = true;
            this.resultsWrapper.BackColor = System.Drawing.Color.White;
            this.resultsWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsWrapper.Location = new System.Drawing.Point(0, 203);
            this.resultsWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.resultsWrapper.Name = "resultsWrapper";
            this.resultsWrapper.Size = new System.Drawing.Size(1574, 726);
            this.resultsWrapper.TabIndex = 15;
            // 
            // seperator
            // 
            this.seperator.AutoSize = true;
            this.seperator.BackColor = System.Drawing.Color.Silver;
            this.seperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.seperator.Location = new System.Drawing.Point(0, 202);
            this.seperator.Margin = new System.Windows.Forms.Padding(0);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(1574, 1);
            this.seperator.TabIndex = 0;
            // 
            // searchControl
            // 
            this.searchControl.AutoSize = true;
            this.searchControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchControl.BackColor = System.Drawing.Color.White;
            this.searchControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchControl.Location = new System.Drawing.Point(120, 0);
            this.searchControl.Margin = new System.Windows.Forms.Padding(0);
            this.searchControl.MinimumSize = new System.Drawing.Size(1200, 202);
            this.searchControl.Name = "searchControl";
            this.searchControl.Size = new System.Drawing.Size(1454, 202);
            this.searchControl.TabIndex = 0;
            this.searchControl.Search += new System.EventHandler(this.searchControl_Search);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1574, 929);
            this.Controls.Add(this.resultsWrapper);
            this.Controls.Add(this.seperator);
            this.Controls.Add(this.titleWrapper);
            this.MinimumSize = new System.Drawing.Size(1600, 360);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.btBackWrapper.ResumeLayout(false);
            this.titleWrapper.ResumeLayout(false);
            this.titleWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel btBackWrapper;
        private System.Windows.Forms.Panel titleWrapper;
        private System.Windows.Forms.Panel resultsWrapper;
        private Controls.HorizontalSeperatorControl seperator;
        private Controls.SearchControl searchControl;
    }
}