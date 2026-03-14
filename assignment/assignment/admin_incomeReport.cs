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
    public partial class admin_incomeReport : Form
    {
        public admin_incomeReport()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_monthChoice monthChoice = new admin_monthChoice();
            monthChoice.Show();
            this.Hide();
        }
    }
}
