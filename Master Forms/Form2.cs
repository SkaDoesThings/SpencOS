using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Forms
{
    public partial class Form2 : Form
    {
        Form3 frm3 = new Form3();

        public Form2()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        //private void panel1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(Handle, 0x112, 0xf012, 0);
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            PowerOptionFlipFlop();
        }

        private bool FlipFlop = false;
        private void PowerOptionFlipFlop()
        {
            if (FlipFlop == false)
            {
                this.powerOptionPanel.Hide();
                powerOptionUserPanel.Hide();
                FlipFlop = true;
            }
            else if (FlipFlop == true)
            {
                this.powerOptionPanel.Show();
                if (showLoginButton == true)
                {
                    powerOptionUserPanel.Show();
                }
                FlipFlop = false;
            }
        }

        private void powerOptionPanel_Leave(object sender, EventArgs e)
        {

        }

        private void powerPanelOffButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void powerPanelRestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void powerPanelLogoffButton_Click(object sender, EventArgs e)
        {
            if (helloFlipFlop == true)
            {
                helloFlipFlop = false;
                selectUser = true;
                SelectUser();
            }
            else if (helloFlipFlop == false)
            {
                SelectUser();
            }
            PowerOptionFlipFlop();
        }

        private void selectUserPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool selectUser = true;
        private bool showLoginButton = false;

        private bool creatingUserFlipFlop = false;

        private void SelectUser()
        {
            if (selectUser == true)
            {
                this.BackgroundImage = new Bitmap(@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\images\loginwallpaper.jpg");
                selectUserPanel.Show();
                textBox1.Text = "";
                wrongPasswordLabel.Text = "";

                pictureBox1.Hide();
                textBox1.Hide();
                button2.Hide();
                usernameInputBox.Hide();
                helloButton.Show();
                userList.Show();

                showLoginButton = false;

                selectUser = false;
            }
            else if (selectUser == false)
            {
                string currentUser = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Accounts\currentaccount\currentaccount.txt"; //file path needed to read in the text

                selectUserPanel.Hide();
                userList.Hide();
         
                textBox1.Show();
                button2.Show();

                usernameInputBox.Show();
                if (creatingUserFlipFlop == false)
                {
                    usernameInputBox.Text = userList.Text;
                    System.IO.File.WriteAllText(currentUser, $"{usernameInputBox.Text}");
                }
                else if (creatingUserFlipFlop == true)
                {
                    usernameInputBox.Text = createUserName.Text;
                    System.IO.File.WriteAllText(currentUser, $"{createUserName.Text}");
                    creatingUserFlipFlop = false;
                }

                TinyAccountInfo tiny = new TinyAccountInfo();
                tiny.Show();

                pictureBox1.Show();
                try
                {
                    this.BackgroundImage = new Bitmap(tiny.wallpaper);
                    this.pictureBox1.BackgroundImage = new Bitmap(tiny.icon);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                helloButton.Hide();

                showLoginButton = true;

                selectUser = true;
            }
        }

        private bool createFlipFlop = true;
        private void CreateUser()
        {
            if (createFlipFlop == true)
            {
                label3.Text = "Select User";
                createUser.Hide();
                userCreate.Show();
                createFlipFlop = false;
            }
            else if (createFlipFlop == false)
            {
                label3.Text = "Create Account";
                createUser.Show();
                userCreate.Hide();
                createFlipFlop = true;
            }
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            if (FlipFlop == false)
            {
                PowerOptionFlipFlop();
            }

        }



        DirectoryInfo place = new DirectoryInfo($@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Accounts");
        private void Form2_Load(object sender, EventArgs e)
        {
            PowerOptionFlipFlop();
            SelectUser();
            CreateUser();
            powerOptionUserPanel.Hide();
            isLoginScreen = true;

            FileInfo[] Files = place.GetFiles();

            foreach (FileInfo i in Files)
            {
                string nameOnly = Path.GetFileNameWithoutExtension(i.Name);
                userList.Items.Add(nameOnly);
            }
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {

        }

        public bool isLoginScreen;
        private void userLogin_Click(object sender, EventArgs e)
        {
            //this.pictureBox1.BackgroundImage = new Bitmap(@"C:\Users\23AugensteinS\Documents\C#\Master Form\Master Form\images\userdefault.png");
            usernameInputBox.Show();
            SelectUser();
            isLoginScreen = false;
        }

        private void userCreate_Click(object sender, EventArgs e)
        {
            CreateUser();
        }

        private void createUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createUserReturn_Click(object sender, EventArgs e)
        {
            CreateUser();
        }


        private bool helloFlipFlop = false;

        private void helloButton_Click(object sender, EventArgs e)
        {
            Fairground fair = new Fairground();
            fair.Owner = this;
            fair.Show();
            selectUserPanel.Hide();
            userList.Hide();
            helloFlipFlop = true;
            showLoginButton = true;
        }

        private void createUserSubmit_Click(object sender, EventArgs e)
        {
            if (createUserName.Text == "")
            {
                createUserName.Text = "(!) Enter Username";
            }
            if (createUserPass.Text == "")
            {
                createUserPass.Text = "(!) Enter Password";
            }

            string filePath = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Accounts\{createUserName.Text}.txt";
            string currentUser = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Accounts\currentaccount\currentaccount.txt"; //file path needed to read in the text

            string createWallpaperPath = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Settings\{createUserName.Text}Wallpaper.txt";
            string createSettingsPath = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Settings\{createUserName.Text}Settings.txt";
            string createIconPath = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Settings\{createUserName.Text}Icon.txt";


            Account account = new Account();

            account.Username = createUserName.Text;
            account.Password = createUserPass.Text;

            System.IO.File.WriteAllText(filePath, $"{account.Username},{account.Password}");
            System.IO.File.WriteAllText(currentUser, $"{createUserName.Text}");

            System.IO.File.WriteAllText(createWallpaperPath, $"C:\\Users\\23AugensteinS\\Documents\\C#\\Master Form\\Master Form\\images\\wallpaper.png");
            System.IO.File.WriteAllText(createIconPath, $"C:\\Users\\23AugensteinS\\Documents\\Udemy\\C#\\Master Forms\\images\\userdefault.png");
            System.IO.File.WriteAllText(createSettingsPath, $"blank");

            creatingUserFlipFlop = true;

            CreateUser();
            SelectUser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //load text file. Use AssignmentFileIO for reference if needed
            try
            {
                string fileSource = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Accounts\{usernameInputBox.Text}.txt"; //file path needed to read in the text

                //check if the file exists
                if (File.Exists(fileSource) == true)
                {
                    //loads the person info to the necessary text box
                    Account account = new Account(); //declares a new person (has to be out here)

                    List<string> lines = File.ReadAllLines(fileSource).ToList(); //reads in the text and puts it into a list

                    foreach (string line in lines)
                    {
                        string[] entries = line.Split(','); //splits lines in the txt file at the , into different entries

                        //splits the lines and saves each entry into newPerson

                        account.Username = entries[0];
                        account.Password = entries[1];
                    }


                    if (usernameInputBox.Text != account.Username || textBox1.Text != account.Password)
                    {
                        wrongPasswordLabel.ForeColor = Color.Red;
                        wrongPasswordLabel.Text = "Wrong password. Try entering again";
                    }
                    else if (usernameInputBox.Text == account.Username && textBox1.Text == account.Password)
                    {
                        this.Close();
                        frm3.Show();

                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("ENTER THE INFO");
            }
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectUser();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
