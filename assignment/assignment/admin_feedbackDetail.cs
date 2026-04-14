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
    public partial class admin_feedbackDetail : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string selectedFeedbackID = "";

        public admin_feedbackDetail(string feedbackID)
        {
            InitializeComponent();
            selectedFeedbackID = feedbackID;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_viewFeedback viewFeedback = new admin_viewFeedback();
            viewFeedback.Show();
            this.Hide();
        }

        private void admin_feedbackDetail_Load(object sender, EventArgs e)
        {
            txtFeedback.ReadOnly = true;
            txtFeedback.BackColor = System.Drawing.Color.White;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = """
                        select 
                            f.Message, 
                            f.SubmittedAt, 
                            t.Name 
                        from Feedback f
                        inner join Trainer t on f.Email = t.Email
                        where f.FeedbackID = @feedbackID
                        """;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@feedbackID", selectedFeedbackID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblTrainer.Text = reader["Name"].ToString();

                                // Format the date to look professional (e.g., 14 Apr 2026, 02:30 PM)
                                DateTime submitDate = Convert.ToDateTime(reader["SubmittedAt"]);
                                lblDate.Text = submitDate.ToString("dd MMM yyyy, hh:mm tt");

                                txtFeedback.Text = reader["Message"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Feedback record not found.");
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
    }
}
