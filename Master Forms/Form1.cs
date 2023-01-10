using System.Diagnostics;

namespace Master_Forms
{
    public partial class Form1 : Form
    {
        bool show = true;
        Form2 frm2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            timer1.Interval = 500;
            timer1.Start();

            this.Show();
            pictureBox1.Show();

        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (show == true)
            {
                frm2.Show();

                show = false;

                this.Hide();
            }
        }
    }
}