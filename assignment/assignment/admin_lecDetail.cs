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
    public partial class admin_lecDetail : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string currentLecturerID;

        public admin_lecDetail(string selectedID)
        {
            InitializeComponent();

            currentLecturerID = selectedID;
        }

        private void admin_lecDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void admin_lecDetail_Load(object sender, EventArgs e)
        {
            loadLecturerProfile();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_manageLec managePage = new admin_manageLec();
            managePage.Show();
            this.Hide();
        }

        private void loadLecturerProfile()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "select Name, DateOfBirth, Email, ContactNumber, Address from Lecturer where UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", currentLecturerID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblName.Text = reader["Name"].ToString();
                                lblEmail.Text = reader["Email"].ToString();
                                lblContact.Text = reader["ContactNumber"].ToString();
                                lblAddress.Text = reader["Address"].ToString();

                                DateTime dob = Convert.ToDateTime(reader["DateOfBirth"]);
                                lblDOB.Text = dob.ToString("dd MMM yyyy");
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
    }
}
