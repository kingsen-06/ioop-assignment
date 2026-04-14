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
    public partial class lec_assignStudent : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string studentName = "";
        string studentID = "";

        public lec_assignStudent(string selectedStudent)
        {
            InitializeComponent();

            studentName = selectedStudent;
        }

        private void lec_assignStudent_Load(object sender, EventArgs e)
        {
            getStudentID();
            loadModules();
        }

        private void lec_assignStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void getStudentID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "select StuID from Student where Name = @name";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", studentName);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            studentID = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void loadModules()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "select distinct ModuleName from Class";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cmbModule.Items.Clear();
                            while (reader.Read())
                            {
                                cmbModule.Items.Add(reader["ModuleName"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading modules: " + ex.Message);
                }
            }
        }

        private void cmbModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModule.SelectedIndex == -1) return;

            string selectedModule = cmbModule.SelectedItem.ToString();
            cmbTrainer.DataSource = null;
            cmbSchedule.DataSource = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // A. Get the Class Level
                    string levelQuery = "select ClassLevel from Modules where ModuleName = @mod";
                    using (SqlCommand cmdLevel = new SqlCommand(levelQuery, connection))
                    {
                        cmdLevel.Parameters.AddWithValue("@mod", selectedModule);

                        object result = cmdLevel.ExecuteScalar();
                        if (result != null)
                        {
                            lblLevel.Text = result.ToString();
                        }
                        else
                        {
                            lblLevel.Text = "Unknown Level";
                        }
                    }

                    string trainerQuery = @"select distinct t.UserID, t.Name from Class c inner join Trainer t on c.TrainerID = t.UserID where c.ModuleName = @mod";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(trainerQuery, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@mod", selectedModule);
                        DataTable dtTrainers = new DataTable();
                        adapter.Fill(dtTrainers);

                        cmbTrainer.DataSource = dtTrainers;
                        cmbTrainer.DisplayMember = "Name";
                        cmbTrainer.ValueMember = "UserID";
                        cmbTrainer.SelectedIndex = -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading trainers: " + ex.Message);
                }
            }
        }

        private void cmbTrainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedModule = cmbModule.SelectedItem.ToString();
            string selectedTrainerID = cmbTrainer.SelectedValue.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string scheduleQuery = @"select ClassID, concat(ClassStartTime, ' to ', ClassEndTime) as ScheduleText from Class where ModuleName = @mod and TrainerID = @trainer";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(scheduleQuery, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@mod", selectedModule);
                        adapter.SelectCommand.Parameters.AddWithValue("@trainer", selectedTrainerID);

                        DataTable dtSchedule = new DataTable();
                        adapter.Fill(dtSchedule);

                        cmbSchedule.DataSource = dtSchedule;
                        cmbSchedule.DisplayMember = "ScheduleText";
                        cmbSchedule.ValueMember = "ClassID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading schedule: " + ex.Message);
                }
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cmbModule.SelectedIndex == -1 || cmbTrainer.SelectedIndex == -1 || cmbSchedule.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Module, Trainer and Schedule to assign the class.");
                return;
            }

            string selectedClassID = cmbSchedule.SelectedValue.ToString();

            StudentClass newEnrollment = new StudentClass(studentID, selectedClassID);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkQuery = "select count(*0 from StudentClass where StuID = @stu and ClassID = @class";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, connection))
                    {
                        cmdCheck.Parameters.AddWithValue("@stu", newEnrollment.StuID);
                        cmdCheck.Parameters.AddWithValue("@class", newEnrollment.ClassID);
                        int exists = int.Parse(cmdCheck.ExecuteScalar().ToString());

                        if (exists > 0)
                        {
                            MessageBox.Show($"{studentName} is already assigned to this class schedule!");
                            return;
                        }
                    }

                    string insertQuery = "insert into StudentClass values (@stu, @class)";
                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, connection))
                    {
                        cmdInsert.Parameters.AddWithValue("@stu", newEnrollment.StuID);
                        cmdInsert.Parameters.AddWithValue("@class", newEnrollment.ClassID);

                        cmdInsert.ExecuteNonQuery();
                    }

                    MessageBox.Show($"{studentName} has been successfully assigned to {cmbModule.SelectedItem}.");

                    lec_viewStudent viewPage = new lec_viewStudent();
                    viewPage.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            lec_viewStudent viewPage = new lec_viewStudent();
            viewPage.Show();
            this.Hide();
        }
    }
}
