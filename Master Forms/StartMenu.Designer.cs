namespace Master_Forms
{
    partial class StartMenu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.startButtonLogOff = new System.Windows.Forms.Button();
            this.startButtonExitProgram = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.accountUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appList = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.startButtonCalculator = new System.Windows.Forms.Button();
            this.startButtonSettings = new System.Windows.Forms.Button();
            this.processOpen = new System.Diagnostics.Process();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.startButtonLogOff);
            this.groupBox1.Controls.Add(this.startButtonExitProgram);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(-1, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::Master_Forms.Properties.Resources.icons8_restart_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(185, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Restart";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // startButtonExitProgram
            // 
            this.startButtonExitProgram.BackColor = System.Drawing.Color.CornflowerBlue;
            this.startButtonExitProgram.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startButtonExitProgram.Image = global::Master_Forms.Properties.Resources.icons8_shutdown_32;
            this.startButtonExitProgram.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.startButtonExitProgram.Location = new System.Drawing.Point(280, 7);
            this.startButtonExitProgram.Name = "startButtonExitProgram";
            this.startButtonExitProgram.Size = new System.Drawing.Size(101, 38);
            this.startButtonExitProgram.TabIndex = 0;
            this.startButtonExitProgram.Text = "Shutdown";
            this.startButtonExitProgram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startButtonExitProgram.UseVisualStyleBackColor = false;
            this.startButtonExitProgram.Click += new System.EventHandler(this.startButtonExitProgram_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Controls.Add(this.accountUsername);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(-1, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(403, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            this.accountUsername.Click += new System.EventHandler(this.label1_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            "Hello World"});
            this.appList.Location = new System.Drawing.Point(0, 76);
            this.appList.Name = "appList";
            this.appList.ScrollAlwaysVisible = true;
            this.appList.Size = new System.Drawing.Size(198, 386);
            this.appList.TabIndex = 14;
            this.appList.SelectedIndexChanged += new System.EventHandler(this.appList_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Controls.Add(this.startButtonCalculator);
            this.groupBox4.Controls.Add(this.startButtonSettings);
            this.groupBox4.Location = new System.Drawing.Point(199, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(194, 398);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
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
            this.startButtonSettings.Size = new System.Drawing.Size(202, 52);
            this.startButtonSettings.TabIndex = 0;
            this.startButtonSettings.Text = "Settings";
            this.startButtonSettings.UseVisualStyleBackColor = false;
            this.startButtonSettings.Click += new System.EventHandler(this.startButtonSettings_Click);
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
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 516);
            this.Controls.Add(this.appList);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StartMenu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.StartMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button startButtonExitProgram;
        private GroupBox groupBox4;
        private Button startButtonLogOff;
        private Button button1;
        private Label accountUsername;
        private PictureBox pictureBox1;
        private System.Diagnostics.Process processOpen;
        private Button startButtonSettings;
        private FileSystemWatcher fileSystemWatcher1;
        private Button startButtonCalculator;
        private ListBox appList;
    }
}