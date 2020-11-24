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
    public partial class MainMenu___PullDownMenu : Form
    {
        public MainMenu___PullDownMenu()
        {
            InitializeComponent();
        }

        private void MainMenu___PullDownMenu_Load(object sender, EventArgs e)
        {

        }

        private void SwipeDownMenuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pulldownexit = new MainMenu();
            pulldownexit.Show();
        }

        private void SwipeDownMenuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pulldownexit = new MainMenu();
            pulldownexit.Show();
        }
    }
}
