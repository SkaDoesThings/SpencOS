using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win32Interop.Structs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Master_Forms.Diary
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (setUsername.Text != "" && setPassword.Text != "" && setPassword2.Text != "")
            {
                if (setPassword.Text == setPassword2.Text)
                {
                    Master_Forms.Properties.Settings.Default.diary_username = setUsername.Text;
                    Master_Forms.Properties.Settings.Default.diary_password = setPassword.Text;
                    Master_Forms.Properties.Settings.Default.Save();             
                }
                else
                {
                    label4.Text = "You must enter the same password";
                }
            }
            else
            {
                label4.Text = "Please enter all information properly";
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            string directoryName = "C:\\Users\\23AugensteinS\\Documents\\Udemy\\C#\\Master Forms\\Applications\\Diary\\pfps\\1.jpg";

            label4.Text = "";
            setUsername.Text = Master_Forms.Properties.Settings.Default.diary_username;
            setPassword.Text = Master_Forms.Properties.Settings.Default.diary_password;
            accountPicture.BackgroundImage = new Bitmap(Master_Forms.Properties.Settings.Default.diary_icon);
        }

        bool changeImage = false;
        private void button3_Click(object sender, EventArgs e)
        {
            changeImage = true;
            openFileDialog1.ShowDialog();
            Master_Forms.Properties.Settings.Default.diary_icon = openFileDialog1.FileName;
            Master_Forms.Properties.Settings.Default.Save();
            accountPicture.BackgroundImage = new Bitmap(Master_Forms.Properties.Settings.Default.diary_icon);
        }
    }
}

