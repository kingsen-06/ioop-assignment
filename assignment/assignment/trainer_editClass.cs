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
    public partial class trainer_editClass : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string selectedClassID = "";

        public trainer_editClass(string classID)
        {
            InitializeComponent();
            selectedClassID = classID;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            trainer_updateClass updateClass = new trainer_updateClass();
            updateClass.Show();
            this.Hide();
        }

        private void trainer_editClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void trainer_editClass_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = """
                        select 
                            c.ModuleName, 
                            m.ClassLevel, 
                            c.ClassStartTime, 
                            c.ClassVenue, 
                            c.ClassFee
                        from Class c
                        inner join Modules m on c.ModuleName = m.ModuleName
                        where c.ClassID = @classID
                        """;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@classID", selectedClassID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblName.Text = reader["ModuleName"].ToString();
                                lblLevel.Text = reader["ClassLevel"].ToString();

                                if (reader["ClassStartTime"] != DBNull.Value)
                                    dateSchedule.Value = Convert.ToDateTime(reader["ClassStartTime"]);

                                if (reader["ClassFee"] != DBNull.Value)
                                {
                                    numFee.Value = decimal.Parse(reader["ClassFee"].ToString());
                                }

                                txtVenue.Text = reader["ClassVenue"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Could not find the class details in the database.");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVenue.Text) || numFee.Value <= 0)
            {
                MessageBox.Show("Please enter a valid Class Venue and a Class Fee greater than 0.");
                return;
            }

            string updatedVenue = txtVenue.Text.Trim();
            decimal updatedFee = numFee.Value;

            DateTime updatedStartTime = dateSchedule.Value;
            DateTime updatedEndTime = updatedStartTime.AddHours(2);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();


                    string updateQuery = """
                        update Class 
                        set ClassStartTime = @start, 
                            ClassEndTime = @end, 
                            ClassVenue = @venue, 
                            ClassFee = @fee 
                        where ClassID = @classID
                        """;

                    using (SqlCommand cmdUpdate = new SqlCommand(updateQuery, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@start", updatedStartTime);
                        cmdUpdate.Parameters.AddWithValue("@end", updatedEndTime);
                        cmdUpdate.Parameters.AddWithValue("@venue", updatedVenue);
                        cmdUpdate.Parameters.AddWithValue("@fee", updatedFee);
                        cmdUpdate.Parameters.AddWithValue("@classID", selectedClassID);

                        cmdUpdate.ExecuteNonQuery();
                    }

                    MessageBox.Show("Class details have been updated successfully!");

                    trainer_updateClass updatePage = new trainer_updateClass();
                    updatePage.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating class: " + ex.Message);
                }
            }
        }
    }
}
