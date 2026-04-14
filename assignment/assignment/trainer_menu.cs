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
    public partial class trainer_menu : Form
    {
        public trainer_menu()
        {
            InitializeComponent();
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            trainer_updateClass updateClass = new trainer_updateClass();
            updateClass.Show();
            this.Hide();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            trainer_viewStudent student = new trainer_viewStudent();
            student.Show();
            this.Hide();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            trainer_feedback feedback = new trainer_feedback();
            feedback.Show();
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

        private void trainer_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
