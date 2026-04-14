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
    public partial class superAdmin_adminDetail : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string selectedEmail = "";

        public superAdmin_adminDetail(string email)
        {
            InitializeComponent();
            selectedEmail = email;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            superAdmin_manageAdmin managePage = new superAdmin_manageAdmin();
            managePage.Show();
            this.Hide();
        }

        private void superAdmin_adminDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void superAdmin_adminDetail_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "select Name, Email, ContactNumber, Address from Admin where Email = @email";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@email", selectedEmail);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblName.Text = reader["Name"].ToString();
                                lblEmail.Text = reader["Email"].ToString();
                                lblContact.Text = reader["ContactNumber"].ToString();
                                lblAddress.Text = reader["Address"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Admin details not found in the database.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }
    }
}
