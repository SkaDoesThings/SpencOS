using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Master_Forms
{
    public partial class Calculator : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void closeCalculator_MouseHover(object sender, EventArgs e)
        {


        }


        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public Calculator()
        {
            InitializeComponent();
        }


        private void Calculator_Load(object sender, EventArgs e)
        {
            previousNumberLabel.Text = "";
            operatorLabel.Text = "";
        }

        private void closeCalculator_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Number Entries
        private void actionClear_Click(object sender, EventArgs e)
        {
            this.mainDisplayValue.ResetText();
            this.previousNumberLabel.ResetText();
            this.operatorLabel.ResetText();
        }


        private void NumberSelection(String NumberSymbol)
        {
                this.mainDisplayValue.Text = this.mainDisplayValue.Text + NumberSymbol;
        }

        private void OperatorTransition(String OperatorSymbol)
        {
            //Allows you to repeat adding numbers
            if (this.mainDisplayValue.Text != "" && this.previousNumberLabel.Text != "" && OperatorSymbol != "")
            {
                MessageBox.Show("hello");
                FinalAnswer();
            }
            //If first number exists, move it to previous number line
            else if (this.mainDisplayValue.Text != "")
            {
                this.previousNumberLabel.Text = this.mainDisplayValue.Text;
            }
            //If you have your previous number and an operator, it lets you change the operator
            else if (this.operatorLabel.Text != "" && OperatorSymbol != "")
            {

            }
            //Automatically add 0 to previous number line if no initial number is given
            else
            {
                this.previousNumberLabel.Text = "0";
            }
            //Imagine this code is apart of each if else statement
            this.operatorLabel.Text = OperatorSymbol;
            this.mainDisplayValue.ResetText();
        }

        private void FinalAnswer()
        {
            double first;
            double second;
            double third;
            double.TryParse(this.previousNumberLabel.Text, out first);
            double.TryParse(this.mainDisplayValue.Text, out second);
            this.previousNumberLabel.Text = "";

            string CaseOperator = this.operatorLabel.Text;
            switch (CaseOperator)
            {
                case "+":
                    {
                        this.operatorLabel.Text = "";
                        third = first + second;
                        mainDisplayValue.Text = Convert.ToString(third);
                        break;
                    }
                case "-":
                    {
                        this.operatorLabel.Text = "";
                        third = first - second;
                        mainDisplayValue.Text = Convert.ToString(third);
                        break;
                    }
                case "*":
                    {
                        this.operatorLabel.Text = "";
                        third = first * second;
                        mainDisplayValue.Text = Convert.ToString(third);
                        break;
                    }
                case "÷":
                    {
                        this.operatorLabel.Text = "";
                        third = first / second;
                        mainDisplayValue.Text = Convert.ToString(third);
                        break;
                    }
            }
        }


        //All the numbers and read statements
        private void number0_Click(object sender, EventArgs e)
        {
            NumberSelection("0");
        }

        private void number1_Click(object sender, EventArgs e)
        {
            NumberSelection("1");
        }

        private void number2_Click(object sender, EventArgs e)
        {
            NumberSelection("2");
        }

        private void number3_Click(object sender, EventArgs e)
        {
            NumberSelection("3");
        }

        private void number4_Click(object sender, EventArgs e)
        {
            NumberSelection("4");
        }

        private void number5_Click(object sender, EventArgs e)
        {
            NumberSelection("5");
        }

        private void number6_Click(object sender, EventArgs e)
        {
            NumberSelection("6");
        }

        private void number7_Click(object sender, EventArgs e)
        {
            NumberSelection("7");
        }

        private void number8_Click(object sender, EventArgs e)
        {
            NumberSelection("8");
        }

        private void number9_Click(object sender, EventArgs e)
        {
            NumberSelection("9");
        }

        private void numberDot_Click(object sender, EventArgs e)
        {
            NumberSelection(".");
        }

        private void actionPlus_Click(object sender, EventArgs e)
        {
            OperatorTransition("+");
        }
        private void actionMinus_Click(object sender, EventArgs e)
        {
            OperatorTransition("-");
        }
        private void actionMultiply_Click(object sender, EventArgs e)
        {
            OperatorTransition("*");
        }
        private void actionDivide_Click(object sender, EventArgs e)
        {
            OperatorTransition("÷");
        }

        private void actionEqual_Click(object sender, EventArgs e)
        {
            FinalAnswer();
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            //Numbers
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                NumberSelection("0");
            }
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                NumberSelection("1");
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                NumberSelection("2");
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                NumberSelection("3");
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                NumberSelection("4");
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                NumberSelection("5");
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                NumberSelection("6");
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                NumberSelection("7");
            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                NumberSelection("8");
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                NumberSelection("9");
            }
            else if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Delete)
            {
                NumberSelection(".");
            }

            //Operators
            else if (e.KeyCode == Keys.Oemplus)
            {
                OperatorTransition("+");
            }
            else if (e.KeyCode == Keys.OemMinus)
            {
                OperatorTransition("-");
            }
            else if (e.KeyCode == Keys.X)
            {
                OperatorTransition("*");
            }
            else if (e.KeyCode == Keys.OemBackslash)
            {
                OperatorTransition("-");
            }
            else if (e.KeyCode == Keys.Enter)
            {
                FinalAnswer();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainDisplayValue_Click(object sender, EventArgs e)
        {

        }
    }
}
