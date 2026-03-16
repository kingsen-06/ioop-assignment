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
    public partial class student_paymentList : Form
    {
        public student_paymentList()
        {
            InitializeComponent();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            student_invoice invoice = new student_invoice();
            invoice.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            student_menu studentMenu = new student_menu();
            studentMenu.Show();
            this.Hide();
        }
    }
}
