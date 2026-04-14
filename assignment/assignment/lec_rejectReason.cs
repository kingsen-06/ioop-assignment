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
    public partial class lec_rejectReason : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string selectedRequestID = "";

        public lec_rejectReason(string requestID)
        {
            InitializeComponent();
            selectedRequestID = requestID;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            lec_viewRequest viewRequest = new lec_viewRequest();
            viewRequest.Show();
            this.Hide();
        }

        private void lec_rejectReason_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string reason = txtReason.Text.Trim();

            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Please type a reason for the rejection.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string updateRequest = "update ClassRequest set Status = 'Rejected' where RequestID = @reqID";
                    using (SqlCommand cmdUpdate = new SqlCommand(updateRequest, conn, transaction))
                    {
                        cmdUpdate.Parameters.AddWithValue("@reqID", selectedRequestID);

                        cmdUpdate.ExecuteNonQuery();
                    }

                    string insertReason = "insert into RejectReason (RequestID, Reason) values (@reqID, @reason)";
                    using (SqlCommand cmdInsert = new SqlCommand(insertReason, conn, transaction))
                    {
                        cmdInsert.Parameters.AddWithValue("@reqID", selectedRequestID);
                        cmdInsert.Parameters.AddWithValue("@reason", reason);

                        cmdInsert.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("The request has been rejected and the student will see your reason.");

                    lec_viewRequest viewRequest = new lec_viewRequest();
                    viewRequest.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }
    }
}
