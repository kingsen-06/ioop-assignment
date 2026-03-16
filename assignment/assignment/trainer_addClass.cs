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
    public partial class trainer_addClass : Form
    {
        public trainer_addClass()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            trainer_updateClass updateClass = new trainer_updateClass();
            updateClass.Show();
            this.Hide();
        }
    }
}
