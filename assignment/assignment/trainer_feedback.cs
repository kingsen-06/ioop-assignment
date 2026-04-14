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
    public partial class trainer_feedback : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public trainer_feedback()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            trainer_menu trainerMenu = new trainer_menu();
            trainerMenu.Show();
            this.Hide();
        }

        private void trainer_feedback_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string feedbackMessage = txtFeedback.Text.Trim();

            if (string.IsNullOrEmpty(feedbackMessage))
            {
                MessageBox.Show("Please enter your feedback before sending.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string insertQuery = "insert into Feedback (Email, Message, Role) values (@email, @message, @role)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", User.CurrentUser.Email);
                        cmd.Parameters.AddWithValue("@message", feedbackMessage);
                        cmd.Parameters.AddWithValue("@role", User.CurrentUser.Role);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thank you! Your feedback has been submitted successfully.");

                    txtFeedback.Clear();
                    txtFeedback.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending feedback: " + ex.Message);
                }
            }
        }
    }
}
