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
    public partial class admin_addLec : Form
    {
        LecturerManager lecManager = new LecturerManager();

        public admin_addLec()
        {
            InitializeComponent();
        }

        private void admin_addLec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string dob = dateDOB.Value.ToString("yyyy-MM-dd");
            string email = txtEmail.Text.Trim();
            string contact = txtContact.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(contact) || string.IsNullOrEmpty(address))
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
                return;
            }

            User newLecturerData = new User(name, email, contact, address, dob);
            string defaultPassword = "lecturer123";

            string result = lecManager.registerLecturer(newLecturerData, defaultPassword);

            if (result == "Success")
            {
                MessageBox.Show($"Successfully registered lecturer: {name}!\nTemporary password: {defaultPassword}");
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
            if (User.CurrentUser.Role == "Super Admin")
            {
                superAdmin_menu superAdminMenu = new superAdmin_menu();
                superAdminMenu.Show();
            }
            else
            {
                admin_menu adminMenu = new admin_menu();
                adminMenu.Show();
            }

            this.Hide();
        }
    }
}
