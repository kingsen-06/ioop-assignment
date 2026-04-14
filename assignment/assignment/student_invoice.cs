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
    public partial class student_invoice : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        string selectedID;
        public student_invoice(string paymentID)
        {
            InitializeComponent();
            selectedID = paymentID;
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            student_paymentList paymentList = new student_paymentList();
            paymentList.Show();
            this.Hide();
        }

        private void student_invoice_Load(object sender, EventArgs e)
        {
            dataDetail.AllowUserToAddRows = false;
            dataDetail.AllowUserToDeleteRows = false;
            dataDetail.ReadOnly = true;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = """
                    select
                        s.Name,
                        s.Address,
                        s.Email,
                        sp.PaymentID,
                        sp.PaymentDate,
                        sp.Description,
                        c.ClassFee,
                        sp.Status
                    from StudentPayment sp
                    inner join Student s on sp.StuID = s.StuID
                    inner join StudentClass sc on s.StuID = sc.StuID
                    inner join Class c on sc.ClassID = c.ClassID
                    where sp.PaymentID = @paymentID
                    """;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@paymentID", selectedID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblName.Text = reader["Name"].ToString();
                                lblEmail.Text = reader["Email"].ToString();
                                lblID.Text = reader["PaymentID"].ToString();
                                lblDate.Text = Convert.ToDateTime(reader["PaymentDate"]).ToString("dd/MM/yyyy");

                                dataDetail.Rows.Clear();
                                dataDetail.Rows.Add(reader["Description"].ToString());

                                decimal fee = Convert.ToDecimal(reader["ClassFee"]);
                                lblTotal.Text = "RM " + fee.ToString("0.00");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating invoice: " + ex.Message);
                }
            }
        }
    }
}
