using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Master_Forms
{
    public partial class Settings : Form
    {

        public Settings()
        {
            InitializeComponent();
        }

        private void optionChangeWallpaper_Click(object sender, EventArgs e)
        {

        }

        private void buttonPersonalize_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckForm(Color.Black);
        }
        private void CheckForm(Color col)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.BackColor = col;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void changeWallpaperDialog_Click(object sender, EventArgs e)
        {
            string wallpaperSource = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Settings\{tiny.username}Wallpaper.txt";

            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                try
                {
                    Image myImage = new Bitmap(open.FileName);

                    System.IO.File.WriteAllText(wallpaperSource, $"{open.FileName}");

                    this.displayWallpaper.BackgroundImage = myImage;

                    foreach (Form form in System.Windows.Forms.Application.OpenForms)
                        if (form is Form3)
                        {
                            form.Close();
                            break;
                        }
                    Form3 form3 = new Form3();

                    form3.Hide();
                    form3.Show();
                }
                catch (Exception)
                {
                    if (MessageBox.Show("Unable to Use Wallpaper. Try again?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                       
                    }
                    else
                    {
                        
                    }
                }
            }
        }

        private void changeIconDialog_Click(object sender, EventArgs e)
        {
            string iconSource = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Settings\{tiny.username}Icon.txt";

            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                try
                {
                    Image myImage = new Bitmap(open.FileName);

                    System.IO.File.WriteAllText(iconSource, $"{open.FileName}");

                    this.displayIcon.BackgroundImage = myImage;

                    foreach (Form form in System.Windows.Forms.Application.OpenForms)
                        if (form is Form3)
                        {
                            form.Close();
                            break;
                        }
                    Form3 form3 = new Form3();

                    form3.Hide();
                    form3.Show();
                }
                catch (Exception)
                {
                    if (MessageBox.Show("Unable to Use Wallpaper. Try again?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                    {

                    }
                    else
                    {

                    }
                }
            }
        }

        TinyAccountInfo tiny = new TinyAccountInfo();
        private void Settings_Load(object sender, EventArgs e)
        {
            tiny.Show();

            this.displayWallpaper.BackgroundImage = new Bitmap(tiny.wallpaper);
            this.displayIcon.BackgroundImage = new Bitmap(tiny.icon);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}