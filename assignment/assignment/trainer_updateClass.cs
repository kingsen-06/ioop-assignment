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
    public partial class trainer_updateClass : Form
    {
        public trainer_updateClass()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            trainer_addClass addClass = new trainer_addClass();
            addClass.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            trainer_editClass editClass = new trainer_editClass();
            editClass.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            trainer_menu trainerMenu = new trainer_menu();
            trainerMenu.Show();
            this.Hide();
        }
    }
}
