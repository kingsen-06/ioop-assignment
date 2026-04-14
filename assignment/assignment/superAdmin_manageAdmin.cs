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
    public partial class superAdmin_manageAdmin : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public superAdmin_manageAdmin()
        {
            InitializeComponent();
        }

        private void superAdmin_manageAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void superAdmin_manageAdmin_Load(object sender, EventArgs e)
        {
            loadAdminList();
        }

        private void loadAdminList()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "select Name, Email from Admin";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dtAdmins = new DataTable();
                        adapter.Fill(dtAdmins);

                        lstAdmin.DataSource = dtAdmins;

                        lstAdmin.DisplayMember = "Name";
                        lstAdmin.ValueMember = "Email";
                        lstAdmin.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Admin list: " + ex.Message);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            superAdmin_addAdmin addAdmin = new superAdmin_addAdmin();
            addAdmin.Show();
            this.Hide();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstAdmin.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Admin to remove.");
                return;
            }

            string selectedEmail = lstAdmin.SelectedValue.ToString();
            string selectedName = lstAdmin.Text;

            if (selectedEmail == User.CurrentUser.Email)
            {
                MessageBox.Show("You cannot delete your own account!");
                return;
            }

            DialogResult confirm = MessageBox.Show($"Are you sure you want to permanently delete {selectedName}'s account?\nThis action cannot be undone!", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        string deleteAdmin = "delete from Admin where Email = @email";
                        using (SqlCommand cmdAdmin = new SqlCommand(deleteAdmin, connection, transaction))
                        {
                            cmdAdmin.Parameters.AddWithValue("@email", selectedEmail);

                            cmdAdmin.ExecuteNonQuery();
                        }

                        string deleteUser = "delete from Users where Email = @email";
                        using (SqlCommand cmdUser = new SqlCommand(deleteUser, connection, transaction))
                        {
                            cmdUser.Parameters.AddWithValue("@email", selectedEmail);

                            cmdUser.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show($"{selectedName} has been successfully removed.");

                        loadAdminList();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error removing Admin: " + ex.Message);
                    }
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (lstAdmin.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Admin to view.");
                return;
            }

            string selectedEmail = lstAdmin.SelectedValue.ToString();

            superAdmin_adminDetail viewPage = new superAdmin_adminDetail(selectedEmail);
            viewPage.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            superAdmin_menu superMenu = new superAdmin_menu();
            superMenu.Show();
            this.Hide();
        }
    }
}
