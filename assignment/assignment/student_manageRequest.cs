using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace assignment
{
    public partial class student_manageRequest : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        public student_manageRequest()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            student_addRequest addRequest = new student_addRequest();
            addRequest.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            student_menu studentMenu = new student_menu();
            studentMenu.Show();
            this.Hide();
        }

        private void student_manageRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void student_manageRequest_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = """
                    select 
                        cr.RequestID,
                        cr.ModuleName, 
                        m.ClassLevel, 
                        l.Name,
                        cr.Status,
                        r.Reason 
                    from ClassRequest cr
                    inner join Modules m on cr.ModuleName = m.ModuleName
                    inner join Student s on cr.StuID = s.StuID
                    inner join Lecturer l on cr.LecturerID = l.LecID
                    left join RejectReason r on cr.RequestID = r.RequestID
                    where s.Email = @email
                    """;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", User.CurrentUser.Email);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dataRequest.Rows.Clear();

                            while (reader.Read())
                            {
                                string rejectReason = "-";
                                if (reader["Reason"] != DBNull.Value)
                                {
                                    rejectReason = reader["Reason"].ToString();
                                }

                                dataRequest.Rows.Add(
                                    reader["RequestID"].ToString(),
                                    reader["ModuleName"].ToString(),
                                    reader["ClassLevel"].ToString(),
                                    reader["Name"].ToString(),
                                    reader["Status"].ToString(),
                                    rejectReason
                                );
                            }
                        }
                    }

                    if (dataRequest.Columns.Count > 0)
                    {
                        dataRequest.Columns[0].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading requests: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dataRequest.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request row first.");
                return;
            }

            string requestID = dataRequest.SelectedRows[0].Cells[0].Value?.ToString();
            string status = dataRequest.SelectedRows[0].Cells[4].Value?.ToString();

            if (status.ToLower() == "pending")
            {
                MessageBox.Show("You can only cancel Pending requests.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to cancel this class request?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string deleteQuery = "delete from ClassRequest where RequestID = @id";
                        using (SqlCommand cmdDelete = new SqlCommand(deleteQuery, conn))
                        {
                            cmdDelete.Parameters.AddWithValue("@id", requestID);

                            cmdDelete.ExecuteNonQuery();

                            MessageBox.Show("Request cancelled successfully.");

                            student_manageRequest_Load(sender, e);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error cancelling request: " + ex.Message);
                    }
                }
            }
        }
    }
}
