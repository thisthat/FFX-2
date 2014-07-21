using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace FFX_2
{
    class Updater
    {
        string url = "http://thisthat.altervista.org/FFX-2HD_Cheater/";
        string page = "update.php?v=";
        string version;
        string lang;

        public Updater()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            version = fileVersionInfo.ProductVersion;
            CultureInfo ci = CultureInfo.InstalledUICulture;
            lang = "&l=" + ci.Name;
            WebClient client = new WebClient();
            try
            {
                string v = client.DownloadString(url + page + version + lang);
                if (v.Trim() != "")
                {
                    var r = MessageBox.Show(v,"Update",System.Windows.MessageBoxButton.YesNo);
                    if (r == System.Windows.MessageBoxResult.Yes)
                    {
                        System.Diagnostics.Process.Start("http://thisthat.github.io/FFX-2/");
                    }
                }
            }
            catch(Exception e){}
            
            
        }

    }
}
