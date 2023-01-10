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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Master_Forms.Phonebook
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerNew_Click(object sender, EventArgs e)
        {
            registerNew.Enabled = false;
            registerInfobox.Enabled = true;
            this.ClientSize = sizingBox.Size;

            //Clear Textboses
            inputId.ResetText();
            inputFirst.ResetText();
            inputLast.ResetText();
            inputCell.ResetText();
            inputTele.ResetText();
            inputEmail.ResetText();
            inputAddress.ResetText();
            inputComment.ResetText();

            registerSave.Enabled = true;
        }

        private void registerSave_Click(object sender, EventArgs e)
        {
            if (inputId.Text != "")
            {
                registerSave.Enabled = false;
                registerInfobox.Enabled = false;
                this.ClientSize = sizingBox2.Size;

                string data = "," + inputId.Text + "\n," + inputFirst.Text + "\n," + inputLast.Text + "\n," + inputCell.Text + "\n," + inputTele.Text + "\n," + inputEmail.Text + "\n," + inputAddress.Text + "\n," + inputComment.Text;

                string fileName = "C:\\Users\\23AugensteinS\\Documents\\Udemy\\C#\\Master Forms\\Applications\\Phonebook\\data";
                string p = fileName + inputId.Text + ".txt";
                System.IO.File.WriteAllText(p, data, Encoding.UTF8);

                registerNew.Enabled = true;
            }
            else
            {
                MessageBox.Show("You must enter an ID");
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.ClientSize = sizingBox2.Size;
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

        private void registerInfobox_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
