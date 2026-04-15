using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class admin_menu : Form
    {
        public admin_menu()
        {
            InitializeComponent();
        }

        private void admin_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnManageLecturer_Click(object sender, EventArgs e)
        {
            admin_manageLec manageLec = new admin_manageLec();
            manageLec.Show();
            this.Hide();
        }

        private void btnManageTrainer_Click(object sender, EventArgs e)
        {
            admin_manageTrainer manageTrainer = new admin_manageTrainer();
            manageTrainer.Show();
            this.Hide();
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            admin_addModule newModule = new admin_addModule();
            newModule.Show();
            this.Hide();
        }

        private void btnViewFeedback_Click(object sender, EventArgs e)
        {
            admin_viewFeedback viewFeedback = new admin_viewFeedback();
            viewFeedback.Show();
            this.Hide();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
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
