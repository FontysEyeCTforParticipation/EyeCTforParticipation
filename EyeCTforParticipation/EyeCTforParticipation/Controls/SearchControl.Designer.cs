namespace EyeCTforParticipation.Controls
{
    partial class SearchControl
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
            this.tbSearchWrapper = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.searchWrapper = new System.Windows.Forms.Panel();
            this.locationWrapper = new System.Windows.Forms.Panel();
            this.tbPostalCodeWrapper = new System.Windows.Forms.Panel();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.cbDistance = new System.Windows.Forms.ComboBox();
            this.lbPostalCode = new System.Windows.Forms.Label();
            this.btSearchWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbSearchWrapper.SuspendLayout();
            this.searchWrapper.SuspendLayout();
            this.locationWrapper.SuspendLayout();
            this.tbPostalCodeWrapper.SuspendLayout();
            this.btSearchWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearchWrapper
            // 
            this.tbSearchWrapper.AutoSize = true;
            this.tbSearchWrapper.Controls.Add(this.tbSearch);
            this.tbSearchWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearchWrapper.Location = new System.Drawing.Point(0, 105);
            this.tbSearchWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbSearchWrapper.Name = "tbSearchWrapper";
            this.tbSearchWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 20, 40);
            this.tbSearchWrapper.Size = new System.Drawing.Size(384, 83);
            this.tbSearchWrapper.TabIndex = 7;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(40, 0);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(324, 43);
            this.tbSearch.TabIndex = 1;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSearch.Location = new System.Drawing.Point(0, 0);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Padding = new System.Windows.Forms.Padding(40, 40, 40, 20);
            this.lbSearch.Size = new System.Drawing.Size(205, 105);
            this.lbSearch.TabIndex = 8;
            this.lbSearch.Text = "Zoeken";
            // 
            // searchWrapper
            // 
            this.searchWrapper.Controls.Add(this.tbSearchWrapper);
            this.searchWrapper.Controls.Add(this.lbSearch);
            this.searchWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchWrapper.Location = new System.Drawing.Point(0, 0);
            this.searchWrapper.Name = "searchWrapper";
            this.searchWrapper.Size = new System.Drawing.Size(384, 190);
            this.searchWrapper.TabIndex = 2;
            // 
            // locationWrapper
            // 
            this.locationWrapper.Controls.Add(this.tbPostalCodeWrapper);
            this.locationWrapper.Controls.Add(this.lbPostalCode);
            this.locationWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.locationWrapper.Location = new System.Drawing.Point(384, 0);
            this.locationWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.locationWrapper.MinimumSize = new System.Drawing.Size(360, 0);
            this.locationWrapper.Name = "locationWrapper";
            this.locationWrapper.Size = new System.Drawing.Size(360, 190);
            this.locationWrapper.TabIndex = 2;
            // 
            // tbPostalCodeWrapper
            // 
            this.tbPostalCodeWrapper.AutoSize = true;
            this.tbPostalCodeWrapper.Controls.Add(this.tbPostalCode);
            this.tbPostalCodeWrapper.Controls.Add(this.cbDistance);
            this.tbPostalCodeWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPostalCodeWrapper.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostalCodeWrapper.Location = new System.Drawing.Point(0, 105);
            this.tbPostalCodeWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.tbPostalCodeWrapper.Name = "tbPostalCodeWrapper";
            this.tbPostalCodeWrapper.Padding = new System.Windows.Forms.Padding(20, 0, 20, 40);
            this.tbPostalCodeWrapper.Size = new System.Drawing.Size(360, 85);
            this.tbPostalCodeWrapper.TabIndex = 8;
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPostalCode.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostalCode.Location = new System.Drawing.Point(20, 0);
            this.tbPostalCode.Margin = new System.Windows.Forms.Padding(0);
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(199, 43);
            this.tbPostalCode.TabIndex = 3;
            // 
            // cbDistance
            // 
            this.cbDistance.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbDistance.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbDistance.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDistance.FormattingEnabled = true;
            this.cbDistance.IntegralHeight = false;
            this.cbDistance.ItemHeight = 37;
            this.cbDistance.Location = new System.Drawing.Point(219, 0);
            this.cbDistance.Margin = new System.Windows.Forms.Padding(0);
            this.cbDistance.Name = "cbDistance";
            this.cbDistance.Size = new System.Drawing.Size(121, 43);
            this.cbDistance.TabIndex = 2;
            // 
            // lbPostalCode
            // 
            this.lbPostalCode.AutoSize = true;
            this.lbPostalCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPostalCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPostalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPostalCode.Location = new System.Drawing.Point(0, 0);
            this.lbPostalCode.Margin = new System.Windows.Forms.Padding(0);
            this.lbPostalCode.Name = "lbPostalCode";
            this.lbPostalCode.Padding = new System.Windows.Forms.Padding(20, 40, 40, 20);
            this.lbPostalCode.Size = new System.Drawing.Size(211, 105);
            this.lbPostalCode.TabIndex = 9;
            this.lbPostalCode.Text = "Postcode";
            // 
            // btSearchWrapper
            // 
            this.btSearchWrapper.AutoSize = true;
            this.btSearchWrapper.Controls.Add(this.btSearch);
            this.btSearchWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSearchWrapper.Location = new System.Drawing.Point(744, 0);
            this.btSearchWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btSearchWrapper.Name = "btSearchWrapper";
            this.btSearchWrapper.Padding = new System.Windows.Forms.Padding(20, 105, 40, 0);
            this.btSearchWrapper.Size = new System.Drawing.Size(176, 190);
            this.btSearchWrapper.TabIndex = 10;
            // 
            // btSearch
            // 
            this.btSearch.AutoSize = true;
            this.btSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSearch.FlatAppearance.BorderSize = 0;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSearch.Location = new System.Drawing.Point(20, 105);
            this.btSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btSearch.Name = "btSearch";
            this.btSearch.Padding = new System.Windows.Forms.Padding(1);
            this.btSearch.Size = new System.Drawing.Size(116, 44);
            this.btSearch.TabIndex = 3;
            this.btSearch.Text = "ZOEKEN";
            this.btSearch.UseVisualStyleBackColor = false;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.searchWrapper);
            this.Controls.Add(this.locationWrapper);
            this.Controls.Add(this.btSearchWrapper);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(920, 190);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(920, 190);
            this.tbSearchWrapper.ResumeLayout(false);
            this.tbSearchWrapper.PerformLayout();
            this.searchWrapper.ResumeLayout(false);
            this.searchWrapper.PerformLayout();
            this.locationWrapper.ResumeLayout(false);
            this.locationWrapper.PerformLayout();
            this.tbPostalCodeWrapper.ResumeLayout(false);
            this.tbPostalCodeWrapper.PerformLayout();
            this.btSearchWrapper.ResumeLayout(false);
            this.btSearchWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tbSearchWrapper;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Panel searchWrapper;
        private System.Windows.Forms.Panel locationWrapper;
        private System.Windows.Forms.Panel tbPostalCodeWrapper;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.ComboBox cbDistance;
        private System.Windows.Forms.Label lbPostalCode;
        private System.Windows.Forms.FlowLayoutPanel btSearchWrapper;
        private System.Windows.Forms.Button btSearch;
    }
}
