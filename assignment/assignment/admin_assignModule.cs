using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class admin_assignModule : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string currentTrainerID;

        public admin_assignModule(string selectedID)
        {
            InitializeComponent();

            currentTrainerID = selectedID;
        }

        private void admin_assignModule_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_trainerDetail trainerDetail = new admin_trainerDetail(currentTrainerID);
            trainerDetail.Show();
            this.Hide();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbModule.Text))
            {
                MessageBox.Show("Module Name cannot be empty!");
                return;
            }

            string selectedModuleID = cmbModule.SelectedValue.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkQuery = "select count(*) from TrainerAssignedModules where UserID = @UserID and ModuleID = @ModuleID";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@UserID", currentTrainerID);
                        checkCommand.Parameters.AddWithValue("@ModuleID", selectedModuleID);

                        int existingCount = (int)checkCommand.ExecuteScalar();

                        if (existingCount > 0)
                        {
                            MessageBox.Show("This trainer is already assigned to this module!");
                            return;
                        }
                    }

                    string insertQuery = @"insert into TrainerAssignedModules (UserID, ModuleID) values (@UserID, @Module)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", currentTrainerID);
                        command.Parameters.AddWithValue("@Module", cmbModule.SelectedValue.ToString());

                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Module successfully assigned!");

                    admin_trainerDetail trainerDetail = new admin_trainerDetail(currentTrainerID);
                    trainerDetail.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error assigning module: " + ex.Message);
                }
            }
        }

        private void admin_assignModule_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "select ModuleID, ModuleName, ClassLevel from Modules";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable Modules = new DataTable();
                        adapter.Fill(Modules);

                        cmbModule.DataSource = Modules;
                        cmbModule.DisplayMember = "ModuleName";
                        cmbModule.ValueMember = "ModuleID";

                        cmbModule.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading modules: " + ex.Message);
                }
            }
        }

        private void cmbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModule.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)cmbModule.SelectedItem;

                lblLevel.Text = selectedRow["ClassLevel"].ToString();
            }
            else
            {
                lblLevel.Text = "";
            }
        }
    }
}
