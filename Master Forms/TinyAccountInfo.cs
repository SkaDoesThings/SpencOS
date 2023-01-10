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
    public partial class TinyAccountInfo : Form
    {
        public TinyAccountInfo()
        {
            InitializeComponent();
        }


        public string username;
        public string password;
        public string wallpaper;
        public string icon;
        public bool hasChangedWallpaper = false;

        private void TinyAccountInfo_Load(object sender, EventArgs e)
        {
            string currentUser = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Accounts\currentaccount\currentaccount.txt";

            string currentName = File.ReadAllText(currentUser);

            string fileSource = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Accounts\{currentName}.txt";

            string wallpaperSource = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Settings\{currentName}Wallpaper.txt";

            string iconSource = $@"C:\Users\23AugensteinS\Documents\Udemy\C#\Master Forms\Settings\{currentName}Icon.txt";

            List<string> lines = File.ReadAllLines(fileSource).ToList();

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');

                username = entries[0];
                password = entries[1];
            }

            wallpaper = File.ReadAllText(wallpaperSource);
            icon = File.ReadAllText(iconSource);

            foreach (Form form in System.Windows.Forms.Application.OpenForms)
                if (form is TinyAccountInfo)
                {
                    form.Close();
                    break;
                }
        }
    }
}