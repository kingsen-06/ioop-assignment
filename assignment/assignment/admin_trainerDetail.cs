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
    public partial class admin_trainerDetail : Form
    {
        TrainerManager trainerManager = new TrainerManager();
        string currentTrainerID;

        public admin_trainerDetail(string selectedID)
        {
            InitializeComponent();
            currentTrainerID = selectedID;
        }

        private void admin_trainerDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void admin_trainerDetail_Load(object sender, EventArgs e)
        {
            loadTrainerProfile();
            loadTrainerModules();
        }

        private void loadTrainerProfile()
        {
            try
            {
                User trainerDetails = trainerManager.getTrainerDetails(currentTrainerID);

                if (trainerDetails != null)
                {
                    lblName.Text = trainerDetails.Name;
                    lblEmail.Text = trainerDetails.Email;
                    lblContact.Text = trainerDetails.ContactNumber;
                    lblAddress.Text = trainerDetails.Address;
                    lblDOB.Text = trainerDetails.DOB;
                }
                else
                {
                    MessageBox.Show("Trainer details not found in database");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void loadTrainerModules()
        {
            try
            {
                DataTable trainerModules = new DataTable();
                dataClass.DataSource = trainerModules;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading modules: " + ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            admin_assignTrainer assignClass = new admin_assignTrainer(currentTrainerID);
            assignClass.Show();
            this.Hide();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataClass.CurrentRow != null && dataClass.CurrentRow.Index != -1)
            {
                string selectedModuleID = dataClass.CurrentRow.Cells["ModuleID"].Value.ToString();
                string selectedModuleName = dataClass.CurrentRow.Cells["Module Name"].Value.ToString();

                DialogResult confirm = MessageBox.Show($"Are you sure you want to remove '{selectedModuleName}' from this trainer?\nThis action cannot be undone!", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    bool isSuccess = trainerManager.removeTrainerModule(currentTrainerID, selectedModuleID);

                    if (isSuccess)
                    {
                        MessageBox.Show($"{selectedModuleName} has been successfully removed.");
                        loadTrainerModules();
                    }
                    else
                    {
                        MessageBox.Show("Error removing module from the database.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a module from the list to remove.");
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_manageTrainer managePage = new admin_manageTrainer();
            managePage.Show();
            this.Hide();
        }
    }
}
