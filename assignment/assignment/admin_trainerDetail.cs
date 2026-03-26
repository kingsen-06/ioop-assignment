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
    public partial class admin_trainerDetail : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            admin_assignModule assignClass = new admin_assignModule(currentTrainerID);
            assignClass.Show();
            this.Hide();
        }

        private void loadTrainerProfile()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "select Name, Email, ContactNumber, Address from Trainer where UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", currentTrainerID);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblName.Text = reader["Name"].ToString();
                                lblEmail.Text = reader["Email"].ToString();
                                lblContact.Text = reader["ContactNumber"].ToString();
                                lblAddress.Text = reader["Address"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading profile: " + ex.Message);
                }
            }
        }

        private void loadTrainerModules()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "select ModuleName as 'Module Name', ClassLevel as 'Class Level' from TrainerModules where UserID = @UserID";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@UserID", currentTrainerID);

                        DataTable moduleTable = new DataTable();
                        adapter.Fill(moduleTable);

                        dataClass.DataSource = moduleTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading modules: " + ex.Message);
                }
            }
        }
    }
}
