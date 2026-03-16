using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class admin_viewFeedback : Form
    {
        public admin_viewFeedback()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            admin_feedbackDetail feedbackDetail = new admin_feedbackDetail();
            feedbackDetail.Show();
            this.Hide();
        }

        private void lblBack_Click_1(object sender, EventArgs e)
        {
            admin_menu adminMenu = new admin_menu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
