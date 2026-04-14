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
    public partial class admin_viewFeedback : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public admin_viewFeedback()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_menu adminMenu = new admin_menu();
            adminMenu.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dataFeedback.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a feedback record from the list to view.");
                return;
            }

            string selectedFeedbackID = dataFeedback.SelectedRows[0].Cells["FeedbackID"].Value.ToString();

            admin_feedbackDetail feedbackDetail = new admin_feedbackDetail(selectedFeedbackID);
            feedbackDetail.Show();
            this.Hide();
        }

        private void admin_viewFeedback_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void admin_viewFeedback_Load(object sender, EventArgs e)
        {
            dataFeedback.AllowUserToAddRows = false;
            dataFeedback.AllowUserToDeleteRows = false;
            dataFeedback.ReadOnly = true;
            dataFeedback.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataFeedback.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            loadFeedbackList();
        }

        private void loadFeedbackList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // left() to create a short preview of the message if it's super long.
                    string query = """
                        select 
                            f.FeedbackID, 
                            case 
                                when len(f.Message) > 50 then left(f.Message, 50) + '...' 
                                else f.Message 
                            end as [Feedback], 
                            t.Name as [Trainer],
                            f.SubmittedAt as [Date Submitted]
                        from Feedback f
                        inner join Trainer t on f.Email = t.Email
                        order by f.SubmittedAt desc
                        """;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dtFeedback = new DataTable();
                            adapter.Fill(dtFeedback);

                            dataFeedback.DataSource = dtFeedback;
                        }
                    }

                    if (dataFeedback.Columns.Count > 0)
                    {
                        dataFeedback.Columns["FeedbackID"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading feedback: " + ex.Message);
                }
            }
        }
    }
}
