using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Maker___mk._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  webBrowser1.DocumentText = "<iframe width='560' height='315' src='https://www.youtube.com/embed/z6A2LHGx8_A' frameborder='0' allow='autoplay; encrypted-media' allowfullscreen></iframe>";
            int BrowserVer, RegVal;

            // get the installed IE version
            using (WebBrowser Wb = new WebBrowser())
                BrowserVer = Wb.Version.Major;

            // set the appropriate IE version
            if (BrowserVer >= 11)
                RegVal = 11001;
            else if (BrowserVer == 10)
                RegVal = 10001;
            else if (BrowserVer == 9)
                RegVal = 9999;
            else if (BrowserVer == 8)
                RegVal = 8888;
            else
                RegVal = 7000;

            // set the actual key
            using (RegistryKey Key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", RegistryKeyPermissionCheck.ReadWriteSubTree))
                if (Key.GetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe") == null)
                    Key.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", RegVal, RegistryValueKind.DWord);

            WebBrowser player = new WebBrowser();
            this.Controls.Add(player);
            player.Size = this.Size;
            player.Navigate(new Uri("http://www.youtube.com/embed/dt5CNi0aEpI"));

        }
        private void Form1_ResizeEnd(Object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
