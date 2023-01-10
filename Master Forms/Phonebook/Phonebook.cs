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

namespace Master_Forms.Phonebook
{
    public partial class Phonebook : Form
    {
        public Phonebook()
        {
            InitializeComponent();
        }

        //Makes window draggable
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void Phonebook_Load(object sender, EventArgs e)
        {

        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.MdiParent = this;
            register.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.MdiParent = this;
            search.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this;
            about.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void spencOSCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.Show();
        }

        private void windowsCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Phonebook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                toolStripButton1_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                toolStripButton2_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                Calculator calc = new Calculator();
                calc.Show();
            }
            if (e.KeyCode == Keys.F5)
            {
                toolStripButton4_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                toolStripButton5_Click(sender, e);
            }
        }
    }
}
