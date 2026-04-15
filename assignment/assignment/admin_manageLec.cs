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
    public partial class admin_manageLec : Form
    {
        LecturerManager lecManager = new LecturerManager();

        public admin_manageLec()
        {
            InitializeComponent();
        }

        private void admin_manageLec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void admin_manageLec_Load(object sender, EventArgs e)
        {
            loadLecturerData();
        }

        private void loadLecturerData()
        {
            try
            {
                DataTable lecturerTable = lecManager.getAllLecturers();
                lstLec.DataSource = lecturerTable;
                lstLec.DisplayMember = "Name";
                lstLec.ValueMember = "UserID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnAddLec_Click(object sender, EventArgs e)
        {
            admin_addLec addLec = new admin_addLec();
            addLec.Show();
            this.Hide();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (lstLec.SelectedValue != null)
            {
                string selectedID = lstLec.SelectedValue.ToString();

                admin_lecDetail lecDetail = new admin_lecDetail(selectedID);
                lecDetail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a lecturer from the list first.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLec.SelectedValue == null)
            {
                MessageBox.Show("Please select a lecturer to remove");
                return;
            }

            string selectedID = lstLec.SelectedValue.ToString();
            string lecturerName = lstLec.Text;

            DialogResult confirm = MessageBox.Show($"Are you sure you want to remove {lecturerName}?\nThis action cannot be undone!", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bool isSuccess = lecManager.deleteLecturer(selectedID);

                if (isSuccess)
                {
                    MessageBox.Show($"{lecturerName} has been successfully removed.");
                    loadLecturerData();
                }
                else
                {
                    MessageBox.Show("Error removing lecturer from the database");
                }
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
                admin_menu admin_Menu = new admin_menu();
                admin_Menu.Show();
            }

            this.Hide();
        }
    }
}
