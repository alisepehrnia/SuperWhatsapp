using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using MultiWhatsapp.Forms;

namespace MultiWhatsapp
{
    public static class Program
    {
        //private static SplashForm _splashScreen;
        private static Form1 _mainForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            ////License Check Procedure
            ////Licence File Exist Check
            //if (!File.Exists(Register.LicensePath))
            //{ 
            //    new ActivateForm().ShowDialog();
            //    return -10;
            //}

            ////License Data Exist Check
            //var license = Register.ReadLicense(Register.LicensePath, out var pk);
            //if (license is null || string.IsNullOrWhiteSpace(pk))
            //{
            //    MessageBox.Show("خطای فعالسازی : کد2");
            //    return -2;
            //}

            //if (!Validator.IsLicenseValidated(license, pk))
            //{
            //    MessageBox.Show("خطای فعالسازی : کد1");
            //    return -1;
            //}

            //_splashScreen = new SplashForm();
            //UI.ShowSplashScreen(_splashScreen);

            #region CEF

            #if ANYCPU
                CefRuntime.SubscribeAnyCpuAssemblyResolver();
            #endif

            //For Windows 7 and above, best to include relevant app.manifest entries as well
            Cef.EnableHighDPISupport();

            var settings = new CefSettings();

            //Example of setting a command line argument
            //Enables WebRTC
            // - CEF Doesn't currently support permissions on a per browser basis see https://bitbucket.org/chromiumembedded/cef/issues/2582/allow-run-time-handling-of-media-access
            // - CEF Doesn't currently support displaying a UI for media access permissions
            //
            //NOTE: WebRTC Device Id's aren't persisted as they are in Chrome see https://bitbucket.org/chromiumembedded/cef/issues/2064/persist-webrtc-deviceids-across-restart
            settings.CefCommandLineArgs.Add("enable-media-stream");
            //https://peter.sh/experiments/chromium-command-line-switches/#use-fake-ui-for-media-stream
            settings.CefCommandLineArgs.Add("use-fake-ui-for-media-stream");
            //For screen sharing add (see https://bitbucket.org/chromiumembedded/cef/issues/2582/allow-run-time-handling-of-media-access#comment-58677180)
            settings.CefCommandLineArgs.Add("enable-usermedia-screen-capturing");

            //Perform dependency check to make sure all relevant resources are in our output directory.
            Cef.Initialize(settings, true, browserProcessHandler: null);

            #endregion

            //Create and Show Main Form
            _mainForm = new Form1();
            //_mainForm.Shown += MainForm_Shown;
            Application.Run(_mainForm);
        }

        //private static void MainForm_Shown(object sender, EventArgs e)
        //{
        //    Task.Delay(500);
        //    UI.SafeSplashClose(_splashScreen);
        //    _mainForm.Activate();
        //}
    }
}
