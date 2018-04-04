using System;
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
            MessageBox.Show("Wersja 0.2\n\nAplikacja sprawdza zainstalowane standardowe programy i w razie potrzeby instaluje lub aktualizuje.");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void check_Click(object sender, EventArgs e)
        {
            Check check = new Check();

            output.Items.Add(check.checkInstalled("7-Zip") + " | " + check.okOrNot("7-zip", check.SevenZip));
            output.Items.Add(check.checkInstalled("Google Chrome") + " | " + check.okOrNot("Google Chrome", check.Chrome));
            output.Items.Add(check.checkInstalled("Adobe Acrobat Reader") + " | " + check.okOrNot("Adobe Acrobat Reader", check.Reader));
            output.Items.Add(check.checkInstalled("Firefox") + " | " + check.okOrNot("Firefox", check.Firefox));
            output.Items.Add(check.checkInstalled("Java") + " | " + check.okOrNot("Java", check.Java));
        }
    }
}
