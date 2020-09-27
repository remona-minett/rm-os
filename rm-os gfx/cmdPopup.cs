using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace rm_os_gfx
{
    public partial class cmdPopup : Form
    {
        public cmdPopup()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var userlandCmd = new ProcessStartInfo("cmd.exe")
            {
                WorkingDirectory = "C:"
            };
            Process.Start(userlandCmd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var elevatedCmd = new ProcessStartInfo("cmd.exe")
            {
                UseShellExecute = true,
                Verb = "runas"
            };
            try { Process.Start(elevatedCmd); }
            catch (Exception) { /* ignored */ }
        }
    }
}
