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
    public partial class lec_rejectReason : Form
    {
        public lec_rejectReason()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            lec_viewRequest viewRequest = new lec_viewRequest();
            viewRequest.Show();
            this.Hide();
        }
    }
}
