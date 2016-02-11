using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLauncher
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string IIS_EXPRESS = @"C:\Program Files\IIS Express\iisexpress.exe";
                string IIS_EXPRESSTRAY = @"C:\Program Files\IIS Express\iisexpresstray.exe";

                StringBuilder arguments = new StringBuilder();
                arguments.Append(@"/path:");
                arguments.Append(@"C:\www");
                arguments.Append(@" /port:8080");
                Process process = Process.Start(new ProcessStartInfo()
                {
                    FileName = IIS_EXPRESS,
                    Arguments = arguments.ToString(),
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                });

                Process tray = Process.Start(new ProcessStartInfo()
                {
                    FileName = IIS_EXPRESSTRAY
                });
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                Console.ReadKey();
            }
        }
    }
}
