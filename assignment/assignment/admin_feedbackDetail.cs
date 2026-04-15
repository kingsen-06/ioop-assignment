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
        FeedbackManager feedbackManager = new FeedbackManager();
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
            Feedback details = feedbackManager.getFeedbackByID(selectedFeedbackID);

            if (details != null)
            {
                lblTrainer.Text = details.Name;
                lblDate.Text = details.SubmittedAt.ToString("dd MMM yyyy, hh:mm tt");
                txtFeedback.Text = details.Message;
            }
            else
            {
                MessageBox.Show("Feedback record not found.");
            }
        }
    }
}
