using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using Microsoft.VisualBasic;

namespace rm_os_gfx
{
    public partial class rmos : Form
    {
        private string b37PS; // tab 1
        private string b36PS;
        private string b35PS;
        private string b34PS;
        private string b33PS;
        private string b32PS;
        private string b31PS;
        private string b30PS;
        private string b29PS;
        private string b28PS;
        private string b27PS;
        private string b26PS;
        private string b25PS;
        // private string b##PS; // tab 2
        // private string b##PS; // tab 3

        public rmos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var popup = new cmdPopup();
            popup.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                try
                {
                    label28.Visible = true;
                    label28.Text = client.DownloadString("https://raw.githubusercontent.com/remona-minett/rm-os/master/rm-os%20gfx/rm-os%20gfx/ver.txt");
                }
                catch (Exception)
                {
                    label28.Visible = true;
                    label28.Text = "Unable to connect...";
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/remona-minett/rm-os/releases");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (b37PS != null) {
                try { Process.Start(b37PS); }
                catch (Exception)
                { 
                    // ignored
                }
            }
            else { PathTesting.PathAssign("1","1"); }
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                this.Width = 244;
                this.Height = 478;
            }
            if (tabControl1.SelectedIndex == 1)
            {
                this.Width = 244;
                this.Height = 333;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var lockCmd = new ProcessStartInfo("cmd.exe")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                Arguments = "/C rundll32.exe user32.dll,LockWorkStation"
            };
            try { Process.Start(lockCmd); }
            catch (Exception)
            {
                var popup = new errNotFound();
                popup.ShowDialog();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try { Process.Start("missing.exe"); }
            catch (Exception)
            {
                var popup = new errNotFound();
                popup.ShowDialog();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try { Process.Start("missing.exe"); }
            catch (Exception)
            {
                var popup = new errNotFound();
                popup.ShowDialog();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try { Process.Start("missing.exe"); }
            catch (Exception)
            {
                var popup = new errNotFound();
                popup.ShowDialog();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try { Process.Start("taskmgr.exe"); }
            catch (Exception)
            {
                var popup = new errNotFound();
                popup.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try { Process.Start("mspaint.exe"); }
            catch (Exception)
            {
                var popup = new errNotFound();
                popup.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { Process.Start("control.exe"); }
            catch (Exception)
            {
                var popup = new errNotFound();
                popup.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { Process.Start("notepad++.exe"); }
            catch (Exception)
            {
                var popup = new errNotFound();
                popup.ShowDialog();
            }
        }

        private void rmos_Load(object sender, EventArgs e)
        {
            b37PS = null; // tab 1, this resets all vars to null on reload
            b36PS = null;
            b35PS = null;
            b34PS = null;
            b33PS = null;
            b32PS = null;
            b31PS = null;
            b30PS = null;
            b29PS = null;
            b28PS = null;
            b27PS = null;
            b26PS = null;
            b25PS = null;
            reloadProgBar.Maximum = 13; // main page progress bar init
            reloadProgBar.Value = 0;
            reloadProgBar.Step = 1;
            // progressLabel.Text = "Progress:"
            var configFile = PathTesting.PathChk("1", "1");
            if (configFile != null) // label51 corresponds
            {
                var label51Text = configFile[2];
                b37PS = configFile[3];
                label51.Text = label51Text;
                button37.Text = "Start";
                reloadProgBar.PerformStep();
            }
            else
            {
                label51.Text = "(None)";
                button37.Text = "Assign";
                reloadProgBar.PerformStep();
            }
            configFile = PathTesting.PathChk("1", "2");
            if (configFile != null) // label46 corresponds
            {
                var label46Text = configFile[2];
                b36PS = configFile[3];
                label46.Text = label46Text;
                button36.Text = "Start";
                reloadProgBar.PerformStep();
            }
            else
            {
                label46.Text = "(None)";
                button36.Text = "Assign";
                reloadProgBar.PerformStep();
            }
            configFile = PathTesting.PathChk("1", "3");
            if (configFile != null) // label47 corresponds
            {
                var label47Text = configFile[2];
                b35PS = configFile[3];
                label47.Text = label47Text;
                button35.Text = "Start";
                reloadProgBar.PerformStep();
            }
            else
            {
                label47.Text = "(None)";
                button35.Text = "Assign";
                reloadProgBar.PerformStep();
            }
            configFile = PathTesting.PathChk("1", "4");
            if (configFile != null) // label48 corresponds
            {
                var label48Text = configFile[2];
                b34PS = configFile[3];
                label48.Text = label48Text;
                button34.Text = "Start";
                reloadProgBar.PerformStep();
            }
            else
            {
                label48.Text = "(None)";
                button34.Text = "Assign";
                reloadProgBar.PerformStep();
            }
            configFile = PathTesting.PathChk("1", "5");
            if (configFile != null) // label49 corresponds
            {
                var label49Text = configFile[2];
                b33PS = configFile[3];
                label49.Text = label49Text;
                button33.Text = "Start";
                reloadProgBar.PerformStep();
            }
            else
            {
                label49.Text = "(None)";
                button33.Text = "Assign";
                reloadProgBar.PerformStep();
            }
            configFile = PathTesting.PathChk("1", "6");
            if (configFile != null) // label50 corresponds
            {
                var label50Text = configFile[2];
                b32PS = configFile[3];
                label50.Text = label50Text;
                button32.Text = "Start";
                reloadProgBar.PerformStep();
            }
            else
            {
                label50.Text = "(None)";
                button32.Text = "Assign";
                reloadProgBar.PerformStep();
            }
            configFile = PathTesting.PathChk("1", "7");
            if (configFile != null) // label43 corresponds
            {
                var label43Text = configFile[2];
                b31PS = configFile[3];
                label43.Text = label43Text;
                button31.Text = "Start";
                reloadProgBar.PerformStep();
            }
            else
            {
                label43.Text = "(None)";
                button31.Text = "Assign";
                reloadProgBar.PerformStep();
            }
            configFile = PathTesting.PathChk("1", "8");
            if (configFile != null) // label44 corresponds
            {
                var label44Text = configFile[2];
                b30PS = configFile[3];
                label44.Text = label44Text;
                button30.Text = "Start";
                reloadProgBar.PerformStep();
            }
            else
            {
                label44.Text = "(None)";
                button30.Text = "Assign";
                reloadProgBar.PerformStep();
            }
            configFile = PathTesting.PathChk("1", "9");
            if (configFile != null) // label45 corresponds
            {
                var label45Text = configFile[2];
                b29PS = configFile[3];
                label45.Text = label45Text;
                button29.Text = "Start";
                reloadProgBar.PerformStep();
            }
            else
            {
                label45.Text = "(None)";
                button29.Text = "Assign";
                reloadProgBar.PerformStep();
            }
            configFile = PathTesting.PathChk("1", "10");
            if (configFile != null) // label42 corresponds
            {
                var label42Text = configFile[2];
                b28PS = configFile[3];
                label42.Text = label42Text;
                button28.Text = "Start";
                reloadProgBar.PerformStep();
            }
            else
            {
                label42.Text = "(None)";
                button28.Text = "Assign";
                reloadProgBar.PerformStep();
            }
            configFile = PathTesting.PathChk("1", "11");
            if (configFile != null) // label39 corresponds
            {
                var label39Text = configFile[2];
                b27PS = configFile[3];
                label39.Text = label39Text;
                button27.Text = "Start";
                reloadProgBar.PerformStep();
            }
            else
            {
                label39.Text = "(None)";
                button27.Text = "Assign";
                reloadProgBar.PerformStep();
            }
            configFile = PathTesting.PathChk("1", "12");
            if (configFile != null) // label40 corresponds
            {
                var label40Text = configFile[2];
                b26PS = configFile[3];
                label40.Text = label40Text;
                button26.Text = "Start";
                reloadProgBar.PerformStep();
            }
            else
            {
                label40.Text = "(None)";
                button26.Text = "Assign";
                reloadProgBar.PerformStep();
            }
            configFile = PathTesting.PathChk("1", "13");
            if (configFile != null) // label41 corresponds
            {
                var label41Text = configFile[2];
                b25PS = configFile[3];
                label41.Text = label41Text;
                button25.Text = "Start";
                reloadProgBar.PerformStep();
            }
            else
            {
                label41.Text = "(None)";
                button25.Text = "Assign";
                reloadProgBar.PerformStep();
            }
            // if (reloadProgBar.Value == 13) { progressLabel.Text = "Ready"; }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (b36PS != null)
            {
                try { Process.Start(b36PS); }
                catch (Exception)
                {
                    // ignored
                }
            }
            else { PathTesting.PathAssign("1", "2"); }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (b35PS != null)
            {
                try { Process.Start(b35PS); }
                catch (Exception)
                {
                    // ignored
                }
            }
            else { PathTesting.PathAssign("1", "3"); }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (b34PS != null)
            {
                try { Process.Start(b34PS); }
                catch (Exception)
                {
                    // ignored
                }
            }
            else { PathTesting.PathAssign("1", "4"); }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (b33PS != null)
            {
                try { Process.Start(b33PS); }
                catch (Exception)
                {
                    // ignored
                }
            }
            else { PathTesting.PathAssign("1", "5"); }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (b32PS != null)
            {
                try { Process.Start(b32PS); }
                catch (Exception)
                {
                    // ignored
                }
            }
            else { PathTesting.PathAssign("1", "6"); }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (b31PS != null)
            {
                try { Process.Start(b31PS); }
                catch (Exception)
                {
                    // ignored
                }
            }
            else { PathTesting.PathAssign("1", "6"); }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (b30PS != null)
            {
                try { Process.Start(b30PS); }
                catch (Exception)
                {
                    // ignored
                }
            }
            else { PathTesting.PathAssign("1", "7"); }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (b29PS != null)
            {
                try { Process.Start(b29PS); }
                catch (Exception)
                {
                    // ignored
                }
            }
            else { PathTesting.PathAssign("1", "8"); }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (b28PS != null)
            {
                try { Process.Start(b28PS); }
                catch (Exception)
                {
                    // ignored
                }
            }
            else { PathTesting.PathAssign("1", "9"); }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (b27PS != null)
            {
                try { Process.Start(b27PS); }
                catch (Exception)
                {
                    // ignored
                }
            }
            else { PathTesting.PathAssign("1", "10"); }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (b26PS != null)
            {
                try { Process.Start(b26PS); }
                catch (Exception)
                {
                    // ignored
                }
            }
            else { PathTesting.PathAssign("1", "11"); }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (b25PS != null)
            {
                try { Process.Start(b25PS); }
                catch (Exception)
                {
                    // ignored
                }
            }
            else { PathTesting.PathAssign("1", "12"); }
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            rmos_Load(null,null);
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            var DiscordLoc = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Discord");
            var discordCmd = new ProcessStartInfo("cmd.exe")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = DiscordLoc,
                Arguments = "/C Update.exe --processStart Discord.exe"
            };
            try { Process.Start(discordCmd); }
            catch(Exception)
            {
                var popup = new errNotFound();
                popup.ShowDialog();
            }
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "rm-os"));
            var rmosConfigDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "rm-os");
            try { Process.Start("explorer.exe", rmosConfigDir); }
            catch(Exception) { MessageBox.Show("Something went wrong. Please check folder access permissions.","Folder Location 404"); }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try { Process.Start("notepad.exe"); }
            catch (Exception)
            {
                var popup = new errNotFound();
                popup.ShowDialog();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try { Process.Start("calc.exe"); }
            catch (Exception)
            {
                var popup = new errNotFound();
                popup.ShowDialog();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cmdPopup popup = new cmdPopup();
            popup.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try { Process.Start("https://www.google.com"); }
            catch (Exception)
            {
                var popup = new errNotFound();
                popup.ShowDialog();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try { Process.Start("explorer.exe"); }
            catch (Exception)
            {
                var popup = new errNotFound();
                popup.ShowDialog();
            }
        }
    }
}