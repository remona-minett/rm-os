using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace rm_os_gfx
{
    public static class PathTesting
    {

        public static string[] PathChk(string tab, string row)
        {
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "rm-os"));
            var rmosConfigDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "rm-os");
            Directory.SetCurrentDirectory(rmosConfigDir); // sets up appdata folder
            foreach (var file in Directory.EnumerateFiles(rmosConfigDir, "*.txt"))
            {
                string[] lines = File.ReadLines(file).Take(2).ToArray();
                if (lines[0] == tab && lines[1] == row)
                {
                    string[] foundConfig = File.ReadAllLines(file);
                    return foundConfig;
                }
            }
            return null;
        }
        public static void PathAssign(string tab, string row)
        {
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "rm-os"));
            var rmosConfigDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "rm-os");
            Directory.SetCurrentDirectory(rmosConfigDir); // sets up appdata folder
            var inputname = Interaction.InputBox("Input program name:", "Program Name"); // popups for name/path
            var inputpath = Interaction.InputBox("Input program path:", "Program Path");
            var validpath = Path.IsPathRooted(inputpath);
            if (validpath)
            {
                if (File.Exists(inputpath))
                {
                    try
                    {
                        string[] inputdata = { tab, row, inputname, inputpath };
                        File.WriteAllLines(inputname + "conf.txt", inputdata);
                        MessageBox.Show("Wrote " + inputname + " to " + tab + ", " + row + ", " + rmosConfigDir + ".", "Success!"); // displays information on added shortcut.
                        PathChk(tab, row);
                    }
                    catch (Exception) { MessageBox.Show("Something went wrong. Check folder access and try again."); } // generic exception for missing folder permissions
                }
                else
                {
                    MessageBox.Show("This path either does not exist or is invalid, please try again.","File path 404"); // if it is not <drive letter>:\path\to\executable.exe it will return this
                }
            }
            else
            {
                MessageBox.Show("This path either does not exist or is invalid, please try again.","File Path 404"); // if it is not <drive letter>:\path\to\executable.exe it will return this
            }
        }
    }
}
