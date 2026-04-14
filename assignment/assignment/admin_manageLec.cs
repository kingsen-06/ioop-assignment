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
    public partial class admin_manageLec : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public admin_manageLec()
        {
            InitializeComponent();
        }

        private void admin_manageLec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void admin_manageLec_Load(object sender, EventArgs e)
        {
            loadLecturerData();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_menu adminMenu = new admin_menu();
            adminMenu.Show();
            this.Hide();
        }

        private void btnAddLec_Click(object sender, EventArgs e)
        {
            admin_addLec addLec = new admin_addLec();
            addLec.Show();
            this.Hide();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (lstLec.SelectedValue != null)
            {
                string selectedID = lstLec.SelectedValue.ToString();

                admin_lecDetail lecDetail = new admin_lecDetail(selectedID);
                lecDetail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a lecturer from the list first.");
            }
        }

        private void loadLecturerData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    string query = "select UserID, Name from Lecturer";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable lecturerTable = new DataTable();
                        adapter.Fill(lecturerTable);

                        lstLec.DataSource = lecturerTable;
                        lstLec.DisplayMember = "Name";
                        lstLec.ValueMember = "UserID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLec.SelectedValue == null)
            {
                MessageBox.Show("Please select a lecturer to remove");
                return;
            }

            string selectedID = lstLec.SelectedValue.ToString();
            string lecturerName = lstLec.Text;

            DialogResult confirm = MessageBox.Show($"Are you sure you want to remove {lecturerName}?\nThis action cannot be undone!", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        string query1 = "delete from Lecturer where UserID = @UserID";
                        using (SqlCommand command1 = new SqlCommand(query1, connection, transaction))
                        {
                            command1.Parameters.AddWithValue("@UserID", selectedID);
                            command1.ExecuteNonQuery();
                        }

                        string query2 = "delete from Users where UserID = @UserID";
                        using (SqlCommand command2 = new SqlCommand(query2, connection, transaction))
                        {
                            command2.Parameters.AddWithValue("UserID", selectedID);
                            command2.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        MessageBox.Show($"{lecturerName} has been successfully removed.");
                        loadLecturerData();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error removing lecturer: " + ex.Message);
                    }
                }
            }
        }
    }
}
