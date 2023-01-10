using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win32Interop.Structs;

namespace Master_Forms
{
    public partial class Fairground : Form
    {
        public Fairground()
        {
            InitializeComponent();
        }

        //Makes window draggable
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        //Exit button
        private void exitFairButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        //=-=-=-=-=-=-=-=- ( Page 1 ) -=-=-=-=-=-=-=-=
        int clicked;
        private void tabPage1_Click(object sender, EventArgs e)
        {


            switch (clicked)
            {
                case 1:
                    label2.Text = "You Clicked Me ...";
                    break;
                case 2:
                    label2.Text = "You Missed Me ?";
                    break;
                case 3:
                    label2.Text = "Are you great programmer now ?";
                    break;
                case 4:
                    label2.Text = "No ...?";
                    break;
                case 5:
                    label2.Text = "Then the universe will help you remember";
                    break;
                case 6:
                    Application.Exit();
                    break;
            }

            clicked++;

        }

        private void tabPage1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.Text = e.KeyCode.ToString();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.Text = "You are on Me!!!!";
        }

        private void Fairground_KeyDown(object sender, KeyEventArgs e)
        {
            this.Text = e.KeyCode.ToString();
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F5)
            {
                button1_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                this.BackColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.label1.Text = this.textBox1.Text;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.Yellow;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            this.textBox2.BackColor = Color.Yellow;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            this.textBox3.BackColor = Color.Yellow;

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.textBox1.BackColor = Color.White;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            this.textBox2.BackColor = Color.White;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            this.textBox3.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I clicked!!!!");
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.Yellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.LightGray;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBox1.Text = this.checkBox1.Checked.ToString();

            if (this.checkBox1.Checked == false)
            {
                label4.Text = "You Unchecked Me!";
            }
            else if (this.checkBox1.Checked == true)
            {
                label4.Text = "You Checked Me!";
            }
        }

        private void showSelected_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                textBox2.Text = "Select An Item First";
            }
            else
            {
                ChangeItem(1);
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.Yellow;
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.White;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeItem(2);
        }

        public void ChangeItem(int number)
        {
            switch (number)
            {
                case 1:
                    textBox2.Text = comboBox1.SelectedIndex.ToString();
                    textBox1.Text = comboBox1.Text;
                    break;

                case 2:
                    textBox2.Text = listBox1.SelectedIndex.ToString();
                    textBox1.Text = listBox1.Text;
                    break;
            }
        }


        //=-=-=-=-=-=-=-=- ( Page 2 ) -=-=-=-=-=-=-=-=
        private void comboAdd_Click(object sender, EventArgs e)
        {
            if (boxName.Text != "")
            {
                comboBox2.Items.Add(boxName.Text);
                items.Text = "Item Count: " + comboBox2.Items.Count.ToString();
            }
            else
            {
                boxName.Text = "Enter Text";
            }
        }

        private void deleteItems_Click(object sender, EventArgs e)
        {
            Int32 si;
            si = comboBox1.SelectedIndex;
            comboBox1.Items.RemoveAt(si);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = comboBox2.SelectedIndex.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
        }

        private void Fairground_Load(object sender, EventArgs e)
        {
            items.Text = "Item Count: " + comboBox2.Items.Count.ToString();

            this.textBox.Text = System.IO.File.ReadAllText(textOneFileLocation, Encoding.UTF8);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Int32 fi;
            fi = this.comboBox2.FindStringExact(textBox4.Text);

            if (fi != -1)
            {
                comboBox3.SelectedIndex = fi;
            }
            else
            {
                comboBox3.Text = "Not Found";
            }
        }

        //=-=-=-=-=-=-=-=- ( Page 3 ) -=-=-=-=-=-=-=-=

        string firstPath = "C:\\Users\\23AugensteinS\\Documents\\File IO\\temp\\Koala.jpg";
        string secondPath = "C:\\Users\\23AugensteinS\\Documents\\File IO\\tuts\\Koala2.jpg";

        //Koala Buttons
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.Copy(firstPath, secondPath, true);
                label8.Text = "Status: You have brand new koala!!";
            }
            catch (Exception a)
            {
                label8.Text = "Status: " + a.Message;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(secondPath) == true)
            {
                label8.Text = "Status: I can see your koala!!!!";
            }
            else
            {
                label8.Text = "Status: You are missing your koala, find it";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.File.Exists(secondPath) == true)
                {
                    label8.Text = "Status: You have sent your koala to paradise";
                    System.IO.File.Delete(secondPath);
                }
                else
                {
                    label8.Text = "Status: There is no paradise without a koala";
                }
            }
            catch (Exception a)
            {
                label8.Text = "Status: " + a.Message;
            }
        }

        //Regular Buttons
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string fileName;
                fileName = openFileDialog1.FileName;

                saveFileDialog1.ShowDialog();
                string saveName;
                saveName = saveFileDialog1.FileName;

                System.IO.File.Copy(fileName, saveName, true);

                label8.Text = "Status: You have copied a file" + "\nFrom: " + fileName + "\nTo: " + secondPath;
            }
            catch (Exception a)
            {
                label8.Text = "Status: " + a.Message;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string fileName;
                fileName = openFileDialog1.FileName;

                saveFileDialog1.ShowDialog();
                string saveName;
                saveName = saveFileDialog1.FileName;

                System.IO.File.Copy(fileName, saveName, true);

                label8.Text = "Status: You have moved a file" + "\nFrom: " + fileName + "\nTo: " + saveName;
            }
            catch (Exception a)
            {
                label8.Text = "Status: " + a.Message;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                string fileName;
                fileName = openFileDialog1.FileName;

                System.IO.File.Delete(fileName);
                label8.Text = "Status: You have sent " + fileName + " to paradise";
            }
            catch (Exception a)
            {
                label8.Text = "Status: " + a.Message;
            }
        }

        //Text Editor
        string textOneFileLocation = "C:\\Users\\23AugensteinS\\Documents\\File IO\\txt.txt";
        private void textFileSave_Click(object sender, EventArgs e)
        {
            string currentFile = textBox.Text;
            System.IO.File.WriteAllText(textOneFileLocation, currentFile, Encoding.UTF8);
            label8.Text = "Status: You have saved your text file";
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (autosave == true)
            {
                string currentFile = textBox.Text;
                System.IO.File.WriteAllText(textOneFileLocation, currentFile, Encoding.UTF8);
            }
        }

        bool autosave = false;
        private void textAutosave_Click(object sender, EventArgs e)
        {
            if (autosave == false)
            {
                textAutosave.Text = "Autosave (✔)";
                textFileSave.Visible = false;
                autosave = true;

            }
            else if (autosave == true)
            {
                textAutosave.Text = "Autosave (X)";
                textFileSave.Visible = true;
                autosave = false;
            }
        }

        //Dynamic Files
        private void dynamicSave_Click(object sender, EventArgs e)
        {
            string fileName;
            fileName = "C:\\Users\\23AugensteinS\\Documents\\File IO\\texts\\texts" + dynamicId.Text + ".txt";
            if (dynamicId.Text == "" || dynamicName.Text == "")
            {
                label8.Text = "Status: Please enter your info!";
                return;
            }
            System.IO.File.WriteAllText(fileName, dynamicName.Text, Encoding.UTF8);
        }

        private void dynamicLoad_Click(object sender, EventArgs e)
        {
            string fileName;
            fileName = "C:\\Users\\23AugensteinS\\Documents\\File IO\\texts\\texts" + dynamicId.Text + ".txt";
            if (dynamicId.Text == "")
            {
                label8.Text = "Status: Please enter your ID!";
                return;
            }
            if (System.IO.File.Exists(fileName))
            {
                string r = System.IO.File.ReadAllText(fileName, Encoding.UTF8);
                dynamicName.Text = r;
            }
            else
            {
                label8.Text = "Status: I can't find your info. Please try again!";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FileExplorer files = new FileExplorer();
            files.MdiParent = this;
            files.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
