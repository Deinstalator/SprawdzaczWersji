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
            var sevenZ = FileVersionInfo.GetVersionInfo("C:\\Program Files\\7-Zip\\7zFM.exe");
            string version = sevenZ.ProductVersion;
            output.Items.Add($"7zip - {version}");
        }
    }
}
