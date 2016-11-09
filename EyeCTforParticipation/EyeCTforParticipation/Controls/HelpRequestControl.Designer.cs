namespace EyeCTforParticipation.Controls
{
    partial class HelpRequestControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpRequestControl));
            this.lbContent = new System.Windows.Forms.Label();
            this.lbSubtitle = new System.Windows.Forms.Label();
            this.contentWrapper = new System.Windows.Forms.Panel();
            this.locationWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbDistance = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.btBackWrapper = new System.Windows.Forms.Panel();
            this.btBack = new System.Windows.Forms.Button();
            this.titleWrapper = new System.Windows.Forms.Panel();
            this.lbTitleWrapper = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbUrgencyCrititcalWrapper = new System.Windows.Forms.Panel();
            this.lbUrgencyCritical = new System.Windows.Forms.Label();
            this.lbUrgencyNormalWrapper = new System.Windows.Forms.Panel();
            this.lbUrgencyNormal = new System.Windows.Forms.Label();
            this.lbUrgencyLowWrapper = new System.Windows.Forms.Panel();
            this.lbUrgencyLow = new System.Windows.Forms.Label();
            this.lbCloseWrapper = new System.Windows.Forms.Panel();
            this.lbClose = new System.Windows.Forms.Label();
            this.btApplicationsWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btApplications = new System.Windows.Forms.Button();
            this.btEditWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btEdit = new System.Windows.Forms.Button();
            this.btCancelWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btApplyWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btApply = new System.Windows.Forms.Button();
            this.btCloseWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btClose = new System.Windows.Forms.Button();
            this.btOpenWrapper = new System.Windows.Forms.FlowLayoutPanel();
            this.btOpen = new System.Windows.Forms.Button();
            this.horizontalSeperator = new EyeCTforParticipation.Controls.HorizontalSeperatorControl();
            this.contentWrapper.SuspendLayout();
            this.locationWrapper.SuspendLayout();
            this.btBackWrapper.SuspendLayout();
            this.titleWrapper.SuspendLayout();
            this.lbTitleWrapper.SuspendLayout();
            this.lbUrgencyCrititcalWrapper.SuspendLayout();
            this.lbUrgencyNormalWrapper.SuspendLayout();
            this.lbUrgencyLowWrapper.SuspendLayout();
            this.lbCloseWrapper.SuspendLayout();
            this.btApplicationsWrapper.SuspendLayout();
            this.btEditWrapper.SuspendLayout();
            this.btCancelWrapper.SuspendLayout();
            this.btApplyWrapper.SuspendLayout();
            this.btCloseWrapper.SuspendLayout();
            this.btOpenWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbContent.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lbContent.Location = new System.Drawing.Point(0, 134);
            this.lbContent.Margin = new System.Windows.Forms.Padding(0);
            this.lbContent.MaximumSize = new System.Drawing.Size(920, 0);
            this.lbContent.Name = "lbContent";
            this.lbContent.Padding = new System.Windows.Forms.Padding(40);
            this.lbContent.Size = new System.Drawing.Size(920, 820);
            this.lbContent.TabIndex = 0;
            this.lbContent.Text = resources.GetString("lbContent.Text");
            // 
            // lbSubtitle
            // 
            this.lbSubtitle.AutoSize = true;
            this.lbSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lbSubtitle.Location = new System.Drawing.Point(120, 85);
            this.lbSubtitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbSubtitle.Name = "lbSubtitle";
            this.lbSubtitle.Padding = new System.Windows.Forms.Padding(40, 20, 0, 40);
            this.lbSubtitle.Size = new System.Drawing.Size(144, 105);
            this.lbSubtitle.TabIndex = 4;
            this.lbSubtitle.Text = "Naam";
            // 
            // contentWrapper
            // 
            this.contentWrapper.AutoScroll = true;
            this.contentWrapper.AutoSize = true;
            this.contentWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.contentWrapper.Controls.Add(this.lbContent);
            this.contentWrapper.Controls.Add(this.locationWrapper);
            this.contentWrapper.Controls.Add(this.lbDate);
            this.contentWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentWrapper.Location = new System.Drawing.Point(0, 203);
            this.contentWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.contentWrapper.Name = "contentWrapper";
            this.contentWrapper.Size = new System.Drawing.Size(2206, 1039);
            this.contentWrapper.TabIndex = 5;
            // 
            // locationWrapper
            // 
            this.locationWrapper.AutoSize = true;
            this.locationWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.locationWrapper.Controls.Add(this.lbLocation);
            this.locationWrapper.Controls.Add(this.lbDistance);
            this.locationWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.locationWrapper.Location = new System.Drawing.Point(0, 77);
            this.locationWrapper.Name = "locationWrapper";
            this.locationWrapper.Padding = new System.Windows.Forms.Padding(40, 20, 0, 0);
            this.locationWrapper.Size = new System.Drawing.Size(2206, 57);
            this.locationWrapper.TabIndex = 15;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbLocation.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.ForeColor = System.Drawing.Color.Gray;
            this.lbLocation.Location = new System.Drawing.Point(40, 20);
            this.lbLocation.Margin = new System.Windows.Forms.Padding(0);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(142, 37);
            this.lbLocation.TabIndex = 12;
            this.lbLocation.Text = "Eindhoven";
            // 
            // lbDistance
            // 
            this.lbDistance.AutoSize = true;
            this.lbDistance.BackColor = System.Drawing.Color.Transparent;
            this.lbDistance.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistance.ForeColor = System.Drawing.Color.Gray;
            this.lbDistance.Location = new System.Drawing.Point(182, 20);
            this.lbDistance.Margin = new System.Windows.Forms.Padding(0);
            this.lbDistance.Name = "lbDistance";
            this.lbDistance.Size = new System.Drawing.Size(75, 37);
            this.lbDistance.TabIndex = 13;
            this.lbDistance.Text = "5 km";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Gray;
            this.lbDate.Location = new System.Drawing.Point(0, 0);
            this.lbDate.Margin = new System.Windows.Forms.Padding(0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Padding = new System.Windows.Forms.Padding(40, 40, 0, 0);
            this.lbDate.Size = new System.Drawing.Size(199, 77);
            this.lbDate.TabIndex = 11;
            this.lbDate.Text = "10-10-2016";
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
            this.btBackWrapper.TabIndex = 16;
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
            // titleWrapper
            // 
            this.titleWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleWrapper.Controls.Add(this.lbSubtitle);
            this.titleWrapper.Controls.Add(this.lbTitleWrapper);
            this.titleWrapper.Controls.Add(this.btApplicationsWrapper);
            this.titleWrapper.Controls.Add(this.btEditWrapper);
            this.titleWrapper.Controls.Add(this.btCancelWrapper);
            this.titleWrapper.Controls.Add(this.btApplyWrapper);
            this.titleWrapper.Controls.Add(this.btCloseWrapper);
            this.titleWrapper.Controls.Add(this.btOpenWrapper);
            this.titleWrapper.Controls.Add(this.btBackWrapper);
            this.titleWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleWrapper.Location = new System.Drawing.Point(0, 0);
            this.titleWrapper.Name = "titleWrapper";
            this.titleWrapper.Size = new System.Drawing.Size(2206, 202);
            this.titleWrapper.TabIndex = 16;
            // 
            // lbTitleWrapper
            // 
            this.lbTitleWrapper.AutoSize = true;
            this.lbTitleWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lbTitleWrapper.Controls.Add(this.lbTitle);
            this.lbTitleWrapper.Controls.Add(this.lbUrgencyCrititcalWrapper);
            this.lbTitleWrapper.Controls.Add(this.lbUrgencyNormalWrapper);
            this.lbTitleWrapper.Controls.Add(this.lbUrgencyLowWrapper);
            this.lbTitleWrapper.Controls.Add(this.lbCloseWrapper);
            this.lbTitleWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitleWrapper.Location = new System.Drawing.Point(120, 0);
            this.lbTitleWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitleWrapper.MinimumSize = new System.Drawing.Size(0, 85);
            this.lbTitleWrapper.Name = "lbTitleWrapper";
            this.lbTitleWrapper.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lbTitleWrapper.Size = new System.Drawing.Size(664, 85);
            this.lbTitleWrapper.TabIndex = 20;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTitle.Location = new System.Drawing.Point(606, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Padding = new System.Windows.Forms.Padding(0, 40, 60, 10);
            this.lbTitle.Size = new System.Drawing.Size(141, 95);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Titel";
            // 
            // lbUrgencyCrititcalWrapper
            // 
            this.lbUrgencyCrititcalWrapper.AutoSize = true;
            this.lbUrgencyCrititcalWrapper.Controls.Add(this.lbUrgencyCritical);
            this.lbUrgencyCrititcalWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbUrgencyCrititcalWrapper.Location = new System.Drawing.Point(441, 0);
            this.lbUrgencyCrititcalWrapper.Name = "lbUrgencyCrititcalWrapper";
            this.lbUrgencyCrititcalWrapper.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.lbUrgencyCrititcalWrapper.Size = new System.Drawing.Size(165, 85);
            this.lbUrgencyCrititcalWrapper.TabIndex = 7;
            this.lbUrgencyCrititcalWrapper.Visible = false;
            // 
            // lbUrgencyCritical
            // 
            this.lbUrgencyCritical.AutoSize = true;
            this.lbUrgencyCritical.BackColor = System.Drawing.Color.Red;
            this.lbUrgencyCritical.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUrgencyCritical.ForeColor = System.Drawing.Color.White;
            this.lbUrgencyCritical.Location = new System.Drawing.Point(0, 40);
            this.lbUrgencyCritical.Name = "lbUrgencyCritical";
            this.lbUrgencyCritical.Padding = new System.Windows.Forms.Padding(5);
            this.lbUrgencyCritical.Size = new System.Drawing.Size(162, 40);
            this.lbUrgencyCritical.TabIndex = 4;
            this.lbUrgencyCritical.Text = "ZEER URGENT";
            // 
            // lbUrgencyNormalWrapper
            // 
            this.lbUrgencyNormalWrapper.AutoSize = true;
            this.lbUrgencyNormalWrapper.Controls.Add(this.lbUrgencyNormal);
            this.lbUrgencyNormalWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbUrgencyNormalWrapper.Location = new System.Drawing.Point(331, 0);
            this.lbUrgencyNormalWrapper.Name = "lbUrgencyNormalWrapper";
            this.lbUrgencyNormalWrapper.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.lbUrgencyNormalWrapper.Size = new System.Drawing.Size(110, 85);
            this.lbUrgencyNormalWrapper.TabIndex = 6;
            this.lbUrgencyNormalWrapper.Visible = false;
            // 
            // lbUrgencyNormal
            // 
            this.lbUrgencyNormal.AutoSize = true;
            this.lbUrgencyNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbUrgencyNormal.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUrgencyNormal.ForeColor = System.Drawing.Color.White;
            this.lbUrgencyNormal.Location = new System.Drawing.Point(0, 40);
            this.lbUrgencyNormal.Name = "lbUrgencyNormal";
            this.lbUrgencyNormal.Padding = new System.Windows.Forms.Padding(5);
            this.lbUrgencyNormal.Size = new System.Drawing.Size(107, 40);
            this.lbUrgencyNormal.TabIndex = 4;
            this.lbUrgencyNormal.Text = "URGENT";
            // 
            // lbUrgencyLowWrapper
            // 
            this.lbUrgencyLowWrapper.AutoSize = true;
            this.lbUrgencyLowWrapper.Controls.Add(this.lbUrgencyLow);
            this.lbUrgencyLowWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbUrgencyLowWrapper.Location = new System.Drawing.Point(179, 0);
            this.lbUrgencyLowWrapper.Name = "lbUrgencyLowWrapper";
            this.lbUrgencyLowWrapper.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.lbUrgencyLowWrapper.Size = new System.Drawing.Size(152, 85);
            this.lbUrgencyLowWrapper.TabIndex = 5;
            this.lbUrgencyLowWrapper.Visible = false;
            // 
            // lbUrgencyLow
            // 
            this.lbUrgencyLow.AutoSize = true;
            this.lbUrgencyLow.BackColor = System.Drawing.Color.Yellow;
            this.lbUrgencyLow.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUrgencyLow.ForeColor = System.Drawing.Color.Black;
            this.lbUrgencyLow.Location = new System.Drawing.Point(0, 40);
            this.lbUrgencyLow.Name = "lbUrgencyLow";
            this.lbUrgencyLow.Padding = new System.Windows.Forms.Padding(5);
            this.lbUrgencyLow.Size = new System.Drawing.Size(149, 40);
            this.lbUrgencyLow.TabIndex = 4;
            this.lbUrgencyLow.Text = "BELANGRIJK";
            // 
            // lbCloseWrapper
            // 
            this.lbCloseWrapper.AutoSize = true;
            this.lbCloseWrapper.Controls.Add(this.lbClose);
            this.lbCloseWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCloseWrapper.Location = new System.Drawing.Point(40, 0);
            this.lbCloseWrapper.Name = "lbCloseWrapper";
            this.lbCloseWrapper.Padding = new System.Windows.Forms.Padding(0, 40, 10, 0);
            this.lbCloseWrapper.Size = new System.Drawing.Size(139, 85);
            this.lbCloseWrapper.TabIndex = 8;
            this.lbCloseWrapper.Visible = false;
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.BackColor = System.Drawing.Color.Gray;
            this.lbClose.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.ForeColor = System.Drawing.Color.White;
            this.lbClose.Location = new System.Drawing.Point(0, 40);
            this.lbClose.Name = "lbClose";
            this.lbClose.Padding = new System.Windows.Forms.Padding(5);
            this.lbClose.Size = new System.Drawing.Size(126, 40);
            this.lbClose.TabIndex = 4;
            this.lbClose.Text = "GESLOTEN";
            // 
            // btApplicationsWrapper
            // 
            this.btApplicationsWrapper.AutoSize = true;
            this.btApplicationsWrapper.Controls.Add(this.btApplications);
            this.btApplicationsWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.btApplicationsWrapper.Location = new System.Drawing.Point(784, 0);
            this.btApplicationsWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btApplicationsWrapper.Name = "btApplicationsWrapper";
            this.btApplicationsWrapper.Padding = new System.Windows.Forms.Padding(0, 67, 40, 0);
            this.btApplicationsWrapper.Size = new System.Drawing.Size(304, 202);
            this.btApplicationsWrapper.TabIndex = 19;
            this.btApplicationsWrapper.Visible = false;
            // 
            // btApplications
            // 
            this.btApplications.AutoSize = true;
            this.btApplications.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btApplications.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btApplications.FlatAppearance.BorderSize = 0;
            this.btApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btApplications.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btApplications.Location = new System.Drawing.Point(0, 67);
            this.btApplications.Margin = new System.Windows.Forms.Padding(0);
            this.btApplications.Name = "btApplications";
            this.btApplications.Padding = new System.Windows.Forms.Padding(10);
            this.btApplications.Size = new System.Drawing.Size(264, 67);
            this.btApplications.TabIndex = 4;
            this.btApplications.Text = "AANMELDINGEN";
            this.btApplications.UseVisualStyleBackColor = false;
            this.btApplications.Click += new System.EventHandler(this.btApplications_Click);
            // 
            // btEditWrapper
            // 
            this.btEditWrapper.AutoSize = true;
            this.btEditWrapper.Controls.Add(this.btEdit);
            this.btEditWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.btEditWrapper.Location = new System.Drawing.Point(1088, 0);
            this.btEditWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btEditWrapper.Name = "btEditWrapper";
            this.btEditWrapper.Padding = new System.Windows.Forms.Padding(0, 67, 40, 0);
            this.btEditWrapper.Size = new System.Drawing.Size(245, 202);
            this.btEditWrapper.TabIndex = 18;
            this.btEditWrapper.Visible = false;
            // 
            // btEdit
            // 
            this.btEdit.AutoSize = true;
            this.btEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btEdit.FlatAppearance.BorderSize = 0;
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btEdit.Location = new System.Drawing.Point(0, 67);
            this.btEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btEdit.Name = "btEdit";
            this.btEdit.Padding = new System.Windows.Forms.Padding(10);
            this.btEdit.Size = new System.Drawing.Size(205, 67);
            this.btEdit.TabIndex = 4;
            this.btEdit.Text = "AANPASSEN";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btCancelWrapper
            // 
            this.btCancelWrapper.AutoSize = true;
            this.btCancelWrapper.Controls.Add(this.btCancel);
            this.btCancelWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCancelWrapper.Location = new System.Drawing.Point(1333, 0);
            this.btCancelWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btCancelWrapper.Name = "btCancelWrapper";
            this.btCancelWrapper.Padding = new System.Windows.Forms.Padding(0, 67, 40, 0);
            this.btCancelWrapper.Size = new System.Drawing.Size(229, 202);
            this.btCancelWrapper.TabIndex = 18;
            this.btCancelWrapper.Visible = false;
            // 
            // btCancel
            // 
            this.btCancel.AutoSize = true;
            this.btCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btCancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCancel.Location = new System.Drawing.Point(0, 67);
            this.btCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btCancel.Name = "btCancel";
            this.btCancel.Padding = new System.Windows.Forms.Padding(10);
            this.btCancel.Size = new System.Drawing.Size(189, 67);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "AFMELDEN";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btApplyWrapper
            // 
            this.btApplyWrapper.AutoSize = true;
            this.btApplyWrapper.Controls.Add(this.btApply);
            this.btApplyWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.btApplyWrapper.Location = new System.Drawing.Point(1562, 0);
            this.btApplyWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btApplyWrapper.Name = "btApplyWrapper";
            this.btApplyWrapper.Padding = new System.Windows.Forms.Padding(0, 67, 40, 0);
            this.btApplyWrapper.Size = new System.Drawing.Size(255, 202);
            this.btApplyWrapper.TabIndex = 17;
            this.btApplyWrapper.Visible = false;
            // 
            // btApply
            // 
            this.btApply.AutoSize = true;
            this.btApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btApply.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btApply.FlatAppearance.BorderSize = 0;
            this.btApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btApply.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btApply.Location = new System.Drawing.Point(0, 67);
            this.btApply.Margin = new System.Windows.Forms.Padding(0);
            this.btApply.Name = "btApply";
            this.btApply.Padding = new System.Windows.Forms.Padding(10);
            this.btApply.Size = new System.Drawing.Size(215, 67);
            this.btApply.TabIndex = 4;
            this.btApply.Text = "AANMELDEN";
            this.btApply.UseVisualStyleBackColor = false;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // btCloseWrapper
            // 
            this.btCloseWrapper.AutoSize = true;
            this.btCloseWrapper.Controls.Add(this.btClose);
            this.btCloseWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.btCloseWrapper.Location = new System.Drawing.Point(1817, 0);
            this.btCloseWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btCloseWrapper.Name = "btCloseWrapper";
            this.btCloseWrapper.Padding = new System.Windows.Forms.Padding(0, 67, 40, 0);
            this.btCloseWrapper.Size = new System.Drawing.Size(195, 202);
            this.btCloseWrapper.TabIndex = 20;
            this.btCloseWrapper.Visible = false;
            // 
            // btClose
            // 
            this.btClose.AutoSize = true;
            this.btClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btClose.Location = new System.Drawing.Point(0, 67);
            this.btClose.Margin = new System.Windows.Forms.Padding(0);
            this.btClose.Name = "btClose";
            this.btClose.Padding = new System.Windows.Forms.Padding(10);
            this.btClose.Size = new System.Drawing.Size(155, 67);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "SLUITEN";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btOpenWrapper
            // 
            this.btOpenWrapper.AutoSize = true;
            this.btOpenWrapper.Controls.Add(this.btOpen);
            this.btOpenWrapper.Dock = System.Windows.Forms.DockStyle.Right;
            this.btOpenWrapper.Location = new System.Drawing.Point(2012, 0);
            this.btOpenWrapper.Margin = new System.Windows.Forms.Padding(0);
            this.btOpenWrapper.Name = "btOpenWrapper";
            this.btOpenWrapper.Padding = new System.Windows.Forms.Padding(0, 67, 40, 0);
            this.btOpenWrapper.Size = new System.Drawing.Size(194, 202);
            this.btOpenWrapper.TabIndex = 21;
            this.btOpenWrapper.Visible = false;
            // 
            // btOpen
            // 
            this.btOpen.AutoSize = true;
            this.btOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btOpen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btOpen.FlatAppearance.BorderSize = 0;
            this.btOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpen.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btOpen.Location = new System.Drawing.Point(0, 67);
            this.btOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btOpen.Name = "btOpen";
            this.btOpen.Padding = new System.Windows.Forms.Padding(10);
            this.btOpen.Size = new System.Drawing.Size(154, 67);
            this.btOpen.TabIndex = 4;
            this.btOpen.Text = "OPENEN";
            this.btOpen.UseVisualStyleBackColor = false;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // horizontalSeperator
            // 
            this.horizontalSeperator.AutoSize = true;
            this.horizontalSeperator.BackColor = System.Drawing.Color.Silver;
            this.horizontalSeperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.horizontalSeperator.Location = new System.Drawing.Point(0, 202);
            this.horizontalSeperator.Margin = new System.Windows.Forms.Padding(0);
            this.horizontalSeperator.Name = "horizontalSeperator";
            this.horizontalSeperator.Size = new System.Drawing.Size(2206, 1);
            this.horizontalSeperator.TabIndex = 6;
            // 
            // HelpRequestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.contentWrapper);
            this.Controls.Add(this.horizontalSeperator);
            this.Controls.Add(this.titleWrapper);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "HelpRequestControl";
            this.Size = new System.Drawing.Size(2206, 1242);
            this.Load += new System.EventHandler(this.HelpRequestControl_Load);
            this.SizeChanged += new System.EventHandler(this.HelpRequestControl_SizeChanged);
            this.contentWrapper.ResumeLayout(false);
            this.contentWrapper.PerformLayout();
            this.locationWrapper.ResumeLayout(false);
            this.locationWrapper.PerformLayout();
            this.btBackWrapper.ResumeLayout(false);
            this.titleWrapper.ResumeLayout(false);
            this.titleWrapper.PerformLayout();
            this.lbTitleWrapper.ResumeLayout(false);
            this.lbTitleWrapper.PerformLayout();
            this.lbUrgencyCrititcalWrapper.ResumeLayout(false);
            this.lbUrgencyCrititcalWrapper.PerformLayout();
            this.lbUrgencyNormalWrapper.ResumeLayout(false);
            this.lbUrgencyNormalWrapper.PerformLayout();
            this.lbUrgencyLowWrapper.ResumeLayout(false);
            this.lbUrgencyLowWrapper.PerformLayout();
            this.lbCloseWrapper.ResumeLayout(false);
            this.lbCloseWrapper.PerformLayout();
            this.btApplicationsWrapper.ResumeLayout(false);
            this.btApplicationsWrapper.PerformLayout();
            this.btEditWrapper.ResumeLayout(false);
            this.btEditWrapper.PerformLayout();
            this.btCancelWrapper.ResumeLayout(false);
            this.btCancelWrapper.PerformLayout();
            this.btApplyWrapper.ResumeLayout(false);
            this.btApplyWrapper.PerformLayout();
            this.btCloseWrapper.ResumeLayout(false);
            this.btCloseWrapper.PerformLayout();
            this.btOpenWrapper.ResumeLayout(false);
            this.btOpenWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Label lbSubtitle;
        private System.Windows.Forms.Panel contentWrapper;
        private HorizontalSeperatorControl horizontalSeperator;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.FlowLayoutPanel locationWrapper;
        private System.Windows.Forms.Label lbDistance;
        private System.Windows.Forms.Panel btBackWrapper;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel titleWrapper;
        private System.Windows.Forms.FlowLayoutPanel btApplyWrapper;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.FlowLayoutPanel btApplicationsWrapper;
        private System.Windows.Forms.Button btApplications;
        private System.Windows.Forms.FlowLayoutPanel btEditWrapper;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Panel lbTitleWrapper;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel lbUrgencyCrititcalWrapper;
        private System.Windows.Forms.Label lbUrgencyCritical;
        private System.Windows.Forms.Panel lbUrgencyNormalWrapper;
        private System.Windows.Forms.Label lbUrgencyNormal;
        private System.Windows.Forms.Panel lbUrgencyLowWrapper;
        private System.Windows.Forms.Label lbUrgencyLow;
        private System.Windows.Forms.FlowLayoutPanel btCloseWrapper;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.FlowLayoutPanel btOpenWrapper;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Panel lbCloseWrapper;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.FlowLayoutPanel btCancelWrapper;
        private System.Windows.Forms.Button btCancel;
    }
}
