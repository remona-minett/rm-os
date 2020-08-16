using System;
using rm_os.Kernel;

namespace rm_os
{
    class Program
    {
        static void Main()
        {
            KInfo.kernelInfo();
            Console.ReadKey(); // eof hang to read output
        }
    }
}
