using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Master_Forms.Applications.Games
{
    public partial class Dwayne : Form
    {
        public Dwayne()
        {
            InitializeComponent();
        }

        private void Dwayne_Load(object sender, EventArgs e)
        {
            this.Width = 507;
            this.Height = 530;
            wordbank = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Applications\ChatAI\wordbanks\Dwayne.txt";

            GetNames();

            GatherWords();
            settingsFlipFlop = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string wordbank = "";
        private void commandSpeak_Click(object sender, EventArgs e)
        {
            chatBox.Text = "";
            wordAmount = 0;
            PrintWords();
        }

        public void GetNames()
        {
            DirectoryInfo place = new DirectoryInfo($@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Applications\ChatAI\wordbanks");

            FileInfo[] Files = place.GetFiles();

            foreach (FileInfo i in Files)
            {
                string nameOnly = Path.GetFileNameWithoutExtension(i.Name);
                comboBox1.Items.Add(nameOnly);
            }
        }

        List<string> words = new List<string>();
        int finalNumberCount;
        public void GatherWords()
        {
            words.Clear();
            string input = File.ReadAllText(wordbank);
            int entryNumber = 0;
            string[] entries = input.Split(' ');

            foreach (string entry in entries)
            {
                words.Add(entries[entryNumber]);
                entryNumber++;
            }
            finalNumberCount = entryNumber;
        }

        int wordAmount = 0;
        public void PrintWords()
        {
            Random random = new Random();
            int sentanceLength = random.Next(3, 20);

            while (wordAmount <= sentanceLength)
            {
                int sentanceWords = random.Next(0, finalNumberCount);

                chatBox.Text = chatBox.Text + " " + words[sentanceWords].ToString();
                wordAmount++;
            }
        }

        private bool settingsFlipFlop;
        private void button1_Click(object sender, EventArgs e)
        {
            if (settingsFlipFlop == true)
            {
                this.Width = 775;
                settingsFlipFlop = false;
            }
            else if (settingsFlipFlop == false)
            {
                this.Width = 504;
                settingsFlipFlop = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = comboBox1.Text;

            wordbank = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Applications\ChatAI\wordbanks\{selectedName}.txt";


            if (editingFlipFlop == false)
            {
                GatherWords();
            }
            else if (editingFlipFlop == true)
            {
                UpdateWords();
            }

            commandSpeak.Text = "Speak, " + comboBox1.Text + "!";
        }

        private void addWord_Click(object sender, EventArgs e)
        {
            string file = File.ReadAllText(wordbank);
            string input = file + " " + typeWord.Text;
            System.IO.File.WriteAllText(wordbank, input);

            GatherWords();
            if (editingFlipFlop == true)
            {
                UpdateWords();
            }

            typeWord.Text = "";
        }

        bool editingFlipFlop = false;
        private void settingsEdit_Click(object sender, EventArgs e)
        {
            if (editingFlipFlop == false)
            {
                viewEdit.Visible = true;
                viewInteract.Visible = false;

                UpdateWords();

                settingsEdit.Text = "Close Wordbank";

                editingFlipFlop = true;
            }
            else if (editingFlipFlop == true)
            {
                GatherWords();
                viewEdit.Visible = false;
                viewInteract.Visible = true;

                settingsEdit.Text = "Open Wordbank";

                editingFlipFlop = false;
            }
        }

        public void UpdateWords()
        {
            string file = File.ReadAllText(wordbank);
            editBox.Text = file;
        }

        private void addName_Click(object sender, EventArgs e)
        {
            typeName.Text = "";
            comboBox1.Items.Clear();
            string selectedName = typeName.Text;
            wordbank = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Applications\ChatAI\wordbanks\{selectedName}.txt";
            System.IO.File.WriteAllText(wordbank, "hello");
            comboBox1.Text = selectedName;
            commandSpeak.Text = "Speak, " + comboBox1.Text + "!";

            GetNames();
            GatherWords();
            UpdateWords();
        }

        string currentText = "";
        private void editBox_TextChanged(object sender, EventArgs e)

        {
            currentText = editBox.Text;

            System.IO.File.WriteAllText(wordbank, currentText, Encoding.UTF8);
        }
    }
}