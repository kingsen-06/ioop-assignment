using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class admin_manageTrainer : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public admin_manageTrainer()
        {
            InitializeComponent();
        }

        private void admin_manageTrainer_Load(object sender, EventArgs e)
        {
            loadTrainerData();
        }

        private void btnAddTrainer_Click(object sender, EventArgs e)
        {
            admin_addTrainer registerTrainer = new admin_addTrainer();
            registerTrainer.Show();
            this.Hide();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            admin_monthChoice monthChoice = new admin_monthChoice();
            monthChoice.Show();
            this.Hide();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (lstTrainer.SelectedValue != null)
            {
                string selectedID = lstTrainer.SelectedValue.ToString();

                admin_trainerDetail trainerDetail = new admin_trainerDetail(selectedID);
                trainerDetail.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a trainer from the list first.");
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            admin_menu adminMenu = new admin_menu();
            adminMenu.Show();
            this.Hide();
        }

        private void loadTrainerData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "select UserID, Name from Trainer";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable trainerTable = new DataTable();
                        adapter.Fill(trainerTable);

                        lstTrainer.DataSource = trainerTable;
                        lstTrainer.DisplayMember = "Name";
                        lstTrainer.ValueMember = "UserID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
