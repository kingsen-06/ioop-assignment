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
    public partial class lec_menu : Form
    {
        public lec_menu()
        {
            InitializeComponent();
        }

        private void lec_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            lec_viewStudent viewStudent = new lec_viewStudent();
            viewStudent.Show();
            this.Hide();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            lec_viewRequest request = new lec_viewRequest();
            request.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            share_confirmPassword confirmPassword = new share_confirmPassword();
            confirmPassword.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            main_loginPage loginPage = new main_loginPage();
            loginPage.Show();
            this.Hide();
        }
    }
}
