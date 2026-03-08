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
    public partial class share_updateProfile : Form
    {
        public share_updateProfile()
        {
            InitializeComponent();
            txtPw.PasswordChar = '*';
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            txtPw.PasswordChar = '\0';
        }
    }
}
