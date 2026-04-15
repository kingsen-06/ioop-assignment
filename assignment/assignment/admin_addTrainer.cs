using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class admin_addTrainer : Form
    {
        TrainerManager trainerManager = new TrainerManager();

        public admin_addTrainer()
        {
            InitializeComponent();
        }

        private void admin_addTrainer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void admin_addTrainer_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable modules = trainerManager.getModules();
                cmbModule.DataSource = modules;
                cmbModule.DisplayMember = "ModuleName";
                cmbModule.ValueMember = "ModuleID";
                cmbModule.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading modules: " + ex.Message);
            }
        }

        private void cmbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModule.SelectedItem != null && cmbModule.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)cmbModule.SelectedItem;
                lblLevel.Text = selectedRow["ClassLevel"].ToString();
            }
            else
            {
                lblLevel.Text = "";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string dob = dateDOB.Value.ToString("yyyy-MM-dd");
            string email = txtEmail.Text.Trim();
            string contact = txtContact.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(address) || cmbModule.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email format. (e.g. example@gmail.com)");
                return;
            }

            string contactPattern = @"^01\d-\d{7,8}$";
            if (!Regex.IsMatch(contact, contactPattern))
            {
                MessageBox.Show("Please enter a valid contact number format. (e.g. 012-3456789)");
            }

            User newTrainerData = new User(name, email, contact, address, dob);
            string selectedModuleID = cmbModule.SelectedValue.ToString();
            string defaultPassword = "trainer123";

            string result = trainerManager.registerTrainer(newTrainerData, selectedModuleID, defaultPassword);

            if (result == "Success")
            {
                MessageBox.Show($"Successfully registered trainer: {name}!\nTemporary password: {defaultPassword}");
                lblBack_Click(null, null);
            }
            else if (result == "Email Exists")
            {
                MessageBox.Show("This email is already registered to another user! Please use a different email.");
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_manageTrainer manageTrainer = new admin_manageTrainer();
            manageTrainer.Show();
            this.Hide();
        }
    }
}
