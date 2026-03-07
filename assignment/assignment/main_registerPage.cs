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
    public partial class main_registerPage : Form
    {
        public main_registerPage()
        {
            InitializeComponent();
            txtPw.PasswordChar = '*';
            txtConfirmPw.PasswordChar = '*';
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            main_loginPage login = new main_loginPage();
            login.Show();
            this.Hide();
        }
    }
}
