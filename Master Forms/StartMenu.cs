using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Security.Principal;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.DataFormats;

namespace Master_Forms
{
    public partial class StartMenu : Form
    {
        bool flipflop = false;


        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );

       

        public StartMenu()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(5, 520);

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 13, 13));


        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            TinyAccountInfo tiny = new TinyAccountInfo();
            tiny.Show();
            accountUsername.Text = tiny.username;
            this.pictureBox1.BackgroundImage = new Bitmap(tiny.icon);

            tiny.Close();
        }


        public void FlipFlop()
        {
            if (flipflop == false)
            {
                this.Show();
                flipflop = true;
            }
            else
            {
                this.Hide();
                flipflop = false;
            }
        }

        public void CloseStartMenu()
        {
            this.Hide();
            flipflop = false;
        }

        public void AppOpenError()
        {
            MessageBox.Show("Unable to Open Program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void startButtonExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void startButtonLogOff_Click(object sender, EventArgs e)
        {
            InternetBrowser web4 = new InternetBrowser();
            Form3 form3 = new Form3();
            Form2 form2 = new Form2();
            Settings settings = new Settings();
            Fairground fair = new Fairground();
            Calculator calc = new Calculator();

            FlipFlop();
            form3.Hide();
            web4.Hide();
            settings.Hide();
            fair.Hide();
            calc.Hide();
            form2.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void startButtonSettings_Click(object sender, EventArgs e)
        {
            FlipFlop();
            Settings settings = new Settings();
            try
            {
                settings.Show();
            }
            catch (Exception)
            {
                AppOpenError();
            }
        }

        private void startButtonCalculator_Click(object sender, EventArgs e)
        {
            FlipFlop();
            Calculator calc = new Calculator();
            try
            {
                calc.Show();
            }
            catch (Exception)
            {
                AppOpenError();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void appList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FlipFlop();
                if (appList.Text == "Spider Web")
                {
                    InternetBrowser web4 = new InternetBrowser();
                    web4.Show();
                }
                else if (appList.Text == "Phonebook")
                {
                    Master_Forms.Phonebook.Phonebook phone = new Master_Forms.Phonebook.Phonebook();
                    phone.Show();
                }
                if (appList.Text == "Fairgrounds")
                {
                    Fairground fair = new Fairground();
                    fair.Show();
                }
                if (appList.Text == "Hello World")
                {
                    HelloWorld hello = new HelloWorld();

                    hello.Show();
                    Process p = Process.Start("C:\\Users\\23AugensteinS\\Documents\\Udemy\\C#\\Hello World\\Hello World\\bin\\Debug\\net6.0-windows\\Hello World.exe");
                    Thread.Sleep(500);
                    SetParent(p.MainWindowHandle, hello.Handle);
                }
                if (appList.Text == "Folder Traveler")
                {
                    FileExplorer files = new FileExplorer();
                    files.Show();
                }

                if (appList.Text == "Diary Diet")
                {
                    Master_Forms.Diary.Diary diet = new Master_Forms.Diary.Diary();
                    diet.Show();
                }

            }
            catch (Exception a)
            {
                MessageBox.Show("Unable to Open Program because:\n" + a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}





























//Micah Says Console.WriteLine("fuck");