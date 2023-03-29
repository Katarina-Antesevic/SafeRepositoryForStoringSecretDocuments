using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRZ
{
    class Functions
    {
        public static readonly string CERTIFICATES_ROOT = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ";
        public static readonly string ROOT_FOLDER = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ";

        public static String executeCommandReturn(String command)
        {
            var process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe", command);
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.WorkingDirectory = "C:\\Users\\AcerAspireE5\\Desktop\\KRZ\\KRZ";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
            return process.StandardOutput.ReadToEnd();
        }

        public static void ExecuteCommand(String command)
        {

            var process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe", command);
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        public static string ExecutePowerShellCommand(string command, bool redirect = true)
        {

            var process = new Process();

            if (redirect)
                process.StartInfo = new ProcessStartInfo("cmd.exe", "/C " + command + " 2> errors.txt");

            else
                process.StartInfo = new ProcessStartInfo("cmd.exe", "/C " + command);


            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            while (!process.HasExited) ;
            return process.StandardOutput.ReadToEnd().Trim();
        }

    }
}
