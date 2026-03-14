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
    public partial class lec_viewRequest : Form
    {
        public lec_viewRequest()
        {
            InitializeComponent();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            lec_rejectReason rejectReason = new lec_rejectReason();
            rejectReason.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lec_menu lecMenu = new lec_menu();
            lecMenu.Show();
            this.Hide();
        }
    }
}
