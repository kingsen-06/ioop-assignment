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
    public partial class student_viewSchedule : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        public student_viewSchedule()
        {
            InitializeComponent();
        }

        private void student_viewSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            student_menu studentMenu = new student_menu();
            studentMenu.Show();
            this.Hide();
        }

        private void student_viewSchedule_Load(object sender, EventArgs e)
        {
            dataSchedule.AllowUserToAddRows = false;
            dataSchedule.AllowUserToDeleteRows = false;
            dataSchedule.ReadOnly = true;

            string query = """
                select
                    c.ModuleName,
                    m.ClassLevel,
                    t.Name,
                    c.ClassStartTime,
                    c.ClassEndTime,
                    c.ClassVenue
                from Class c
                inner join Modules m on c.ModuleName = m.ModuleName
                inner join Trainer t on c.TrainerID = t.UserID
                inner join StudentClass sc on c.ClassID = sc.ClassID
                inner join Student s on sc.StuID = s.StuID
                where s.Email = @email
                """;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@email", User.CurrentUser.Email);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dataSchedule.Rows.Clear();

                            while (reader.Read())
                            {
                                DateTime startTime = Convert.ToDateTime(reader["ClassStartTime"]);
                                DateTime endTime = Convert.ToDateTime(reader["ClassEndTime"]);
                                string schedule = $"{startTime:hh:mm tt} - {endTime:hh:mm tt}";

                                dataSchedule.Rows.Add(
                                    reader["ModuleName"].ToString(),
                                    reader["ClassLevel"].ToString(),
                                    reader["Name"].ToString(),
                                    schedule,
                                    reader["ClassVenue"].ToString()
                                    );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading schedule: " + ex.Message);
                }
            }
        }  
    }
}


