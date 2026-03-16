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
    public partial class admin_manageTrainer : Form
    {
        public admin_manageTrainer()
        {
            InitializeComponent();
        }

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            admin_addTrainer registerTrainer = new admin_addTrainer();
            registerTrainer.Show();
            this.Hide();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            admin_monthChoice monthChoice = new admin_monthChoice();
            monthChoice.Show();
            this.Hide();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            admin_trainerDetail trainerDetail = new admin_trainerDetail();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_menu adminMenu = new admin_menu();
            adminMenu.Show();
            this.Show();
        }
    }
}
