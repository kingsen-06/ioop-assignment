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
    public partial class student_registerPage : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public student_registerPage()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
        }

        private void btnShowPw_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                btnShowPw.Text = "Hide";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnShowPw.Text = "Show";
            }
        }

        private void btnShowConfPw_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '*')
            {
                txtConfirmPassword.PasswordChar = '\0';
                btnShowConfPw.Text = "Hide";
            }
            else
            {
                txtConfirmPassword.PasswordChar = '*';
                btnShowConfPw.Text = "Show";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string name = txtName.Text.Trim();
            string tpNumber = txtTPNum.Text.Trim().ToUpper();
            string contact = txtContact.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(tpNumber) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(address))
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

            string TPNumPattern = @"^TP[0-9]{6}$";
            if (!Regex.IsMatch(tpNumber, TPNumPattern))
            {
                MessageBox.Show("Please enter a valid TP Number format (e.g., TP123456).");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
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
                            MessageBox.Show("This email is already registered. Please log in or use a different email.");
                            transaction.Rollback();
                            return;
                        }
                    }

                    string insertUser = "insert into Users values (@email, @password, 'Student')";
                    using (SqlCommand cmdUser = new SqlCommand(insertUser, connection, transaction))
                    {
                        cmdUser.Parameters.AddWithValue("@email", email);
                        cmdUser.Parameters.AddWithValue("@password", password);

                        cmdUser.ExecuteNonQuery();
                    }

                    string fetchedUserID = "";
                    string getUserID = "select UserID from Users where Email = @email";
                    using (SqlCommand cmdGetID = new SqlCommand(getUserID, connection, transaction))
                    {
                        cmdGetID.Parameters.AddWithValue("@email", email);

                        fetchedUserID = cmdGetID.ExecuteScalar()?.ToString();
                    }

                    string insertStudent = "insert into Student (UserID, TPNumber, Name, Email, Address, ContactNumber) values (@userID, @tp, @name, @email, @address, @contact)";
                    using (SqlCommand cmdStudent = new SqlCommand(insertStudent, connection, transaction))
                    {
                        cmdStudent.Parameters.AddWithValue("@userID", fetchedUserID);
                        cmdStudent.Parameters.AddWithValue("@tp", tpNumber);
                        cmdStudent.Parameters.AddWithValue("@name", name);
                        cmdStudent.Parameters.AddWithValue("@email", email);
                        cmdStudent.Parameters.AddWithValue("@address", address);
                        cmdStudent.Parameters.AddWithValue("@contact", contact);

                        cmdStudent.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("Account successfully registered!");

                    main_loginPage loginPage = new main_loginPage();
                    loginPage.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error creating account: " + ex.Message);
                }
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            main_loginPage loginPage = new main_loginPage();
            loginPage.Show();
            this.Hide();
        }

        private void student_registerPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
