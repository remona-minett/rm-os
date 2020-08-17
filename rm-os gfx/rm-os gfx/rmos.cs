using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace rm_os_gfx
{
    public partial class rmos : Form
    {
        public string configFile;

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

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {
            configFile = PathCheck.PathChk("1","1"); // if (configured) x else if (unconfigured) y?
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

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            try { Process.Start("missing.exe"); }
            catch (Exception)
            {
                errNotFound popup = new errNotFound();
                DialogResult dialogresult = popup.ShowDialog();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try { Process.Start("missing.exe"); }
            catch (Exception)
            {
                errNotFound popup = new errNotFound();
                DialogResult dialogresult = popup.ShowDialog();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try { Process.Start("missing.exe"); }
            catch (Exception)
            {
                errNotFound popup = new errNotFound();
                DialogResult dialogresult = popup.ShowDialog();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try { Process.Start("missing.exe"); }
            catch (Exception)
            {
                errNotFound popup = new errNotFound();
                DialogResult dialogresult = popup.ShowDialog();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try { Process.Start("missing.exe"); }
            catch (Exception)
            {
                errNotFound popup = new errNotFound();
                DialogResult dialogresult = popup.ShowDialog();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try { Process.Start("missing.exe"); }
            catch (Exception)
            {
                errNotFound popup = new errNotFound();
                DialogResult dialogresult = popup.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { Process.Start("missing.exe"); }
            catch (Exception)
            {
                errNotFound popup = new errNotFound();
                DialogResult dialogresult = popup.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { Process.Start("notepad++.exe"); }
            catch (Exception)
            {
                errNotFound popup = new errNotFound();
                DialogResult dialogresult = popup.ShowDialog();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
