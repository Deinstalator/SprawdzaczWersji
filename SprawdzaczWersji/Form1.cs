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
            MessageBox.Show("Wersja 1.0 FINAL\n\nAplikacja sprawdza zainstalowane standardowe programy i w razie potrzeby instaluje lub aktualizuje.", "O sprawdzaczu");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        
        private void check_Click(object sender, EventArgs e)
        {
            output.Items.Clear();

            Check check = new Check();

            output.Items.Add(check.checkInstalled("Zip") + " | " + check.okOrNot("Zip", check.SevenZip));
            progressBar1.Increment(1);
            output.Items.Add(check.checkInstalled("Google Chrome") + " | " + check.okOrNot("Google Chrome", check.Chrome));
            progressBar1.Increment(1);
            output.Items.Add(check.checkInstalled("Adobe Acrobat Reader") + " | " + check.okOrNot("Adobe Acrobat Reader", check.Reader));
            progressBar1.Increment(1);
            output.Items.Add(check.checkInstalled("Mozilla Firefox") + " | " + check.okOrNot("Firefox", check.Firefox));
            progressBar1.Increment(1);
            output.Items.Add(check.checkInstalled("Java") + " | " + check.okOrNot("Java", check.Java));
            progressBar1.Increment(1);
            output.Items.Add(check.checkInstalled("NPAPI") + " | " + check.okOrNot("NPAPI", check.Npapi));
            progressBar1.Increment(1);
            output.Items.Add(check.checkInstalled("PPAPI") + " | " + check.okOrNot("PPAPI", check.Ppapi));
            progressBar1.Increment(1);
            output.Items.Add(check.checkInstalled("Silver") + " | " + check.okOrNot("Silver", check.Silverlight));
            progressBar1.Increment(1);
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (output.Items.Count != 0)
            {
                string[] directory = {
                    @"instalki\7z1801-x64.exe",
                    @"instalki\ChromeStandaloneSetup64.exe",
                    @"instalki\AcroRdrDC1800920044_pl_PL.exe",
                    @"instalki\Firefox Setup 59.0.2.exe",
                    @"instalki\jre-8u131-windows-i586.exe",
                    @"instalki\install_flash_player.exe",
                    @"instalki\install_flash_player_ppapi.exe",
                    @"instalki\Silverlight_x64.exe",
                };


                string[] listaAplikacji = new string[output.Items.Count];

                for (int i = 0; i < output.Items.Count; i++)
                {
                    listaAplikacji[i] = output.Items[i].ToString();
                }

                for (int i = 0; i < output.Items.Count; i++)
                {
                    try
                    {
                        if (listaAplikacji[i].Contains("inna") || listaAplikacji[i].Contains("znalazłem"))
                        {
                            var process = Process.Start(directory[i]);
                            process.WaitForExit();
                        }
                    }

                    catch
                    {
                        MessageBox.Show("Anulowano instalację lub coś poszło nie tak.", "Debil");
                    }
                }
            }
            else
                MessageBox.Show("Najpierw sprawdź!", "Error");
        }
    }
}
