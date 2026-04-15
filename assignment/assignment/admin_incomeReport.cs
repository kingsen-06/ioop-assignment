using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class admin_incomeReport : Form
    {
        TrainerManager trainerManager = new TrainerManager();
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

            loadTrainerDetails();
            generateFinancialReport();
        }

        private void loadTrainerDetails()
        {
            User trainerDetails = trainerManager.getTrainerDetails(currentTrainerID);

            if (trainerDetails != null) 
            {
                lblName.Text = trainerDetails.Name;
                lblAddress1.Text = trainerDetails.Address;
            }
            else
            {
                MessageBox.Show("Error loading trainer details");
            }
        }

        private void generateFinancialReport()
        {
            IncomeReport report = trainerManager.generateTrainerIncomeReport(currentTrainerID);

            if (report != null) 
            {
                dataReport.Rows.Add($"{report.ModuleCount} Assigned Modules", report.TotalEarnings.ToString("0.00"), "Tax (5%)", report.TotalDeductions.ToString("0.00"));

                lblTotal.Text = report.TotalEarnings.ToString("0.00");
                lblTotal2.Text = report.TotalDeductions.ToString("0.00");
                lblNet.Text = report.NetIncome.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Error generating financial report.");
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_monthChoice monthChoice = new admin_monthChoice(currentTrainerID);
            monthChoice.Show();
            this.Hide();
        }
    }
}
