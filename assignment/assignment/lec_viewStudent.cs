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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace assignment
{
    public partial class lec_viewStudent : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public lec_viewStudent()
        {
            InitializeComponent();
            cmbName.Items.Clear(); // To avoid double loaded when the user double clicked
        }

        private void lec_viewStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void lec_viewStudent_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string moduleQuery = "select distinct ModuleName from Class";
                    using (SqlCommand commandModule = new SqlCommand(moduleQuery, connection))
                    {
                        using (SqlDataReader reader = commandModule.ExecuteReader())
                        {
                            cmbName.Items.Clear();

                            cmbName.Items.Add("All Modules");

                            while (reader.Read())
                            {
                                string item = reader["ModuleName"].ToString();
                                cmbName.Items.Add(item);
                            }                           
                        }
                    }

                    if (cmbName.Items.Count > 0)
                    {
                        cmbName.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading modules: " + ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lec_addStudent addStudent = new lec_addStudent();
            addStudent.Show();
            this.Hide();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            lec_menu lecMenu = new lec_menu();
            lecMenu.Show();
            this.Hide();
        }

        private void btnAssignClass_Click(object sender, EventArgs e)
        {
            if (dataStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student from the table first before assigning a class");
                return;
            }

            string selectedStudent = dataStudent.SelectedRows[0].Cells[0].Value.ToString();

            lec_assignStudent assignStudent = new lec_assignStudent(selectedStudent);
            assignStudent.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student from the table first before assigning a class");
                return;
            }

            string selectedStudent = dataStudent.SelectedRows[0].Cells[0].Value.ToString();
            string selectedModule = dataStudent.SelectedRows[0].Cells[1].Value.ToString();
            string currentStatus = dataStudent.SelectedRows[0].Cells[2].Value.ToString();

            lec_editClass editClass = new lec_editClass(selectedStudent, selectedModule, currentStatus);
            editClass.Show();
            this.Hide();
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string module = cmbName.Text.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (module == "All Modules")
                    {
                        lblClassLevel.Text = "-";
                    }
                    else
                    {
                        string levelQuery = "select ClassLevel from Modules where ModuleName = @module";
                        using (SqlCommand commandClass = new SqlCommand(levelQuery, connection))
                        {
                            commandClass.Parameters.AddWithValue("@module", module);

                            object result = commandClass.ExecuteScalar();
                            if (result != null)
                            {
                                lblClassLevel.Text = result.ToString();
                            }
                            else
                            {
                                lblClassLevel.Text = "Level Not Found";
                            }
                        }
                    } 

                    // input needed for data grid view: ModuleName to get students in the class
                    dataStudent.Rows.Clear(); // To avoid double load when the user double clicked

                    dataStudent.AllowUserToAddRows = false;
                    dataStudent.AllowUserToDeleteRows = false;
                    dataStudent.ReadOnly = true;

                    List<string[]> temp = new List<string[]>();
                    string studentQuery = "select s.StuID, s.Name, c.ModuleName from StudentClass sc inner join Student s on sc.StuID = s.StuID inner join Class c on sc.ClassID = c.ClassID";

                    if (module != "All Modules")
                    {
                        studentQuery += " where c.ModuleName = @mod";
                    }

                    using (SqlCommand commandStudent = new SqlCommand(studentQuery, connection))
                    {
                        if (module != "All Modules")
                        {
                            commandStudent.Parameters.AddWithValue("@mod", module);
                        }

                        using (SqlDataReader reader1 = commandStudent.ExecuteReader())
                        {
                            // Extract data of every rows
                            while (reader1.Read())
                            {
                                string stuID = reader1["StuID"].ToString();
                                string name = reader1["Name"].ToString();
                                string mod = reader1["ModuleName"].ToString();          
                                // Status should be paid, conducting and finished

                                // Add values into list before add into datagridview
                                temp.Add(new string[] { stuID, name, mod });
                            }
                        }
                    }

                    foreach (string[] item in temp)
                    {
                        string getClassNum = "select count(sc.ClassID) as ClassNumber from StudentClass sc inner join Class c on sc.ClassID = c.ClassID where sc.StuID = @stuID and c.ModuleName = @mod";

                        string stuID = item[0];
                        string name = item[1];
                        string mod = item[2];
                        string status = "Unknown";

                        using (SqlCommand cmdClassNum = new SqlCommand(getClassNum, connection))
                        {
                            cmdClassNum.Parameters.AddWithValue("@stuID", stuID);
                            cmdClassNum.Parameters.AddWithValue("@mod", mod);

                            using (SqlDataReader reader2 = cmdClassNum.ExecuteReader())
                            {
                                if (reader2.Read())
                                {
                                    int classNum = int.Parse(reader2["ClassNumber"].ToString());
                                    if (classNum == 0) status = "Paid";
                                    else if (classNum >= 1 && classNum <= 3) status = "Conducting";
                                    else status = "Done";
                                }
                            }
                        }

                        dataStudent.Rows.Add(name, mod, status);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            // To ensure the user at least choose 1 row
            if (dataStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please choose at least 1 row for this action! ");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to remove the selected student(s)?\nThis action cannot be redone!", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        int totalDeleted = 0;

                        string delStuClass = @"delete from StudentClass where StuID = (select StuID from student where Name = @name) and ClassID = (select ClassID from Class where ModuleName = @mod)";

                        foreach (DataGridViewRow row in dataStudent.SelectedRows)
                        {
                            string name = row.Cells[0].Value?.ToString();
                            string mod = row.Cells[1].Value?.ToString();

                            using (SqlCommand cmdDel = new SqlCommand(delStuClass, connection))
                            {
                                cmdDel.Parameters.AddWithValue("@name", name);
                                cmdDel.Parameters.AddWithValue("@mod", mod);

                                int rowsAffected = cmdDel.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    totalDeleted++;
                                }
                            }
                        }

                        if (totalDeleted > 0)
                        {
                            MessageBox.Show($"Successfully deleted {totalDeleted} student(s).");
                            cmbName_SelectedIndexChanged(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Error: Could not find matching student/class in the database");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error during deletion: " + ex.Message);
                    }
                }
            }
        }
    }
}
