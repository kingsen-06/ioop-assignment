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
    public partial class student_payment : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string selectedPaymentID = "";

        public student_payment(string paymentID)
        {
            InitializeComponent();
            selectedPaymentID = paymentID;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (!radCard.Checked && !radWallet.Checked)
            {
                MessageBox.Show("Please select a Payment Method to proceed.");
                return;
            }

            string paymentMethod;

            if (radCard.Checked)
            {
                paymentMethod = "Debit/Credit Card";
            }
            else
            {
                paymentMethod = "E-wallet";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string updateQuery = "update StudentPayment set Status = 'Paid', PaymentDate = getdate() where PaymentID = @paymentID";

                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@paymentID", selectedPaymentID);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Payment of {lblAmount.Text} via {paymentMethod} was successful!\nThank you for your payment.");

                    student_menu studentMenu = new student_menu();
                    studentMenu.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing payment: " + ex.Message);
                }
            }

            MessageBox.Show("Payment has done, redirecting back to the student menu... ");
            student_menu Menu = new student_menu();
            Menu.Show();
            this.Hide();
        }

        private void student_payment_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "select AmountPaid from StudentPayment where PaymentID = @paymentID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@paymentID", selectedPaymentID);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            lblID.Text = selectedPaymentID;
                            lblDesc.Text = "Class Tuition Fee";
                            lblReceiver.Text = "APU CodeCamp Institute";

                            decimal amount = decimal.Parse(result.ToString());
                            lblAmount.Text = "RM " + amount.ToString("0.00");
                        }
                        else
                        {
                            MessageBox.Show("Payment record not found.");
                            btnProceed.Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void student_payment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            student_paymentList paymentList = new student_paymentList();
            paymentList.Show();
            this.Hide();
        }
    }
}
