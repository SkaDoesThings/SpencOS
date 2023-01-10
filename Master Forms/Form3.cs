using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Image = System.Drawing.Image;

namespace Master_Forms
{
    public partial class Form3 : Form
    {
        StartMenu start = new StartMenu();
        Settings settings = new Settings();

        public Form3()
        {
            InitializeComponent();


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            notifcationPanel.Width = 0;
            monthCalendar1.Visible = false;
            selectionPanel.Visible = false;

            //wallpaperPanel.Visible = false;

            ChangeSettings();
            notiflipflop = true;
        }

        private void ChangeSettings()
        {
            TinyAccountInfo tiny = new TinyAccountInfo();
            tiny.Show();

            try
            {
                this.BackgroundImage = new Bitmap(tiny.wallpaper);
            }
            catch (Exception e)
            {
                MessageBox.Show("Destkop: {0}", e.Message);
            }
            try
            {
                accountUsername.Text = tiny.username;
                pictureBox1.BackgroundImage = new Bitmap(tiny.icon);
            }
            catch (Exception exe)
            {
                MessageBox.Show("Start Menu: {0}", exe.Message);
            }
        }

        private void CloseCalender(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.barTimeBox.Text = DateTime.Now.ToString("hh:mm:ss tt");
            this.barDateBox.Text = DateTime.Now.ToString("dd/mm/yyyy");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barStartButton_Click(object sender, EventArgs e)
        {
            StartFlipFlop();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            InternetBrowser web4 = new InternetBrowser();
            listBox1.Items.Add("Spider Web");
            web4.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void barTimeBox_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void barDateBox_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void wallpaperPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displayWallpaper_Click(object sender, EventArgs e)
        {

        }

        bool wflipflop = false;
        //public void WallpaperFlipFlop()
        //{
        //    if (wflipflop == false)
        //    {
        //        wallpaperPanel.Visible = true;
        //        wflipflop = true;
        //    }
        //    else if (wflipflop == true)
        //    {
        //        wallpaperPanel.Visible = false;
        //        wflipflop = false;
        //    }
        //}
        //    private void exitWallpaperButton_Click(object sender, EventArgs e)
        //{
        //    WallpaperFlipFlop();
        //}

        //public void SelectWallpaper()
        //{
        //    OpenFileDialog open = new OpenFileDialog();

        //    if (open.ShowDialog() == DialogResult.OK)
        //    {
        //        // display image in picture box  
        //        try
        //        {
        //            Image myImage = new Bitmap(open.FileName);

        //            this.displayWallpaper.BackgroundImage = myImage;
        //            this.BackgroundImage = myImage;
        //        }
        //        catch (Exception)
        //        {
        //            if (MessageBox.Show("Unable to Use Wallpaper. Try again?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
        //            {
        //                SelectWallpaper();
        //            }
        //            else
        //            {
        //                WallpaperFlipFlop();
        //            }
        //        }
        //    }
        //}

        //private void changeWallpaperDialog_Click(object sender, EventArgs e)
        //{
        //    SelectWallpaper();
        //}

        //    private void openChangeWallpaper_Click(object sender, EventArgs e)
        //{
        //    WallpaperFlipFlop();
        //}

        //private void closeWallpaperMenu_Click(object sender, EventArgs e)
        //{
        //    WallpaperFlipFlop();
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeSettings();
        }

        DirectoryInfo place = new DirectoryInfo($@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Accounts");

        private void desktoptimer_Tick(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //Taskbar
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.Text == "Spider Web")
            {
                foreach (Form form in System.Windows.Forms.Application.OpenForms)
                    if (form is InternetBrowser)
                    {
                        form.Close();
                        break;
                    }
                listBox1.Items.Remove("Spider Web");
            }
            else if (listBox1.Text == "Phonebook")
            {
                foreach (Form form in System.Windows.Forms.Application.OpenForms)
                    if (form is Master_Forms.Phonebook.Phonebook)
                    {
                        form.Close();
                        break;
                    }
                listBox1.Items.Remove("Phonebook");
            }
            else if (listBox1.Text == "Fairgrounds")
            {
                foreach (Form form in System.Windows.Forms.Application.OpenForms)
                    if (form is Fairground)
                    {
                        form.Close();
                        break;
                    }
                listBox1.Items.Remove("Fairgrounds");
            }
            else if (listBox1.Text == "Hello World")
            {
                foreach (Form form in System.Windows.Forms.Application.OpenForms)
                    if (form is HelloWorld)
                    {
                        form.Close();
                        break;
                    }
                listBox1.Items.Remove("Hello World");
            }
            else if (listBox1.Text == "Folders")
            {
                foreach (Form form in System.Windows.Forms.Application.OpenForms)
                    if (form is FileExplorer)
                    {
                        form.Close();
                        break;
                    }
                listBox1.Items.Remove("Folders");
            }
            else if (listBox1.Text == "Diary Diet")
            {
                foreach (Form form in System.Windows.Forms.Application.OpenForms)
                    if (form is Master_Forms.Diary.Diary)
                    {
                        form.Close();
                        break;
                    }
                listBox1.Items.Remove("Diary Diet");
            }
            else if (listBox1.Text == "Settings")
            {
                foreach (Form form in System.Windows.Forms.Application.OpenForms)
                    if (form is Settings)
                    {
                        form.Close();
                        break;
                    }
                listBox1.Items.Remove("Settings");
            }
            else if (listBox1.Text == "Calculator")
            {
                foreach (Form form in System.Windows.Forms.Application.OpenForms)
                    if (form is Calculator)
                    {
                        form.Close();
                        break;
                    }
                listBox1.Items.Remove("Calculator");
            }
        }

        //Desktop Rubberband Selection

        bool allowResize = false;
        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (startFlipFlop == true)
            {
                StartFlipFlop();
            }

            allowResize = true;
            this.Cursor = new Cursor(Cursor.Current.Handle);
            selectionPanel.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (allowResize == true)
            {

                selectionPanel.Visible = true;

                this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Clip = new Rectangle(this.Location, this.Size);

                this.selectionPanel.Height = Cursor.Position.Y - selectionPanel.Location.Y;
                this.selectionPanel.Width = Cursor.Position.X - selectionPanel.Location.X;
            }
        }

        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            selectionPanel.Visible = false;

            allowResize = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        //Start Menu

        bool startFlipFlop = false;
        public void StartFlipFlop()
        {
            if (startFlipFlop == false)
            {
                startMenu.Visible = true;
                startFlipFlop = true;
            }
            else
            {
                startMenu.Visible = false;
                startFlipFlop = false;
            }
        }

        public void AppOpenError()
        {
            MessageBox.Show("Unable to Open Program", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void startButtonShutdown_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void startButtonRestart_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Restart();
        }

        private void startButtonLogOff_Click(object sender, EventArgs e)
        {
            foreach (Form form in System.Windows.Forms.Application.OpenForms)
            {
                form.Hide();
            }
            Form2 login = new Form2();
            login.Show();
        }

        private void appList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                StartFlipFlop();
                if (appList.Text == "Spider Web")
                {
                    InternetBrowser web4 = new InternetBrowser();
                    listBox1.Items.Add("Spider Web");
                    web4.Show();
                }
                else if (appList.Text == "Phonebook")
                {
                    Master_Forms.Phonebook.Phonebook phone = new Master_Forms.Phonebook.Phonebook();
                    listBox1.Items.Add("Phonebook");
                    phone.Show();
                }
                if (appList.Text == "Fairgrounds")
                {
                    Fairground fair = new Fairground();
                    listBox1.Items.Add("Fairgrounds");
                    fair.Show();
                }
                if (appList.Text == "Hello World")
                {
                    HelloWorld hello = new HelloWorld();
                    listBox1.Items.Add("Hello World");
                    hello.Show();
                    Process p = Process.Start("C:\\Users\\23AugensteinS\\Documents\\Udemy\\C#\\Hello World\\Hello World\\bin\\Debug\\net6.0-windows\\Hello World.exe");
                    Thread.Sleep(500);
                    //SetParent(p.MainWindowHandle, hello.Handle);
                }
                if (appList.Text == "Folder Traveler")
                {
                    FileExplorer files = new FileExplorer();
                    listBox1.Items.Add("Folders");
                    files.Show();
                }

                if (appList.Text == "Diary Diet")
                {
                    Master_Forms.Diary.Diary diet = new Master_Forms.Diary.Diary();
                    listBox1.Items.Add("Diary Diet");
                    diet.Show();
                }
                if (appList.Text == "Ropapsi")
                {
                    Master_Forms.Applications.Games.RPS rps = new Master_Forms.Applications.Games.RPS();
                    listBox1.Items.Add("Ropapsi");
                    rps.Show();
                }
                if (appList.Text == "Dwayne ChatAI")
                {
                    Master_Forms.Applications.Games.Dwayne chatai = new Master_Forms.Applications.Games.Dwayne();
                    listBox1.Items.Add("Dwayne");
                    chatai.Show();
                }

            }
            catch (Exception a)
            {
                MessageBox.Show("Unable to Open Program because:\n" + a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startButtonSettings_Click(object sender, EventArgs e)
        {
            StartFlipFlop();
            Settings settings = new Settings();
            try
            {
                listBox1.Items.Add("Settings");
                settings.Show();
            }
            catch (Exception)
            {
                AppOpenError();
            }
        }

        private void startButtonCalculator_Click(object sender, EventArgs e)
        {
            StartFlipFlop();
            Calculator calc = new Calculator();
            try
            {
                listBox1.Items.Add("Calculator");
                calc.Show();
            }
            catch (Exception)
            {
                AppOpenError();
            }
        }
        private void barNotificationTray_Click(object sender, EventArgs e)
        {
            NotiFlipFlop();
        }

        private bool notiflipflop = false;
        private void NotiFlipFlop()
        {
            if (notiflipflop == false)
            {
                while (notifcationPanel.Width < 350)
                {
                    notifcationPanel.Width = notifcationPanel.Width + 1;
                }
                notiflipflop = true;
            }
            else if (notiflipflop == true)
            {
                while (notifcationPanel.Width > 0)
                {
                    notifcationPanel.Width = notifcationPanel.Width - 1;
                }
                notiflipflop = false;
            }
        }

        private bool hideShow = true;
        private void hideAllWindows_Click(object sender, EventArgs e)
        {
            if (hideShow == true)
            {
                foreach (Form form in System.Windows.Forms.Application.OpenForms)
                {
                    if (form is Form3)
                    {

                    }
                    else
                    {
                        form.Hide();
                    }
                }
                hideShow = false;
            }
            else if (hideShow == false)
            {
                foreach (Form form in System.Windows.Forms.Application.OpenForms)
                {
                    if (form is Form1)
                    {
                        form.Hide();
                    }
                    else
                    {
                        form.Show();
                    }
                }
                hideShow = true;
            }
        }
    }
}
