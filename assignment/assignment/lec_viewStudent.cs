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
    public partial class lec_viewStudent : Form
    {
        public lec_viewStudent()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lec_addStudent addStudent = new lec_addStudent();
            addStudent.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            lec_menu lecMenu = new lec_menu();
            lecMenu.Show();
            this.Hide();
        }

        private void btnAssignClass_Click(object sender, EventArgs e)
        {
            lec_assignStudent assignStudent = new lec_assignStudent();
            assignStudent.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lec_editClass editClass = new lec_editClass();
            editClass.Show();
            this.Hide();
        }
    }
}
