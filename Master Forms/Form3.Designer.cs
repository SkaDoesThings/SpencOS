namespace Master_Forms
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.hideAllWindows = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.barStartButton = new System.Windows.Forms.Button();
            this.openChangeWallpaper = new System.Windows.Forms.Button();
            this.barDateBox = new System.Windows.Forms.Label();
            this.barTimeBox = new System.Windows.Forms.Label();
            this.barNotificationTray = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.processOpen = new System.Diagnostics.Process();
            this.label1 = new System.Windows.Forms.Label();
            this.desktoptimer = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.process1 = new System.Diagnostics.Process();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.selectionPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startButtonRestart = new System.Windows.Forms.Button();
            this.startButtonLogOff = new System.Windows.Forms.Button();
            this.startButtonShutdown = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.accountUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appList = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.startButtonCalculator = new System.Windows.Forms.Button();
            this.startButtonSettings = new System.Windows.Forms.Button();
            this.process2 = new System.Diagnostics.Process();
            this.fileSystemWatcher2 = new System.IO.FileSystemWatcher();
            this.startMenu = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.notifcationPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).BeginInit();
            this.startMenu.SuspendLayout();
            this.notifcationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.hideAllWindows);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.barStartButton);
            this.panel1.Controls.Add(this.openChangeWallpaper);
            this.panel1.Controls.Add(this.barDateBox);
            this.panel1.Controls.Add(this.barTimeBox);
            this.panel1.Controls.Add(this.barNotificationTray);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 1037);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1921, 43);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // hideAllWindows
            // 
            this.hideAllWindows.BackColor = System.Drawing.Color.Transparent;
            this.hideAllWindows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hideAllWindows.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hideAllWindows.Location = new System.Drawing.Point(1911, -2);
            this.hideAllWindows.Name = "hideAllWindows";
            this.hideAllWindows.Size = new System.Drawing.Size(10, 45);
            this.hideAllWindows.TabIndex = 10;
            this.hideAllWindows.UseVisualStyleBackColor = false;
            this.hideAllWindows.Click += new System.EventHandler(this.hideAllWindows_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(146, 9);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1567, 25);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // barStartButton
            // 
            this.barStartButton.BackColor = System.Drawing.Color.Transparent;
            this.barStartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barStartButton.BackgroundImage")));
            this.barStartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.barStartButton.ForeColor = System.Drawing.Color.Transparent;
            this.barStartButton.Location = new System.Drawing.Point(-4, -5);
            this.barStartButton.Name = "barStartButton";
            this.barStartButton.Size = new System.Drawing.Size(144, 52);
            this.barStartButton.TabIndex = 3;
            this.barStartButton.UseVisualStyleBackColor = false;
            this.barStartButton.Click += new System.EventHandler(this.barStartButton_Click);
            // 
            // openChangeWallpaper
            // 
            this.openChangeWallpaper.Location = new System.Drawing.Point(1719, 2);
            this.openChangeWallpaper.Name = "openChangeWallpaper";
            this.openChangeWallpaper.Size = new System.Drawing.Size(43, 38);
            this.openChangeWallpaper.TabIndex = 9;
            this.openChangeWallpaper.UseVisualStyleBackColor = true;
            this.openChangeWallpaper.Visible = false;
            // 
            // barDateBox
            // 
            this.barDateBox.AutoSize = true;
            this.barDateBox.BackColor = System.Drawing.Color.Transparent;
            this.barDateBox.Location = new System.Drawing.Point(1770, 23);
            this.barDateBox.Name = "barDateBox";
            this.barDateBox.Size = new System.Drawing.Size(65, 15);
            this.barDateBox.TabIndex = 1;
            this.barDateBox.Text = "00/00/0000";
            this.barDateBox.Click += new System.EventHandler(this.barDateBox_Click);
            // 
            // barTimeBox
            // 
            this.barTimeBox.AutoSize = true;
            this.barTimeBox.BackColor = System.Drawing.Color.Transparent;
            this.barTimeBox.Location = new System.Drawing.Point(1768, 6);
            this.barTimeBox.Name = "barTimeBox";
            this.barTimeBox.Size = new System.Drawing.Size(70, 15);
            this.barTimeBox.TabIndex = 0;
            this.barTimeBox.Text = "00:00:00 NN";
            this.barTimeBox.Click += new System.EventHandler(this.barTimeBox_Click);
            // 
            // barNotificationTray
            // 
            this.barNotificationTray.BackColor = System.Drawing.Color.Transparent;
            this.barNotificationTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.barNotificationTray.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.barNotificationTray.Image = global::Master_Forms.Properties.Resources.notifcationComment;
            this.barNotificationTray.Location = new System.Drawing.Point(1861, -2);
            this.barNotificationTray.Name = "barNotificationTray";
            this.barNotificationTray.Size = new System.Drawing.Size(46, 45);
            this.barNotificationTray.TabIndex = 2;
            this.barNotificationTray.UseVisualStyleBackColor = false;
            this.barNotificationTray.Click += new System.EventHandler(this.barNotificationTray_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.BackgroundImage = global::Master_Forms.Properties.Resources.icons8_molecule_64;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(18, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 78);
            this.button2.TabIndex = 1;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // processOpen
            // 
            this.processOpen.StartInfo.Domain = "";
            this.processOpen.StartInfo.LoadUserProfile = false;
            this.processOpen.StartInfo.Password = null;
            this.processOpen.StartInfo.StandardErrorEncoding = null;
            this.processOpen.StartInfo.StandardInputEncoding = null;
            this.processOpen.StartInfo.StandardOutputEncoding = null;
            this.processOpen.StartInfo.UserName = "";
            this.processOpen.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(25, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spider Web";
            // 
            // desktoptimer
            // 
            this.desktoptimer.Enabled = true;
            this.desktoptimer.Tick += new System.EventHandler(this.desktoptimer_Tick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardInputEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // selectionPanel
            // 
            this.selectionPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.selectionPanel.Location = new System.Drawing.Point(127, 12);
            this.selectionPanel.Name = "selectionPanel";
            this.selectionPanel.Size = new System.Drawing.Size(200, 100);
            this.selectionPanel.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.startButtonRestart);
            this.groupBox1.Controls.Add(this.startButtonLogOff);
            this.groupBox1.Controls.Add(this.startButtonShutdown);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 469);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 51);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // startButtonRestart
            // 
            this.startButtonRestart.BackColor = System.Drawing.Color.CornflowerBlue;
            this.startButtonRestart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startButtonRestart.Image = global::Master_Forms.Properties.Resources.icons8_restart_32;
            this.startButtonRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startButtonRestart.Location = new System.Drawing.Point(185, 8);
            this.startButtonRestart.Name = "startButtonRestart";
            this.startButtonRestart.Size = new System.Drawing.Size(89, 37);
            this.startButtonRestart.TabIndex = 2;
            this.startButtonRestart.Text = "Restart";
            this.startButtonRestart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startButtonRestart.UseVisualStyleBackColor = false;
            this.startButtonRestart.Click += new System.EventHandler(this.startButtonRestart_Click);
            // 
            // startButtonLogOff
            // 
            this.startButtonLogOff.BackColor = System.Drawing.Color.CornflowerBlue;
            this.startButtonLogOff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startButtonLogOff.Image = global::Master_Forms.Properties.Resources.icons8_headstone_32;
            this.startButtonLogOff.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.startButtonLogOff.Location = new System.Drawing.Point(99, 7);
            this.startButtonLogOff.Name = "startButtonLogOff";
            this.startButtonLogOff.Size = new System.Drawing.Size(80, 38);
            this.startButtonLogOff.TabIndex = 1;
            this.startButtonLogOff.Text = "Log Off";
            this.startButtonLogOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startButtonLogOff.UseVisualStyleBackColor = false;
            this.startButtonLogOff.Click += new System.EventHandler(this.startButtonLogOff_Click);
            // 
            // startButtonShutdown
            // 
            this.startButtonShutdown.BackColor = System.Drawing.Color.CornflowerBlue;
            this.startButtonShutdown.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startButtonShutdown.Image = global::Master_Forms.Properties.Resources.icons8_shutdown_32;
            this.startButtonShutdown.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.startButtonShutdown.Location = new System.Drawing.Point(280, 7);
            this.startButtonShutdown.Name = "startButtonShutdown";
            this.startButtonShutdown.Size = new System.Drawing.Size(101, 38);
            this.startButtonShutdown.TabIndex = 0;
            this.startButtonShutdown.Text = "Shutdown";
            this.startButtonShutdown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startButtonShutdown.UseVisualStyleBackColor = false;
            this.startButtonShutdown.Click += new System.EventHandler(this.startButtonShutdown_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.accountUsername);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(0, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 73);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // accountUsername
            // 
            this.accountUsername.AutoSize = true;
            this.accountUsername.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.accountUsername.Location = new System.Drawing.Point(67, 11);
            this.accountUsername.Name = "accountUsername";
            this.accountUsername.Size = new System.Drawing.Size(153, 50);
            this.accountUsername.TabIndex = 1;
            this.accountUsername.Text = "Spencer";
            this.accountUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Master_Forms.Properties.Resources.MicrosoftTeams_image__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 59);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // appList
            // 
            this.appList.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.appList.BackColor = System.Drawing.SystemColors.Control;
            this.appList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appList.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.appList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.appList.FormattingEnabled = true;
            this.appList.ItemHeight = 32;
            this.appList.Items.AddRange(new object[] {
            "Spider Web",
            "Phonebook",
            "Fairgrounds",
            "Diary Diet",
            "Folder Traveler",
            "Hello World",
            "Ropapsi",
            "Dwayne ChatAI"});
            this.appList.Location = new System.Drawing.Point(1, 78);
            this.appList.Name = "appList";
            this.appList.ScrollAlwaysVisible = true;
            this.appList.Size = new System.Drawing.Size(198, 386);
            this.appList.TabIndex = 18;
            this.appList.SelectedIndexChanged += new System.EventHandler(this.appList_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Controls.Add(this.startButtonCalculator);
            this.groupBox4.Controls.Add(this.startButtonSettings);
            this.groupBox4.Location = new System.Drawing.Point(200, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 398);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // startButtonCalculator
            // 
            this.startButtonCalculator.Location = new System.Drawing.Point(-2, 291);
            this.startButtonCalculator.Name = "startButtonCalculator";
            this.startButtonCalculator.Size = new System.Drawing.Size(195, 58);
            this.startButtonCalculator.TabIndex = 1;
            this.startButtonCalculator.Text = "Calculator";
            this.startButtonCalculator.UseVisualStyleBackColor = false;
            this.startButtonCalculator.Click += new System.EventHandler(this.startButtonCalculator_Click);
            // 
            // startButtonSettings
            // 
            this.startButtonSettings.Location = new System.Drawing.Point(-2, 346);
            this.startButtonSettings.Name = "startButtonSettings";
            this.startButtonSettings.Size = new System.Drawing.Size(195, 52);
            this.startButtonSettings.TabIndex = 0;
            this.startButtonSettings.Text = "Settings";
            this.startButtonSettings.UseVisualStyleBackColor = false;
            this.startButtonSettings.Click += new System.EventHandler(this.startButtonSettings_Click);
            // 
            // process2
            // 
            this.process2.StartInfo.Domain = "";
            this.process2.StartInfo.LoadUserProfile = false;
            this.process2.StartInfo.Password = null;
            this.process2.StartInfo.StandardErrorEncoding = null;
            this.process2.StartInfo.StandardInputEncoding = null;
            this.process2.StartInfo.StandardOutputEncoding = null;
            this.process2.StartInfo.UserName = "";
            this.process2.SynchronizingObject = this;
            // 
            // fileSystemWatcher2
            // 
            this.fileSystemWatcher2.EnableRaisingEvents = true;
            this.fileSystemWatcher2.SynchronizingObject = this;
            // 
            // startMenu
            // 
            this.startMenu.Controls.Add(this.groupBox2);
            this.startMenu.Controls.Add(this.groupBox4);
            this.startMenu.Controls.Add(this.groupBox1);
            this.startMenu.Controls.Add(this.appList);
            this.startMenu.Location = new System.Drawing.Point(12, 510);
            this.startMenu.Name = "startMenu";
            this.startMenu.Size = new System.Drawing.Size(390, 521);
            this.startMenu.TabIndex = 19;
            this.startMenu.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1676, 872);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.MouseLeave += new System.EventHandler(this.CloseCalender);
            // 
            // notifcationPanel
            // 
            this.notifcationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.notifcationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notifcationPanel.Controls.Add(this.pictureBox2);
            this.notifcationPanel.Controls.Add(this.groupBox5);
            this.notifcationPanel.Controls.Add(this.groupBox3);
            this.notifcationPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.notifcationPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.notifcationPanel.Location = new System.Drawing.Point(1571, 0);
            this.notifcationPanel.Name = "notifcationPanel";
            this.notifcationPanel.Size = new System.Drawing.Size(350, 1037);
            this.notifcationPanel.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(60, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 219);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(10, 278);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(329, 515);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.monthCalendar2);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(10, 799);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 225);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.monthCalendar2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.monthCalendar2.Location = new System.Drawing.Point(53, 37);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1921, 1080);
            this.Controls.Add(this.notifcationPanel);
            this.Controls.Add(this.startMenu);
            this.Controls.Add(this.selectionPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monthCalendar1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher2)).EndInit();
            this.startMenu.ResumeLayout(false);
            this.notifcationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.Timer timer;
        private Button barNotificationTray;
        private Label barDateBox;
        private Label barTimeBox;
        private ContextMenuStrip contextMenuStrip1;
        private Button barStartButton;
        private Button button2;
        private System.Diagnostics.Process processOpen;
        private Label label1;
        private Button openChangeWallpaper;
        private System.Windows.Forms.Timer desktoptimer;
        private FileSystemWatcher fileSystemWatcher1;
        private System.Diagnostics.Process process1;
        private ListBox listBox1;
        private ImageList imageList1;
        private Panel selectionPanel;
        private System.Windows.Forms.Timer timer1;
        private Panel startMenu;
        private GroupBox groupBox2;
        private Label accountUsername;
        private PictureBox pictureBox1;
        private GroupBox groupBox4;
        private Button startButtonCalculator;
        private Button startButtonSettings;
        private GroupBox groupBox1;
        private Button startButtonRestart;
        private Button startButtonLogOff;
        private Button startButtonShutdown;
        private ListBox appList;
        private System.Diagnostics.Process process2;
        private FileSystemWatcher fileSystemWatcher2;
        private MonthCalendar monthCalendar1;
        private Panel notifcationPanel;
        private PictureBox pictureBox2;
        private Button hideAllWindows;
        private GroupBox groupBox3;
        private MonthCalendar monthCalendar2;
        private GroupBox groupBox5;
    }
}