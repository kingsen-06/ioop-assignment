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
    public partial class superAdmin_manageAdmin : Form
    {
        public superAdmin_manageAdmin()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            superAdmin_menu superAdminMenu = new superAdmin_menu();
            superAdminMenu.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            superAdmin_addAdmin addAdmin = new superAdmin_addAdmin();
            addAdmin.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            superAdmin_adminDetail adminDetail = new superAdmin_adminDetail();
            adminDetail.Show();
            this.Hide();
        }
    }
}
