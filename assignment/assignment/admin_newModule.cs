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
    public partial class admin_newModule : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public admin_newModule()
        {
            InitializeComponent();
        }

        private void admin_newModule_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            string moduleName = txtModule.Text.Trim();
            string classLevel = "";

            if (cmbLevel.SelectedIndex != -1)
            {
                classLevel = cmbLevel.SelectedItem.ToString();
            }

            if (string.IsNullOrEmpty(moduleName) || string.IsNullOrEmpty(classLevel))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkQuery = "select count(*) from Modules where ModuleName = @moduleName";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, connection))
                    {
                        cmdCheck.Parameters.AddWithValue("@moduleName", moduleName);

                        int exists = int.Parse(cmdCheck.ExecuteScalar().ToString());
                        if (exists > 0)
                        {
                            MessageBox.Show($"The module '{moduleName}' already exists in the system!");
                            return;
                        }
                    }

                    string insertQuery = "insert into Modules values (@moduleName, @classLevel)";
                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, connection))
                    {
                        cmdInsert.Parameters.AddWithValue("@moduleName", moduleName);
                        cmdInsert.Parameters.AddWithValue("@classLevel", classLevel);

                        cmdInsert.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Successfully added '{moduleName}' at the {classLevel} level.");

                    txtModule.Clear();
                    txtModule.Focus();
                    cmbLevel.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_menu adminMenu = new admin_menu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
