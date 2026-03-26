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
            if (string.IsNullOrEmpty(cmbLevel.Text))
            {
                MessageBox.Show("Class Level cannot be empty!");
                return;
            }

            if (string.IsNullOrEmpty(cmbModule.Text))
            {
                MessageBox.Show("Module Name cannot be empty!");
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"insert into TrainerAssignedModules values (@UserID, @Module, @Level)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", currentTrainerID);
                        command.Parameters.AddWithValue("@Module", cmbModule.Text);
                        command.Parameters.AddWithValue("@Level", cmbLevel.Text);

                        connection.Open();
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
    }
}
