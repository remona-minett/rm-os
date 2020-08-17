using System;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace rm_os_gfx
{
    class PathCheck
    {

        public static string PathChk(string tab, string row)
        {
            fiChk:
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "rm-os"));
            string rmosConfigDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "rm-os");
            Directory.SetCurrentDirectory(rmosConfigDir); // sets up appdata folder
            foreach (string file in Directory.EnumerateFiles(rmosConfigDir, "*.txt"))
            {
                string[] lines = File.ReadLines(file).Take(2).ToArray();
                if (lines[0] == tab && lines[1] == row)
                {
                    return file;
                }
            }
            string inputname;
            string inputpath;
            bool validpath;
            inputname = Interaction.InputBox("Input program name:"); // popups for name/path
            inputpath = Interaction.InputBox("Input program path:");
            validpath = Path.IsPathRooted(inputpath);
            if (validpath == true)
            {
                if (File.Exists(inputpath) == true)
                {
                    try
                    {
                        string[] inputdata = new string[4] { tab, row, inputname, inputpath };
                        File.WriteAllLines(inputname + "conf.txt", inputdata);
                        MessageBox.Show("Wrote " + inputname + " to " + tab + ", " + row + ", " + rmosConfigDir + ".","Success!"); // displays information on added shortcut.
                        goto fiChk;
                    }
                    catch (Exception) { MessageBox.Show("Something went wrong. Check folder access and try again."); return null; } // generic exception for missing folder permissions
                }
                else
                {
                    MessageBox.Show("This path either does not exist or is invalid, please try again.","File path 404"); 
                    return null; // if it is not <drive letter>:\path\to\executable.exe it will return this
                }
            }
            else
            {
                MessageBox.Show("This path either does not exist or is invalid, please try again.","File Path 404");
                return null; // if it is not <drive letter>:\path\to\executable.exe it will return this
            }
        }
    }
}
