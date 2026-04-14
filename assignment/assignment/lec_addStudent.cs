using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace assignment
{
    public partial class lec_addStudent : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public lec_addStudent()
        {
            InitializeComponent();
        }

        private void lec_addStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lec_addStudent_Load(object sender, EventArgs e)
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
                            cmbModName.Items.Clear();
                            while (reader.Read())
                            {
                                cmbModName.Items.Add(reader["ModuleName"].ToString());
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

        private void lblBack_Click(object sender, EventArgs e)
        {
            lec_viewStudent viewStudent = new lec_viewStudent();
            viewStudent.Show();
            this.Hide();
        }

        private void cmbModName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModName.SelectedIndex != -1)
            {
                string module = cmbModName.SelectedItem.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string levelQuery = "select ClassLevel from Modules where ModuleName = @module";
                        using (SqlCommand commandLevel = new SqlCommand(levelQuery, connection))
                        {
                            commandLevel.Parameters.AddWithValue("@module", module);

                            object result = commandLevel.ExecuteScalar();
                            if (result != null)
                            {
                                lblLevel.Text = result.ToString();
                            }
                            else
                            {
                                lblLevel.Text = "Level Not Found";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading level: " + ex.Message);
                    }
                }
            }
        }

        private void bnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtName.Text.Trim();
            string tpNum = txtTPNum.Text.Trim().ToUpper();
            string email = txtEmail.Text.Trim();
            string contact = txtContact.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtTPNum.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtContact.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || cmbModName.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string tpPattern = @"^TP\d{6}$";
            if (!Regex.IsMatch(tpNum, tpPattern))
            {
                MessageBox.Show("Please enter a valid TP Number format. (e.g., TP123456)");
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email format. (e.g. user@gmail.com)");
                return;
            }

            string contactPattern = @"^01\d-\d{7,8}$";
            if (!Regex.IsMatch(contact, contactPattern))
            {
                MessageBox.Show("Please enter a valid contact number format. (e.g., 012-3456789)");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string checkQuery = "select count(*) from Student where Email = @email or TPNumber = @tp";
                    using (SqlCommand commandCheck = new SqlCommand(checkQuery, connection, transaction))
                    {
                        commandCheck.Parameters.AddWithValue("@email", email);
                        commandCheck.Parameters.AddWithValue("@tp", tpNum);

                        int exists = int.Parse(commandCheck.ExecuteScalar().ToString());
                        if (exists > 0)
                        {
                            MessageBox.Show("A student with this Email or TP Number already exists!");
                            transaction.Rollback();
                            return;
                        }
                    }

                    string defaultPassword = "student123";
                    string generatedUserID = "";

                    string userQuery = "insert into Users output inserted.UserID values (@email, @password, 'Student')";
                    using (SqlCommand userCommand = new SqlCommand(userQuery, connection, transaction))
                    {
                        userCommand.Parameters.AddWithValue("@email", email);
                        userCommand.Parameters.AddWithValue("@password", defaultPassword);

                        generatedUserID = userCommand.ExecuteScalar().ToString();
                    }

                    string generatedStuID = "";

                    string studentQuery = "insert into Student output inserted.StuID values (@userID, @email, @name, @tp, @contact, @address)";
                    using (SqlCommand studentCommand = new SqlCommand(studentQuery, connection, transaction))
                    {
                        studentCommand.Parameters.AddWithValue("@userID", generatedUserID);
                        studentCommand.Parameters.AddWithValue("@email", email);
                        studentCommand.Parameters.AddWithValue("@name", fullName);
                        studentCommand.Parameters.AddWithValue("@tp", tpNum);
                        studentCommand.Parameters.AddWithValue("@contact", contact);
                        studentCommand.Parameters.AddWithValue("@address", address);

                        generatedStuID = studentCommand.ExecuteScalar().ToString();
                    }

                    if (cmbModName.SelectedIndex != -1)
                    {
                        string module = cmbModName.SelectedItem.ToString();
                        string classID = "";
                        string getClass = "select ClassID from Class where ModuleName = @mod";
                        using (SqlCommand commandGetClass = new SqlCommand(getClass, connection, transaction))
                        {
                            commandGetClass.Parameters.AddWithValue("@mod", module);

                            object classResult = commandGetClass.ExecuteScalar();
                            if (classResult != null)
                            {
                                classID = classResult.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No scheduled class found for this module.");
                            }
                        }

                        if (!string.IsNullOrEmpty(classID))
                        {
                            string insertClass = "insert into StudentClass values (@stuID, @classID)";
                            using (SqlCommand commandClass = new SqlCommand(insertClass, connection, transaction))
                            {
                                commandClass.Parameters.AddWithValue("@stuID", generatedStuID);
                                commandClass.Parameters.AddWithValue("@classID", classID);
                                commandClass.ExecuteNonQuery();
                            }
                        }                  
                    }

                    transaction.Commit();

                    MessageBox.Show($"Successfully registered Student: {fullName}!\nTemporary password: {defaultPassword}");

                    lec_viewStudent viewPage = new lec_viewStudent();
                    viewPage.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error registering student: " + ex.Message);
                }
            }
        }
    }
}
