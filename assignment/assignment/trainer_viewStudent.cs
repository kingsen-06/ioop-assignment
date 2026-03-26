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
    public partial class trainer_viewStudent : Form
    {
        public trainer_viewStudent()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            trainer_menu trainerMenu = new trainer_menu();
            trainerMenu.Show();
            this.Hide();
        }
    }
}
