using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace rm_os_wfa_test
{
    public partial class cmdPopup : Form
    {
        public cmdPopup()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo userlandCmd = new ProcessStartInfo("cmd.exe")
            {
                WorkingDirectory = "C:"
            };
            Process.Start(userlandCmd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo elevatedCmd = new ProcessStartInfo("cmd.exe")
            {
                UseShellExecute = true,
                Verb = "runas"
            };
            try { Process.Start(elevatedCmd); }
            catch (Exception) { }
        }
    }
}
