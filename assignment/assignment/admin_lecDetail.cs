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
    public partial class admin_lecDetail : Form
    {
        LecturerManager lecManager = new LecturerManager();
        string currentLecturerID;

        public admin_lecDetail(string selectedID)
        {
            InitializeComponent();
            currentLecturerID = selectedID;
        }

        private void admin_lecDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void admin_lecDetail_Load(object sender, EventArgs e)
        {
            loadLecturerProfile();
        }

        private void loadLecturerProfile()
        {
            try
            {
                User lecDetails = lecManager.getLecturerDetails(currentLecturerID);

                if (lecDetails != null)
                {
                    lblName.Text = lecDetails.Name;
                    lblEmail.Text = lecDetails.Email;
                    lblContact.Text = lecDetails.ContactNumber;
                    lblAddress.Text = lecDetails.Address;
                    lblDOB.Text = lecDetails.DOB;
                }
                else
                {
                    MessageBox.Show("Lecturer details not found in database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_manageLec managePage = new admin_manageLec();
            managePage.Show();
            this.Hide();
        }
    }
}
