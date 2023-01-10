using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Forms
{
    public partial class FileExplorer : Form
    {
        WebBrowser webBrowser = new WebBrowser();

        public FileExplorer()
        {
            InitializeComponent();
        }

        private void pathOpen_Click(object sender, EventArgs e)
        {
            //Open browser dialog allows you to select the path
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    webBrowser.Url = new Uri(fbd.SelectedPath);
                    pathDisplay.Text = fbd.SelectedPath;
                }
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoBack)
                webBrowser.GoBack();
        }

        private void goForward_Click(object sender, EventArgs e)
        {
            if (webBrowser.CanGoForward)
                webBrowser.GoForward();
        }

        private void FileExplorer_Load(object sender, EventArgs e)
        {

        }
    }
}
