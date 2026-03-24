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
    public partial class admin_manageLec : Form
    {
        public admin_manageLec()
        {
            InitializeComponent();
        }

        private void btnAddLec_Click(object sender, EventArgs e)
        {
            admin_addLec addLec = new admin_addLec();
            addLec.Show();
            this.Hide();
        }
    }
}
