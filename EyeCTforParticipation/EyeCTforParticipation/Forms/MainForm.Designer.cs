namespace EyeCTforParticipation.Forms
{
    partial class MainForm
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
            this.views = new EyeCTforParticipation.Controls.ViewControl();
            this.startView = new System.Windows.Forms.TabPage();
            this.lbStartTitle = new System.Windows.Forms.Label();
            this.volunteerView = new System.Windows.Forms.TabPage();
            this.btSearchWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btSearch = new System.Windows.Forms.Button();
            this.lbVolunteerTitle = new System.Windows.Forms.Label();
            this.searchView = new System.Windows.Forms.TabPage();
            this.resultsWrapper = new System.Windows.Forms.Panel();
            this.searchSeperator = new EyeCTforParticipation.Controls.HorizontalSeperatorControl();
            this.titleWrapper = new System.Windows.Forms.Panel();
            this.search = new EyeCTforParticipation.Controls.SearchControl();
            this.btBackWrapper = new System.Windows.Forms.Panel();
            this.btBack = new System.Windows.Forms.Button();
            this.resultView = new System.Windows.Forms.TabPage();
            this.helpRequest = new EyeCTforParticipation.Controls.HelpRequestControl();
            this.account = new EyeCTforParticipation.Controls.AccountControl();
            this.views.SuspendLayout();
            this.startView.SuspendLayout();
            this.volunteerView.SuspendLayout();
            this.btSearchWrapper.SuspendLayout();
            this.searchView.SuspendLayout();
            this.titleWrapper.SuspendLayout();
            this.btBackWrapper.SuspendLayout();
            this.resultView.SuspendLayout();
            this.SuspendLayout();
            // 
            // views
            // 
            this.views.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.views.Controls.Add(this.startView);
            this.views.Controls.Add(this.volunteerView);
            this.views.Controls.Add(this.searchView);
            this.views.Controls.Add(this.resultView);
            this.views.CurrentView = this.searchView;
            this.views.Dock = System.Windows.Forms.DockStyle.Fill;
            this.views.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.views.ItemSize = new System.Drawing.Size(0, 1);
            this.views.Location = new System.Drawing.Point(0, 148);
            this.views.Margin = new System.Windows.Forms.Padding(0);
            this.views.Name = "views";
            this.views.Padding = new System.Drawing.Point(0, 0);
            this.views.SelectedIndex = 0;
            this.views.Size = new System.Drawing.Size(1574, 781);
            this.views.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.views.TabIndex = 0;
            // 
            // startView
            // 
            this.startView.BackColor = System.Drawing.Color.White;
            this.startView.Controls.Add(this.lbStartTitle);
            this.startView.Location = new System.Drawing.Point(0, 0);
            this.startView.Margin = new System.Windows.Forms.Padding(0);
            this.startView.Name = "startView";
            this.startView.Size = new System.Drawing.Size(1574, 781);
            this.startView.TabIndex = 2;
            this.startView.Text = "tabPage1";
            // 
            // lbStartTitle
            // 
            this.lbStartTitle.AutoSize = true;
            this.lbStartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbStartTitle.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartTitle.Location = new System.Drawing.Point(0, 0);
            this.lbStartTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbStartTitle.Name = "lbStartTitle";
            this.lbStartTitle.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.lbStartTitle.Size = new System.Drawing.Size(599, 151);
            this.lbStartTitle.TabIndex = 0;
            this.lbStartTitle.Text = "EyeCT for Participation";
            this.lbStartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // volunteerView
            // 
            this.volunteerView.BackColor = System.Drawing.Color.White;
            this.volunteerView.Controls.Add(this.btSearchWrapper);
            this.volunteerView.Controls.Add(this.lbVolunteerTitle);
            this.volunteerView.Location = new System.Drawing.Point(0, 0);
            this.volunteerView.Margin = new System.Windows.Forms.Padding(0);
            this.volunteerView.Name = "volunteerView";
            this.volunteerView.Size = new System.Drawing.Size(1574, 781);
            this.volunteerView.TabIndex = 3;
            this.volunteerView.Text = "tabPage1";
            // 
            // btSearchWrapper
            // 
            this.btSearchWrapper.AutoSize = true;
            this.btSearchWrapper.Controls.Add(this.btSearch);
            this.btSearchWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSearchWrapper.Location = new System.Drawing.Point(0, 151);
            this.btSearchWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btSearchWrapper.Name = "btSearchWrapper";
            this.btSearchWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 0, 20);
            this.btSearchWrapper.Size = new System.Drawing.Size(1574, 87);
            this.btSearchWrapper.TabIndex = 19;
            // 
            // btSearch
            // 
            this.btSearch.AutoSize = true;
            this.btSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSearch.FlatAppearance.BorderSize = 0;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSearch.Location = new System.Drawing.Point(40, 0);
            this.btSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btSearch.Name = "btSearch";
            this.btSearch.Padding = new System.Windows.Forms.Padding(10);
            this.btSearch.Size = new System.Drawing.Size(149, 67);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "ZOEKEN";
            this.btSearch.UseVisualStyleBackColor = false;
            // 
            // lbVolunteerTitle
            // 
            this.lbVolunteerTitle.AutoSize = true;
            this.lbVolunteerTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbVolunteerTitle.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVolunteerTitle.Location = new System.Drawing.Point(0, 0);
            this.lbVolunteerTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbVolunteerTitle.Name = "lbVolunteerTitle";
            this.lbVolunteerTitle.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.lbVolunteerTitle.Size = new System.Drawing.Size(599, 151);
            this.lbVolunteerTitle.TabIndex = 1;
            this.lbVolunteerTitle.Text = "EyeCT for Participation";
            this.lbVolunteerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchView
            // 
            this.searchView.Controls.Add(this.resultsWrapper);
            this.searchView.Controls.Add(this.searchSeperator);
            this.searchView.Controls.Add(this.titleWrapper);
            this.searchView.Location = new System.Drawing.Point(0, 0);
            this.searchView.Margin = new System.Windows.Forms.Padding(0);
            this.searchView.Name = "searchView";
            this.searchView.Size = new System.Drawing.Size(1574, 781);
            this.searchView.TabIndex = 0;
            this.searchView.Text = "tabPage1";
            this.searchView.UseVisualStyleBackColor = true;
            // 
            // resultsWrapper
            // 
            this.resultsWrapper.AutoScroll = true;
            this.resultsWrapper.BackColor = System.Drawing.Color.White;
            this.resultsWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsWrapper.Location = new System.Drawing.Point(0, 203);
            this.resultsWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.resultsWrapper.Name = "resultsWrapper";
            this.resultsWrapper.Size = new System.Drawing.Size(1574, 578);
            this.resultsWrapper.TabIndex = 15;
            // 
            // searchSeperator
            // 
            this.searchSeperator.AutoSize = true;
            this.searchSeperator.BackColor = System.Drawing.Color.Silver;
            this.searchSeperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchSeperator.Location = new System.Drawing.Point(0, 202);
            this.searchSeperator.Margin = new System.Windows.Forms.Padding(0);
            this.searchSeperator.Name = "searchSeperator";
            this.searchSeperator.Size = new System.Drawing.Size(1574, 1);
            this.searchSeperator.TabIndex = 0;
            // 
            // titleWrapper
            // 
            this.titleWrapper.AutoSize = true;
            this.titleWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleWrapper.BackColor = System.Drawing.Color.White;
            this.titleWrapper.Controls.Add(this.search);
            this.titleWrapper.Controls.Add(this.btBackWrapper);
            this.titleWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleWrapper.Location = new System.Drawing.Point(0, 0);
            this.titleWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.titleWrapper.Name = "titleWrapper";
            this.titleWrapper.Size = new System.Drawing.Size(1574, 202);
            this.titleWrapper.TabIndex = 14;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.search.BackColor = System.Drawing.Color.White;
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.Location = new System.Drawing.Point(120, 0);
            this.search.Margin = new System.Windows.Forms.Padding(0);
            this.search.MinimumSize = new System.Drawing.Size(1200, 202);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(1454, 202);
            this.search.TabIndex = 0;
            this.search.Search += new System.EventHandler(this.searchControl_Search);
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
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // resultView
            // 
            this.resultView.Controls.Add(this.helpRequest);
            this.resultView.Location = new System.Drawing.Point(0, 0);
            this.resultView.Margin = new System.Windows.Forms.Padding(0);
            this.resultView.Name = "resultView";
            this.resultView.Size = new System.Drawing.Size(1574, 781);
            this.resultView.TabIndex = 1;
            this.resultView.Text = "tabPage2";
            this.resultView.UseVisualStyleBackColor = true;
            // 
            // helpRequest
            // 
            this.helpRequest.AutoSize = true;
            this.helpRequest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpRequest.BackColor = System.Drawing.Color.White;
            this.helpRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpRequest.Location = new System.Drawing.Point(0, 0);
            this.helpRequest.Margin = new System.Windows.Forms.Padding(0);
            this.helpRequest.Name = "helpRequest";
            this.helpRequest.Size = new System.Drawing.Size(1574, 781);
            this.helpRequest.TabIndex = 0;
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.account.BackColor = System.Drawing.Color.White;
            this.account.Dock = System.Windows.Forms.DockStyle.Top;
            this.account.Location = new System.Drawing.Point(0, 0);
            this.account.MinimumSize = new System.Drawing.Size(920, 0);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(1574, 148);
            this.account.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1574, 929);
            this.Controls.Add(this.views);
            this.Controls.Add(this.account);
            this.MinimumSize = new System.Drawing.Size(1600, 360);
            this.Name = "MainForm";
            this.Text = "EyeCT for Participation";
            this.views.ResumeLayout(false);
            this.startView.ResumeLayout(false);
            this.startView.PerformLayout();
            this.volunteerView.ResumeLayout(false);
            this.volunteerView.PerformLayout();
            this.btSearchWrapper.ResumeLayout(false);
            this.btSearchWrapper.PerformLayout();
            this.searchView.ResumeLayout(false);
            this.searchView.PerformLayout();
            this.titleWrapper.ResumeLayout(false);
            this.titleWrapper.PerformLayout();
            this.btBackWrapper.ResumeLayout(false);
            this.resultView.ResumeLayout(false);
            this.resultView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel btBackWrapper;
        private System.Windows.Forms.Panel titleWrapper;
        private System.Windows.Forms.Panel resultsWrapper;
        private Controls.HorizontalSeperatorControl searchSeperator;
        private Controls.SearchControl search;
        private Controls.ViewControl views;
        private System.Windows.Forms.TabPage searchView;
        private System.Windows.Forms.TabPage resultView;
        private Controls.HelpRequestControl helpRequest;
        private System.Windows.Forms.TabPage startView;
        private System.Windows.Forms.Label lbStartTitle;
        private System.Windows.Forms.TabPage volunteerView;
        private System.Windows.Forms.Label lbVolunteerTitle;
        private System.Windows.Forms.FlowLayoutPanel btSearchWrapper;
        private System.Windows.Forms.Button btSearch;
        private Controls.AccountControl account;
    }
}