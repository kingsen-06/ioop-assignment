using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace assignment
{
    public partial class share_updateProfile : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string roleTable = "";

        public share_updateProfile()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '*';
        }

        public void share_updateProfile_Load(object sender, EventArgs e)
        {
            string role = User.CurrentUser.Role;
            string currentEmail = User.CurrentUser.Email;

            if (role == "Admin" || role == "Super Admin")
            {
                roleTable = "Admin";
            }
            else if (role == "Trainer")
            {
                roleTable = "Trainer";
            }
            else if (role == "Lecturer")
            {
                roleTable = "Lecturer";
            }
            else if (role == "Student")
            {
                roleTable = "Student";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = $"""
                        select u.Password, r.Name, r.ContactNumber, r.Address 
                        from Users u 
                        inner join {roleTable} r on u.Email = r.Email 
                        where u.Email = @email
                        """;

                    using (SqlCommand cmdRole = new SqlCommand(query, connection))
                    {
                        cmdRole.Parameters.AddWithValue("@email", currentEmail);

                        using (SqlDataReader reader = cmdRole.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtEmail.Text = currentEmail;
                                txtName.Text = reader["Name"].ToString();
                                txtPassword.Text = reader["Password"].ToString();
                                txtContact.Text = reader["ContactNumber"].ToString();
                                txtAddress.Text = reader["Address"].ToString();
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                btnShow.Text = "Hide";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnShow.Text = "Show";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string oldEmail = User.CurrentUser.Email;
            string newEmail = txtEmail.Text.Trim();
            string newName = txtName.Text.Trim();
            string newPassword = txtPassword.Text;
            string newContact = txtContact.Text.Trim();
            string newAddress = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(newEmail) || string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(newEmail, emailPattern))
            {
                MessageBox.Show("Please enter a valid email format. (e.g. user@mail.apu.edu.my)");
                return;
            }

            string contactPattern = @"^01\d-\d{7,8}$";
            if (!Regex.IsMatch(newContact, contactPattern))
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
                    string updateRole = $"update {roleTable} set Email = @newEmail, Name = @name, ContactNumber = @contact, Address = @address where Email = @oldEmail";
                    using (SqlCommand cmdRole = new SqlCommand(updateRole, connection, transaction))
                    {
                        cmdRole.Parameters.AddWithValue("@newEmail", newEmail);
                        cmdRole.Parameters.AddWithValue("@name", newName);
                        cmdRole.Parameters.AddWithValue("@contact", newContact);
                        cmdRole.Parameters.AddWithValue("@address", newAddress);
                        cmdRole.Parameters.AddWithValue("@oldEmail", oldEmail);

                        cmdRole.ExecuteNonQuery();
                    }

                    string updateUsers = "update Users set Email = @newEmail, Password = @password where Email = @oldEmail";
                    using (SqlCommand cmdUsers = new SqlCommand(updateUsers, connection, transaction))
                    {
                        cmdUsers.Parameters.AddWithValue("@newEmail", newEmail);
                        cmdUsers.Parameters.AddWithValue("@password", newPassword);
                        cmdUsers.Parameters.AddWithValue("@oldEmail", oldEmail);

                        cmdUsers.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    User.CurrentUser.Email = newEmail;

                    MessageBox.Show("Profile updated successfully!");

                    string role = User.CurrentUser.Role;

                    if (role == "Super Admin")
                    {
                        new superAdmin_menu().Show();
                    }
                    else if (role == "Admin")
                    {
                        new admin_menu().Show();
                    }
                    else if (role == "Lecturer")
                    {
                        new lec_menu().Show();
                    }
                    else if (role == "Student")
                    {
                        new student_menu().Show();
                    }
                    else if (role == "Trainer")
                    {
                        new trainer_menu().Show();
                    }

                    this.Hide();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error updating profile: " + ex.Message);
                }
            }
        }

        private void share_updateProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            string role = User.CurrentUser.Role;

            if (role == "Super Admin")
            {
                new superAdmin_menu().Show();
            }
            else if (role == "Admin")
            {
                new admin_menu().Show();
            }
            else if (role == "Lecturer")
            {
                new lec_menu().Show();
            }
            else if (role == "Student")
            {
                new student_menu().Show();
            }
            else if (role == "Trainer")
            {
                new trainer_menu().Show();
            }

            this.Hide();
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you  sure you want to delete your account?\nThis action cannot be undone!", "Confirm Account Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        string email = User.CurrentUser.Email;

                        if (roleTable == "Student")
                        {
                            string stuID = "";

                            string studentQuery = "select StuID from Student where Email = @email";
                            using (SqlCommand getStuCmd = new SqlCommand(studentQuery, connection, transaction))
                            {
                                getStuCmd.Parameters.AddWithValue("@email", email);

                                stuID = getStuCmd.ExecuteScalar()?.ToString();
                            }

                            if (!string.IsNullOrEmpty(stuID))
                            {
                                string deleteStudentClassQuery = $"delete from StudentClass where StuID = '{stuID}'";
                                using (SqlCommand deleteStudentClassCmd = new SqlCommand(deleteStudentClassQuery, connection, transaction))
                                {
                                    deleteStudentClassCmd.ExecuteNonQuery();
                                }

                                string deleteStudentPaymentQuery = $"delete from StudentPayment where StuID = '{stuID}'";
                                using (SqlCommand deleteStudentPaymentCmd = new SqlCommand(deleteStudentPaymentQuery, connection, transaction))
                                {
                                    deleteStudentPaymentCmd.ExecuteNonQuery();
                                }

                                string deleteClassRequestQuery = $"delete from ClassRequest where StuID = '{stuID}'";
                                using (SqlCommand deleteClassRequestCmd = new SqlCommand(deleteClassRequestQuery, connection, transaction))
                                {
                                    deleteClassRequestCmd.ExecuteNonQuery();
                                }
                            }
                        }

                        string deleteRole = $"delete from {roleTable} where Email = @email";
                        using (SqlCommand cmdRole = new SqlCommand(deleteRole, connection, transaction))
                        {
                            cmdRole.Parameters.AddWithValue("@email", email);

                            cmdRole.ExecuteNonQuery();
                        }

                        string deleteUser = "delete from Users where Email = @email";
                        using (SqlCommand cmdUser = new SqlCommand(deleteUser, connection, transaction))
                        {
                            cmdUser.Parameters.AddWithValue("@email", email);

                            cmdUser.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show("Your account has been successfully deleted.");

                        main_loginPage loginPage = new main_loginPage();
                        loginPage.Show();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error deleting account: " + ex.Message);
                    }
                }
            }
        }
    }
}
