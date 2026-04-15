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
    public partial class admin_assignTrainer : Form
    {
        TrainerManager trainerManager = new TrainerManager();
        string currentTrainerID;

        public admin_assignTrainer(string selectedID)
        {
            InitializeComponent();
            currentTrainerID = selectedID;
        }

        private void admin_assignModule_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void admin_assignModule_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable modules = trainerManager.getModules();
                cmbModule.DataSource = modules;
                cmbModule.DisplayMember = "ModuleName";
                cmbModule.ValueMember = "ModuleID";
                cmbModule.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading modules: " + ex.Message);
            }
        }

        private void cmbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModule.SelectedItem != null && cmbModule.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)cmbModule.SelectedItem;

                lblLevel.Text = selectedRow["ClassLevel"].ToString();
            }
            else
            {
                lblLevel.Text = "";
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cmbModule.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid module.");
                return;
            }

            string selectedModuleID = cmbModule.SelectedValue.ToString();

            string result = trainerManager.assignModuleToTrainer(currentTrainerID, selectedModuleID);

            if (result == "Success")
            {
                MessageBox.Show("Module successfully assigned!");
                lblBack_Click(null, null);
            }
            else if (result == "Exists")
            {
                MessageBox.Show("This trainer is already assigned to this module!");
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_trainerDetail trainerDetail = new admin_trainerDetail(currentTrainerID);
            trainerDetail.Show();
            this.Hide();
        }
    }
}
