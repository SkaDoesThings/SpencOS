namespace Master_Forms
{
    partial class FileExplorer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pathDisplay = new System.Windows.Forms.TextBox();
            this.pathOpen = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.goForward = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.SuspendLayout();
            // 
            // webView2
            // 
            this.webView2.AllowExternalDrop = true;
            this.webView2.CreationProperties = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2.Location = new System.Drawing.Point(2, 55);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(796, 394);
            this.webView2.TabIndex = 0;
            this.webView2.ZoomFactor = 1D;
            // 
            // pathDisplay
            // 
            this.pathDisplay.Location = new System.Drawing.Point(141, 16);
            this.pathDisplay.Name = "pathDisplay";
            this.pathDisplay.Size = new System.Drawing.Size(529, 23);
            this.pathDisplay.TabIndex = 1;
            // 
            // pathOpen
            // 
            this.pathOpen.Location = new System.Drawing.Point(698, 16);
            this.pathOpen.Name = "pathOpen";
            this.pathOpen.Size = new System.Drawing.Size(75, 23);
            this.pathOpen.TabIndex = 2;
            this.pathOpen.Text = "button1";
            this.pathOpen.UseVisualStyleBackColor = true;
            this.pathOpen.Click += new System.EventHandler(this.pathOpen_Click);
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(12, 16);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(35, 23);
            this.goBack.TabIndex = 3;
            this.goBack.Text = "<-";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // goForward
            // 
            this.goForward.Location = new System.Drawing.Point(53, 16);
            this.goForward.Name = "goForward";
            this.goForward.Size = new System.Drawing.Size(37, 23);
            this.goForward.TabIndex = 4;
            this.goForward.Text = "->";
            this.goForward.UseVisualStyleBackColor = true;
            this.goForward.Click += new System.EventHandler(this.goForward_Click);
            // 
            // FileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goForward);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.pathOpen);
            this.Controls.Add(this.pathDisplay);
            this.Controls.Add(this.webView2);
            this.Name = "FileExplorer";
            this.Text = "Folder Adventurer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FileExplorer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private TextBox pathDisplay;
        private Button pathOpen;
        private Button goBack;
        private Button goForward;
    }
}