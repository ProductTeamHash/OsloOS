﻿using Microsoft.TeamFoundation.Common.Internal;
using OsloOS.Home_And_Integrated_Apps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xamarin.Essentials;

namespace OsloOS
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        //string[] getdesktop = Directory.GetFiles(@"%desktop%", "*.lnk");

        private void MainMenu_Load(object sender, EventArgs e)
        {
           
                
        
        
            //shows background layer to hide loading between apps
            var background = new background();
            background.Show();
            {
                //var getdesktopcoverted = getdesktop.Select(Int32.Parse).ToList();

                //Process calc = Process.Start(getdesktopcoverted);
                //calc.WaitForInputIdle();
                //NativeMethods.SetParent(calc.MainWindowHandle, this.Handle);

                //Icon ico = Icon.ExtractAssociatedIcon(calc.MainModule.FileName);
                //Bitmap bmp = ico.ToBitmap();
                //button_WOC1.BackgroundImage = bmp;
            }
        }

        private void SwipeDownMenuButton1_Click(object sender, EventArgs e)
        {
            ActiveForm.TopMost = false;
            var pulldown1 = new PullDown();
            pulldown1.Show();
        }

        private void SwipeDownMenuButton2_Click(object sender, EventArgs e)
        {
            ActiveForm.TopMost = false;
            var form2 = new PullDown();
            form2.Show();
        }

        private void Button_WOC2_Click(object sender, EventArgs e)
        {
            //saving for new page system for vm

            //Process process = new Process();
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.FileName = "cmd.exe";
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //startInfo.Arguments = "/C \"C:/Program Files/Oracle/VirtualBox/VBoxManage.exe\" --nologo startvm PheonixOS_OsloOS";
            //process.StartInfo = startInfo;
            //ActiveForm.TopMost = false;
            //process.Start();

            ActiveForm.TopMost = false;
            var form2 = new AndroidVM_StartupPage();
            form2.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC10_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC3_Click(object sender, EventArgs e)
        {
            ActiveForm.TopMost = false;
            var form2 = new SettingsPage();
            form2.Show();
        }

        private void button_WOC4_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC8_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC7_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC9_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC6_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC5_Click(object sender, EventArgs e)
        {

        }
    }
}
