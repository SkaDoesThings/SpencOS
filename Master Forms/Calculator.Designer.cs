namespace Master_Forms
{
    partial class Calculator
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
            this.numberDot = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.actionEqual = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.number3 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.actionPlus = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.actionMinus = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.mainDisplayValue = new System.Windows.Forms.Label();
            this.actionMultiply = new System.Windows.Forms.Button();
            this.actionDivide = new System.Windows.Forms.Button();
            this.actionClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleCalculator = new System.Windows.Forms.Label();
            this.closeCalculator = new System.Windows.Forms.Button();
            this.operatorLabel = new System.Windows.Forms.Label();
            this.previousNumberLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numberDot
            // 
            this.numberDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.numberDot.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.numberDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.numberDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numberDot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberDot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numberDot.Location = new System.Drawing.Point(24, 268);
            this.numberDot.Name = "numberDot";
            this.numberDot.Size = new System.Drawing.Size(69, 63);
            this.numberDot.TabIndex = 11;
            this.numberDot.Text = ".";
            this.numberDot.UseVisualStyleBackColor = false;
            this.numberDot.Click += new System.EventHandler(this.numberDot_Click);
            // 
            // number9
            // 
            this.number9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.number9.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.number9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.number9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.number9.Location = new System.Drawing.Point(168, 76);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(69, 63);
            this.number9.TabIndex = 3;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = false;
            this.number9.Click += new System.EventHandler(this.number9_Click);
            // 
            // number0
            // 
            this.number0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.number0.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.number0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.number0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.number0.Location = new System.Drawing.Point(96, 268);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(69, 63);
            this.number0.TabIndex = 10;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = false;
            this.number0.Click += new System.EventHandler(this.number0_Click);
            // 
            // actionEqual
            // 
            this.actionEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.actionEqual.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.actionEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.actionEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionEqual.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actionEqual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.actionEqual.Location = new System.Drawing.Point(168, 268);
            this.actionEqual.Name = "actionEqual";
            this.actionEqual.Size = new System.Drawing.Size(140, 63);
            this.actionEqual.TabIndex = 0;
            this.actionEqual.Text = "=";
            this.actionEqual.UseVisualStyleBackColor = false;
            this.actionEqual.Click += new System.EventHandler(this.actionEqual_Click);
            // 
            // number1
            // 
            this.number1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.number1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.number1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.number1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.number1.Location = new System.Drawing.Point(24, 204);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(69, 63);
            this.number1.TabIndex = 7;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = false;
            this.number1.Click += new System.EventHandler(this.number1_Click);
            // 
            // number2
            // 
            this.number2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.number2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.number2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.number2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.number2.Location = new System.Drawing.Point(96, 204);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(69, 63);
            this.number2.TabIndex = 8;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = false;
            this.number2.Click += new System.EventHandler(this.number2_Click);
            // 
            // number3
            // 
            this.number3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.number3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.number3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.number3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.number3.Location = new System.Drawing.Point(168, 204);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(69, 63);
            this.number3.TabIndex = 9;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = false;
            this.number3.Click += new System.EventHandler(this.number3_Click);
            // 
            // number4
            // 
            this.number4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.number4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.number4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.number4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.number4.Location = new System.Drawing.Point(24, 140);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(69, 63);
            this.number4.TabIndex = 4;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = false;
            this.number4.Click += new System.EventHandler(this.number4_Click);
            // 
            // actionPlus
            // 
            this.actionPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.actionPlus.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.actionPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.actionPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionPlus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actionPlus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.actionPlus.Location = new System.Drawing.Point(240, 204);
            this.actionPlus.Name = "actionPlus";
            this.actionPlus.Size = new System.Drawing.Size(69, 63);
            this.actionPlus.TabIndex = 15;
            this.actionPlus.Text = "+";
            this.actionPlus.UseVisualStyleBackColor = false;
            this.actionPlus.Click += new System.EventHandler(this.actionPlus_Click);
            // 
            // number6
            // 
            this.number6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.number6.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.number6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.number6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.number6.Location = new System.Drawing.Point(168, 140);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(69, 63);
            this.number6.TabIndex = 6;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = false;
            this.number6.Click += new System.EventHandler(this.number6_Click);
            // 
            // number5
            // 
            this.number5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.number5.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.number5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.number5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.number5.Location = new System.Drawing.Point(96, 140);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(69, 63);
            this.number5.TabIndex = 5;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = false;
            this.number5.Click += new System.EventHandler(this.number5_Click);
            // 
            // number7
            // 
            this.number7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.number7.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.number7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.number7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.number7.Location = new System.Drawing.Point(24, 76);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(69, 63);
            this.number7.TabIndex = 1;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = false;
            this.number7.Click += new System.EventHandler(this.number7_Click);
            // 
            // actionMinus
            // 
            this.actionMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.actionMinus.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.actionMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.actionMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionMinus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actionMinus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.actionMinus.Location = new System.Drawing.Point(240, 140);
            this.actionMinus.Name = "actionMinus";
            this.actionMinus.Size = new System.Drawing.Size(69, 63);
            this.actionMinus.TabIndex = 14;
            this.actionMinus.Text = "-";
            this.actionMinus.UseVisualStyleBackColor = false;
            this.actionMinus.Click += new System.EventHandler(this.actionMinus_Click);
            // 
            // number8
            // 
            this.number8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.number8.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.number8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.number8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.number8.Location = new System.Drawing.Point(96, 76);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(69, 63);
            this.number8.TabIndex = 2;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = false;
            this.number8.Click += new System.EventHandler(this.number8_Click);
            // 
            // mainDisplayValue
            // 
            this.mainDisplayValue.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainDisplayValue.Location = new System.Drawing.Point(13, 94);
            this.mainDisplayValue.Name = "mainDisplayValue";
            this.mainDisplayValue.Size = new System.Drawing.Size(295, 59);
            this.mainDisplayValue.TabIndex = 17;
            this.mainDisplayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mainDisplayValue.Click += new System.EventHandler(this.mainDisplayValue_Click);
            // 
            // actionMultiply
            // 
            this.actionMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.actionMultiply.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.actionMultiply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.actionMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionMultiply.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actionMultiply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.actionMultiply.Location = new System.Drawing.Point(240, 76);
            this.actionMultiply.Name = "actionMultiply";
            this.actionMultiply.Size = new System.Drawing.Size(69, 63);
            this.actionMultiply.TabIndex = 13;
            this.actionMultiply.Text = "X";
            this.actionMultiply.UseVisualStyleBackColor = false;
            this.actionMultiply.Click += new System.EventHandler(this.actionMultiply_Click);
            // 
            // actionDivide
            // 
            this.actionDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.actionDivide.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.actionDivide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.actionDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionDivide.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actionDivide.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.actionDivide.Location = new System.Drawing.Point(239, 10);
            this.actionDivide.Name = "actionDivide";
            this.actionDivide.Size = new System.Drawing.Size(69, 63);
            this.actionDivide.TabIndex = 12;
            this.actionDivide.Text = "÷";
            this.actionDivide.UseVisualStyleBackColor = false;
            this.actionDivide.Click += new System.EventHandler(this.actionDivide_Click);
            // 
            // actionClear
            // 
            this.actionClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.actionClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.actionClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.actionClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionClear.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actionClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.actionClear.Location = new System.Drawing.Point(24, 10);
            this.actionClear.Name = "actionClear";
            this.actionClear.Size = new System.Drawing.Size(213, 63);
            this.actionClear.TabIndex = 16;
            this.actionClear.Text = "C";
            this.actionClear.UseVisualStyleBackColor = false;
            this.actionClear.Click += new System.EventHandler(this.actionClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titleCalculator);
            this.panel1.Controls.Add(this.closeCalculator);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 35);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            // 
            // titleCalculator
            // 
            this.titleCalculator.AutoSize = true;
            this.titleCalculator.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleCalculator.Location = new System.Drawing.Point(3, 8);
            this.titleCalculator.Name = "titleCalculator";
            this.titleCalculator.Size = new System.Drawing.Size(70, 19);
            this.titleCalculator.TabIndex = 7;
            this.titleCalculator.Text = "Calculator";
            // 
            // closeCalculator
            // 
            this.closeCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.closeCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeCalculator.ForeColor = System.Drawing.SystemColors.Control;
            this.closeCalculator.Location = new System.Drawing.Point(274, 0);
            this.closeCalculator.Name = "closeCalculator";
            this.closeCalculator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeCalculator.Size = new System.Drawing.Size(50, 35);
            this.closeCalculator.TabIndex = 6;
            this.closeCalculator.Text = "X";
            this.closeCalculator.UseVisualStyleBackColor = false;
            this.closeCalculator.Click += new System.EventHandler(this.closeCalculator_Click);
            this.closeCalculator.MouseHover += new System.EventHandler(this.closeCalculator_MouseHover);
            // 
            // operatorLabel
            // 
            this.operatorLabel.AutoSize = true;
            this.operatorLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.operatorLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.operatorLabel.Location = new System.Drawing.Point(260, 57);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new System.Drawing.Size(39, 28);
            this.operatorLabel.TabIndex = 23;
            this.operatorLabel.Text = "Op";
            this.operatorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // previousNumberLabel
            // 
            this.previousNumberLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.previousNumberLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.previousNumberLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.previousNumberLabel.Location = new System.Drawing.Point(30, 56);
            this.previousNumberLabel.Name = "previousNumberLabel";
            this.previousNumberLabel.Size = new System.Drawing.Size(234, 31);
            this.previousNumberLabel.TabIndex = 24;
            this.previousNumberLabel.Text = "Numbers";
            this.previousNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.number5);
            this.panel2.Controls.Add(this.numberDot);
            this.panel2.Controls.Add(this.number9);
            this.panel2.Controls.Add(this.number0);
            this.panel2.Controls.Add(this.actionEqual);
            this.panel2.Controls.Add(this.actionClear);
            this.panel2.Controls.Add(this.number1);
            this.panel2.Controls.Add(this.actionDivide);
            this.panel2.Controls.Add(this.number2);
            this.panel2.Controls.Add(this.actionMultiply);
            this.panel2.Controls.Add(this.number3);
            this.panel2.Controls.Add(this.number8);
            this.panel2.Controls.Add(this.number4);
            this.panel2.Controls.Add(this.actionMinus);
            this.panel2.Controls.Add(this.actionPlus);
            this.panel2.Controls.Add(this.number7);
            this.panel2.Controls.Add(this.number6);
            this.panel2.Location = new System.Drawing.Point(-4, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 340);
            this.panel2.TabIndex = 0;
            // 
            // Calculator
            // 
            this.AcceptButton = this.actionEqual;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(328, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainDisplayValue);
            this.Controls.Add(this.previousNumberLabel);
            this.Controls.Add(this.operatorLabel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button numberDot;
        private Button number9;
        private Button number0;
        private Button actionEqual;
        private Button number1;
        private Button number2;
        private Button number3;
        private Button number4;
        private Button actionPlus;
        private Button number6;
        private Button number5;
        private Button number7;
        private Button actionMinus;
        private Button number8;
        private Label mainDisplayValue;
        private Button actionMultiply;
        private Button actionDivide;
        private Button actionClear;
        private Panel panel1;
        private Button closeCalculator;
        private Label operatorLabel;
        private Label previousNumberLabel;
        private Panel panel2;
        private Label titleCalculator;
    }
}