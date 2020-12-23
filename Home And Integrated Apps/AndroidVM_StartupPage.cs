using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OsloOS.Home_And_Integrated_Apps
{
    public partial class AndroidVM_StartupPage : Form
    {
        public AndroidVM_StartupPage()
        {
            InitializeComponent();
        }

        private void AndroidVM_StartupPage_Load(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path1 = "C:/Program Files/OsloOS/";
            string path2 = "TEMP2";

            if (File.Exists(path1))
            {
                if (File.Exists(path2))
                {
                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "cmd.exe";
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.Arguments = "/C \"C:/Program Files/Oracle/VirtualBox/VBoxManage.exe\" --nologo startvm PheonixOS_OsloOS";
                    process.StartInfo = startInfo;
                    ActiveForm.TopMost = false;
                    process.Start();
                }
            }
        }
    }
}
