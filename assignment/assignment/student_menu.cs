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
    public partial class student_menu : Form
    {
        public student_menu()
        {
            InitializeComponent();
        }

        private void student_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            student_viewSchedule viewSchedule = new student_viewSchedule();
            viewSchedule.Show();
            this.Hide();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            student_manageRequest manageRequest = new student_manageRequest();
            manageRequest.Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            student_paymentList paymentList = new student_paymentList();
            paymentList.Show();
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
            User.CurrentUser = null;

            main_loginPage loginPage = new main_loginPage();
            loginPage.Show();
            this.Hide();
        }
    }
}
