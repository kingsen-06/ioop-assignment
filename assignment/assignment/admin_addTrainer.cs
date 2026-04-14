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
            string dob = dateDOB.Value.ToString("yyyy-MM-dd");
            string email = txtEmail.Text.Trim();
            string contact = txtContact.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(address) || cmbModule.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all fields.");
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
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // A SqlTransaction ensures that if the Trainer insert fails, the User insert is reversed!
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    

                    string defaultPassword = "trainer123";
                    string generatedUserID = "";

                    string userQuery = @"insert into Users output inserted.UserID values (@email, @password, 'Trainer')";
                    using (SqlCommand userCommand = new SqlCommand(userQuery, connection, transaction))
                    {
                        userCommand.Parameters.AddWithValue("@email", email);
                        userCommand.Parameters.AddWithValue("@password", defaultPassword);

                        generatedUserID = userCommand.ExecuteScalar().ToString(); // Run the user insert and returns the output value
                    }

                    string trainerQuery = @"insert into Trainer values (@UserID, @email, @name, @DOB, @contact, @address)";
                    using (SqlCommand trainerCommand = new SqlCommand(trainerQuery, connection, transaction))
                    {
                        trainerCommand.Parameters.AddWithValue("@UserID", generatedUserID);
                        trainerCommand.Parameters.AddWithValue("@email", email);
                        trainerCommand.Parameters.AddWithValue("@name", fullName);
                        trainerCommand.Parameters.AddWithValue("@DOB", dob);
                        trainerCommand.Parameters.AddWithValue("@contact", contact);
                        trainerCommand.Parameters.AddWithValue("@address", address);

                        trainerCommand.ExecuteNonQuery(); // Run the trainer insert
                    }

                    string assignQuery = @"insert into TrainerAssignedModules values (@UserID, @ModuleID)";
                    using (SqlCommand assignCommand = new SqlCommand(assignQuery, connection, transaction))
                    {
                        assignCommand.Parameters.AddWithValue("@UserID", generatedUserID);
                        assignCommand.Parameters.AddWithValue("@ModuleID", cmbModule.SelectedValue.ToString());

                        assignCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show($"Successfully registered Trainer: {fullName}!\nTemporary password: {defaultPassword}");

                    admin_manageTrainer manageTrainer = new admin_manageTrainer();
                    manageTrainer.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error registering trainer: " + ex.Message);
                }
            }
        }

        private void admin_addTrainer_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "select ModuleID, ModuleName, ClassLevel from Modules";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable modules = new DataTable();
                        adapter.Fill(modules);

                        cmbModule.DataSource = modules;
                        cmbModule.DisplayMember = "ModuleName";
                        cmbModule.ValueMember = "ModuleID";
                        cmbModule.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading modules: " + ex.Message);
                }
            }
        }

        private void cmbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModule.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)cmbModule.SelectedItem;
                lblLevel.Text = selectedRow["ClassLevel"].ToString();
            }
            else
            {
                lblLevel.Text = "";
            }
        }
    }
}
