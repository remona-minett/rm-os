using System;
using System.IO;

namespace rm_os.Configuration
{
    public class LoadConfig
    {
        public static string[] LoadCFile(string confloc)
        {
            string[] confdata = null;
            try { confdata = File.ReadAllLines(confloc); } // reads each line into the array
            catch (Exception)
            {
                Console.WriteLine("Failed to read configuration data. Check read permissions.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            return confdata;
        }
    }
}