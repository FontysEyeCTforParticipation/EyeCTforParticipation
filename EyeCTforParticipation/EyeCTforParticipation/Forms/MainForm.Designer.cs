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
            this.helpSeekerView = new System.Windows.Forms.TabPage();
            this.btAidWorkersManageWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btAidWorkersManage = new System.Windows.Forms.Button();
            this.lbAidWorkers = new System.Windows.Forms.Label();
            this.btHelpRequestsManageWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btHelpRequestsManage = new System.Windows.Forms.Button();
            this.lbHelpRequests = new System.Windows.Forms.Label();
            this.btHelpSeekerEditProfileWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btHelpSeekerEditProfile = new System.Windows.Forms.Button();
            this.lbHelpSeekerProfile = new System.Windows.Forms.Label();
            this.helpSeekerTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.pbHelpSeekerAvatar = new System.Windows.Forms.PictureBox();
            this.lbHelpSeekerName = new System.Windows.Forms.Label();
            this.volunteerView = new System.Windows.Forms.TabPage();
            this.searchView = new System.Windows.Forms.TabPage();
            this.resultsWrapper = new System.Windows.Forms.Panel();
            this.searchSeperator = new EyeCTforParticipation.Controls.HorizontalSeperatorControl();
            this.searchTitleWrapper = new System.Windows.Forms.Panel();
            this.search = new EyeCTforParticipation.Controls.SearchControl();
            this.btSearchBackWrapper = new System.Windows.Forms.Panel();
            this.btSearchBack = new System.Windows.Forms.Button();
            this.helpRequestView = new System.Windows.Forms.TabPage();
            this.helpRequest = new EyeCTforParticipation.Controls.HelpRequestControl();
            this.helpRequestsManageView = new System.Windows.Forms.TabPage();
            this.helpRequestsWrapper = new System.Windows.Forms.Panel();
            this.helpRequestsSeperator = new EyeCTforParticipation.Controls.HorizontalSeperatorControl();
            this.helpRequestsTitleWrapper = new System.Windows.Forms.Panel();
            this.btHelpRequestCreateWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btHelpRequestCreate = new System.Windows.Forms.Button();
            this.lbHelpRequestsManage = new System.Windows.Forms.Label();
            this.btHelpRequestsBackWrapper = new System.Windows.Forms.Panel();
            this.btHelpRequestsBack = new System.Windows.Forms.Button();
            this.header = new EyeCTforParticipation.Controls.HeaderControl();
            this.volunteerTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.pbVolunteerAvatar = new System.Windows.Forms.PictureBox();
            this.lbVolunteerName = new System.Windows.Forms.Label();
            this.btVolunteerProfileWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btVolunteerProfile = new System.Windows.Forms.Button();
            this.lbVolunteerProfile = new System.Windows.Forms.Label();
            this.btSearchWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btSearch = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.views.SuspendLayout();
            this.startView.SuspendLayout();
            this.helpSeekerView.SuspendLayout();
            this.btAidWorkersManageWrapper.SuspendLayout();
            this.btHelpRequestsManageWrapper.SuspendLayout();
            this.btHelpSeekerEditProfileWrapper.SuspendLayout();
            this.helpSeekerTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelpSeekerAvatar)).BeginInit();
            this.volunteerView.SuspendLayout();
            this.searchView.SuspendLayout();
            this.searchTitleWrapper.SuspendLayout();
            this.btSearchBackWrapper.SuspendLayout();
            this.helpRequestView.SuspendLayout();
            this.helpRequestsManageView.SuspendLayout();
            this.helpRequestsTitleWrapper.SuspendLayout();
            this.btHelpRequestCreateWrapper.SuspendLayout();
            this.btHelpRequestsBackWrapper.SuspendLayout();
            this.volunteerTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolunteerAvatar)).BeginInit();
            this.btVolunteerProfileWrapper.SuspendLayout();
            this.btSearchWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // views
            // 
            this.views.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.views.Controls.Add(this.startView);
            this.views.Controls.Add(this.helpSeekerView);
            this.views.Controls.Add(this.volunteerView);
            this.views.Controls.Add(this.searchView);
            this.views.Controls.Add(this.helpRequestView);
            this.views.Controls.Add(this.helpRequestsManageView);
            this.views.CurrentView = this.volunteerView;
            this.views.Dock = System.Windows.Forms.DockStyle.Fill;
            this.views.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.views.ItemSize = new System.Drawing.Size(0, 1);
            this.views.Location = new System.Drawing.Point(0, 148);
            this.views.Margin = new System.Windows.Forms.Padding(0);
            this.views.Name = "views";
            this.views.Padding = new System.Drawing.Point(0, 0);
            this.views.SelectedIndex = 0;
            this.views.Size = new System.Drawing.Size(1574, 981);
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
            this.startView.Size = new System.Drawing.Size(1574, 981);
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
            // helpSeekerView
            // 
            this.helpSeekerView.BackColor = System.Drawing.Color.White;
            this.helpSeekerView.Controls.Add(this.btAidWorkersManageWrapper);
            this.helpSeekerView.Controls.Add(this.lbAidWorkers);
            this.helpSeekerView.Controls.Add(this.btHelpRequestsManageWrapper);
            this.helpSeekerView.Controls.Add(this.lbHelpRequests);
            this.helpSeekerView.Controls.Add(this.btHelpSeekerEditProfileWrapper);
            this.helpSeekerView.Controls.Add(this.lbHelpSeekerProfile);
            this.helpSeekerView.Controls.Add(this.helpSeekerTitle);
            this.helpSeekerView.Location = new System.Drawing.Point(0, 0);
            this.helpSeekerView.Margin = new System.Windows.Forms.Padding(0);
            this.helpSeekerView.Name = "helpSeekerView";
            this.helpSeekerView.Size = new System.Drawing.Size(1574, 981);
            this.helpSeekerView.TabIndex = 4;
            this.helpSeekerView.Text = "tabPage1";
            // 
            // btAidWorkersManageWrapper
            // 
            this.btAidWorkersManageWrapper.AutoSize = true;
            this.btAidWorkersManageWrapper.Controls.Add(this.btAidWorkersManage);
            this.btAidWorkersManageWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAidWorkersManageWrapper.Location = new System.Drawing.Point(0, 826);
            this.btAidWorkersManageWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btAidWorkersManageWrapper.Name = "btAidWorkersManageWrapper";
            this.btAidWorkersManageWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 0, 20);
            this.btAidWorkersManageWrapper.Size = new System.Drawing.Size(1574, 87);
            this.btAidWorkersManageWrapper.TabIndex = 22;
            // 
            // btAidWorkersManage
            // 
            this.btAidWorkersManage.AutoSize = true;
            this.btAidWorkersManage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAidWorkersManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btAidWorkersManage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAidWorkersManage.FlatAppearance.BorderSize = 0;
            this.btAidWorkersManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAidWorkersManage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAidWorkersManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAidWorkersManage.Location = new System.Drawing.Point(40, 0);
            this.btAidWorkersManage.Margin = new System.Windows.Forms.Padding(0);
            this.btAidWorkersManage.Name = "btAidWorkersManage";
            this.btAidWorkersManage.Padding = new System.Windows.Forms.Padding(10);
            this.btAidWorkersManage.Size = new System.Drawing.Size(163, 67);
            this.btAidWorkersManage.TabIndex = 4;
            this.btAidWorkersManage.Text = "BEHEREN";
            this.btAidWorkersManage.UseVisualStyleBackColor = false;
            // 
            // lbAidWorkers
            // 
            this.lbAidWorkers.AutoSize = true;
            this.lbAidWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbAidWorkers.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAidWorkers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbAidWorkers.Location = new System.Drawing.Point(0, 675);
            this.lbAidWorkers.Margin = new System.Windows.Forms.Padding(0);
            this.lbAidWorkers.Name = "lbAidWorkers";
            this.lbAidWorkers.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.lbAidWorkers.Size = new System.Drawing.Size(392, 151);
            this.lbAidWorkers.TabIndex = 5;
            this.lbAidWorkers.Text = "Hulpverleners";
            this.lbAidWorkers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btHelpRequestsManageWrapper
            // 
            this.btHelpRequestsManageWrapper.AutoSize = true;
            this.btHelpRequestsManageWrapper.Controls.Add(this.btHelpRequestsManage);
            this.btHelpRequestsManageWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHelpRequestsManageWrapper.Location = new System.Drawing.Point(0, 588);
            this.btHelpRequestsManageWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btHelpRequestsManageWrapper.Name = "btHelpRequestsManageWrapper";
            this.btHelpRequestsManageWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 0, 20);
            this.btHelpRequestsManageWrapper.Size = new System.Drawing.Size(1574, 87);
            this.btHelpRequestsManageWrapper.TabIndex = 21;
            // 
            // btHelpRequestsManage
            // 
            this.btHelpRequestsManage.AutoSize = true;
            this.btHelpRequestsManage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btHelpRequestsManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btHelpRequestsManage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btHelpRequestsManage.FlatAppearance.BorderSize = 0;
            this.btHelpRequestsManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHelpRequestsManage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHelpRequestsManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btHelpRequestsManage.Location = new System.Drawing.Point(40, 0);
            this.btHelpRequestsManage.Margin = new System.Windows.Forms.Padding(0);
            this.btHelpRequestsManage.Name = "btHelpRequestsManage";
            this.btHelpRequestsManage.Padding = new System.Windows.Forms.Padding(10);
            this.btHelpRequestsManage.Size = new System.Drawing.Size(163, 67);
            this.btHelpRequestsManage.TabIndex = 4;
            this.btHelpRequestsManage.Text = "BEHEREN";
            this.btHelpRequestsManage.UseVisualStyleBackColor = false;
            this.btHelpRequestsManage.Click += new System.EventHandler(this.btHelpRequestsManage_Click);
            // 
            // lbHelpRequests
            // 
            this.lbHelpRequests.AutoSize = true;
            this.lbHelpRequests.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHelpRequests.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHelpRequests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHelpRequests.Location = new System.Drawing.Point(0, 437);
            this.lbHelpRequests.Margin = new System.Windows.Forms.Padding(0);
            this.lbHelpRequests.Name = "lbHelpRequests";
            this.lbHelpRequests.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.lbHelpRequests.Size = new System.Drawing.Size(341, 151);
            this.lbHelpRequests.TabIndex = 3;
            this.lbHelpRequests.Text = "Hulpvragen";
            this.lbHelpRequests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btHelpSeekerEditProfileWrapper
            // 
            this.btHelpSeekerEditProfileWrapper.AutoSize = true;
            this.btHelpSeekerEditProfileWrapper.Controls.Add(this.btHelpSeekerEditProfile);
            this.btHelpSeekerEditProfileWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.btHelpSeekerEditProfileWrapper.Location = new System.Drawing.Point(0, 350);
            this.btHelpSeekerEditProfileWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btHelpSeekerEditProfileWrapper.Name = "btHelpSeekerEditProfileWrapper";
            this.btHelpSeekerEditProfileWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 0, 20);
            this.btHelpSeekerEditProfileWrapper.Size = new System.Drawing.Size(1574, 87);
            this.btHelpSeekerEditProfileWrapper.TabIndex = 20;
            // 
            // btHelpSeekerEditProfile
            // 
            this.btHelpSeekerEditProfile.AutoSize = true;
            this.btHelpSeekerEditProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btHelpSeekerEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btHelpSeekerEditProfile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btHelpSeekerEditProfile.FlatAppearance.BorderSize = 0;
            this.btHelpSeekerEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHelpSeekerEditProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHelpSeekerEditProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btHelpSeekerEditProfile.Location = new System.Drawing.Point(40, 0);
            this.btHelpSeekerEditProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btHelpSeekerEditProfile.Name = "btHelpSeekerEditProfile";
            this.btHelpSeekerEditProfile.Padding = new System.Windows.Forms.Padding(10);
            this.btHelpSeekerEditProfile.Size = new System.Drawing.Size(170, 67);
            this.btHelpSeekerEditProfile.TabIndex = 4;
            this.btHelpSeekerEditProfile.Text = "WIJZIGEN";
            this.btHelpSeekerEditProfile.UseVisualStyleBackColor = false;
            // 
            // lbHelpSeekerProfile
            // 
            this.lbHelpSeekerProfile.AutoSize = true;
            this.lbHelpSeekerProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHelpSeekerProfile.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHelpSeekerProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbHelpSeekerProfile.Location = new System.Drawing.Point(0, 199);
            this.lbHelpSeekerProfile.Margin = new System.Windows.Forms.Padding(0);
            this.lbHelpSeekerProfile.Name = "lbHelpSeekerProfile";
            this.lbHelpSeekerProfile.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.lbHelpSeekerProfile.Size = new System.Drawing.Size(220, 151);
            this.lbHelpSeekerProfile.TabIndex = 4;
            this.lbHelpSeekerProfile.Text = "Profiel";
            this.lbHelpSeekerProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // helpSeekerTitle
            // 
            this.helpSeekerTitle.AutoSize = true;
            this.helpSeekerTitle.Controls.Add(this.pbHelpSeekerAvatar);
            this.helpSeekerTitle.Controls.Add(this.lbHelpSeekerName);
            this.helpSeekerTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpSeekerTitle.Location = new System.Drawing.Point(0, 0);
            this.helpSeekerTitle.Name = "helpSeekerTitle";
            this.helpSeekerTitle.Padding = new System.Windows.Forms.Padding(40, 40, 0, 20);
            this.helpSeekerTitle.Size = new System.Drawing.Size(1574, 199);
            this.helpSeekerTitle.TabIndex = 25;
            // 
            // pbHelpSeekerAvatar
            // 
            this.pbHelpSeekerAvatar.Location = new System.Drawing.Point(40, 40);
            this.pbHelpSeekerAvatar.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.pbHelpSeekerAvatar.Name = "pbHelpSeekerAvatar";
            this.pbHelpSeekerAvatar.Size = new System.Drawing.Size(128, 128);
            this.pbHelpSeekerAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHelpSeekerAvatar.TabIndex = 23;
            this.pbHelpSeekerAvatar.TabStop = false;
            this.pbHelpSeekerAvatar.Visible = false;
            // 
            // lbHelpSeekerName
            // 
            this.lbHelpSeekerName.AutoSize = true;
            this.lbHelpSeekerName.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHelpSeekerName.ForeColor = System.Drawing.Color.Gray;
            this.lbHelpSeekerName.Location = new System.Drawing.Point(208, 40);
            this.lbHelpSeekerName.Margin = new System.Windows.Forms.Padding(0);
            this.lbHelpSeekerName.Name = "lbHelpSeekerName";
            this.lbHelpSeekerName.Padding = new System.Windows.Forms.Padding(0, 40, 0, 40);
            this.lbHelpSeekerName.Size = new System.Drawing.Size(202, 139);
            this.lbHelpSeekerName.TabIndex = 2;
            this.lbHelpSeekerName.Text = "John Doe";
            this.lbHelpSeekerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // volunteerView
            // 
            this.volunteerView.BackColor = System.Drawing.Color.White;
            this.volunteerView.Controls.Add(this.btSearchWrapper);
            this.volunteerView.Controls.Add(this.lbSearch);
            this.volunteerView.Controls.Add(this.btVolunteerProfileWrapper);
            this.volunteerView.Controls.Add(this.lbVolunteerProfile);
            this.volunteerView.Controls.Add(this.volunteerTitle);
            this.volunteerView.Location = new System.Drawing.Point(0, 0);
            this.volunteerView.Margin = new System.Windows.Forms.Padding(0);
            this.volunteerView.Name = "volunteerView";
            this.volunteerView.Size = new System.Drawing.Size(1574, 981);
            this.volunteerView.TabIndex = 3;
            this.volunteerView.Text = "tabPage1";
            // 
            // searchView
            // 
            this.searchView.Controls.Add(this.resultsWrapper);
            this.searchView.Controls.Add(this.searchSeperator);
            this.searchView.Controls.Add(this.searchTitleWrapper);
            this.searchView.Location = new System.Drawing.Point(0, 0);
            this.searchView.Margin = new System.Windows.Forms.Padding(0);
            this.searchView.Name = "searchView";
            this.searchView.Size = new System.Drawing.Size(1574, 981);
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
            this.resultsWrapper.Size = new System.Drawing.Size(1574, 778);
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
            // searchTitleWrapper
            // 
            this.searchTitleWrapper.AutoSize = true;
            this.searchTitleWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchTitleWrapper.BackColor = System.Drawing.Color.White;
            this.searchTitleWrapper.Controls.Add(this.search);
            this.searchTitleWrapper.Controls.Add(this.btSearchBackWrapper);
            this.searchTitleWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchTitleWrapper.Location = new System.Drawing.Point(0, 0);
            this.searchTitleWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.searchTitleWrapper.Name = "searchTitleWrapper";
            this.searchTitleWrapper.Size = new System.Drawing.Size(1574, 202);
            this.searchTitleWrapper.TabIndex = 14;
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
            // btSearchBackWrapper
            // 
            this.btSearchBackWrapper.AutoSize = true;
            this.btSearchBackWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSearchBackWrapper.BackColor = System.Drawing.Color.White;
            this.btSearchBackWrapper.Controls.Add(this.btSearchBack);
            this.btSearchBackWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.btSearchBackWrapper.Location = new System.Drawing.Point(0, 0);
            this.btSearchBackWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btSearchBackWrapper.Name = "btSearchBackWrapper";
            this.btSearchBackWrapper.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.btSearchBackWrapper.Size = new System.Drawing.Size(120, 202);
            this.btSearchBackWrapper.TabIndex = 15;
            // 
            // btSearchBack
            // 
            this.btSearchBack.BackColor = System.Drawing.Color.White;
            this.btSearchBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btSearchBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSearchBack.FlatAppearance.BorderSize = 0;
            this.btSearchBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearchBack.Font = new System.Drawing.Font("Arial Narrow", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSearchBack.Location = new System.Drawing.Point(40, 40);
            this.btSearchBack.Margin = new System.Windows.Forms.Padding(0);
            this.btSearchBack.MinimumSize = new System.Drawing.Size(80, 100);
            this.btSearchBack.Name = "btSearchBack";
            this.btSearchBack.Size = new System.Drawing.Size(80, 122);
            this.btSearchBack.TabIndex = 14;
            this.btSearchBack.Text = "❮";
            this.btSearchBack.UseVisualStyleBackColor = false;
            this.btSearchBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // helpRequestView
            // 
            this.helpRequestView.Controls.Add(this.helpRequest);
            this.helpRequestView.Location = new System.Drawing.Point(0, 0);
            this.helpRequestView.Margin = new System.Windows.Forms.Padding(0);
            this.helpRequestView.Name = "helpRequestView";
            this.helpRequestView.Size = new System.Drawing.Size(1574, 981);
            this.helpRequestView.TabIndex = 1;
            this.helpRequestView.Text = "tabPage2";
            this.helpRequestView.UseVisualStyleBackColor = true;
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
            this.helpRequest.Size = new System.Drawing.Size(1574, 981);
            this.helpRequest.TabIndex = 0;
            // 
            // helpRequestsManageView
            // 
            this.helpRequestsManageView.BackColor = System.Drawing.Color.White;
            this.helpRequestsManageView.Controls.Add(this.helpRequestsWrapper);
            this.helpRequestsManageView.Controls.Add(this.helpRequestsSeperator);
            this.helpRequestsManageView.Controls.Add(this.helpRequestsTitleWrapper);
            this.helpRequestsManageView.Location = new System.Drawing.Point(0, 0);
            this.helpRequestsManageView.Margin = new System.Windows.Forms.Padding(0);
            this.helpRequestsManageView.Name = "helpRequestsManageView";
            this.helpRequestsManageView.Size = new System.Drawing.Size(1574, 981);
            this.helpRequestsManageView.TabIndex = 5;
            this.helpRequestsManageView.Text = "tabPage1";
            // 
            // helpRequestsWrapper
            // 
            this.helpRequestsWrapper.AutoScroll = true;
            this.helpRequestsWrapper.BackColor = System.Drawing.Color.White;
            this.helpRequestsWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpRequestsWrapper.Location = new System.Drawing.Point(0, 203);
            this.helpRequestsWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.helpRequestsWrapper.Name = "helpRequestsWrapper";
            this.helpRequestsWrapper.Size = new System.Drawing.Size(1574, 778);
            this.helpRequestsWrapper.TabIndex = 16;
            // 
            // helpRequestsSeperator
            // 
            this.helpRequestsSeperator.AutoSize = true;
            this.helpRequestsSeperator.BackColor = System.Drawing.Color.Silver;
            this.helpRequestsSeperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpRequestsSeperator.Location = new System.Drawing.Point(0, 202);
            this.helpRequestsSeperator.Margin = new System.Windows.Forms.Padding(0);
            this.helpRequestsSeperator.Name = "helpRequestsSeperator";
            this.helpRequestsSeperator.Size = new System.Drawing.Size(1574, 1);
            this.helpRequestsSeperator.TabIndex = 17;
            // 
            // helpRequestsTitleWrapper
            // 
            this.helpRequestsTitleWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpRequestsTitleWrapper.BackColor = System.Drawing.Color.White;
            this.helpRequestsTitleWrapper.Controls.Add(this.btHelpRequestCreateWrapper);
            this.helpRequestsTitleWrapper.Controls.Add(this.lbHelpRequestsManage);
            this.helpRequestsTitleWrapper.Controls.Add(this.btHelpRequestsBackWrapper);
            this.helpRequestsTitleWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpRequestsTitleWrapper.Location = new System.Drawing.Point(0, 0);
            this.helpRequestsTitleWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.helpRequestsTitleWrapper.Name = "helpRequestsTitleWrapper";
            this.helpRequestsTitleWrapper.Size = new System.Drawing.Size(1574, 202);
            this.helpRequestsTitleWrapper.TabIndex = 18;
            // 
            // btHelpRequestCreateWrapper
            // 
            this.btHelpRequestCreateWrapper.AutoSize = true;
            this.btHelpRequestCreateWrapper.Controls.Add(this.btHelpRequestCreate);
            this.btHelpRequestCreateWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.btHelpRequestCreateWrapper.Location = new System.Drawing.Point(1181, 0);
            this.btHelpRequestCreateWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btHelpRequestCreateWrapper.Name = "btHelpRequestCreateWrapper";
            this.btHelpRequestCreateWrapper.Padding = new System.Windows.Forms.Padding(40, 67, 40, 67);
            this.btHelpRequestCreateWrapper.Size = new System.Drawing.Size(393, 202);
            this.btHelpRequestCreateWrapper.TabIndex = 22;
            // 
            // btHelpRequestCreate
            // 
            this.btHelpRequestCreate.AutoSize = true;
            this.btHelpRequestCreate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btHelpRequestCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btHelpRequestCreate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btHelpRequestCreate.FlatAppearance.BorderSize = 0;
            this.btHelpRequestCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHelpRequestCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHelpRequestCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btHelpRequestCreate.Location = new System.Drawing.Point(40, 67);
            this.btHelpRequestCreate.Margin = new System.Windows.Forms.Padding(0);
            this.btHelpRequestCreate.Name = "btHelpRequestCreate";
            this.btHelpRequestCreate.Padding = new System.Windows.Forms.Padding(10);
            this.btHelpRequestCreate.Size = new System.Drawing.Size(313, 67);
            this.btHelpRequestCreate.TabIndex = 4;
            this.btHelpRequestCreate.Text = "NIEUWE HULPVRAAG";
            this.btHelpRequestCreate.UseVisualStyleBackColor = false;
            this.btHelpRequestCreate.Click += new System.EventHandler(this.btHelpRequestCreate_Click);
            // 
            // lbHelpRequestsManage
            // 
            this.lbHelpRequestsManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHelpRequestsManage.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHelpRequestsManage.Location = new System.Drawing.Point(120, 0);
            this.lbHelpRequestsManage.Margin = new System.Windows.Forms.Padding(0);
            this.lbHelpRequestsManage.Name = "lbHelpRequestsManage";
            this.lbHelpRequestsManage.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lbHelpRequestsManage.Size = new System.Drawing.Size(1454, 202);
            this.lbHelpRequestsManage.TabIndex = 16;
            this.lbHelpRequestsManage.Text = "Hulpvragen";
            this.lbHelpRequestsManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btHelpRequestsBackWrapper
            // 
            this.btHelpRequestsBackWrapper.AutoSize = true;
            this.btHelpRequestsBackWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btHelpRequestsBackWrapper.BackColor = System.Drawing.Color.White;
            this.btHelpRequestsBackWrapper.Controls.Add(this.btHelpRequestsBack);
            this.btHelpRequestsBackWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.btHelpRequestsBackWrapper.Location = new System.Drawing.Point(0, 0);
            this.btHelpRequestsBackWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btHelpRequestsBackWrapper.Name = "btHelpRequestsBackWrapper";
            this.btHelpRequestsBackWrapper.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.btHelpRequestsBackWrapper.Size = new System.Drawing.Size(120, 202);
            this.btHelpRequestsBackWrapper.TabIndex = 15;
            // 
            // btHelpRequestsBack
            // 
            this.btHelpRequestsBack.BackColor = System.Drawing.Color.White;
            this.btHelpRequestsBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btHelpRequestsBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btHelpRequestsBack.FlatAppearance.BorderSize = 0;
            this.btHelpRequestsBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHelpRequestsBack.Font = new System.Drawing.Font("Arial Narrow", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHelpRequestsBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btHelpRequestsBack.Location = new System.Drawing.Point(40, 40);
            this.btHelpRequestsBack.Margin = new System.Windows.Forms.Padding(0);
            this.btHelpRequestsBack.MinimumSize = new System.Drawing.Size(80, 100);
            this.btHelpRequestsBack.Name = "btHelpRequestsBack";
            this.btHelpRequestsBack.Size = new System.Drawing.Size(80, 122);
            this.btHelpRequestsBack.TabIndex = 14;
            this.btHelpRequestsBack.Text = "❮";
            this.btHelpRequestsBack.UseVisualStyleBackColor = false;
            this.btHelpRequestsBack.Click += new System.EventHandler(this.btHelpRequestsBack_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.LoggedIn = false;
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.MinimumSize = new System.Drawing.Size(920, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1574, 148);
            this.header.TabIndex = 1;
            // 
            // volunteerTitle
            // 
            this.volunteerTitle.AutoSize = true;
            this.volunteerTitle.Controls.Add(this.pbVolunteerAvatar);
            this.volunteerTitle.Controls.Add(this.lbVolunteerName);
            this.volunteerTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.volunteerTitle.Location = new System.Drawing.Point(0, 0);
            this.volunteerTitle.Name = "volunteerTitle";
            this.volunteerTitle.Padding = new System.Windows.Forms.Padding(40, 40, 0, 20);
            this.volunteerTitle.Size = new System.Drawing.Size(1574, 199);
            this.volunteerTitle.TabIndex = 26;
            // 
            // pbVolunteerAvatar
            // 
            this.pbVolunteerAvatar.Location = new System.Drawing.Point(40, 40);
            this.pbVolunteerAvatar.Margin = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.pbVolunteerAvatar.Name = "pbVolunteerAvatar";
            this.pbVolunteerAvatar.Size = new System.Drawing.Size(128, 128);
            this.pbVolunteerAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVolunteerAvatar.TabIndex = 23;
            this.pbVolunteerAvatar.TabStop = false;
            this.pbVolunteerAvatar.Visible = false;
            // 
            // lbVolunteerName
            // 
            this.lbVolunteerName.AutoSize = true;
            this.lbVolunteerName.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVolunteerName.ForeColor = System.Drawing.Color.Gray;
            this.lbVolunteerName.Location = new System.Drawing.Point(208, 40);
            this.lbVolunteerName.Margin = new System.Windows.Forms.Padding(0);
            this.lbVolunteerName.Name = "lbVolunteerName";
            this.lbVolunteerName.Padding = new System.Windows.Forms.Padding(0, 40, 0, 40);
            this.lbVolunteerName.Size = new System.Drawing.Size(202, 139);
            this.lbVolunteerName.TabIndex = 2;
            this.lbVolunteerName.Text = "John Doe";
            this.lbVolunteerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btVolunteerProfileWrapper
            // 
            this.btVolunteerProfileWrapper.AutoSize = true;
            this.btVolunteerProfileWrapper.Controls.Add(this.btVolunteerProfile);
            this.btVolunteerProfileWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.btVolunteerProfileWrapper.Location = new System.Drawing.Point(0, 350);
            this.btVolunteerProfileWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btVolunteerProfileWrapper.Name = "btVolunteerProfileWrapper";
            this.btVolunteerProfileWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 0, 20);
            this.btVolunteerProfileWrapper.Size = new System.Drawing.Size(1574, 87);
            this.btVolunteerProfileWrapper.TabIndex = 27;
            // 
            // btVolunteerProfile
            // 
            this.btVolunteerProfile.AutoSize = true;
            this.btVolunteerProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btVolunteerProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btVolunteerProfile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btVolunteerProfile.FlatAppearance.BorderSize = 0;
            this.btVolunteerProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVolunteerProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolunteerProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btVolunteerProfile.Location = new System.Drawing.Point(40, 0);
            this.btVolunteerProfile.Margin = new System.Windows.Forms.Padding(0);
            this.btVolunteerProfile.Name = "btVolunteerProfile";
            this.btVolunteerProfile.Padding = new System.Windows.Forms.Padding(10);
            this.btVolunteerProfile.Size = new System.Drawing.Size(170, 67);
            this.btVolunteerProfile.TabIndex = 4;
            this.btVolunteerProfile.Text = "WIJZIGEN";
            this.btVolunteerProfile.UseVisualStyleBackColor = false;
            // 
            // lbVolunteerProfile
            // 
            this.lbVolunteerProfile.AutoSize = true;
            this.lbVolunteerProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbVolunteerProfile.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVolunteerProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbVolunteerProfile.Location = new System.Drawing.Point(0, 199);
            this.lbVolunteerProfile.Margin = new System.Windows.Forms.Padding(0);
            this.lbVolunteerProfile.Name = "lbVolunteerProfile";
            this.lbVolunteerProfile.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.lbVolunteerProfile.Size = new System.Drawing.Size(220, 151);
            this.lbVolunteerProfile.TabIndex = 28;
            this.lbVolunteerProfile.Text = "Profiel";
            this.lbVolunteerProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btSearchWrapper
            // 
            this.btSearchWrapper.AutoSize = true;
            this.btSearchWrapper.Controls.Add(this.btSearch);
            this.btSearchWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSearchWrapper.Location = new System.Drawing.Point(0, 588);
            this.btSearchWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btSearchWrapper.Name = "btSearchWrapper";
            this.btSearchWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 0, 20);
            this.btSearchWrapper.Size = new System.Drawing.Size(1574, 87);
            this.btSearchWrapper.TabIndex = 29;
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
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSearch.Font = new System.Drawing.Font("Segoe UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbSearch.Location = new System.Drawing.Point(0, 437);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Padding = new System.Windows.Forms.Padding(40, 40, 0, 40);
            this.lbSearch.Size = new System.Drawing.Size(638, 151);
            this.lbSearch.TabIndex = 30;
            this.lbSearch.Text = "Zoeken naar hulpvragen";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1574, 1129);
            this.Controls.Add(this.views);
            this.Controls.Add(this.header);
            this.MinimumSize = new System.Drawing.Size(1600, 1200);
            this.Name = "MainForm";
            this.Text = "EyeCT for Participation";
            this.views.ResumeLayout(false);
            this.startView.ResumeLayout(false);
            this.startView.PerformLayout();
            this.helpSeekerView.ResumeLayout(false);
            this.helpSeekerView.PerformLayout();
            this.btAidWorkersManageWrapper.ResumeLayout(false);
            this.btAidWorkersManageWrapper.PerformLayout();
            this.btHelpRequestsManageWrapper.ResumeLayout(false);
            this.btHelpRequestsManageWrapper.PerformLayout();
            this.btHelpSeekerEditProfileWrapper.ResumeLayout(false);
            this.btHelpSeekerEditProfileWrapper.PerformLayout();
            this.helpSeekerTitle.ResumeLayout(false);
            this.helpSeekerTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelpSeekerAvatar)).EndInit();
            this.volunteerView.ResumeLayout(false);
            this.volunteerView.PerformLayout();
            this.searchView.ResumeLayout(false);
            this.searchView.PerformLayout();
            this.searchTitleWrapper.ResumeLayout(false);
            this.searchTitleWrapper.PerformLayout();
            this.btSearchBackWrapper.ResumeLayout(false);
            this.helpRequestView.ResumeLayout(false);
            this.helpRequestView.PerformLayout();
            this.helpRequestsManageView.ResumeLayout(false);
            this.helpRequestsManageView.PerformLayout();
            this.helpRequestsTitleWrapper.ResumeLayout(false);
            this.helpRequestsTitleWrapper.PerformLayout();
            this.btHelpRequestCreateWrapper.ResumeLayout(false);
            this.btHelpRequestCreateWrapper.PerformLayout();
            this.btHelpRequestsBackWrapper.ResumeLayout(false);
            this.volunteerTitle.ResumeLayout(false);
            this.volunteerTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVolunteerAvatar)).EndInit();
            this.btVolunteerProfileWrapper.ResumeLayout(false);
            this.btVolunteerProfileWrapper.PerformLayout();
            this.btSearchWrapper.ResumeLayout(false);
            this.btSearchWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSearchBack;
        private System.Windows.Forms.Panel btSearchBackWrapper;
        private System.Windows.Forms.Panel searchTitleWrapper;
        private System.Windows.Forms.Panel resultsWrapper;
        private Controls.HorizontalSeperatorControl searchSeperator;
        private Controls.SearchControl search;
        private Controls.ViewControl views;
        private System.Windows.Forms.TabPage searchView;
        private System.Windows.Forms.TabPage helpRequestView;
        private System.Windows.Forms.TabPage startView;
        private System.Windows.Forms.Label lbStartTitle;
        private System.Windows.Forms.TabPage volunteerView;
        private Controls.HeaderControl header;
        private System.Windows.Forms.TabPage helpSeekerView;
        private System.Windows.Forms.Label lbHelpSeekerName;
        private System.Windows.Forms.Label lbAidWorkers;
        private System.Windows.Forms.Label lbHelpRequests;
        private System.Windows.Forms.Label lbHelpSeekerProfile;
        private System.Windows.Forms.FlowLayoutPanel btAidWorkersManageWrapper;
        private System.Windows.Forms.Button btAidWorkersManage;
        private System.Windows.Forms.FlowLayoutPanel btHelpRequestsManageWrapper;
        private System.Windows.Forms.Button btHelpRequestsManage;
        private System.Windows.Forms.FlowLayoutPanel btHelpSeekerEditProfileWrapper;
        private System.Windows.Forms.Button btHelpSeekerEditProfile;
        private System.Windows.Forms.TabPage helpRequestsManageView;
        private Controls.HorizontalSeperatorControl helpRequestsSeperator;
        private System.Windows.Forms.Panel helpRequestsWrapper;
        private System.Windows.Forms.Panel helpRequestsTitleWrapper;
        private System.Windows.Forms.Panel btHelpRequestsBackWrapper;
        private System.Windows.Forms.Button btHelpRequestsBack;
        private System.Windows.Forms.Label lbHelpRequestsManage;
        private System.Windows.Forms.FlowLayoutPanel btHelpRequestCreateWrapper;
        private System.Windows.Forms.Button btHelpRequestCreate;
        private Controls.HelpRequestControl helpRequest;
        private System.Windows.Forms.FlowLayoutPanel helpSeekerTitle;
        private System.Windows.Forms.PictureBox pbHelpSeekerAvatar;
        private System.Windows.Forms.Label lbVolunteerProfile;
        private System.Windows.Forms.FlowLayoutPanel btVolunteerProfileWrapper;
        private System.Windows.Forms.Button btVolunteerProfile;
        private System.Windows.Forms.FlowLayoutPanel volunteerTitle;
        private System.Windows.Forms.PictureBox pbVolunteerAvatar;
        private System.Windows.Forms.Label lbVolunteerName;
        private System.Windows.Forms.FlowLayoutPanel btSearchWrapper;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label lbSearch;
    }
}