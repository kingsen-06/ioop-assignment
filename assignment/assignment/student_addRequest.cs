using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace assignment
{
    public partial class student_addRequest : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string currentStuID = "";

        public student_addRequest()
        {
            InitializeComponent();
        }

        private void student_addRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void student_addRequest_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string stuQuery = "select StuID from Student where Email = @email";
                    using (SqlCommand cmdStu = new SqlCommand(stuQuery, conn))
                    {
                        cmdStu.Parameters.AddWithValue("@email", User.CurrentUser.Email);
                        currentStuID = cmdStu.ExecuteScalar()?.ToString();
                    }

                    string lecQuery = "select LecID, Name from Lecturer";
                    using (SqlDataAdapter adapterLec = new SqlDataAdapter(lecQuery, conn))
                    {
                        DataTable dtLec = new DataTable();
                        adapterLec.Fill(dtLec);

                        cmbLec.DataSource = dtLec;
                        cmbLec.DisplayMember = "Name";
                        cmbLec.ValueMember = "LecID";
                        cmbLec.SelectedIndex = -1;
                    }

                    string modQuery = "select distinct ModuleName from Modules";
                    using (SqlCommand cmdMod = new SqlCommand(modQuery, conn))
                    {
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
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            student_manageRequest manageRequest = new student_manageRequest();
            manageRequest.Show();
            this.Hide();
        }

        public void AddRequest(string lecturerName, string module, string level)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string stuID = "";
                using (SqlCommand findStuQuery = new SqlCommand("Select StuID FROM Student WHERE Email = @email", conn))
                {
                    using (SqlDataReader readerStu = findStuQuery.ExecuteReader())
                    {
                        if (readerStu.Read())
                        {
                            stuID = readerStu["StuID"].ToString();
                        }
                    }

                    string lect_id = "";
                    using (SqlCommand findLecQuery = new SqlCommand("Select LecID from Lecturer where Name = @a", conn))
                    {
                        findLecQuery.Parameters.AddWithValue("@a", lecturerName);

                        using (SqlDataReader reader = findLecQuery.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lect_id = reader["LecID"].ToString();
                            }
                        }
                    }

                    using (SqlCommand insertQuery = new SqlCommand("Insert into ClassRequest(StuID,ModuleName,ClassLevel,LecturerID,Status) values(@stuID,@module,@lvl,@lecID,'Pending')", conn))
                    {
                        insertQuery.Parameters.AddWithValue("@stuID", stuID);
                        insertQuery.Parameters.AddWithValue("@module", module);
                        insertQuery.Parameters.AddWithValue("@lvl", level);
                        insertQuery.Parameters.AddWithValue("@lecID", lect_id);

                        insertQuery.ExecuteNonQuery();
                    }
                }
            }
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbName.SelectedIndex != -1)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string levelQuery = "select ClassLevel from Modules where ModuleName = @mod";
                        using (SqlCommand cmdLvl = new SqlCommand(levelQuery, conn))
                        {
                            cmdLvl.Parameters.AddWithValue("@mod", cmbName.SelectedItem.ToString());

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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading level: " + ex.Message);
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if (cmbLec.SelectedIndex == -1 || cmbName.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both a Lecturer and a Module.");
                return;
            }

            string selectedLecID = cmbLec.SelectedValue.ToString();
            string selectedModule = cmbName.SelectedItem.ToString();
            string selectedLevel = lblLevel.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string checkQuery = "select count(*) from ClassRequest where StuID = @stuID and ModuleName = @module and Status = 'Pending'";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@stuID", currentStuID);
                        cmdCheck.Parameters.AddWithValue("@module", selectedModule);

                        int exists = int.Parse(cmdCheck.ExecuteScalar().ToString());
                        if (exists > 0)
                        {
                            MessageBox.Show("You already have a Pending request for this module!", "Duplicate Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    string insertQuery = "insert into ClassRequest values (@stuID, @module, @lvl, @lecID, 'Pending')";
                    using (SqlCommand cmdInsert = new SqlCommand(insertQuery, conn))
                    {
                        cmdInsert.Parameters.AddWithValue("@stuID", currentStuID);
                        cmdInsert.Parameters.AddWithValue("@module", selectedModule);
                        cmdInsert.Parameters.AddWithValue("@lvl", selectedLevel);
                        cmdInsert.Parameters.AddWithValue("@lecID", selectedLecID);

                        cmdInsert.ExecuteNonQuery();
                    }

                    MessageBox.Show("Your request has been sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    student_manageRequest manageRequest = new student_manageRequest();
                    manageRequest.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error sending request: " + ex.Message);
                }
            }
        }
    }
}
