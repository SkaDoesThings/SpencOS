using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace Master_Forms.Applications.Games
{
    public partial class RPS : Form
    {
        public RPS()
        {
            InitializeComponent();
        }

        //=-=-=-=-=-=-=-=-= ( Window Controls ) =-=-=-=-=-=-=-=-=\\

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void toMainMenu_Click(object sender, EventArgs e)
        {
            this.Height = 310;
            toMainMenu.Visible = false;

            buttonRopapsi.Visible = true;
            selectModeBox.Visible = false;
            singleplayerBox.Visible = false;
            multiplayerBox.Visible = false;

            ResetThings();
            ResetScore();
        }

        //=-=-=-=-=-=-=-=-= ( Initilization ) =-=-=-=-=-=-=-=-=\\

        private void RPS_Load(object sender, EventArgs e)
        {
            this.Height = 310;
            this.Width = 560;
            buttonRopapsi.Location = new Point(25, 70);


            //Make sure the result field is clear
            ResetThings();
            buttonNew.Visible = false;
            textBox1.Visible = false;

            multiMatchBox.Visible = false;
        }

        string yourChoiceString = "";
        string theirChoiceString = "";

        int scoreYouInt = 0;
        int scoreThemInt = 0;
        int scoreTiesInt = 0;

        int yourChoiceInt;
        int theirChoiceInt = 0;

        //=-=-=-=-=-=-=-=-= ( Reset Progress ) =-=-=-=-=-=-=-=-=\\
        private void ResetThings()
        {
            resultsYouChose.Text = "";
            resultsAnd.Text = "";
            resultsTheyChose.Text = "";
            resultsSo.Text = "";
            resultsWhoWon.Visible = false;
            buttonNew.Visible = false;

            buttonRock.Enabled = true;
            buttonPaper.Enabled = true;
            buttonScissors.Enabled = true;

            buttonReset.Enabled = false;
        }
        private void ResetScore()
        {
            scoreYouInt = 0;
            scoreThemInt = 0;
            scoreTiesInt = 0;
            scoreYou.Text = "0";
            scoreBot.Text = "0";
            scoreTies.Text = "0";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.Height = 310;
            ResetThings();
            ResetScore();
        }

        //=-=-=-=-=-=-=-=-= ( Title Screen ) =-=-=-=-=-=-=-=-=\\
        private void buttonRopapsi_Click(object sender, EventArgs e)
        {
            this.Height = 310;
            toMainMenu.Visible = true;
            buttonRopapsi.Visible = false;
            selectModeBox.Visible = true;
            selectModeBox.Location = new Point(9, 60);

            ResetThings();
            ResetScore();
        }

        private void chooseSingleplayer_Click(object sender, EventArgs e)
        {
            singleplayerBox.Location = new Point(9, 60);
            selectModeBox.Visible = false;
            singleplayerBox.Visible = true;

            textBox1.Visible = false;
            groupBox3.Visible = true;

            //Insert SpencOS account name into user
            TinyAccountInfo tiny = new TinyAccountInfo();
            tiny.Show();

            scoreboardYou.Text = tiny.username;
            scoreboardThem.Text = "GregBot";
        }

        private void chooseMultiplayer_Click(object sender, EventArgs e)
        {
            multiplayerBox.Location = new Point(9, 60);
            selectModeBox.Visible = false;
            multiplayerBox.Visible = true;


            scoreboardYou.Text = "Player 1";
            scoreboardThem.Text = "Player 2";
        }

        //=-=-=-=-=-=-=-=-= ( Singleplayer ) =-=-=-=-=-=-=-=-=\\

        public void UserSelection()
        {
            buttonRock.Enabled = false;
            buttonPaper.Enabled = false;
            buttonScissors.Enabled = false;

            Random rng = new Random();
            theirChoiceInt = rng.Next(1, 4);

            ContrastAndConquer();
        }

        private void buttonRock_Click(object sender, EventArgs e)
        {
            yourChoiceInt = 1;
            UserSelection();
        }
        private void buttonPaper_Click(object sender, EventArgs e)
        {
            yourChoiceInt = 2;
            UserSelection();
        }
        private void buttonScissors_Click(object sender, EventArgs e)
        {
            yourChoiceInt = 3;
            UserSelection();
        }

        //=-=-=-=-=-=-=-=-= ( Multiplayer ) =-=-=-=-=-=-=-=-=\\

        bool matchOngoing;
        bool P1HasChoosed;
        bool P2HasChoosed;

        private void multiplayerBeginMatch_Click(object sender, EventArgs e)
        {
            this.Height = 310;
            P1HasChoosed = false;
            P2HasChoosed = false;
            P1Progress.Text = "❌";
            P2Progress.Text = "❌";
            inMatchCountdown.Text = "Ro";
            matchOngoing = true;

            multiplayerBeginMatch.Visible = false;
            multiMatchBox.Visible = true;

            timerPlay.Enabled = true;
            counterScroll = 0;
            timerPlay.Start();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            this.Height = 310;
            ResetThings();
        }

        private void RPS_KeyDown(object sender, KeyEventArgs e)
        {
            if (matchOngoing == true)
            {
                if (P1HasChoosed == false)
                {

                    if (e.KeyCode == Keys.A)
                    {
                        yourChoiceInt = 1;
                        P1Done();
                    }
                    else if (e.KeyCode == Keys.S)
                    {
                        yourChoiceInt = 2;
                        P1Done();
                    }
                    else if (e.KeyCode == Keys.D)
                    {
                        yourChoiceInt = 3;
                        P1Done();
                    }
                }

                if (P2HasChoosed == false)
                {
                    if (e.KeyCode == Keys.J)
                    {
                        theirChoiceInt = 1;
                        P2Done();
                    }
                    else if (e.KeyCode == Keys.K)
                    {
                        theirChoiceInt = 2;
                        P2Done();
                    }
                    else if (e.KeyCode == Keys.L)
                    {
                        theirChoiceInt = 3;
                        P2Done();
                    }
                }
            }
        }
        private void P1Done()
        {
            P1Progress.Text = "✔";
            P1HasChoosed = true;
        }
        private void P2Done()
        {
            P2Progress.Text = "✔";
            P2HasChoosed = false;
        }

        //=-=-=-=-=-=-=-=-= ( Select and Compare ) =-=-=-=-=-=-=-=-=\\

        private void ContrastAndConquer()
        {
            this.Height = 650;

            // P1 Choice
            if (yourChoiceInt == 1)
            {
                yourChoiceString = "Rock";
            }
            else if (yourChoiceInt == 2)
            {
                yourChoiceString = "Paper";
            }
            else if (yourChoiceInt == 3)
            {
                yourChoiceString = "Scissors";
            }

            // P2 or Bot Choice
            switch (theirChoiceInt)
            {
                case 1:
                    theirChoiceString = "Rock";
                    break;
                case 2:
                    theirChoiceString = "Paper";
                    break;
                case 3:
                    theirChoiceString = "Scissors";
                    break;
                case 4:
                    break;
            }

            //'Twas tie
            if (yourChoiceInt == theirChoiceInt)
            {
                resultsWhoWon.Text = "This match was a draw";
                scoreTiesInt++;
            }
            //You win
            else if (yourChoiceString == "Rock" && theirChoiceString == "Scissors")
            {
                resultsWhoWon.Text = scoreboardYou.Text + " won!";
                scoreYouInt++;
            }
            else if (yourChoiceString == "Paper" && theirChoiceString == "Rock")
            {
                resultsWhoWon.Text = scoreboardYou.Text + " won!";
                scoreYouInt++;
            }
            else if (yourChoiceString == "Scissors" && theirChoiceString == "Paper")
            {
                resultsWhoWon.Text = scoreboardYou.Text + " won!";
                scoreYouInt++;
            }
            //They win
            else if (yourChoiceString == "Rock" && theirChoiceString == "Paper")
            {
                resultsWhoWon.Text = scoreboardThem.Text + " won!";
                scoreThemInt++;
            }
            else if (yourChoiceString == "Paper" && theirChoiceString == "Scissors")
            {
                resultsWhoWon.Text = scoreboardThem.Text + " won!";
                scoreThemInt++;
            }
            else if (yourChoiceString == "Scissors" && theirChoiceString == "Rock")
            {
                resultsWhoWon.Text = scoreboardThem.Text + " won!";
                scoreThemInt++;
            }


            timerResults.Enabled = true;
            resultsScroll = 0;
            timerResults.Start();
        }

        //=-=-=-=-=-=-= ( Winner Winner Chicken Dinner ) =-=-=-=-=-=-=\\

        private bool someoneWon = false;
        public void SomeoneWon()
        {
            if (scoreYouInt == 5)
            {
                textBox1.Text = scoreboardYou.Text + " has won the battle! But the war with " + scoreboardThem.Text + " is not over.";
                SomeoneWonCode();
            }
            if (scoreThemInt == 5)
            {
                textBox1.Text = scoreboardThem.Text + " has won the battle! Sucks to be " + scoreboardYou.Text;
                SomeoneWonCode();
            }
            if (scoreTiesInt == 10)
            {
                textBox1.Text = "This game was a draw, better luck next time.";
                SomeoneWonCode();
            }
        }

        public void SomeoneWonCode()
        {
            ResetThings();

            //buttonRopapsi.Visible = true;
            groupBox3.Visible = false;
            textBox1.Visible = true;

            textBox1.BackColor = Color.FromArgb(50, 50, 50);
        }

        //=-=-=-=-=-=-=-=-= ( Timer Controls ) =-=-=-=-=-=-=-=-=\\

        //Multiplayer Timer Countdown
        int counterScroll = 0;
        private void timerPlay_Tick(object sender, EventArgs e)
        {
            if (P1Progress.Text != "✔" || P2Progress.Text != "✔")
            {
                switch (counterScroll)
                {
                    case 0:
                        inMatchCountdown.Text = "Pap";
                        break;
                    case 1:
                        inMatchCountdown.Text = "Si";
                        break;
                    case 2:
                        inMatchCountdown.Text = "Time's Up";
                        NoMoreCounter();
                        break;
                    case 3:
                        resultsYouChose.Text = scoreboardYou.Text + " Chose:";
                        resultsTheyChose.Text = scoreboardThem.Text + " Chose:";
                        break;
                    case 4:
                        resultsYouChose.Text = "You Chose: " + yourChoiceString;
                        resultsTheyChose.Text = "They Chose: " + theirChoiceString;
                        break;
                }
                counterScroll++;
            }
            else
            {
                inMatchCountdown.Text = "GG";
                NoMoreCounter();
            }
        }

        private void NoMoreCounter()
        {
            this.Height = 650;
            if (P1Progress.Text != "✔")
            {
                yourChoiceString = "Nothing";
            }
            else if (P2Progress.Text != "✔")
            {
                theirChoiceString = "Nothing";
            }
            timerPlay.Stop();
            timerPlay.Enabled = false;

            ContrastAndConquer();
        }

        //Dramatic Results Panel
        int resultsScroll = 0;
        private void timerResults_Tick(object sender, EventArgs e)
        {
            if (matchOngoing == false)
            {
                switch (resultsScroll)
                {
                    case 0:
                        resultsYouChose.Text = "You Chose:";
                        break;
                    case 1:
                        resultsYouChose.Text = "You Chose: " + yourChoiceString;
                        break;
                    case 2:
                        resultsAnd.Text = "And";
                        break;
                    case 3:
                        resultsTheyChose.Text = "They Chose:";
                        break;
                    case 4:
                        resultsTheyChose.Text = "They Chose: " + theirChoiceString;
                        break;
                }
            }
            if (matchOngoing == true)
            {
                switch (resultsScroll)
                {
                    case 0:
                        resultsYouChose.Text = scoreboardYou.Text;
                        resultsAnd.Text = "And";
                        resultsTheyChose.Text = scoreboardThem.Text;
                        break;
                    case 1:
                        resultsYouChose.Text = scoreboardYou.Text + " Chose:";
                        resultsTheyChose.Text = scoreboardThem.Text + " Chose:";
                        break;
                    case 2:
                        resultsYouChose.Text = scoreboardYou.Text + " Chose: " + yourChoiceString;
                        resultsTheyChose.Text = scoreboardThem.Text + " Chose: " + theirChoiceString;
                        timerResults.Interval = 100;
                        break;
                }
            }

            switch (resultsScroll)
            {
                case 5:
                    resultsSo.Text = "So";
                    break;
                case 6:
                    timerResults.Interval = 300;
                    resultsWhoWon.Visible = true;
                    break;
                case 7:
                    groupBox2.BackColor = Color.FromArgb(50, 50, 50);
                    scoreYou.Text = Convert.ToString(scoreYouInt);
                    scoreBot.Text = Convert.ToString(scoreThemInt);
                    scoreTies.Text = Convert.ToString(scoreTiesInt);
                    break;
                case 8:
                    groupBox2.BackColor = Color.FromArgb(39, 39, 39);
                    break;

                case 9:
                    if (someoneWon == false)
                    {
                        ResetThings();
                    }
                    else if (someoneWon == true)
                    {
                        textBox1.BackColor = Color.FromArgb(50, 50, 50);
                    }

                    if (matchOngoing == true)
                    {
                        multiplayerBeginMatch.Visible = true;
                        multiMatchBox.Visible = false;
                        matchOngoing = false;
                    }

                    yourChoiceInt = 0;
                    theirChoiceInt = 0;

                    buttonReset.Enabled = true;
                    timerResults.Stop();
                    timerResults.Enabled = false;
                    break;
            }
            resultsScroll++;
        }
    }
}
