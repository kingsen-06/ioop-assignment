using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

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

        public void lec_viewStudent_Load(object sender, EventArgs e)
        {
            string getMod = "select ModuleName from Class";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmdMod = new SqlCommand(getMod, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = cmdMod.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                string item = reader["ModuleName"].ToString();
                                cmbName.Items.Add(item);
                            }
                            catch
                            {
                                MessageBox.Show("Error occurs. Returning back to Menu Page... ");
                            }
                        }
                    }
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
            lec_assignStudent assignStudent = new lec_assignStudent();
            assignStudent.Show();
            this.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lec_editClass editClass = new lec_editClass();
            editClass.Show();
            this.Hide();
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string module = cmbName.Text.ToString();
            string getClass = "select ClassLevel from Class where ModuleName = @mod";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmdClass = new SqlCommand(getClass, connection))
                {
                    cmdClass.Parameters.AddWithValue("@mod", module);
                    connection.Open();

                    using (SqlDataReader reader = cmdClass.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            try
                            {
                                lblLevel.Text = reader["ClassLevel"].ToString();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error occurs. Returning back to Menu Page... ");
                                student_menu Menu = new student_menu();
                                Menu.Show();
                                this.Hide();
                            }
                        }
                    }
                }
            }

            // input needed for data grid view: ModuleName, ClassLevel to get students in the class
            dataStudent.Rows.Clear(); // To avoid double load when the user double clicked
            string getStu = "select Name, ModuleName, ClassLevel from StudentClass inner join Student on StudentClass.StuID = Student.StuID \ninner join Class on StudentClass.ClassID = Class.ClassID \nwhere ModuleName = @mod and ClassLevel = @lvl";
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmdStu = new SqlCommand(getStu, connection))
                    {
                        cmdStu.Parameters.AddWithValue("@mod", cmbName.Text.ToString());
                        cmdStu.Parameters.AddWithValue("@lvl", lblLevel.Text);

                        connection.Open();

                        using (SqlDataReader reader = cmdStu.ExecuteReader())
                        {
                            // Extract data of every rows
                            while (reader.Read())
                            {
                                try
                                {
                                    string name = reader["Name"].ToString();
                                    string mod = reader["ModuleName"].ToString();
                                    string lvl = reader["ClassLevel"].ToString();
                                    // Status should be paid, conducting and finished
                                    string status = reader["ClassLevel"].ToString();

                                    dataStudent.Rows.Add(name, mod, lvl, status);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error occurs. Returning back to Menu Page... ");
                                    student_menu Menu = new student_menu();
                                    Menu.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                }
            } 
        }
    }
}
