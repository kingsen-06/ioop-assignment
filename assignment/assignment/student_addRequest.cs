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
    public partial class student_addRequest : Form
    {
        public student_addRequest()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            student_manageRequest manageRequest = new student_manageRequest();
            manageRequest.Show();
            this.Hide();
        }
    }
}
