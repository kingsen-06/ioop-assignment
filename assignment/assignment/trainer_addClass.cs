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
    public partial class trainer_addClass : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string currentTrainerID = "";

        public trainer_addClass()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            trainer_updateClass updateClass = new trainer_updateClass();
            updateClass.Show();
            this.Hide();
        }

        private void trainer_addClass_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string getTrainerID = "select UserID from Trainer where Email = @email";
                    using (SqlCommand cmdTrainer = new SqlCommand(getTrainerID, conn))
                    {
                        cmdTrainer.Parameters.AddWithValue("@email", User.CurrentUser.Email);

                        currentTrainerID = cmdTrainer.ExecuteScalar()?.ToString();
                    }

                    string getModules = "select distinct ModuleName from Modules";
                    using (SqlCommand cmdMod = new SqlCommand(getModules, conn))
                    {
                        using (SqlDataReader reader = cmdMod.ExecuteReader())
                        {
                            cmbName.Items.Clear();

                            while (reader.Read())
                            {
                                cmbName.Items.Add(reader["ModuleName"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbName.SelectedIndex != -1)
            {
                string selectedModule = cmbName.SelectedItem.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string getLevel = "select ClassLevel from Modules where ModuleName = @mod";
                        using (SqlCommand cmdLvl = new SqlCommand(getLevel, conn))
                        {
                            cmdLvl.Parameters.AddWithValue("@mod", selectedModule);

                            object result = cmdLvl.ExecuteScalar();
                            if (result != null)
                            {
                                lblLevel.Text = result.ToString();
                            }
                            else
                            {
                                lblLevel.Text = "Level Not Found";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching Class Level: " + ex.Message);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbName.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtVenue.Text) || numFee.Value <= 0)
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            string moduleName = cmbName.SelectedItem.ToString();
            string venue = txtVenue.Text.Trim();
            decimal fee = numFee.Value;

            DateTime startTime = dateSchedule.Value;
            DateTime endTime = startTime.AddHours(2);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string insertQuery = "insert into Class (ModuleName, TrainerID, ClassStartTime, ClassEndTime, ClassVenue, ClassFee values (@mod, @trainer, @start, @end, @venue, @fee)";

                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@mod", moduleName);
                        cmdInsert.Parameters.AddWithValue("@trainer", currentTrainerID);
                        cmdInsert.Parameters.AddWithValue("@start", startTime);
                        cmdInsert.Parameters.AddWithValue("@end", endTime);
                        cmdInsert.Parameters.AddWithValue("@venue", venue);
                        cmdInsert.Parameters.AddWithValue("@fee", fee);

                        cmdInsert.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Success! Scheduled a new {moduleName} class at {venue}.");

                    trainer_updateClass updatePage = new trainer_updateClass();
                    updatePage.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding class: " + ex.Message);
                }
            }
        }

        private void trainer_addClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
