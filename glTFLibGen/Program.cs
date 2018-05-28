using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFLibGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "cmd",
                RedirectStandardInput = true,
                UseShellExecute = false
            };

            var run = Process.Start(psi);
            run.StandardInput.WriteLine("quicktype");
            run.WaitForExit();

            Console.ReadKey();
        }
    }
}
