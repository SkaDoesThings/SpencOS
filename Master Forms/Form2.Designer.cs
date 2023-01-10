namespace Master_Forms
{
    partial class Form2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.powerOptionPanel = new System.Windows.Forms.Panel();
            this.powerPanelRestartButton = new System.Windows.Forms.Button();
            this.powerPanelOffButton = new System.Windows.Forms.Button();
            this.powerPanelLogoffButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wrongPasswordLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.selectUserPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.createUser = new System.Windows.Forms.Panel();
            this.createUserReturn = new System.Windows.Forms.Button();
            this.createUserSubmit = new System.Windows.Forms.Button();
            this.createUserPass = new System.Windows.Forms.TextBox();
            this.createUserName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.userCreate = new System.Windows.Forms.Button();
            this.userList = new System.Windows.Forms.ListBox();
            this.helloButton = new System.Windows.Forms.Button();
            this.powerOptionUserPanel = new System.Windows.Forms.Panel();
            this.usernameInputBox = new System.Windows.Forms.TextBox();
            this.powerOptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.selectUserPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.createUser.SuspendLayout();
            this.panel5.SuspendLayout();
            this.powerOptionUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Image = global::Master_Forms.Properties.Resources.icons8_shutdown_32;
            this.exitButton.Location = new System.Drawing.Point(1828, 993);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 50);
            this.exitButton.TabIndex = 0;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // powerOptionPanel
            // 
            this.powerOptionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.powerOptionPanel.Controls.Add(this.powerPanelRestartButton);
            this.powerOptionPanel.Controls.Add(this.powerPanelOffButton);
            this.powerOptionPanel.Location = new System.Drawing.Point(1767, 884);
            this.powerOptionPanel.Name = "powerOptionPanel";
            this.powerOptionPanel.Size = new System.Drawing.Size(124, 103);
            this.powerOptionPanel.TabIndex = 1;
            this.powerOptionPanel.Leave += new System.EventHandler(this.powerOptionPanel_Leave);
            // 
            // powerPanelRestartButton
            // 
            this.powerPanelRestartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.powerPanelRestartButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.powerPanelRestartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.powerPanelRestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerPanelRestartButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.powerPanelRestartButton.Location = new System.Drawing.Point(9, 54);
            this.powerPanelRestartButton.Name = "powerPanelRestartButton";
            this.powerPanelRestartButton.Size = new System.Drawing.Size(106, 35);
            this.powerPanelRestartButton.TabIndex = 1;
            this.powerPanelRestartButton.Text = "Restart";
            this.powerPanelRestartButton.UseVisualStyleBackColor = false;
            this.powerPanelRestartButton.Click += new System.EventHandler(this.powerPanelRestartButton_Click);
            // 
            // powerPanelOffButton
            // 
            this.powerPanelOffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.powerPanelOffButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.powerPanelOffButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.powerPanelOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerPanelOffButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.powerPanelOffButton.Location = new System.Drawing.Point(9, 13);
            this.powerPanelOffButton.Name = "powerPanelOffButton";
            this.powerPanelOffButton.Size = new System.Drawing.Size(106, 35);
            this.powerPanelOffButton.TabIndex = 0;
            this.powerPanelOffButton.Text = "Shutdown";
            this.powerPanelOffButton.UseVisualStyleBackColor = false;
            this.powerPanelOffButton.Click += new System.EventHandler(this.powerPanelOffButton_Click);
            // 
            // powerPanelLogoffButton
            // 
            this.powerPanelLogoffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.powerPanelLogoffButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.powerPanelLogoffButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.powerPanelLogoffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerPanelLogoffButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.powerPanelLogoffButton.Location = new System.Drawing.Point(9, 13);
            this.powerPanelLogoffButton.Name = "powerPanelLogoffButton";
            this.powerPanelLogoffButton.Size = new System.Drawing.Size(106, 35);
            this.powerPanelLogoffButton.TabIndex = 2;
            this.powerPanelLogoffButton.Text = "Logoff";
            this.powerPanelLogoffButton.UseVisualStyleBackColor = false;
            this.powerPanelLogoffButton.Click += new System.EventHandler(this.powerPanelLogoffButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(1187, 678);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 93);
            this.button2.TabIndex = 2;
            this.button2.Text = "->";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(719, 678);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.PlaceholderText = "Password";
            this.textBox1.Size = new System.Drawing.Size(462, 93);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // wrongPasswordLabel
            // 
            this.wrongPasswordLabel.AutoSize = true;
            this.wrongPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wrongPasswordLabel.Location = new System.Drawing.Point(672, 788);
            this.wrongPasswordLabel.Name = "wrongPasswordLabel";
            this.wrongPasswordLabel.Size = new System.Drawing.Size(0, 50);
            this.wrongPasswordLabel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(781, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 329);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // selectUserPanel
            // 
            this.selectUserPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.selectUserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectUserPanel.Controls.Add(this.panel1);
            this.selectUserPanel.Controls.Add(this.createUser);
            this.selectUserPanel.Controls.Add(this.panel5);
            this.selectUserPanel.Controls.Add(this.userCreate);
            this.selectUserPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.selectUserPanel.Location = new System.Drawing.Point(12, 12);
            this.selectUserPanel.Name = "selectUserPanel";
            this.selectUserPanel.Size = new System.Drawing.Size(465, 1031);
            this.selectUserPanel.TabIndex = 7;
            this.selectUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.selectUserPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 80);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Users";
            // 
            // createUser
            // 
            this.createUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.createUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createUser.Controls.Add(this.createUserReturn);
            this.createUser.Controls.Add(this.createUserSubmit);
            this.createUser.Controls.Add(this.createUserPass);
            this.createUser.Controls.Add(this.createUserName);
            this.createUser.Controls.Add(this.button1);
            this.createUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.createUser.Location = new System.Drawing.Point(27, 747);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(408, 266);
            this.createUser.TabIndex = 9;
            this.createUser.Paint += new System.Windows.Forms.PaintEventHandler(this.createUser_Paint);
            // 
            // createUserReturn
            // 
            this.createUserReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.createUserReturn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createUserReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.createUserReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserReturn.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createUserReturn.ForeColor = System.Drawing.Color.White;
            this.createUserReturn.Location = new System.Drawing.Point(17, 176);
            this.createUserReturn.Name = "createUserReturn";
            this.createUserReturn.Size = new System.Drawing.Size(98, 77);
            this.createUserReturn.TabIndex = 12;
            this.createUserReturn.Text = "<-";
            this.createUserReturn.UseVisualStyleBackColor = false;
            this.createUserReturn.Click += new System.EventHandler(this.createUserReturn_Click);
            // 
            // createUserSubmit
            // 
            this.createUserSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.createUserSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createUserSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.createUserSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createUserSubmit.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createUserSubmit.ForeColor = System.Drawing.Color.White;
            this.createUserSubmit.Location = new System.Drawing.Point(129, 176);
            this.createUserSubmit.Name = "createUserSubmit";
            this.createUserSubmit.Size = new System.Drawing.Size(260, 77);
            this.createUserSubmit.TabIndex = 13;
            this.createUserSubmit.Text = "Submit";
            this.createUserSubmit.UseVisualStyleBackColor = false;
            this.createUserSubmit.Click += new System.EventHandler(this.createUserSubmit_Click);
            // 
            // createUserPass
            // 
            this.createUserPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.createUserPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createUserPass.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createUserPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createUserPass.Location = new System.Drawing.Point(17, 96);
            this.createUserPass.Name = "createUserPass";
            this.createUserPass.PasswordChar = '*';
            this.createUserPass.PlaceholderText = "Password";
            this.createUserPass.Size = new System.Drawing.Size(372, 57);
            this.createUserPass.TabIndex = 11;
            // 
            // createUserName
            // 
            this.createUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.createUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createUserName.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createUserName.Location = new System.Drawing.Point(17, 20);
            this.createUserName.Name = "createUserName";
            this.createUserName.PlaceholderText = "Username";
            this.createUserName.Size = new System.Drawing.Size(372, 57);
            this.createUserName.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(17, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(431, 121);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(3, 656);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(457, 80);
            this.panel5.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dynamic Users";
            // 
            // userCreate
            // 
            this.userCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.userCreate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.userCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.userCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userCreate.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userCreate.ForeColor = System.Drawing.Color.White;
            this.userCreate.Location = new System.Drawing.Point(17, 829);
            this.userCreate.Name = "userCreate";
            this.userCreate.Size = new System.Drawing.Size(431, 121);
            this.userCreate.TabIndex = 12;
            this.userCreate.Text = "Create";
            this.userCreate.UseVisualStyleBackColor = false;
            this.userCreate.Click += new System.EventHandler(this.userCreate_Click);
            // 
            // userList
            // 
            this.userList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.userList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userList.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 89;
            this.userList.Location = new System.Drawing.Point(15, 97);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(458, 536);
            this.userList.TabIndex = 13;
            this.userList.SelectedIndexChanged += new System.EventHandler(this.userList_SelectedIndexChanged);
            // 
            // helloButton
            // 
            this.helloButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.helloButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.helloButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.helloButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helloButton.Image = global::Master_Forms.Properties.Resources.icons8_login_32_1_;
            this.helloButton.Location = new System.Drawing.Point(1767, 993);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(50, 50);
            this.helloButton.TabIndex = 9;
            this.helloButton.UseVisualStyleBackColor = false;
            this.helloButton.Click += new System.EventHandler(this.helloButton_Click);
            // 
            // powerOptionUserPanel
            // 
            this.powerOptionUserPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.powerOptionUserPanel.Controls.Add(this.powerPanelLogoffButton);
            this.powerOptionUserPanel.Location = new System.Drawing.Point(1767, 842);
            this.powerOptionUserPanel.Name = "powerOptionUserPanel";
            this.powerOptionUserPanel.Size = new System.Drawing.Size(124, 53);
            this.powerOptionUserPanel.TabIndex = 10;
            // 
            // usernameInputBox
            // 
            this.usernameInputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.usernameInputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameInputBox.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameInputBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernameInputBox.Location = new System.Drawing.Point(719, 579);
            this.usernameInputBox.Name = "usernameInputBox";
            this.usernameInputBox.PlaceholderText = "Username";
            this.usernameInputBox.Size = new System.Drawing.Size(462, 93);
            this.usernameInputBox.TabIndex = 8;
            // 
            // Form2
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1901, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.userList);
            this.Controls.Add(this.powerOptionUserPanel);
            this.Controls.Add(this.helloButton);
            this.Controls.Add(this.usernameInputBox);
            this.Controls.Add(this.selectUserPanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wrongPasswordLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.powerOptionPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Click += new System.EventHandler(this.Form2_Click);
            this.powerOptionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.selectUserPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.createUser.ResumeLayout(false);
            this.createUser.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.powerOptionUserPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Button powerPanelRestartButton;
        private Button exitButton;
        private ToolStrip toolStrip1;
        private Panel powerOptionPanel;
        private Button button2;
        private TextBox textBox1;
        private Label wrongPasswordLabel;
        private PictureBox pictureBox1;
        private Button powerPanelOffButton;
        private Button powerPanelLogoffButton;
        private Panel selectUserPanel;
        private Panel panel5;
        private Label label3;
        private Button userCreate;
        private Panel createUser;
        private Button button1;
        private Button createUserReturn;
        private Button createUserSubmit;
        private TextBox createUserPass;
        private TextBox createUserName;
        private Button helloButton;
        private Panel powerOptionUserPanel;
        private ListBox userList;
        private Panel panel1;
        private Label label1;
        private TextBox usernameInputBox;
    }
}