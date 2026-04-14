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
    public partial class student_paymentList : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;
        public student_paymentList()
        {
            InitializeComponent();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            if (dataPayment.SelectedRows.Count > 0)
            {
                string status = dataPayment.SelectedRows[0].Cells["Status"].Value.ToString();
                string paymentID = dataPayment.SelectedRows[0].Cells["PaymentID"].Value.ToString();

                if (status.ToLower() == "paid")
                {
                    student_invoice invoice = new student_invoice(paymentID);
                    invoice.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invoice is only available for Paid transactions.");
                }
            }
            else
            {
                MessageBox.Show("Please select a payment record first");
            }
            
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            student_menu studentMenu = new student_menu();
            studentMenu.Show();
            this.Hide();
        }

        private void student_paymentList_Load(object sender, EventArgs e)
        {
            dataPayment.AllowUserToAddRows = false;
            dataPayment.AllowUserToDeleteRows = false;
            dataPayment.ReadOnly = true;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = """
                    select
                        sp.PaymentID,
                        sp.Description,
                        sp.Receiver,
                        c.ClassFee,
                        sp.PaymentDate,
                        sp.Status
                    from StudentPayment sp
                    inner join Student s on sp.StuID = s.StuID
                    inner join StudentClass sc on s.StuID = sc.StuID
                    inner join Class c on sc.ClassID = c.ClassID
                    where s.Email = @email
                    """;

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@email", User.CurrentUser.Email);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dataPayment.Rows.Clear();

                            while (reader.Read())
                            {
                                dataPayment.Rows.Add(
                                reader["PaymentID"].ToString(),
                                reader["Description"].ToString(),
                                reader["Receiver"].ToString(),
                                "RM" + reader["ClassFee"].ToString(),
                                Convert.ToDateTime(reader["PaymentDate"]).ToString("dd/MM/yyyy"),
                                reader["Status"].ToString()
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading payments: " + ex.Message);
                }
            }
        }
    }
}
