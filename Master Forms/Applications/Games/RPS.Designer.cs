namespace Master_Forms.Applications.Games
{
    partial class RPS
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
            this.buttonScissors = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.singleplayerBox = new System.Windows.Forms.GroupBox();
            this.buttonRock = new System.Windows.Forms.Button();
            this.buttonRopapsi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.scoreTies = new System.Windows.Forms.Label();
            this.scoreBot = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scoreYou = new System.Windows.Forms.Label();
            this.scoreboardThem = new System.Windows.Forms.Label();
            this.scoreboardYou = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toMainMenu = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.resultsWhoWon = new System.Windows.Forms.Label();
            this.resultsSo = new System.Windows.Forms.Label();
            this.resultsAnd = new System.Windows.Forms.Label();
            this.resultsTheyChose = new System.Windows.Forms.Label();
            this.buttonNew = new System.Windows.Forms.Button();
            this.resultsYouChose = new System.Windows.Forms.Label();
            this.timerResults = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chooseSingleplayer = new System.Windows.Forms.Button();
            this.chooseMultiplayer = new System.Windows.Forms.Button();
            this.selectModeBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.multiplayerBox = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.multiMatchBox = new System.Windows.Forms.GroupBox();
            this.P2Progress = new System.Windows.Forms.Label();
            this.P1Progress = new System.Windows.Forms.Label();
            this.inMatchCountdown = new System.Windows.Forms.Label();
            this.P2Name = new System.Windows.Forms.Label();
            this.P1Name = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.multiplayerBeginMatch = new System.Windows.Forms.Button();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.singleplayerBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.selectModeBox.SuspendLayout();
            this.multiplayerBox.SuspendLayout();
            this.multiMatchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonScissors
            // 
            this.buttonScissors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.buttonScissors.BackgroundImage = global::Master_Forms.Properties.Resources.scissors;
            this.buttonScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonScissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScissors.Location = new System.Drawing.Point(361, 45);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(142, 145);
            this.buttonScissors.TabIndex = 1;
            this.buttonScissors.UseVisualStyleBackColor = false;
            this.buttonScissors.Click += new System.EventHandler(this.buttonScissors_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.buttonPaper.BackgroundImage = global::Master_Forms.Properties.Resources.paper;
            this.buttonPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPaper.Location = new System.Drawing.Point(199, 45);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(149, 145);
            this.buttonPaper.TabIndex = 2;
            this.buttonPaper.UseVisualStyleBackColor = false;
            this.buttonPaper.Click += new System.EventHandler(this.buttonPaper_Click);
            // 
            // singleplayerBox
            // 
            this.singleplayerBox.Controls.Add(this.buttonPaper);
            this.singleplayerBox.Controls.Add(this.buttonScissors);
            this.singleplayerBox.Controls.Add(this.buttonRock);
            this.singleplayerBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.singleplayerBox.Location = new System.Drawing.Point(575, 286);
            this.singleplayerBox.Name = "singleplayerBox";
            this.singleplayerBox.Size = new System.Drawing.Size(542, 223);
            this.singleplayerBox.TabIndex = 3;
            this.singleplayerBox.TabStop = false;
            this.singleplayerBox.Text = "Play";
            // 
            // buttonRock
            // 
            this.buttonRock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.buttonRock.BackgroundImage = global::Master_Forms.Properties.Resources.rock;
            this.buttonRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRock.Location = new System.Drawing.Point(39, 45);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(147, 145);
            this.buttonRock.TabIndex = 0;
            this.buttonRock.UseVisualStyleBackColor = false;
            this.buttonRock.Click += new System.EventHandler(this.buttonRock_Click);
            // 
            // buttonRopapsi
            // 
            this.buttonRopapsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.buttonRopapsi.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRopapsi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRopapsi.Location = new System.Drawing.Point(585, 45);
            this.buttonRopapsi.Name = "buttonRopapsi";
            this.buttonRopapsi.Size = new System.Drawing.Size(500, 195);
            this.buttonRopapsi.TabIndex = 0;
            this.buttonRopapsi.Text = "Ropapsi";
            this.buttonRopapsi.UseVisualStyleBackColor = false;
            this.buttonRopapsi.Click += new System.EventHandler(this.buttonRopapsi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonReset);
            this.groupBox2.Controls.Add(this.scoreTies);
            this.groupBox2.Controls.Add(this.scoreBot);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.scoreYou);
            this.groupBox2.Controls.Add(this.scoreboardThem);
            this.groupBox2.Controls.Add(this.scoreboardYou);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(346, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 303);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scoreboard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "First to Reach 5 Wins";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReset.Location = new System.Drawing.Point(15, 222);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(168, 62);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // scoreTies
            // 
            this.scoreTies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreTies.AutoSize = true;
            this.scoreTies.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreTies.Location = new System.Drawing.Point(167, 124);
            this.scoreTies.Name = "scoreTies";
            this.scoreTies.Size = new System.Drawing.Size(27, 32);
            this.scoreTies.TabIndex = 6;
            this.scoreTies.Text = "0";
            // 
            // scoreBot
            // 
            this.scoreBot.AutoSize = true;
            this.scoreBot.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreBot.Location = new System.Drawing.Point(167, 78);
            this.scoreBot.Name = "scoreBot";
            this.scoreBot.Size = new System.Drawing.Size(27, 32);
            this.scoreBot.TabIndex = 5;
            this.scoreBot.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 37);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ties";
            // 
            // scoreYou
            // 
            this.scoreYou.AutoSize = true;
            this.scoreYou.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreYou.Location = new System.Drawing.Point(167, 31);
            this.scoreYou.Name = "scoreYou";
            this.scoreYou.Size = new System.Drawing.Size(27, 32);
            this.scoreYou.TabIndex = 3;
            this.scoreYou.Text = "0";
            // 
            // scoreboardThem
            // 
            this.scoreboardThem.AutoSize = true;
            this.scoreboardThem.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreboardThem.Location = new System.Drawing.Point(3, 73);
            this.scoreboardThem.Name = "scoreboardThem";
            this.scoreboardThem.Size = new System.Drawing.Size(115, 37);
            this.scoreboardThem.TabIndex = 2;
            this.scoreboardThem.Text = "GregBot";
            // 
            // scoreboardYou
            // 
            this.scoreboardYou.AutoSize = true;
            this.scoreboardYou.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreboardYou.Location = new System.Drawing.Point(6, 24);
            this.scoreboardYou.Name = "scoreboardYou";
            this.scoreboardYou.Size = new System.Drawing.Size(67, 37);
            this.scoreboardYou.TabIndex = 1;
            this.scoreboardYou.Text = "You:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.toMainMenu);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 38);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // toMainMenu
            // 
            this.toMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.toMainMenu.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.toMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.toMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toMainMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toMainMenu.Location = new System.Drawing.Point(80, 6);
            this.toMainMenu.Name = "toMainMenu";
            this.toMainMenu.Size = new System.Drawing.Size(39, 25);
            this.toMainMenu.TabIndex = 8;
            this.toMainMenu.Text = "<-";
            this.toMainMenu.UseVisualStyleBackColor = false;
            this.toMainMenu.Visible = false;
            this.toMainMenu.Click += new System.EventHandler(this.toMainMenu_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(498, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 37);
            this.button4.TabIndex = 7;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ropapsi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.resultsWhoWon);
            this.groupBox3.Controls.Add(this.resultsSo);
            this.groupBox3.Controls.Add(this.resultsAnd);
            this.groupBox3.Controls.Add(this.resultsTheyChose);
            this.groupBox3.Controls.Add(this.buttonNew);
            this.groupBox3.Controls.Add(this.resultsYouChose);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(22, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 303);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // resultsWhoWon
            // 
            this.resultsWhoWon.AutoSize = true;
            this.resultsWhoWon.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultsWhoWon.Location = new System.Drawing.Point(7, 175);
            this.resultsWhoWon.Name = "resultsWhoWon";
            this.resultsWhoWon.Size = new System.Drawing.Size(149, 28);
            this.resultsWhoWon.TabIndex = 8;
            this.resultsWhoWon.Text = "Someone Wins!";
            // 
            // resultsSo
            // 
            this.resultsSo.AutoSize = true;
            this.resultsSo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultsSo.Location = new System.Drawing.Point(119, 136);
            this.resultsSo.Name = "resultsSo";
            this.resultsSo.Size = new System.Drawing.Size(32, 28);
            this.resultsSo.TabIndex = 7;
            this.resultsSo.Text = "so";
            // 
            // resultsAnd
            // 
            this.resultsAnd.AutoSize = true;
            this.resultsAnd.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultsAnd.Location = new System.Drawing.Point(108, 67);
            this.resultsAnd.Name = "resultsAnd";
            this.resultsAnd.Size = new System.Drawing.Size(48, 28);
            this.resultsAnd.TabIndex = 6;
            this.resultsAnd.Text = "And";
            // 
            // resultsTheyChose
            // 
            this.resultsTheyChose.AutoSize = true;
            this.resultsTheyChose.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultsTheyChose.Location = new System.Drawing.Point(7, 102);
            this.resultsTheyChose.Name = "resultsTheyChose";
            this.resultsTheyChose.Size = new System.Drawing.Size(111, 28);
            this.resultsTheyChose.TabIndex = 5;
            this.resultsTheyChose.Text = "They Chose";
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.buttonNew.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.buttonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNew.Location = new System.Drawing.Point(64, 222);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(159, 62);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "New Match";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // resultsYouChose
            // 
            this.resultsYouChose.AutoSize = true;
            this.resultsYouChose.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultsYouChose.Location = new System.Drawing.Point(6, 26);
            this.resultsYouChose.Name = "resultsYouChose";
            this.resultsYouChose.Size = new System.Drawing.Size(102, 28);
            this.resultsYouChose.TabIndex = 3;
            this.resultsYouChose.Text = "You Chose";
            // 
            // timerResults
            // 
            this.timerResults.Interval = 300;
            this.timerResults.Tick += new System.EventHandler(this.timerResults_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(13, 312);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 316);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Player has won!";
            // 
            // chooseSingleplayer
            // 
            this.chooseSingleplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.chooseSingleplayer.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseSingleplayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseSingleplayer.Location = new System.Drawing.Point(6, 72);
            this.chooseSingleplayer.Name = "chooseSingleplayer";
            this.chooseSingleplayer.Size = new System.Drawing.Size(265, 119);
            this.chooseSingleplayer.TabIndex = 10;
            this.chooseSingleplayer.Text = "Singleplayer";
            this.chooseSingleplayer.UseVisualStyleBackColor = false;
            this.chooseSingleplayer.Click += new System.EventHandler(this.chooseSingleplayer_Click);
            // 
            // chooseMultiplayer
            // 
            this.chooseMultiplayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.chooseMultiplayer.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseMultiplayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseMultiplayer.Location = new System.Drawing.Point(271, 72);
            this.chooseMultiplayer.Name = "chooseMultiplayer";
            this.chooseMultiplayer.Size = new System.Drawing.Size(265, 119);
            this.chooseMultiplayer.TabIndex = 11;
            this.chooseMultiplayer.Text = "Multiplayer";
            this.chooseMultiplayer.UseVisualStyleBackColor = false;
            this.chooseMultiplayer.Click += new System.EventHandler(this.chooseMultiplayer_Click);
            // 
            // selectModeBox
            // 
            this.selectModeBox.Controls.Add(this.label4);
            this.selectModeBox.Controls.Add(this.chooseSingleplayer);
            this.selectModeBox.Controls.Add(this.chooseMultiplayer);
            this.selectModeBox.Location = new System.Drawing.Point(1117, 27);
            this.selectModeBox.Name = "selectModeBox";
            this.selectModeBox.Size = new System.Drawing.Size(542, 213);
            this.selectModeBox.TabIndex = 12;
            this.selectModeBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(162, -16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 72);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ropapsi";
            // 
            // multiplayerBox
            // 
            this.multiplayerBox.Controls.Add(this.label14);
            this.multiplayerBox.Controls.Add(this.label15);
            this.multiplayerBox.Controls.Add(this.label16);
            this.multiplayerBox.Controls.Add(this.label11);
            this.multiplayerBox.Controls.Add(this.label12);
            this.multiplayerBox.Controls.Add(this.label13);
            this.multiplayerBox.Controls.Add(this.label10);
            this.multiplayerBox.Controls.Add(this.label8);
            this.multiplayerBox.Controls.Add(this.label7);
            this.multiplayerBox.Controls.Add(this.multiMatchBox);
            this.multiplayerBox.Controls.Add(this.button3);
            this.multiplayerBox.Controls.Add(this.button5);
            this.multiplayerBox.Controls.Add(this.button6);
            this.multiplayerBox.Controls.Add(this.multiplayerBeginMatch);
            this.multiplayerBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiplayerBox.Location = new System.Drawing.Point(1133, 286);
            this.multiplayerBox.Name = "multiplayerBox";
            this.multiplayerBox.Size = new System.Drawing.Size(542, 223);
            this.multiplayerBox.TabIndex = 4;
            this.multiplayerBox.TabStop = false;
            this.multiplayerBox.Text = "Play";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(123, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 32);
            this.label14.TabIndex = 16;
            this.label14.Text = "L";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(104, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 32);
            this.label15.TabIndex = 15;
            this.label15.Text = "/";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label16.Location = new System.Drawing.Point(81, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 32);
            this.label16.TabIndex = 14;
            this.label16.Text = "D";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(123, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 32);
            this.label11.TabIndex = 13;
            this.label11.Text = "K";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(104, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 32);
            this.label12.TabIndex = 12;
            this.label12.Text = "/";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label13.Location = new System.Drawing.Point(81, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 32);
            this.label13.TabIndex = 11;
            this.label13.Text = "S";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(123, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 32);
            this.label10.TabIndex = 10;
            this.label10.Text = "J";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(104, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(81, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "A";
            // 
            // multiMatchBox
            // 
            this.multiMatchBox.Controls.Add(this.P2Progress);
            this.multiMatchBox.Controls.Add(this.P1Progress);
            this.multiMatchBox.Controls.Add(this.inMatchCountdown);
            this.multiMatchBox.Controls.Add(this.P2Name);
            this.multiMatchBox.Controls.Add(this.P1Name);
            this.multiMatchBox.Location = new System.Drawing.Point(181, 22);
            this.multiMatchBox.Name = "multiMatchBox";
            this.multiMatchBox.Size = new System.Drawing.Size(339, 187);
            this.multiMatchBox.TabIndex = 7;
            this.multiMatchBox.TabStop = false;
            // 
            // P2Progress
            // 
            this.P2Progress.AutoSize = true;
            this.P2Progress.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P2Progress.Location = new System.Drawing.Point(254, 93);
            this.P2Progress.Name = "P2Progress";
            this.P2Progress.Size = new System.Drawing.Size(46, 54);
            this.P2Progress.TabIndex = 10;
            this.P2Progress.Text = "B";
            // 
            // P1Progress
            // 
            this.P1Progress.AutoSize = true;
            this.P1Progress.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P1Progress.Location = new System.Drawing.Point(254, 29);
            this.P1Progress.Name = "P1Progress";
            this.P1Progress.Size = new System.Drawing.Size(49, 54);
            this.P1Progress.TabIndex = 9;
            this.P1Progress.Text = "A";
            // 
            // inMatchCountdown
            // 
            this.inMatchCountdown.AutoSize = true;
            this.inMatchCountdown.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inMatchCountdown.Location = new System.Drawing.Point(148, -4);
            this.inMatchCountdown.Name = "inMatchCountdown";
            this.inMatchCountdown.Size = new System.Drawing.Size(0, 37);
            this.inMatchCountdown.TabIndex = 8;
            // 
            // P2Name
            // 
            this.P2Name.AutoSize = true;
            this.P2Name.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P2Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.P2Name.Location = new System.Drawing.Point(15, 98);
            this.P2Name.Name = "P2Name";
            this.P2Name.Size = new System.Drawing.Size(137, 46);
            this.P2Name.TabIndex = 7;
            this.P2Name.Text = "Player 2";
            // 
            // P1Name
            // 
            this.P1Name.AutoSize = true;
            this.P1Name.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P1Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.P1Name.Location = new System.Drawing.Point(15, 36);
            this.P1Name.Name = "P1Name";
            this.P1Name.Size = new System.Drawing.Size(137, 46);
            this.P1Name.TabIndex = 6;
            this.P1Name.Text = "Player 1";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button3.BackgroundImage = global::Master_Forms.Properties.Resources.paper;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(18, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 60);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button5.BackgroundImage = global::Master_Forms.Properties.Resources.scissors;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(18, 152);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 60);
            this.button5.TabIndex = 1;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button6.BackgroundImage = global::Master_Forms.Properties.Resources.rock;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(18, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(58, 60);
            this.button6.TabIndex = 0;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // multiplayerBeginMatch
            // 
            this.multiplayerBeginMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.multiplayerBeginMatch.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplayerBeginMatch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiplayerBeginMatch.Location = new System.Drawing.Point(181, 21);
            this.multiplayerBeginMatch.Name = "multiplayerBeginMatch";
            this.multiplayerBeginMatch.Size = new System.Drawing.Size(339, 188);
            this.multiplayerBeginMatch.TabIndex = 13;
            this.multiplayerBeginMatch.Text = "Start Match";
            this.multiplayerBeginMatch.UseVisualStyleBackColor = false;
            this.multiplayerBeginMatch.Click += new System.EventHandler(this.multiplayerBeginMatch_Click);
            // 
            // timerPlay
            // 
            this.timerPlay.Interval = 1000;
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // RPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1776, 653);
            this.Controls.Add(this.multiplayerBox);
            this.Controls.Add(this.selectModeBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.singleplayerBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonRopapsi);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "RPS";
            this.Text = "RPS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RPS_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RPS_KeyDown);
            this.singleplayerBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.selectModeBox.ResumeLayout(false);
            this.selectModeBox.PerformLayout();
            this.multiplayerBox.ResumeLayout(false);
            this.multiplayerBox.PerformLayout();
            this.multiMatchBox.ResumeLayout(false);
            this.multiMatchBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonScissors;
        private Button buttonPaper;
        private GroupBox singleplayerBox;
        private GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Button button4;
        private Label label1;
        private Button buttonRock;
        private Button buttonRopapsi;
        private Label label2;
        private GroupBox groupBox3;
        private Label scoreboardYou;
        private Label scoreboardThem;
        private Label scoreTies;
        private Label scoreBot;
        private Label label5;
        private Label scoreYou;
        private Button buttonReset;
        private Label resultsYouChose;
        private Button buttonNew;
        private System.Windows.Forms.Timer timerResults;
        private Label resultsAnd;
        private Label resultsTheyChose;
        private Label resultsWhoWon;
        private Label resultsSo;
        private TextBox textBox1;
        private Label label3;
        private Button chooseSingleplayer;
        private Button chooseMultiplayer;
        private GroupBox selectModeBox;
        private Label label4;
        private GroupBox multiplayerBox;
        private Button button3;
        private Button button5;
        private Button button6;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label10;
        private Label label8;
        private Label label7;
        private GroupBox multiMatchBox;
        private Label P2Progress;
        private Label P1Progress;
        private Label inMatchCountdown;
        private Label P2Name;
        private Label P1Name;
        private Button toMainMenu;
        private System.Windows.Forms.Timer timerPlay;
        private Button multiplayerBeginMatch;
    }
}