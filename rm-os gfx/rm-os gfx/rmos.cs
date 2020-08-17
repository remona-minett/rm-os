using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;

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
            try { Process.Start("missing.exe"); }
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
            try { Process.Start("missing.exe"); }
            catch (Exception)
            {
                var popup = new errNotFound();
                popup.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try { Process.Start("missing.exe"); }
            catch (Exception)
            {
                var popup = new errNotFound();
                popup.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { Process.Start("missing.exe"); }
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
            var configFile = PathTesting.PathChk("1", "1");
            if (configFile != null) // label51 corresponds
            {
                var label51Text = configFile[2];
                b37PS = configFile[3];
                label51.Text = label51Text;
                button37.Text = "Start";
            }
            configFile = PathTesting.PathChk("1", "2");
            if (configFile != null) // label46 corresponds
            {
                var label46Text = configFile[2];
                b36PS = configFile[3];
                label46.Text = label46Text;
                button36.Text = "Start";
            }
            configFile = PathTesting.PathChk("1", "2");
            if (configFile != null) // label46 corresponds
            {
                var label47Text = configFile[2];
                b35PS = configFile[3];
                label47.Text = label47Text;
                button35.Text = "Start";
            }
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
    }
}
