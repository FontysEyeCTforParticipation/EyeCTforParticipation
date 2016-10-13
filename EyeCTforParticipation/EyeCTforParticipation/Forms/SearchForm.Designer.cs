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
            this.titleWrapper = new System.Windows.Forms.Panel();
            this.btBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchControl = new EyeCTforParticipation.Controls.SearchControl();
            this.titleWrapper.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleWrapper
            // 
            this.titleWrapper.AutoSize = true;
            this.titleWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleWrapper.BackColor = System.Drawing.Color.White;
            this.titleWrapper.Controls.Add(this.searchControl);
            this.titleWrapper.Controls.Add(this.panel1);
            this.titleWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleWrapper.Location = new System.Drawing.Point(0, 0);
            this.titleWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.titleWrapper.Name = "titleWrapper";
            this.titleWrapper.Size = new System.Drawing.Size(1174, 190);
            this.titleWrapper.TabIndex = 14;
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
            this.btBack.Size = new System.Drawing.Size(80, 110);
            this.btBack.TabIndex = 14;
            this.btBack.Text = "❮";
            this.btBack.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.panel1.Size = new System.Drawing.Size(120, 190);
            this.panel1.TabIndex = 15;
            // 
            // searchControl
            // 
            this.searchControl.AutoSize = true;
            this.searchControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchControl.BackColor = System.Drawing.Color.White;
            this.searchControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchControl.Location = new System.Drawing.Point(120, 0);
            this.searchControl.Margin = new System.Windows.Forms.Padding(0);
            this.searchControl.MinimumSize = new System.Drawing.Size(920, 190);
            this.searchControl.Name = "searchControl";
            this.searchControl.Size = new System.Drawing.Size(1054, 190);
            this.searchControl.TabIndex = 13;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 629);
            this.Controls.Add(this.titleWrapper);
            this.MinimumSize = new System.Drawing.Size(1200, 71);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.titleWrapper.ResumeLayout(false);
            this.titleWrapper.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.SearchControl searchControl;
        private System.Windows.Forms.Panel titleWrapper;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel panel1;
    }
}