using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsloOS.Home_And_Integrated_Apps
{
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneralPanel.Height = 1620;
            GeneralPanel.Width = 1084;

            WallpaperPanel.Height = 0;
            WallpaperPanel.Width = 0;

            UpdatePanel.Height = 0;
            UpdatePanel.Width = 0;

            AboutPanel.Height = 0;
            AboutPanel.Width = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GeneralPanel.Height = 0;
            GeneralPanel.Width = 0;

            WallpaperPanel.Height = 1620;
            WallpaperPanel.Width = 1084;

            UpdatePanel.Height = 0;
            UpdatePanel.Width = 0;

            AboutPanel.Height = 0;
            AboutPanel.Width = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GeneralPanel.Height = 0;
            GeneralPanel.Width = 0;

            WallpaperPanel.Height = 0;
            WallpaperPanel.Width = 0;

            UpdatePanel.Height = 1620;
            UpdatePanel.Width = 1084;

            AboutPanel.Height = 0;
            AboutPanel.Width = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GeneralPanel.Height = 0;
            GeneralPanel.Width = 0;

            WallpaperPanel.Height = 0;
            WallpaperPanel.Width = 0;

            UpdatePanel.Height = 0;
            UpdatePanel.Width = 0;

            AboutPanel.Height = 1620;
            AboutPanel.Width = 1084;
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }
    }
}
