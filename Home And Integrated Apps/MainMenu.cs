using OsloOS.Home_And_Integrated_Apps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsloOS
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //shows background layer to hide loading between apps
            var background = new background();
            background.Show();
        }

        private void SwipeDownMenuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var pulldown1 = new MainMenu___PullDownMenu();
            pulldown1.Show();
        }

        private void SwipeDownMenuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new MainMenu___PullDownMenu();
            form2.Show();
        }
    }
}
