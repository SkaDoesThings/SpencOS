namespace Master_Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.button2 = new System.Windows.Forms.Button();
            this.settingsPanels = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.displayIcon = new System.Windows.Forms.PictureBox();
            this.changeIconDialog = new System.Windows.Forms.Button();
            this.wallpaperPanel = new System.Windows.Forms.GroupBox();
            this.changeWallpaperDialog = new System.Windows.Forms.Button();
            this.displayWallpaper = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.settingsPanels.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayIcon)).BeginInit();
            this.wallpaperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayWallpaper)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(21, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 44);
            this.button2.TabIndex = 0;
            this.button2.Text = "Switch Theme";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // settingsPanels
            // 
            this.settingsPanels.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.settingsPanels.Controls.Add(this.tabPage2);
            this.settingsPanels.Controls.Add(this.tabPage1);
            this.settingsPanels.Controls.Add(this.tabPage3);
            this.settingsPanels.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsPanels.Location = new System.Drawing.Point(0, 0);
            this.settingsPanels.Name = "settingsPanels";
            this.settingsPanels.SelectedIndex = 0;
            this.settingsPanels.Size = new System.Drawing.Size(893, 658);
            this.settingsPanels.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.wallpaperPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 42);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(885, 612);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Personalize";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.groupBox1.Controls.Add(this.displayIcon);
            this.groupBox1.Controls.Add(this.changeIconDialog);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(530, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 198);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile Image";
            // 
            // displayIcon
            // 
            this.displayIcon.BackgroundImage = global::Master_Forms.Properties.Resources.delivery___surprise_man_box_package_unbox_happy_256;
            this.displayIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayIcon.Location = new System.Drawing.Point(19, 52);
            this.displayIcon.Name = "displayIcon";
            this.displayIcon.Size = new System.Drawing.Size(119, 118);
            this.displayIcon.TabIndex = 6;
            this.displayIcon.TabStop = false;
            // 
            // changeIconDialog
            // 
            this.changeIconDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.changeIconDialog.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.changeIconDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.changeIconDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeIconDialog.Location = new System.Drawing.Point(161, 107);
            this.changeIconDialog.Name = "changeIconDialog";
            this.changeIconDialog.Size = new System.Drawing.Size(151, 63);
            this.changeIconDialog.TabIndex = 5;
            this.changeIconDialog.Text = "Change Wallpaper";
            this.changeIconDialog.UseVisualStyleBackColor = false;
            this.changeIconDialog.Click += new System.EventHandler(this.changeIconDialog_Click);
            // 
            // wallpaperPanel
            // 
            this.wallpaperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.wallpaperPanel.Controls.Add(this.changeWallpaperDialog);
            this.wallpaperPanel.Controls.Add(this.displayWallpaper);
            this.wallpaperPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wallpaperPanel.Location = new System.Drawing.Point(21, 41);
            this.wallpaperPanel.Name = "wallpaperPanel";
            this.wallpaperPanel.Size = new System.Drawing.Size(475, 198);
            this.wallpaperPanel.TabIndex = 8;
            this.wallpaperPanel.TabStop = false;
            this.wallpaperPanel.Text = "Customize Wallpaper";
            // 
            // changeWallpaperDialog
            // 
            this.changeWallpaperDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.changeWallpaperDialog.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.changeWallpaperDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.changeWallpaperDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeWallpaperDialog.Location = new System.Drawing.Point(286, 107);
            this.changeWallpaperDialog.Name = "changeWallpaperDialog";
            this.changeWallpaperDialog.Size = new System.Drawing.Size(151, 63);
            this.changeWallpaperDialog.TabIndex = 5;
            this.changeWallpaperDialog.Text = "Change Wallpaper";
            this.changeWallpaperDialog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changeWallpaperDialog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.changeWallpaperDialog.UseVisualStyleBackColor = false;
            this.changeWallpaperDialog.Click += new System.EventHandler(this.changeWallpaperDialog_Click);
            // 
            // displayWallpaper
            // 
            this.displayWallpaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("displayWallpaper.BackgroundImage")));
            this.displayWallpaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.displayWallpaper.Location = new System.Drawing.Point(28, 42);
            this.displayWallpaper.Name = "displayWallpaper";
            this.displayWallpaper.Size = new System.Drawing.Size(240, 128);
            this.displayWallpaper.TabIndex = 2;
            this.displayWallpaper.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 42);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(885, 612);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 42);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(885, 612);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(107, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 524);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(29, 330);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(610, 166);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "SpencOS is an industry leading software that creates an entirely seperate desktop" +
    " enviorment. Built in C# Winforms and designed to feel modern, this is an expans" +
    "ive program unlike any other.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "By Spencer Augenstein";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "© Seal Studios";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alpha v11.11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "SpencOS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Master_Forms.Properties.Resources.logo;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(291, 286);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(73, 83);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(7, 3, 4, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(123, 147);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(4, 3);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(58, 301);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Location = new System.Drawing.Point(73, 0);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(316, 20);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox2, 6);
            this.pictureBox2.Size = new System.Drawing.Size(58, 301);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(73, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Product Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(893, 658);
            this.Controls.Add(this.settingsPanels);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.settingsPanels.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayIcon)).EndInit();
            this.wallpaperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.displayWallpaper)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button button2;
        private TabControl settingsPanels;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TextBox textBoxDescription;
        private PictureBox logoPictureBox;
        private TableLayoutPanel tableLayoutPanel;
        private Label labelProductName;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox textBox1;
        private TabPage tabPage2;
        public GroupBox wallpaperPanel;
        private Button changeWallpaperDialog;
        private PictureBox displayWallpaper;
        public GroupBox groupBox1;
        private PictureBox displayIcon;
        private Button changeIconDialog;
    }
}