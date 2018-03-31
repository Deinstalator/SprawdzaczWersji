using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SprawdzaczWersji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wersja 0.1\n\nAplikacja sprawdza zainstalowane standardowe programy i w razie potrzeby instaluje lub aktualizuje.");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void check_Click(object sender, EventArgs e)
        {
            string version;

            var sevenZ = FileVersionInfo.GetVersionInfo(@"C:\Program Files\7-Zip\7zFM.exe");
            version = sevenZ.ProductVersion;
            output.Items.Add($"7zip - {version}");

            var adobeReader = FileVersionInfo.GetVersionInfo(@"C:\Program Files (x86)\Adobe\Acrobat Reader DC\Reader\AcroRd32.exe");
            version = adobeReader.ProductVersion;
            output.Items.Add($"Adobe Reader DC - {version}");

            var chrome = FileVersionInfo.GetVersionInfo(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
            version = chrome.ProductVersion;
            output.Items.Add($"Google Chrome - {version}");

            var mozilla = FileVersionInfo.GetVersionInfo(@"C:\Program Files\Mozilla Firefox\firefox.exe");
            version = mozilla.ProductVersion;
            output.Items.Add($"Mozilla Firefox - {version}");

            var java = FileVersionInfo.GetVersionInfo(@"C:\Program Files (x86)\Java\jre1.8.0_131\bin\java.exe");
            version = java.ProductVersion;
            output.Items.Add($"Java - {version}");
        }
    }
}
