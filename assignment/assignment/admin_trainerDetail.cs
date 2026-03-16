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
    public partial class admin_trainerDetail : Form
    {
        public admin_trainerDetail()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            admin_assignClass assignClass = new admin_assignClass();
            assignClass.Show();
            this.Hide();
        }
    }
}
