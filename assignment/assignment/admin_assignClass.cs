using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class admin_assignClass : Form
    {
        public admin_assignClass()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_trainerDetail trainerDetail = new admin_trainerDetail();
            trainerDetail.Show();
            this.Hide();
        }
    }
}
