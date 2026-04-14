using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class superAdmin_addAdmin : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public superAdmin_addAdmin()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            superAdmin_manageAdmin managePage = new superAdmin_manageAdmin();
            managePage.Show();
            this.Hide();
        }

        private void superAdmin_addAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string contact = txtContact.Text.Trim();
            string address = txtAddress.Text.Trim();

            string defaultPassword = "Admin@123";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email format. (e.g. user@mail.apu.edu.my)");
                return;
            }

            string contactPattern = @"^01\d-\d{7,8}$";
            if (!Regex.IsMatch(contact, contactPattern))
            {
                MessageBox.Show("Please enter a valid contact number format. (e.g. 012-3456789)");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string checkEmail = "select count(*) from Users where Email = @email";
                    using (SqlCommand cmdCheck = new SqlCommand(checkEmail, connection, transaction))
                    {
                        cmdCheck.Parameters.AddWithValue("@email", email);

                        int exists = int.Parse(cmdCheck.ExecuteScalar().ToString());
                        if (exists > 0)
                        {
                            MessageBox.Show("This email is already registered to another user.");
                            transaction.Rollback();
                            return;
                        }
                    }

                    string insertUser = "insert into Users (Email, Password, Role) values (@email, @password, 'Admin')";
                    using (SqlCommand cmdUser = new SqlCommand(insertUser, connection, transaction))
                    {
                        cmdUser.Parameters.AddWithValue("@email", email);
                        cmdUser.Parameters.AddWithValue("@password", defaultPassword);

                        cmdUser.ExecuteNonQuery();
                    }

                    string fetchedUserID = "";

                    string getUserID = "select UserID from Users where Email = @email";
                    using (SqlCommand cmdGetID = new SqlCommand(getUserID, connection, transaction))
                    {
                        cmdGetID.Parameters.AddWithValue("@email", email);

                        fetchedUserID = cmdGetID.ExecuteScalar()?.ToString();
                    }

                    string insertAdmin = "insert into Admin (UserID, Name, Email, ContactNumber, Address) values (@userID, @name, @email, @contact, @address)";
                    using (SqlCommand cmdAdmin = new SqlCommand(insertAdmin, connection, transaction))
                    {
                        cmdAdmin.Parameters.AddWithValue("@userID", fetchedUserID);
                        cmdAdmin.Parameters.AddWithValue("@name", name);
                        cmdAdmin.Parameters.AddWithValue("@email", email);
                        cmdAdmin.Parameters.AddWithValue("@contact", contact);
                        cmdAdmin.Parameters.AddWithValue("@address", address);

                        cmdAdmin.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show($"New Admin successfully registered!\nTheir temporary password is: {defaultPassword}");

                    txtName.Clear();
                    txtEmail.Clear();
                    txtContact.Clear();
                    txtAddress.Clear();
                    txtName.Focus();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred while creating the Admin account: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
