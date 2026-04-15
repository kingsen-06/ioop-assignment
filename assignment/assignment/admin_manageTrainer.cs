using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class admin_manageTrainer : Form
    {
        TrainerManager trainerManager = new TrainerManager();

        public admin_manageTrainer()
        {
            InitializeComponent();
        }

        private void amind_manageTrainer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void admin_manageTrainer_Load(object sender, EventArgs e)
        {
            loadTrainerData();
        }

        private void loadTrainerData()
        {
            try
            {
                DataTable trainerTable = trainerManager.getAllTrainers();
                lstTrainer.DataSource = trainerTable;
                lstTrainer.DisplayMember = "Name";
                lstTrainer.ValueMember = "UserID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }   

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            admin_addTrainer registerTrainer = new admin_addTrainer();
            registerTrainer.Show();
            this.Hide();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            if (lstTrainer.SelectedValue != null)
            {
                string selectedID = lstTrainer.SelectedValue.ToString();

                admin_monthChoice monthChoice = new admin_monthChoice(selectedID);
                monthChoice.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a trainer from the list first.");
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (lstTrainer.SelectedValue != null)
            {
                string selectedID = lstTrainer.SelectedValue.ToString();

                admin_trainerDetail trainerDetail = new admin_trainerDetail(selectedID);
                trainerDetail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a trainer from the list first.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstTrainer.SelectedValue == null)
            {
                MessageBox.Show("Please select a trainer from the list to remove.");
                return;
            }

            string selectedID = lstTrainer.SelectedValue.ToString();
            string trainerName = lstTrainer.Text;

            DialogResult confirm = MessageBox.Show($"Are you sure you want to remove {trainerName}?\nThis action cannot be undone!", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bool isSuccess = trainerManager.deleteTrainer(selectedID);

                if (isSuccess)
                {
                    MessageBox.Show($"{trainerName} has been successfully removed.");
                    loadTrainerData();
                }
                else
                {
                    MessageBox.Show("Error removing trainer from the database.");
                }
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            if (User.CurrentUser.Role == "Super Admin")
            {
                superAdmin_menu superAdminMenu = new superAdmin_menu();
                superAdminMenu.Show();
            }
            else
            {
                admin_menu adminMenu = new admin_menu();
                adminMenu.Show();
            }

            this.Hide();
        }
    }
}
