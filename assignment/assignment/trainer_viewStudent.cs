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
    public partial class trainer_viewStudent : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string currentTrainerID = "";

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

        private void trainer_viewStudent_Load(object sender, EventArgs e)
        {
            dataStudent.AllowUserToAddRows = false;
            dataStudent.AllowUserToDeleteRows = false;
            dataStudent.ReadOnly = true;
            dataStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string getTrainerID = "select TrainerID from Trainer where Email = @email";
                    using (SqlCommand cmdTrainer = new SqlCommand(getTrainerID, conn))
                    {
                        cmdTrainer.Parameters.AddWithValue("@email", User.CurrentUser.Email);

                        currentTrainerID = cmdTrainer.ExecuteScalar()?.ToString();
                    }

                    string getModules = "select distinct ModuleName from Class where TrainerID = @trainerID";
                    using (SqlCommand cmdMod = new SqlCommand(getModules, conn))
                    {
                        cmdMod.Parameters.AddWithValue("@trainerID", currentTrainerID);

                        using (SqlDataReader reader = cmdMod.ExecuteReader())
                        {
                            cmbName.Items.Clear();
                            while (reader.Read())
                            {
                                cmbName.Items.Add(reader["ModuleName"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbName.SelectedIndex != -1)
            {
                string selectedModule = cmbName.SelectedItem.ToString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string getLevel = "select ClassLevel from Modules where ModuleName = @mod";
                        using (SqlCommand cmdLvl = new SqlCommand(getLevel, conn))
                        {
                            cmdLvl.Parameters.AddWithValue("@mod", selectedModule);

                            object result = cmdLvl.ExecuteScalar();
                            if (result != null)
                            {
                                lblLevel.Text = result.ToString();
                            }
                            else
                            {
                                lblLevel.Text = "Level Not Found";
                            }
                        }

                        string getStudents = """
                        select 
                            s.Name AS [Student Name], 
                            concat(c.ClassStartTime, ' - ', c.ClassEndTime) as [Class Schedule], 
                            c.ClassVenue as [Class Venue], 
                            s.ContactNumber as [Phone]
                        from StudentClass sc
                        inner join Student s on sc.StuID = s.StuID
                        inner join Class c on sc.ClassID = c.ClassID
                        where c.TrainerID = @trainerID and c.ModuleName = @module
                        """;

                        using (SqlCommand cmdStudents = new SqlCommand(getStudents, conn))
                        {
                            cmdStudents.Parameters.AddWithValue("@trainerID", currentTrainerID);
                            cmdStudents.Parameters.AddWithValue("@module", selectedModule);

                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmdStudents))
                            {
                                DataTable dtStudents = new DataTable();
                                adapter.Fill(dtStudents);

                                dataStudent.DataSource = dtStudents;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading students: " + ex.Message);
                    }
                }
            }
        }
    }
}
