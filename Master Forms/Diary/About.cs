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

namespace Master_Forms.Diary
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        //Makes window draggable
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);


        private void About_Load(object sender, EventArgs e)
        {
            label2.Text = "Version: " + Application.ProductVersion;

            //Load from settings
            label5.Text = Master_Forms.Properties.Settings.Default.programmer_name;
            label1.Text = Master_Forms.Properties.Settings.Default.production_year;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
