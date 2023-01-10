namespace Master_Forms.Phonebook
{
    partial class Register
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.registerNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.registerSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.registerInfobox = new System.Windows.Forms.GroupBox();
            this.inputComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inputTele = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputCell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputLast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputFirst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizingBox = new System.Windows.Forms.GroupBox();
            this.sizingBox2 = new System.Windows.Forms.GroupBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.registerInfobox.SuspendLayout();
            this.sizingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.registerNew,
            this.toolStripSeparator2,
            this.registerSave,
            this.toolStripSeparator3,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(419, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Master_Forms.Properties.Resources.icons8_phone_contact_48;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 51);
            this.toolStripButton2.Text = "Phonebook - Registar Data";
            // 
            // registerNew
            // 
            this.registerNew.Image = global::Master_Forms.Properties.Resources.icons8_add_user_male_48;
            this.registerNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.registerNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.registerNew.Name = "registerNew";
            this.registerNew.Size = new System.Drawing.Size(110, 51);
            this.registerNew.Text = "New Data";
            this.registerNew.Click += new System.EventHandler(this.registerNew_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // registerSave
            // 
            this.registerSave.Enabled = false;
            this.registerSave.Image = global::Master_Forms.Properties.Resources.icons8_save_48;
            this.registerSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.registerSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.registerSave.Name = "registerSave";
            this.registerSave.Size = new System.Drawing.Size(132, 51);
            this.registerSave.Text = "Save Changes";
            this.registerSave.Click += new System.EventHandler(this.registerSave_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::Master_Forms.Properties.Resources.icons8_login_32_1_;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 51);
            this.toolStripButton1.Text = "Exit";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // registerInfobox
            // 
            this.registerInfobox.Controls.Add(this.inputComment);
            this.registerInfobox.Controls.Add(this.label8);
            this.registerInfobox.Controls.Add(this.inputAddress);
            this.registerInfobox.Controls.Add(this.label7);
            this.registerInfobox.Controls.Add(this.inputEmail);
            this.registerInfobox.Controls.Add(this.label6);
            this.registerInfobox.Controls.Add(this.inputTele);
            this.registerInfobox.Controls.Add(this.label5);
            this.registerInfobox.Controls.Add(this.inputCell);
            this.registerInfobox.Controls.Add(this.label4);
            this.registerInfobox.Controls.Add(this.inputLast);
            this.registerInfobox.Controls.Add(this.label3);
            this.registerInfobox.Controls.Add(this.inputFirst);
            this.registerInfobox.Controls.Add(this.label2);
            this.registerInfobox.Controls.Add(this.inputId);
            this.registerInfobox.Controls.Add(this.label1);
            this.registerInfobox.Enabled = false;
            this.registerInfobox.Location = new System.Drawing.Point(18, 22);
            this.registerInfobox.Name = "registerInfobox";
            this.registerInfobox.Size = new System.Drawing.Size(383, 304);
            this.registerInfobox.TabIndex = 1;
            this.registerInfobox.TabStop = false;
            this.registerInfobox.Text = "Information";
            this.registerInfobox.Enter += new System.EventHandler(this.registerInfobox_Enter);
            // 
            // inputComment
            // 
            this.inputComment.Location = new System.Drawing.Point(113, 251);
            this.inputComment.Name = "inputComment";
            this.inputComment.Size = new System.Drawing.Size(217, 23);
            this.inputComment.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Comment:";
            // 
            // inputAddress
            // 
            this.inputAddress.Location = new System.Drawing.Point(113, 222);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(217, 23);
            this.inputAddress.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address:";
            // 
            // inputEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(113, 193);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(217, 23);
            this.inputEmail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email:";
            // 
            // inputTele
            // 
            this.inputTele.Location = new System.Drawing.Point(113, 164);
            this.inputTele.Name = "inputTele";
            this.inputTele.Size = new System.Drawing.Size(217, 23);
            this.inputTele.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cellphone:";
            // 
            // inputCell
            // 
            this.inputCell.Location = new System.Drawing.Point(113, 135);
            this.inputCell.Name = "inputCell";
            this.inputCell.Size = new System.Drawing.Size(217, 23);
            this.inputCell.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telephone:";
            // 
            // inputLast
            // 
            this.inputLast.Location = new System.Drawing.Point(113, 106);
            this.inputLast.Name = "inputLast";
            this.inputLast.Size = new System.Drawing.Size(217, 23);
            this.inputLast.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // inputFirst
            // 
            this.inputFirst.Location = new System.Drawing.Point(113, 77);
            this.inputFirst.Name = "inputFirst";
            this.inputFirst.Size = new System.Drawing.Size(217, 23);
            this.inputFirst.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // inputId
            // 
            this.inputId.Location = new System.Drawing.Point(113, 48);
            this.inputId.Name = "inputId";
            this.inputId.Size = new System.Drawing.Size(217, 23);
            this.inputId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // sizingBox
            // 
            this.sizingBox.Controls.Add(this.sizingBox2);
            this.sizingBox.Controls.Add(this.registerInfobox);
            this.sizingBox.Location = new System.Drawing.Point(0, 57);
            this.sizingBox.Name = "sizingBox";
            this.sizingBox.Size = new System.Drawing.Size(419, 397);
            this.sizingBox.TabIndex = 2;
            this.sizingBox.TabStop = false;
            // 
            // sizingBox2
            // 
            this.sizingBox2.Location = new System.Drawing.Point(0, -55);
            this.sizingBox2.Name = "sizingBox2";
            this.sizingBox2.Size = new System.Drawing.Size(419, 52);
            this.sizingBox2.TabIndex = 2;
            this.sizingBox2.TabStop = false;
            this.sizingBox2.Text = "groupBox1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 409);
            this.Controls.Add(this.sizingBox);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.registerInfobox.ResumeLayout(false);
            this.registerInfobox.PerformLayout();
            this.sizingBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton registerNew;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton registerSave;
        private ToolStripSeparator toolStripSeparator3;
        private GroupBox registerInfobox;
        private TextBox inputComment;
        private Label label8;
        private TextBox inputAddress;
        private Label label7;
        private TextBox inputEmail;
        private Label label6;
        private TextBox inputTele;
        private Label label5;
        private TextBox inputCell;
        private Label label4;
        private TextBox inputLast;
        private Label label3;
        private TextBox inputFirst;
        private Label label2;
        private TextBox inputId;
        private Label label1;
        private GroupBox sizingBox;
        private GroupBox sizingBox2;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator1;
    }
}