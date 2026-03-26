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
    public partial class admin_monthChoice : Form
    {
        string currentTrainerID;

        public admin_monthChoice(string selectedID)
        {
            InitializeComponent();

            currentTrainerID = selectedID;
        }

        private void admin_monthChoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_manageTrainer manageTrainer = new admin_manageTrainer();
            manageTrainer.Show();
            this.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string selectedMonth = lstMonth.SelectedValue.ToString();

            admin_incomeReport reportPage = new admin_incomeReport(currentTrainerID, selectedMonth);
            reportPage.Show();
            this.Close();
        }
    }
}
