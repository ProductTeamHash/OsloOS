using Microsoft.TeamFoundation.Common.Internal;
using OsloOS.Home_And_Integrated_Apps;
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
using Xamarin.Essentials;

namespace OsloOS
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        public Process Calculatoropen()
        {
            Process calc = Process.Start("calc.exe");

            return null;
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            //shows background layer to hide loading between apps
            var background = new background();
            background.Show();

            Process calc = (Process.Start("calc.exe"));

            calc.WaitForInputIdle();
            NativeMethods.SetParent(calc.MainWindowHandle, this.Handle);

            Icon ico = Icon.ExtractAssociatedIcon(calc.MainModule.FileName);
            Bitmap bmp = ico.ToBitmap();
            button_WOC1.BackgroundImage = bmp;
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

        public void button_WOC1_Click(object sender, EventArgs e)
        {
            ActiveForm.TopMost = false;
            Process calc = Process.Start("calc.exe");
        }
    }
}
