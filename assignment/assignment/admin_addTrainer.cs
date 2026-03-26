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
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace assignment
{
    public partial class admin_addTrainer : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public admin_addTrainer()
        {
            InitializeComponent();
        }

        private void admin_addTrainer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_manageTrainer manageTrainer = new admin_manageTrainer();
            manageTrainer.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtName.Text.Trim();
            string dob = dtpDOB.Value.ToString("yyyy-MM-dd");
            string email = txtEmail.Text.Trim();
            string contact = txtContact.Text.Trim();
            string address = txtAddress.Text.Trim();
            string module = cmbModule.Text;
            string level = cmbLevel.Text;

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(module) || string.IsNullOrEmpty(level))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern)) {
                MessageBox.Show("Please enter a valid email format. (e.g.user@mail.apu.edu.my)");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // A SqlTransaction ensures that if the Trainer insert fails, the User insert is reversed!
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string defaultPassword = "trainer123";

                    string userQuery = @"insert into Users output inserted.UserID values (@email, @password, 'Trainer')";

                    string generatedUserID = "";

                    using (SqlCommand userCommand = new SqlCommand(userQuery, connection, transaction))
                    {
                        userCommand.Parameters.AddWithValue("@email", email);
                        userCommand.Parameters.AddWithValue("@password", defaultPassword);

                        generatedUserID = userCommand.ExecuteScalar().ToString(); // Run the user insert and returns the output value
                    }

                    string trainerQuery = @"insert into Trainer values (@UserID, @email, @name, @DOB, @contact, @address, @module, @level";

                    using (SqlCommand trainerCommand = new SqlCommand(trainerQuery, connection, transaction))
                    {
                        trainerCommand.Parameters.AddWithValue("@UserID", generatedUserID);
                        trainerCommand.Parameters.AddWithValue("@email", email);
                        trainerCommand.Parameters.AddWithValue("@name", fullName);
                        trainerCommand.Parameters.AddWithValue("@DOB", dob);
                        trainerCommand.Parameters.AddWithValue("@contact", contact);
                        trainerCommand.Parameters.AddWithValue("@address", address);
                        trainerCommand.Parameters.AddWithValue("@module", module);
                        trainerCommand.Parameters.AddWithValue("@level", level);

                        trainerCommand.ExecuteNonQuery(); // Run the trainer insert
                    }

                    transaction.Commit();

                    MessageBox.Show($"Successfully registered Trainer: {fullName}!\nTemporary password: trainer123");

                    txtName.Clear();
                    txtEmail.Clear();
                    txtContact.Clear();
                    txtAddress.Clear();
                    cmbModule.SelectedIndex = -1;
                    cmbLevel.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error registering trainer: " + ex.Message);
                }
            }
        }
    }
}
