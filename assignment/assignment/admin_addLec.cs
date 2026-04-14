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
    public partial class admin_addLec : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public admin_addLec()
        {
            InitializeComponent();
        }

        private void admin_addLec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_manageLec manageLec = new admin_manageLec();
            manageLec.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtName.Text.Trim();
            string dob = dateDOB.Value.ToString("yyyy-MM-dd");
            string email = txtEmail.Text.Trim();
            string contact = txtContact.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email format. (e.g. user@gmail.com)");
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
                            MessageBox.Show("This email is already registered to another user! Please use a different email.");
                            transaction.Rollback();
                            txtEmail.Focus();
                            return;
                        }
                    }

                    string defaultPassword = "lecturer123";
                    string generatedUserID = "";

                    string userQuery = @"insert into Users output inserted.UserID values (@email, @password, 'Lecturer')";
                    using (SqlCommand userCommand = new SqlCommand(userQuery, connection, transaction))
                    {
                        userCommand.Parameters.AddWithValue("@email", email);
                        userCommand.Parameters.AddWithValue("@password", defaultPassword);

                        generatedUserID = userCommand.ExecuteScalar().ToString();
                    }

                    string lecQuery = @"insert into Lecturer (UserID, Email, Name, DateOfBirth, ContactNumber, Address) values (@UserID, @email, @name, @DOB, @contact, @address)";
                    using (SqlCommand lecCommand = new SqlCommand(lecQuery, connection, transaction))
                    {
                        lecCommand.Parameters.AddWithValue("@UserID", generatedUserID);
                        lecCommand.Parameters.AddWithValue("@email", email);
                        lecCommand.Parameters.AddWithValue("@name", fullName);
                        lecCommand.Parameters.AddWithValue("@DOB", dob);
                        lecCommand.Parameters.AddWithValue("@contact", contact);
                        lecCommand.Parameters.AddWithValue("@address", address);

                        lecCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show($"Successfully registered Lecturer: {fullName}!\nTemporary password: {defaultPassword}");

                    admin_manageLec manageLec = new admin_manageLec();
                    manageLec.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error registering lecturer: " + ex.Message);
                }
            }
        }
    }
}
