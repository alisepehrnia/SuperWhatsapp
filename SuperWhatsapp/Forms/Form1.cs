using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace MultiWhatsapp.Forms
{
    public partial class Form1 : Form
    {
        private readonly List<ChromiumWebBrowser> _browsers = new List<ChromiumWebBrowser>();
        private const string Webapp = "web.whatsapp.com";

        private readonly string _cacheRoot =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CefSharp\\Cache\\SuperWhatsapp");

        private ChromiumWebBrowser ActiveBrowser => _browsers[tabControl.SelectedIndex];

        public Form1()
        {
            InitializeComponent();

            var ctxBuilder = new RequestContextBuilder();

            for (var i = 1; i <= 10; i++)
            {
                var reqCtx = ctxBuilder
                    .PersistUserPreferences()
                    .WithCachePath(Path.Combine(_cacheRoot, i.ToString()))
                    .Create();

                var ctrl = new ChromiumWebBrowser(Webapp, reqCtx)
                {
                    ActivateBrowserOnCreation = true
                };

                _browsers.Add(ctrl);

                var tabPage = new TabPage(i.ToString());
                tabPage.Controls.Add(ctrl);

                tabControl.TabPages.Add(tabPage);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl.TabPages)
            {
                tabControl.SelectTab(tab);
                Task.Delay(1);
            }
            tabControl.SelectTab(tabControl.TabPages[0]);
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            _browsers.ForEach(b => b.Dispose());
            Cef.Shutdown();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ActiveBrowser.Reload();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if(ActiveBrowser.CanGoBack)
                ActiveBrowser.Back();
        }

        private void BackwardButton_Click(object sender, EventArgs e)
        {
            if(ActiveBrowser.CanGoForward)
                ActiveBrowser.Forward();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
