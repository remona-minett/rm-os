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
using System.Net;

namespace rm_os_wfa_test
{
    public partial class rmos : Form
    {
        public rmos()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmdPopup popup = new cmdPopup();
            DialogResult dialogresult = popup.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
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

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/remona-minett/rm-os/releases");
        }
    }
}
