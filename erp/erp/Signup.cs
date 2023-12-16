using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erp
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void signUpPage_Click(object sender, EventArgs e)
        {
            Dashborad dashborad = new Dashborad();
            dashborad.Show();
            this.Hide();
        }
    }
}
