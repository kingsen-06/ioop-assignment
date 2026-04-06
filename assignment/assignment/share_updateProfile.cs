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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace assignment
{
    public partial class share_updateProfile : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string table = "";
        bool emailChange;
        bool nameChange;
        bool passwordChange;
        bool contactChange;
        bool addressChange;
        public share_updateProfile()
        {
            InitializeComponent();

            txtPassword.PasswordChar = '*';
        }

        public void share_updateProfile_Load(object sender, EventArgs e)
        {
            // Get the user role
            string queryRole = "select * from Users where Email = @email";
            string role = "";
            string password = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmdRole = new SqlCommand(queryRole, connection))
                {
                    cmdRole.Parameters.AddWithValue("@email", User.CurrentUser.Email);

                    connection.Open();

                    using (SqlDataReader reader = cmdRole.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            role = reader["Role"].ToString();
                            password = reader["Password"].ToString();
                        }
                    }
                }
            }

            // Get the user information
            if (role != "")
            {
                if (role == "Admin") table = "Admin";
                else if (role == "Trainer") table = "Trainer";
                else if (role == "Lecturer") table = "Lecturer";
                else if (role == "Student") table = "Student";
            }

            string queryTable = $"select * from {table} where Email = @email";
            string name = "";
            string contact = "";
            string address = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmdTable = new SqlCommand(queryTable, connection))
                {
                    cmdTable.Parameters.AddWithValue("@email", User.CurrentUser.Email);

                    connection.Open();

                    using (SqlDataReader reader = cmdTable.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name = reader["Name"].ToString();
                            contact = reader["ContactNumber"].ToString();
                            address = reader["Address"].ToString();
                        }
                    }
                }
            }

            // Display the user information
            txtEmail.Text = User.CurrentUser.Email;
            txtName.Text = name;
            txtPassword.Text = password;
            txtContact.Text = contact;
            txtAddress.Text = address;

        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            emailChange = true;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            nameChange = true;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            passwordChange = true;
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            contactChange = true;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            addressChange = true;
        }

        private void makeChange(string table, string columnName, string newValue)
        {
            string queryChange = $"update {table} set {columnName} = @value where Email = @email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmdChange = new SqlCommand(queryChange, connection))
                {
                    cmdChange.Parameters.AddWithValue("@value", newValue);
                    cmdChange.Parameters.AddWithValue("@email", User.CurrentUser.Email);

                    connection.Open();
                    cmdChange.ExecuteNonQuery();
                }
            }
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (emailChange) makeChange(table, "Email", txtEmail.Text);
            if (nameChange) makeChange(table, "Name", txtName.Text);
            if (passwordChange) makeChange("User", "Password", txtPassword.Text);
            if (contactChange) makeChange(table, "ContactNumber", txtContact.Text);
            if (addressChange) makeChange(table, "Address", txtAddress.Text);
        }
    }
}
