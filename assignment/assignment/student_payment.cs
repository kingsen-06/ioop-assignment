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
    public partial class student_payment : Form
    {
        public student_payment()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment has done, redirecting back to the student menu... ");
            student_menu Menu = new student_menu();
            Menu.Show();
            this.Hide();
        }
    }
}
