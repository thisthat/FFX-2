using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public Updater()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            version = fileVersionInfo.ProductVersion;
            WebClient client = new WebClient();
            string v = client.DownloadString(url + page + version);
            if (v.Trim() != "")
            {
                MessageBox.Show(v);
            }
            
        }
        
    }
}
