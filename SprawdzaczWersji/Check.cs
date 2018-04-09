using Microsoft.Win32;
using System.Linq;

namespace SprawdzaczWersji
{
    public class Check
    {
        public string SevenZip { get; protected set; }

        public string Reader { get; protected set; }

        public string Chrome { get; protected set; }

        public string Firefox { get; protected set; }

        public string Java { get; protected set; }

        public string Npapi { get; set; }

        public string Ppapi { get; set; }

        public string Silverlight { get; set; }

        public string Wersja { get; protected set; }

        public Check(string sevenZip = "16.04", string reader = "18.011.20038", string chrome = "65.0.3325.181",
            string firefox = "59.0.2", string java = "8.0.1310.11", string npapi = "29.0.0.147", 
            string ppapi = "29.0.0.147", string silverlight = "5.1.50905.0")
        {
            SevenZip = sevenZip;
            Reader = reader;
            Chrome = chrome;
            Firefox = firefox;
            Java = java;
            Npapi = npapi;
            Ppapi = ppapi;
            Silverlight = silverlight;
        }

        public string checkInstalled(string c_name)
        {
            string displayName;
            string displayVersion;

            string registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(registryKey);
            if (key != null)
            {
                foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    displayName = subkey.GetValue("DisplayName") as string;
                    displayVersion = subkey.GetValue("DisplayVersion") as string;
                    if (displayName != null && displayName.Contains(c_name))
                    {
                        return displayName + " " + displayVersion;
                    }
                }
                key.Close();
            }

            RegistryKey registryKey64 = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);
            registryKey64 = registryKey64.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            if (registryKey64 != null)
            {
                foreach (RegistryKey subkey in registryKey64.GetSubKeyNames().Select(keyName => registryKey64.OpenSubKey(keyName)))
                {
                    displayName = subkey.GetValue("DisplayName") as string;
                    displayVersion = subkey.GetValue("DisplayVersion") as string;
                    if (displayName != null && displayName.Contains(c_name))
                    {
                        return displayName + " " + displayVersion;
                    }
                }
                key.Close();
            }

            return "Nie znalazłem zainstalowanej aplikacji.";
        }

        public string okOrNot(string c_name, string wersja)
        {
            string displayName;
            string displayVersion;

            string registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            RegistryKey key = Registry.LocalMachine.OpenSubKey(registryKey);
            if (key != null)
            {
                foreach (RegistryKey subkey in key.GetSubKeyNames().Select(keyName => key.OpenSubKey(keyName)))
                {
                    displayName = subkey.GetValue("DisplayName") as string;
                    displayVersion = subkey.GetValue("DisplayVersion") as string;
                    if (displayName != null && displayName.Contains(c_name))
                    {
                        if (displayVersion == wersja)
                            return "OK";
                        else
                            return "Wersja aplikacji inna od zalecanej";
                    }
                }
                key.Close();
            }

            RegistryKey registryKey64 = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);
            registryKey64 = registryKey64.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall");
            if (registryKey64 != null)
            {
                foreach (RegistryKey subkey in registryKey64.GetSubKeyNames().Select(keyName => registryKey64.OpenSubKey(keyName)))
                {
                    displayName = subkey.GetValue("DisplayName") as string;
                    displayVersion = subkey.GetValue("DisplayVersion") as string;
                    if (displayName != null && displayName.Contains(c_name))
                    {
                        if (displayVersion == wersja)
                            return "OK";
                        else
                            return "Wersja aplikacji inna od zalecanej";
                    }
                }
                key.Close();
            }

            return "Meh";
        }
    }
}
