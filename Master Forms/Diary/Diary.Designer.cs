namespace Master_Forms.Diary
{
    partial class Diary
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
            System.Windows.Forms.Button menuButtonExit;
            System.Windows.Forms.Button menuButtonMinimize;
            this.panel1 = new System.Windows.Forms.Panel();
            this.calenderPanel = new System.Windows.Forms.Panel();
            this.calenderDay = new System.Windows.Forms.Label();
            this.calenderYear = new System.Windows.Forms.Label();
            this.calenderMonth = new System.Windows.Forms.Label();
            this.calenderDate = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuButtonMemo = new System.Windows.Forms.ToolStripButton();
            this.menuButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.menuButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.menuButtonTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuButtonAbout = new System.Windows.Forms.ToolStripDropDownButton();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.accountUsername = new System.Windows.Forms.Label();
            menuButtonExit = new System.Windows.Forms.Button();
            menuButtonMinimize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.calenderPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuButtonExit
            // 
            menuButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            menuButtonExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            menuButtonExit.BackgroundImage = global::Master_Forms.Properties.Resources.icons8_cancel_32;
            menuButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            menuButtonExit.Cursor = System.Windows.Forms.Cursors.PanWest;
            menuButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            menuButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            menuButtonExit.Location = new System.Drawing.Point(1340, -1);
            menuButtonExit.Name = "menuButtonExit";
            menuButtonExit.Size = new System.Drawing.Size(36, 36);
            menuButtonExit.TabIndex = 3;
            menuButtonExit.UseVisualStyleBackColor = false;
            menuButtonExit.Click += new System.EventHandler(this.menuButtonExit_Click);
            // 
            // menuButtonMinimize
            // 
            menuButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            menuButtonMinimize.BackColor = System.Drawing.SystemColors.ControlLightLight;
            menuButtonMinimize.BackgroundImage = global::Master_Forms.Properties.Resources.icons8_minus_32;
            menuButtonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            menuButtonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            menuButtonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            menuButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            menuButtonMinimize.Location = new System.Drawing.Point(1305, -1);
            menuButtonMinimize.Name = "menuButtonMinimize";
            menuButtonMinimize.Size = new System.Drawing.Size(36, 36);
            menuButtonMinimize.TabIndex = 4;
            menuButtonMinimize.UseVisualStyleBackColor = false;
            menuButtonMinimize.Click += new System.EventHandler(this.menuButtonMinimize_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.calenderPanel);
            this.panel1.Controls.Add(this.timerLabel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 843);
            this.panel1.TabIndex = 0;
            // 
            // calenderPanel
            // 
            this.calenderPanel.BackgroundImage = global::Master_Forms.Properties.Resources.calender;
            this.calenderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.calenderPanel.Controls.Add(this.calenderDay);
            this.calenderPanel.Controls.Add(this.calenderYear);
            this.calenderPanel.Controls.Add(this.calenderMonth);
            this.calenderPanel.Controls.Add(this.calenderDate);
            this.calenderPanel.Location = new System.Drawing.Point(11, 159);
            this.calenderPanel.Name = "calenderPanel";
            this.calenderPanel.Size = new System.Drawing.Size(231, 212);
            this.calenderPanel.TabIndex = 2;
            // 
            // calenderDay
            // 
            this.calenderDay.AutoSize = true;
            this.calenderDay.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calenderDay.Location = new System.Drawing.Point(42, 132);
            this.calenderDay.Name = "calenderDay";
            this.calenderDay.Size = new System.Drawing.Size(154, 37);
            this.calenderDay.TabIndex = 3;
            this.calenderDay.Text = "Wednesday";
            this.calenderDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calenderYear
            // 
            this.calenderYear.AutoSize = true;
            this.calenderYear.BackColor = System.Drawing.Color.Transparent;
            this.calenderYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calenderYear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calenderYear.Location = new System.Drawing.Point(95, 30);
            this.calenderYear.Name = "calenderYear";
            this.calenderYear.Size = new System.Drawing.Size(41, 19);
            this.calenderYear.TabIndex = 2;
            this.calenderYear.Text = "2019";
            this.calenderYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calenderMonth
            // 
            this.calenderMonth.AutoSize = true;
            this.calenderMonth.BackColor = System.Drawing.Color.Transparent;
            this.calenderMonth.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calenderMonth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.calenderMonth.Location = new System.Drawing.Point(42, 44);
            this.calenderMonth.Name = "calenderMonth";
            this.calenderMonth.Size = new System.Drawing.Size(146, 37);
            this.calenderMonth.TabIndex = 1;
            this.calenderMonth.Text = "September";
            this.calenderMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calenderDate
            // 
            this.calenderDate.AutoSize = true;
            this.calenderDate.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calenderDate.Location = new System.Drawing.Point(87, 84);
            this.calenderDate.Name = "calenderDate";
            this.calenderDate.Size = new System.Drawing.Size(58, 48);
            this.calenderDate.TabIndex = 0;
            this.calenderDate.Text = "27";
            this.calenderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLabel
            // 
            this.timerLabel.BackColor = System.Drawing.Color.Black;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timerLabel.Location = new System.Drawing.Point(-1, 60);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(258, 56);
            this.timerLabel.TabIndex = 1;
            this.timerLabel.Text = "12:33:20";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timerLabel.Click += new System.EventHandler(this.timerLabel_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Image = global::Master_Forms.Properties.Resources.icons8_pro_display_xdr_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(-1, 786);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Snow Desktop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.versionLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(258, 787);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 56);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(904, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Background:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(984, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(66, 20);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(31, 15);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "0.0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuButtonMemo,
            this.menuButtonSearch,
            this.menuButtonSettings,
            this.menuButtonTools,
            this.menuButtonAbout});
            this.toolStrip1.Location = new System.Drawing.Point(258, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1118, 61);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuButtonMemo
            // 
            this.menuButtonMemo.AutoSize = false;
            this.menuButtonMemo.Image = global::Master_Forms.Properties.Resources.icons8_edit_image_32;
            this.menuButtonMemo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuButtonMemo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuButtonMemo.Name = "menuButtonMemo";
            this.menuButtonMemo.Size = new System.Drawing.Size(85, 57);
            this.menuButtonMemo.Text = "Add Memo";
            this.menuButtonMemo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuButtonSearch
            // 
            this.menuButtonSearch.AutoSize = false;
            this.menuButtonSearch.Image = global::Master_Forms.Properties.Resources.icons8_search_32;
            this.menuButtonSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuButtonSearch.Name = "menuButtonSearch";
            this.menuButtonSearch.Size = new System.Drawing.Size(85, 57);
            this.menuButtonSearch.Text = "Search Memo";
            this.menuButtonSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuButtonSettings
            // 
            this.menuButtonSettings.AutoSize = false;
            this.menuButtonSettings.Image = global::Master_Forms.Properties.Resources.icons8_settings_32;
            this.menuButtonSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuButtonSettings.Name = "menuButtonSettings";
            this.menuButtonSettings.Size = new System.Drawing.Size(85, 57);
            this.menuButtonSettings.Text = "Settings";
            this.menuButtonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuButtonTools
            // 
            this.menuButtonTools.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menuButtonTools.AutoSize = false;
            this.menuButtonTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.menuButtonTools.Image = global::Master_Forms.Properties.Resources.icons8_support_32;
            this.menuButtonTools.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuButtonTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuButtonTools.Name = "menuButtonTools";
            this.menuButtonTools.Size = new System.Drawing.Size(85, 57);
            this.menuButtonTools.Text = "Tools";
            this.menuButtonTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // menuButtonAbout
            // 
            this.menuButtonAbout.AutoSize = false;
            this.menuButtonAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuButtonAbout.Image = global::Master_Forms.Properties.Resources.icons8_info_32;
            this.menuButtonAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuButtonAbout.Name = "menuButtonAbout";
            this.menuButtonAbout.Size = new System.Drawing.Size(85, 57);
            this.menuButtonAbout.Text = "About";
            this.menuButtonAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 144);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.accountUsername);
            this.panel3.Controls.Add(this.label);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(14, 382);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 232);
            this.panel3.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 168);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(63, 15);
            this.label.TabIndex = 4;
            this.label.Text = "Username:";
            // 
            // accountUsername
            // 
            this.accountUsername.AutoSize = true;
            this.accountUsername.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.accountUsername.Location = new System.Drawing.Point(81, 168);
            this.accountUsername.Name = "accountUsername";
            this.accountUsername.Size = new System.Drawing.Size(38, 15);
            this.accountUsername.TabIndex = 5;
            this.accountUsername.Text = "label3";
            // 
            // Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1376, 843);
            this.ControlBox = false;
            this.Controls.Add(menuButtonMinimize);
            this.Controls.Add(menuButtonExit);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Diary";
            this.Text = "Diary Diet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Diary_Load);
            this.panel1.ResumeLayout(false);
            this.calenderPanel.ResumeLayout(false);
            this.calenderPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripButton menuButtonMemo;
        private ToolStripButton menuButtonSearch;
        private ToolStripButton menuButtonSettings;
        private ToolStripDropDownButton menuButtonTools;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripDropDownButton menuButtonAbout;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private Button button1;
        private Label timerLabel;
        private System.Windows.Forms.Timer timer1;
        private Panel calenderPanel;
        private Label calenderDay;
        private Label calenderYear;
        private Label calenderMonth;
        private Label calenderDate;
        private Label versionLabel;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Panel panel3;
        private Label accountUsername;
        private Label label;
        private PictureBox pictureBox1;
    }
}