using System;
using System.IO;

namespace rm_os.Configuration
{
    public class SaveConfig
    {
        public static void SaveCFile(string confloc, string[] configuration)
        {
            try { File.WriteAllLines(confloc, configuration); } // attempt to write data to disk
            catch (Exception)
            {
                Console.WriteLine("Failed to write configuration data. Check write permissions.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
        }
    }
}
