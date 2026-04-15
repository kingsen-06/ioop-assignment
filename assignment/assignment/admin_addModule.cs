using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class admin_addModule : Form
    {
        ModuleManager moduleManager = new ModuleManager();

        public admin_addModule()
        {
            InitializeComponent();
        }

        private void admin_newModule_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            string moduleName = txtModule.Text.Trim();
            string classLevel = "";

            if (cmbLevel.SelectedIndex != -1)
            {
                classLevel = cmbLevel.SelectedItem.ToString();
            }

            if (string.IsNullOrEmpty(moduleName) || string.IsNullOrEmpty(classLevel))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            string result = moduleManager.addModule(moduleName, classLevel);

            if (result == "Success")
            {
                MessageBox.Show($"Successfully added '{moduleName}' at the '{classLevel}' level.");
                txtModule.Clear();
                txtModule.Focus();
                cmbLevel.SelectedIndex = -1;
            }
            else if (result == "Exists")
            {
                MessageBox.Show($"The module '{moduleName}' already exists in the system!");
                txtModule.Focus();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_menu adminMenu = new admin_menu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
