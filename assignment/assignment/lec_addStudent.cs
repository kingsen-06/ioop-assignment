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
    public partial class lec_addStudent : Form
    {
        public lec_addStudent()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            lec_viewStudent viewStudent = new lec_viewStudent();
            viewStudent.Show();
            this.Hide();
        }
    }
}
