using System;
using System.IO;

namespace rm_os.Configuration
{
    public class LoadConfig
    {
        public static string[] LoadCFile(string confloc)
        {
            string[] confdata = File.ReadAllLines(confloc); // simply reads each line into the array as a config.
            return confdata;
        }
    }
}