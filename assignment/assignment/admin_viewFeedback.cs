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
    public partial class admin_viewFeedback : Form
    {
        FeedbackManager feedbackManager = new FeedbackManager();

        public admin_viewFeedback()
        {
            InitializeComponent();
        }

        private void admin_viewFeedback_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void admin_viewFeedback_Load(object sender, EventArgs e)
        {
            loadFeedbackList();
        }

        private void loadFeedbackList()
        {
            DataTable feedbackTable = feedbackManager.getAllFeedbackPreview();
            dataFeedback.DataSource = feedbackTable;

            if (dataFeedback.Columns.Count > 0 && dataFeedback.Columns.Contains("FeedbackID"))
            {
                dataFeedback.Columns["FeedbackID"].Visible = false;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dataFeedback.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a feedback record from the list first.");
                return;
            }

            string selectedFeedbackID = dataFeedback.SelectedRows[0].Cells["FeedbackID"].Value.ToString();

            admin_feedbackDetail feedbackDetail = new admin_feedbackDetail(selectedFeedbackID);
            feedbackDetail.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            if (User.CurrentUser.Role == "Super Admin")
            {
                superAdmin_menu superAdminMenu = new superAdmin_menu();
                superAdminMenu.Show();
            }
            else
            {
                admin_menu adminMenu = new admin_menu();
                adminMenu.Show();
            }

            this.Hide();
        }
    }
}
