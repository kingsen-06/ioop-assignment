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
    public partial class admin_addLec : Form
    {
        public admin_addLec()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_manageLec manageLec = new admin_manageLec();
            manageLec.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            DateTime date = dateDOB.Value;
            string email = txtEmail.Text;
            string contact = txtContact.Text;
            string address = txtAddress.Text;
        }
    }
}
