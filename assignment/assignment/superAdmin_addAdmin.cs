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
    public partial class superAdmin_addAdmin : Form
    {
        public superAdmin_addAdmin()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            superAdmin_manageAdmin1 manageAdmin = new superAdmin_manageAdmin1();
            manageAdmin.Show();
            this.Hide();
        }
    }
}
