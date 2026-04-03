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
        string correctPassword = "";
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        public share_confirmPassword()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_menu adminMenu = new admin_menu();
            adminMenu.Show();
            this.Hide();
        }

        private void lblNext_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(password)) 
            { 
                MessageBox.Show("Password cannot be empty! "); 
                return;
            }

            string query = "select Password from Users where Email = @email";

            using (SqlConnection connection = new SqlConnection(connectionString))

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@email", User.CurrentUser.Email);

                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        correctPassword = reader["Password"].ToString();
                    }
                }
            }

            for (int i = 1; i <= 3; i++)
            {
                if (password == correctPassword)
                {
                    MessageBox.Show("Password correct! Proceeding to update profile page... ");
                    share_updateProfile updateProfile = new share_updateProfile();
                    updateProfile.Show();
                    this.Hide();
                }
                else MessageBox.Show($"Password incorrect! {i} attempts more! ");
            }

            
            MessageBox.Show("Too many failed attempts. Loging out... ");
            main_loginPage loginPage = new main_loginPage();
            loginPage.Show();
            this.Close();
        }
    }
}
