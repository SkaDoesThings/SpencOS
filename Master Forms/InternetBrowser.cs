using Microsoft.Web.WebView2.Core;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FireTabs;

namespace Master_Forms
{
    public partial class InternetBrowser : Form
    {
        public Microsoft.Web.WebView2.Core.CoreWebView2Deferral Deferral;
        public Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs Args;

        int canGoBack = 0;
        WebBrowser webBrowser = new WebBrowser();

        [STAThread]

        async void InitializeAsync()
        {
            try
            {
                await webView.EnsureCoreWebView2Async(null);
                webView.CoreWebView2.WebMessageReceived += UpdateAddressBar;
            }
            catch (Exception ex)
            {
                this.Close();
            }
        }

        public InternetBrowser()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
            this.Resize += new System.EventHandler(this.Form_Resize);
            //webView.NavigationStarting += EnsureHttps;
            InitializeAsync();
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            tabControl.Size = this.ClientSize - new System.Drawing.Size(tabControl.Location);
            btnGo.Left = this.ClientSize.Width - btnGo.Width - 200;
            btnNewTab.Left = this.ClientSize.Width - btnGo.Width - 150;
            userImage.Left = this.ClientSize.Width - btnGo.Width - 100;
            buttonSettings.Left = this.ClientSize.Width - btnGo.Width - 50;
            txtUrl.Width = btnGo.Left - txtUrl.Left - 10;

            exitButton.Left = this.ClientSize.Width - btnGo.Width - 0;
        }

        private void CoreWebView2_NewWindowRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NewWindowRequestedEventArgs e)
        {
            InternetBrowser f = new InternetBrowser();
            f.Args = e;
            f.Deferral = e.GetDeferral();
            f.Show();
        }

        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                webView.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
                args.Cancel = true;
            }

        }

        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            txtUrl.Text = uri;
            tabPage1.Text = uri;
            webView.CoreWebView2.PostWebMessageAsString(uri);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            GoNavGo();
        }

        public void GoNavGo()
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                try
                {

                    if (txtUrl.Text != "")
                    {
                        txtUrlWrong.Text = "";
                        webView.CoreWebView2.Navigate(txtUrl.Text);
                    }
                }
                catch (Exception)
                {
                    txtUrlWrong.Text = "Invalid Link";
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webView.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webView.GoForward();
        }

        private void webView_Click(object sender, EventArgs e)
        {

        }

        private void InternetBrowser_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    GoNavGo();
                    break;
            }
        }


        //<-=-=-=-=-=-=-=-=( Start Ability to Resize Window ) =-=-=-=-=-=-=-=-=->
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;

            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }
        //<-=-=-=-=-=-=-=-=( End of Ability to Resize Window ) =-=-=-=-=-=-=-=-=->

        WebBrowser webTab = null;

        private void btnNewTab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            webTab = new WebBrowser();
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("file:///C:/Users/23AugensteinS/Documents/Udemy/C%23/Master%20Forms/Seal%20Search/Search/index.html");
            webTab.DocumentCompleted += WebTab_DocumentCompleted;
        }

        private void WebTab_DocumentCompleted(object? sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void InternetBrowser_Load(object sender, EventArgs e)
        {
            TinyAccountInfo tiny = new TinyAccountInfo();
            tiny.Show();
            this.userImage.BackgroundImage = new Bitmap(tiny.icon);

            tiny.Close();
        }

        private void userImage_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}