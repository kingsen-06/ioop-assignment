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
    public partial class share_confirmPassword : Form
    {
        public share_confirmPassword()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }
    }
}
