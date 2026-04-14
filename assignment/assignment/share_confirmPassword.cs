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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace assignment
{
    public partial class share_confirmPassword : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        int failedAttempts = 0;

        public share_confirmPassword()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            string role = User.CurrentUser.Role;

            if (role == "Admin")
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

        private void lblNext_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty!");
                return;
            }

            string correctPassword = "";

            string query = "select Password from Users where Email = @email";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@email", User.CurrentUser.Email);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                correctPassword = reader["Password"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }

            }

            if (password == correctPassword)
            {
                MessageBox.Show("Password correct!");

                share_updateProfile updateProfile = new share_updateProfile();
                updateProfile.Show();
                this.Hide();

                return;
            }
            else
            {
                failedAttempts++;
                int attemptsLeft = 3 - failedAttempts;

                if (attemptsLeft > 0)
                {
                    MessageBox.Show($"Password incorrect! You have {attemptsLeft} attempt(s) left.");
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Too many failed attempts. Logging out for security reasons.");

                    main_loginPage loginPage = new main_loginPage();
                    loginPage.Show();
                    this.Close();
                }
            }
        }

        private void share_confirmPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
