using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFX_2
{
    class HandleEncript : IDisposable
    {
        string path = "";
        Process sum;
        public HandleEncript() { }

        public void setPath(string p)
        {
            this.path = p;
        }

        public void Decript()
        {
            if (path == "") return;
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = @"pfdtool.exe";
            p.StartInfo.Arguments = " -g BLES01880 -d \"" + path + "\"  SAVES";
            Console.WriteLine(" -g BLES01880 -d \"" + path + "\"  SAVES");
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            //string output_d = p.StandardOutput.ReadToEnd();
            //MessageBox.Show(output_d); 
            p.WaitForExit();
        }
        public void Encript()
        {
            if (path == "") return;
            //Recript
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = @"pfdtool.exe";
            p.StartInfo.Arguments = " -g BLES01880 -e \"" + path + "\"  SAVES";
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            //string output_e = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
        }

        public void MSC()
        {
            sum = new Process();
            // Redirect the output stream of the child process.
            sum.StartInfo.UseShellExecute = false;
            sum.StartInfo.FileName = @"MemorySumChecker.exe";
            sum.Start();
        }

        public void Dispose()
        {
            try
            {
                sum.Kill();
                sum.Close();
                sum.Dispose();
            }
            catch { }
        }
    }
}
