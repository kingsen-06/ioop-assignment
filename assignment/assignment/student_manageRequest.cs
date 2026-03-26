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
    public partial class student_manageRequest : Form
    {
        public student_manageRequest()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            student_addRequest addRequest = new student_addRequest();
            addRequest.Show();
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
