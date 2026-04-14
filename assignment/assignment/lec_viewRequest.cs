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
    public partial class lec_viewRequest : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string currentLecID = "";

        public lec_viewRequest()
        {
            InitializeComponent();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dataRequest.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request from the list to reject.");
                return;
            }

            string selectedRequestID = dataRequest.SelectedRows[0].Cells["RequestID"].Value.ToString();

            lec_rejectReason rejectReason = new lec_rejectReason(selectedRequestID);
            rejectReason.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            lec_menu lecMenu = new lec_menu();
            lecMenu.Show();
            this.Hide();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dataRequest.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a request from the list to approve.");
                return;
            }

            string selectedRequestID = dataRequest.SelectedRows[0].Cells["RequestID"].Value.ToString();

            lec_assignStudent assignStudent = new lec_assignStudent(selectedRequestID);
            assignStudent.Show();
            this.Hide();
        }

        private void lec_viewRequest_Load(object sender, EventArgs e)
        {
            dataRequest.AllowUserToAddRows = false;
            dataRequest.AllowUserToDeleteRows = false;
            dataRequest.ReadOnly = true;
            dataRequest.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataRequest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string getLecID = "select LecID from Lecturer where Email = @email";
                    using (SqlCommand cmdLec = new SqlCommand(getLecID, conn))
                    {
                        cmdLec.Parameters.AddWithValue("@email", User.CurrentUser.Email);

                        currentLecID = cmdLec.ExecuteScalar()?.ToString();
                    }

                    loadPendingRequests();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lec_viewRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loadPendingRequests()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = """
                        select 
                            cr.RequestID, 
                            s.Name as [Student Name], 
                            cr.ModuleName as [Course Name], 
                            cr.ClassLevel as [Class Level]
                        from ClassRequest cr
                        inner join Student s on cr.StuID = s.StuID
                        where cr.LecturerID = @lecID and cr.Status = 'Pending'
                        """;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@lecID", currentLecID);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dtRequests = new DataTable();
                            adapter.Fill(dtRequests);

                            dataRequest.DataSource = dtRequests;
                        }
                    }

                    if (dataRequest.Columns.Count > 0)
                    {
                        dataRequest.Columns["RequestID"].Visible = false;
                    }

                    dataRequest.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading requests: " + ex.Message);
                }
            }
        }

        private void dataRequest_SelectionChanged(object sender, EventArgs e)
        {
            if (dataRequest.SelectedRows.Count > 0)
            {
                lblStudent.Text = dataRequest.SelectedRows[0].Cells["Student Name"].Value.ToString();
            }
        }
    }
}
