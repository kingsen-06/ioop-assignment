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
    public partial class admin_manageTrainer : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

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

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_menu adminMenu = new admin_menu();
            adminMenu.Show();
            this.Hide();
        }

        private void loadTrainerData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "select UserID, Name from Trainer";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable trainerTable = new DataTable();
                        adapter.Fill(trainerTable);

                        lstTrainer.DataSource = trainerTable;
                        lstTrainer.DisplayMember = "Name";
                        lstTrainer.ValueMember = "UserID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
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

            DialogResult confirm = MessageBox.Show($"Are you sure you want to remove {trainerName}?\nThis action cannot be redone!", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        string query1 = "delete from TrainerAssignedModules where UserID = @UserID";
                        using (SqlCommand command1 = new SqlCommand(query1, connection, transaction))
                        {
                            command1.Parameters.AddWithValue("@UserID", selectedID);
                            command1.ExecuteNonQuery();
                        }

                        string query2 = "delete from Trainer where UserID = @UserID";
                        using (SqlCommand command2 = new SqlCommand(query2 , connection, transaction))
                        {
                            command2.Parameters.AddWithValue("@UserID", selectedID);
                            command2.ExecuteNonQuery();
                        }

                        string query3 = "delete from Users where UserID = @UserID";
                        using (SqlCommand command3 = new SqlCommand(query3, connection, transaction))
                        {
                            command3.Parameters.AddWithValue("@UserID", selectedID);
                            command3.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show($"{trainerName} has been successfully removed.");

                        loadTrainerData();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error removing trainer: " + ex.Message);
                    }
                }
            }
        }
    }
}
