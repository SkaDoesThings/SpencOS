using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Forms.Diary
{
    public partial class Diary : Form
    {
        public Diary()
        {
            InitializeComponent();
        }

        private void menuButtonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void menuButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timerLabel_Click(object sender, EventArgs e)
        {
        }

        private void Diary_Load(object sender, EventArgs e)
        {
            GetTime();
            GetDate();

            this.versionLabel.Text = Application.ProductVersion;

            int selectedIndex = Master_Forms.Properties.Settings.Default.selected_image_index;

            LoadBackground(selectedIndex);

            BackgroundComboLoader();
        }

        public void LoadBackground(int selection)
        {
            try
            {

                string fileName = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Applications\Diary\wallpapers\{selection}.png";
                this.BackgroundImage = Image.FromFile(fileName);
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetTime();
        }

        public void GetTime()
        {
            this.timerLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void GetDate()
        {
            System.Globalization.GregorianCalendar g;
            g = new System.Globalization.GregorianCalendar();

            calenderYear.Text = g.GetYear(DateTime.Now).ToString();
            calenderDay.Text = g.GetDayOfWeek(DateTime.Now).ToString();
            calenderMonth.Text = String.Format("{0:MMMM}", DateTime.Now);
            calenderDate.Text = g.GetDayOfMonth(DateTime.Now).ToString();
        }

        public void BackgroundComboLoader()
        {
            for (int i = 0; i < 13; i++)
            {
                this.comboBox1.Items.Add("Image " + i.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBackground(Convert.ToInt32(comboBox1.SelectedIndex));

            //Save image index
            Master_Forms.Properties.Settings.Default.selected_image_index = this.comboBox1.SelectedIndex;
            Master_Forms.Properties.Settings.Default.Save();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master_Forms.Diary.About about = new Master_Forms.Diary.About();
            about.MdiParent = this;
            about.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master_Forms.Diary.Users users = new Master_Forms.Diary.Users();
            users.MdiParent = this;
            users.Show();
        }
    }
}
