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
    public partial class admin_incomeReport : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string currentTrainerID;
        string selectedMonth;

        public admin_incomeReport(string trainerID, string month)
        {
            InitializeComponent();

            currentTrainerID = trainerID;
            selectedMonth = month;
        }

        private void admin_incomeReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void admin_incomeReport_Load(object sender, EventArgs e)
        {
            lblPeriod.Text = selectedMonth;
            lblJob.Text = "CodeCamp Trainer";
            lblDate.Text = DateTime.Now.ToString("dd MM yyyy");

            dataReport.AllowUserToAddRows = false;
            dataReport.RowHeadersVisible = false;
            dataReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            loadTrainerDetails();
            generateFinancialReport();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_monthChoice monthChoice = new admin_monthChoice(currentTrainerID);
            monthChoice.Show();
            this.Hide();
        }

        private void loadTrainerDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "select Name, Address from Trainer where UserID = @UserID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", currentTrainerID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblName.Text = reader["Name"].ToString();
                                lblAddress1.Text = reader["Address"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading details: " + ex.Message);
                }
            }
        }

        private void generateFinancialReport()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string countQuery = "select count(*) from TrainerAssignedModules where UserID = @UserID";
                    int moduleCount = 0;

                    using (SqlCommand command = new SqlCommand(countQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", currentTrainerID);
                        moduleCount = (int)command.ExecuteScalar();
                    }

                    decimal payPerModule = 1500.00m;
                    decimal totalEarnings = moduleCount * payPerModule;

                    decimal taxRate = 0.05m;
                    decimal totalDeductions = totalEarnings * taxRate;

                    decimal netIncome = totalEarnings - totalDeductions;

                    dataReport.Rows.Add($"{moduleCount} Assigned Modules", totalEarnings.ToString("0.00"), "Tax (5%)", totalDeductions.ToString("0.00"));

                    lblTotal.Text = totalEarnings.ToString("0.00");
                    lblTotal2.Text = totalDeductions.ToString("0.00");
                    lblNet.Text = netIncome.ToString("0.00");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating report: " + ex.Message);
                }
            }
        }
    }
}
