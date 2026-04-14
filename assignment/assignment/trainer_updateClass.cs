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
    public partial class trainer_updateClass : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

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
            if (dataClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a class from the list to edit.");
                return;
            }

            string selectedClassID = dataClass.SelectedRows[0].Cells[0].Value?.ToString();

            trainer_editClass editClass = new trainer_editClass(selectedClassID);
            editClass.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            trainer_menu trainerMenu = new trainer_menu();
            trainerMenu.Show();
            this.Hide();
        }

        private void trainer_updateClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void trainer_updateClass_Load(object sender, EventArgs e)
        {
            dataClass.AllowUserToAddRows = false;
            dataClass.AllowUserToDeleteRows = false;
            dataClass.ReadOnly = true;
            dataClass.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            loadTrainerClasses();
        }

        private void loadTrainerClasses()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = """
                        select 
                            c.ClassID, 
                            c.ModuleName, 
                            m.ClassLevel, 
                            concat(c.ClassStartTime, ' - ', c.ClassEndTime) as ClassSchedule,
                            c.ClassVenue
                        from Class c
                        inner join Modules m on c.ModuleName = m.ModuleName
                        inner join Trainer t on c.TrainerID = t.UserID
                        where t.Email = @email
                        """;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", User.CurrentUser.Email);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dataClass.Rows.Clear();

                            while (reader.Read())
                            {
                                dataClass.Rows.Add(
                                    reader["ClassID"].ToString(),
                                    reader["ModuleName"].ToString(),
                                    reader["ClassLevel"].ToString(),
                                    reader["ClassSchedule"].ToString(),
                                    reader["ClassVenue"].ToString()
                                );
                            }
                        }
                    }

                    if (dataClass.Columns.Count > 0)
                    {
                        dataClass.Columns[0].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading classes: " + ex.Message);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a class from the list to remove.");
                return;
            }

            string selectedClassID = dataClass.SelectedRows[0].Cells[0].Value?.ToString();
            string selectedModule = dataClass.SelectedRows[0].Cells[1].Value?.ToString();

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete the schedule for {selectedModule}?This action cannot be undone!", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string checkEnrollment = "select count(*) from StudentClass where ClassID = @classID";
                        using (SqlCommand cmdCheck = new SqlCommand(checkEnrollment, conn))
                        {
                            cmdCheck.Parameters.AddWithValue("@classID", selectedClassID);

                            int studentCount = int.Parse(cmdCheck.ExecuteScalar().ToString());
                            if (studentCount > 0)
                            {
                                MessageBox.Show($"You cannot delete this class because {studentCount} student(s) are currently enrolled in it.\nPlease reassign the students before deleting the schedule.");
                                return;
                            }
                        }

                        string deleteQuery = "delete from Class where ClassID = @classID";
                        using (SqlCommand cmdDelete = new SqlCommand(deleteQuery, conn))
                        {
                            cmdDelete.Parameters.AddWithValue("@classID", selectedClassID);

                            cmdDelete.ExecuteNonQuery();

                            MessageBox.Show("Class schedule deleted successfully.");

                            loadTrainerClasses();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting class: " + ex.Message);
                    }
                }
            }
        }
    }
}
