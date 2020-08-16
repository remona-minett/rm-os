using System;
using rm_os.Kernel;

namespace rm_os
{
    class Program
    {
        static void Main()
        {
            KCheck.KernelInfo();
            KInit.KCheck();
            Console.ReadKey(); // eof hang to read output
        }
    }
}
