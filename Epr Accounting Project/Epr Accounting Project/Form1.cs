using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epr_Accounting_Project
{
    public partial class Form1 : Form
    {
        bool sidebarExpand;
        bool HomeCollapse;
        public Form1()
        {
            InitializeComponent();
        }

        private void sidebarTimer_tick(object sender, EventArgs e)
        {
            if(sidebarExpand) 
            {
                sideBar.Width -= 10;
                if(sideBar.Width == sideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else 
            {
                sideBar.Width += 10;
                if (sideBar.Width == sideBar.MaximumSize.Width) 
                {
                    sidebarExpand = true; 
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void homeMenu_Tick(object sender, EventArgs e)
        {
            if(HomeCollapse) 
            {
                homeClose.Height += 10;
                if(homeClose.Height == homeClose.MaximumSize.Height) 
                {
                    HomeCollapse = false;
                    homeMenu.Stop();
                }
            }
            else 
            {
                homeClose.Height -= 10;
                if (homeClose.Height == homeClose.MinimumSize.Height)
                {
                    HomeCollapse = true;
                    homeMenu.Stop();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homeMenu.Start();
        }
    }
}
