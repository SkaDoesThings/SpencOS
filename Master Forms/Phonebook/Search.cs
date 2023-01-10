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
using Win32Interop.Structs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Master_Forms.Phonebook
{
    public partial class Search : Form
    {
        public Search()
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

            private void button1_Click(object sender, EventArgs e)
        {
           
        }
            private void Search_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (toolStripTextBox1.Text != "")
                {
                    string fileSource = $@"C:\\Users\\23AugensteinS\\Documents\\Udemy\\C#\\Master Forms\\Applications\\Phonebook\\data\\{toolStripTextBox1.Text}.txt";

                    if (System.IO.File.Exists(fileSource) == true)
                    {
                        Person newPerson = new Person();

                        showInfobox.Visible = true;
                        this.ClientSize = groupBox2.Size;

                        List<string> lines = File.ReadAllLines(fileSource).ToList();

                        foreach (string line in lines)
                        {
                            newPerson.Id = lines[0];
                            newPerson.FirstName = lines[1];
                            newPerson.LastName = lines[2];
                            newPerson.Cellphone = lines[3];
                            newPerson.Telephone = lines[4];
                            newPerson.Email = lines[5];
                            newPerson.Address = lines[6];
                            newPerson.Comment = lines[7];
                        }

                        inputFirst.Text = newPerson.FirstName.Trim(',');
                        inputLast.Text = newPerson.LastName.Trim(',');
                        inputCell.Text = newPerson.Cellphone.Trim(',');
                        inputTele.Text = newPerson.Telephone.Trim(',');
                        inputEmail.Text = newPerson.Email.Trim(',');
                        inputAddress.Text = newPerson.Address.Trim(',');
                        inputComment.Text = newPerson.Comment.Trim(',');
                    }
                    else
                    {
                        MessageBox.Show("Your ID does not exist");
                    }
                }
                else
                {
                    MessageBox.Show("Enter an ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
