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
    public partial class lec_editClass : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string studentName = "";
        string moduleName = "";
        string currentStatus = "";
        string stuID = "";
        string oldClassID = "";

        public lec_editClass(string selectedStudent, string selectedModule, string selectedStatus)
        {
            InitializeComponent();

            studentName = selectedStudent;
            moduleName = selectedModule;
            currentStatus = selectedStatus;

            lblStudent.Text = studentName;
            lblModule.Text = moduleName;
        }

        private void lec_editClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lec_editClass_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Paid");
            cmbStatus.Items.Add("Conducting");
            cmbStatus.Items.Add("Done");
            cmbStatus.SelectedItem = currentStatus;

            loadStudentAndClassDetails();
        }

        private void loadStudentAndClassDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string levelQuery = "select ClassLevel from Modules where ModuleName = @mod";
                    using (SqlCommand cmdLevel = new SqlCommand(levelQuery, connection))
                    {
                        cmdLevel.Parameters.AddWithValue("@mod", moduleName);
                        object result = cmdLevel.ExecuteScalar();
                        if (result != null)
                        {
                            lblLevel.Text = result.ToString();
                        }
                        else
                        {
                            lblLevel.Text = "Level Not Found";
                        }
                    }

                    string stuQuery = "select StuID from Student where Name = @name";
                    using (SqlCommand cmdStu = new SqlCommand(stuQuery, connection))
                    {
                        cmdStu.Parameters.AddWithValue("@name", studentName);

                        stuID = cmdStu.ExecuteScalar()?.ToString();
                    }

                    string oldClassQuery = @"select c.ClassID from StudentClass sc inner join Class c on sc.ClassID = c.ClassID where sc.StuID = @stu and c.ModuleName = @mod";
                    using (SqlCommand cmdOldClass = new SqlCommand(oldClassQuery, connection))
                    {
                        cmdOldClass.Parameters.AddWithValue("@stu", stuID);
                        cmdOldClass.Parameters.AddWithValue("@mod", moduleName);

                        oldClassID = cmdOldClass.ExecuteScalar()?.ToString();
                    }

                    string scheduleQuery = @"select c.ClassID, concat(t.Name, ' (', c.ClassStartTime, ' - ', c.ClassEndTime, ')') as ScheduleDetails from Class c inner join Trainer t on c.TrainerID = t.UserID where c.ModuleName = @mod";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(scheduleQuery, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@mod", moduleName);
                        DataTable dtSchedule = new DataTable();
                        adapter.Fill(dtSchedule);

                        cmbSchedule.DataSource = dtSchedule;
                        cmbSchedule.DisplayMember = "ScheduleDetails";
                        cmbSchedule.ValueMember = "ClassID";

                        if (!string.IsNullOrEmpty(oldClassID))
                        {
                            cmbSchedule.SelectedValue = oldClassID;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cmbSchedule.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a new schedule.");
                return;
            }

            string newClassID = cmbSchedule.SelectedValue.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "update StudentClass set ClassID = @newClass where StuID = @stu and ClassID = @oldClass";
                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, connection))
                    {
                        cmdUpdate.Parameters.AddWithValue("@newClass", newClassID);
                        cmdUpdate.Parameters.AddWithValue("@stu", stuID);
                        cmdUpdate.Parameters.AddWithValue("@oldClass", oldClassID);

                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show($"{studentName}'s schedule has been updated successfully!");

                    lec_viewStudent viewPage = new lec_viewStudent();
                    viewPage.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
