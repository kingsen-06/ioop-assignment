using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

namespace assignment
{
    public partial class main_loginPage : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public main_loginPage()
        {
            InitializeComponent();
        }

        private void main_loginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email cannot be empty!");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty!");
                return;
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter a valid email format. (e.g. example@gmail.com)");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string loginQuery = "select UserID, Role from Users where Email = @email and Password = @password";
                    using (SqlCommand loginCommand = new SqlCommand(loginQuery, connection))
                    {
                        loginCommand.Parameters.AddWithValue("@email", email);
                        loginCommand.Parameters.AddWithValue("@password", password);

                        string id = "";
                        string role = "";

                        using (SqlDataReader loginReader = loginCommand.ExecuteReader())
                        {
                            if (loginReader.Read())
                            {
                                id = loginReader["UserID"].ToString();
                                role = loginReader["Role"].ToString();

                                User.CurrentUser = new User(id, email, role);
                            }
                        }

                        if (User.CurrentUser != null)
                        {
                            string tableName = "";
                            bool isStudent = (role == "Student");

                            if (role == "Admin" || role == "Super Admin")
                            {
                                tableName = "Admin";
                            }
                            else if (role == "Lecturer")
                            {
                                tableName = "Lecturer";
                            }
                            else if (role == "Trainer")
                            {
                                tableName = "Trainer";
                            }
                            else if (role == "Student")
                            {
                                tableName = "Student";
                            }

                            if (!string.IsNullOrEmpty(tableName))
                            {
                                string profileQuery = isStudent ? 
                                    $"select Name, TPNumber from {tableName} where UserID = @UserID" : 
                                    $"select Name from {tableName} where UserID = @UserID";

                                using (SqlCommand profileCommand = new SqlCommand(profileQuery, connection))
                                {
                                    profileCommand.Parameters.AddWithValue("@UserID", id);

                                    using (SqlDataReader profileReader = profileCommand.ExecuteReader())
                                    {
                                        if (profileReader.Read())
                                        {
                                            User.CurrentUser.Name = profileReader["Name"].ToString();
                                        }
                                    }
                                }
                            }
                            MessageBox.Show($"Login Successful! Welcome, {User.CurrentUser.Name}!");

                            if (role == "Admin")
                            {
                                admin_menu adminMenu = new admin_menu();
                                adminMenu.Show();
                            }
                            else if (role == "Super Admin")
                            {
                                superAdmin_menu superAdminMenu = new superAdmin_menu();
                                superAdminMenu.Show();
                            }
                            else if (role == "Lecturer")
                            {
                                lec_menu lecMenu = new lec_menu();
                                lecMenu.Show();
                            }
                            else if (role == "Trainer")
                            {
                                trainer_menu trainerMenu = new trainer_menu();
                                trainerMenu.Show();
                            }
                            else if (role == "Student")
                            {
                                student_menu studentMenu = new student_menu();
                                studentMenu.Show();
                            }         

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login Failed!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection error: " + ex.Message);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            student_registerPage registerPage = new student_registerPage();
            registerPage.Show();
            this.Hide();
        }
    }
}
