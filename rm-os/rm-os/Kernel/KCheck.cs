using System;
using System.Runtime.InteropServices;

namespace rm_os.Kernel
{
    class KCheck
    {
        public static void PrintTargetRuntime()
        {
            var stats = new
            {
                RuntimeInformation.OSDescription,
                RuntimeInformation.OSArchitecture,
                RuntimeInformation.ProcessArchitecture,
                RuntimeInformation.FrameworkDescription
            };
            Console.WriteLine("OS Platform is : " + stats.OSDescription);
            Console.WriteLine("OS Architecture is : " + stats.OSArchitecture);
            Console.WriteLine("Framework is " + stats.FrameworkDescription);
            if (stats.ProcessArchitecture == Architecture.Arm)
            {
                Console.WriteLine("ARM process.");
            }
            else if (stats.ProcessArchitecture == Architecture.Arm64)
            {
                Console.WriteLine("ARM64 process.");
            }
            else if (stats.ProcessArchitecture == Architecture.X64)
            {
                Console.WriteLine("x64 process.");
            }
            else if (stats.ProcessArchitecture == Architecture.X86)
            {
                Console.WriteLine("x86 process.");
            }
        }
        public static void KernelInfo()
        {
            string kver = "1.0.0"; // update version number here
            Console.Clear();
            Console.WriteLine("System Info:\n");
            Console.WriteLine("Kernel Version: " + kver);
            PrintTargetRuntime();
        }
    }
}