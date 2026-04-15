using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class LecturerManager
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public DataTable getAllLecturers()
        {
            DataTable lecturerTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select UserID, Name from Lecturer";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(lecturerTable);
                    }
                }   
            }
            return lecturerTable;
        }

        public bool deleteLecturer(string userID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string query1 = "delete from Lecturer where UserID = @UserID";
                    using (SqlCommand command1 = new SqlCommand(query1, connection, transaction))
                    {
                        command1.Parameters.AddWithValue("@UserID", userID);

                        command1.ExecuteNonQuery();
                    }

                    string query2 = "delete from Users where UserID = @UserID";
                    using (SqlCommand command2 = new SqlCommand(query2, connection, transaction))
                    {
                        command2.Parameters.AddWithValue("@UserID", userID);

                        command2.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public string registerLecturer(User newLec, string defaultPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Check if same email is used
                    string checkQuery = "select count(*) from Users where Email = @email";
                    using (SqlCommand commandCheck = new SqlCommand(checkQuery, connection, transaction))
                    {
                        commandCheck.Parameters.AddWithValue("@email", newLec.Email);

                        int exists = int.Parse(commandCheck.ExecuteScalar().ToString());
                        if (exists > 0)
                        {
                            transaction.Rollback();
                            return "Email exists";
                        }
                    }

                    string generatedUserID = "";
                    string userQuery = "insert into Users (Email, Password, Role) output inserted.UserID values (@email, @password, 'Lecturer')";
                    using (SqlCommand userCommand = new SqlCommand(userQuery, connection, transaction))
                    {
                        userCommand.Parameters.AddWithValue("@email", newLec.Email);
                        userCommand.Parameters.AddWithValue("@password", defaultPassword);

                        generatedUserID = userCommand.ExecuteScalar().ToString();
                    }

                    string lecQuery = "insert into Lecturer (UserID, Name, DateOfBirth, ContactNumber, Address) values (@UserID, @name, @DOB, @contact, @address)";
                    using (SqlCommand lecCommand = new SqlCommand(lecQuery, connection, transaction))
                    {
                        lecCommand.Parameters.AddWithValue("@UserID", generatedUserID);
                        lecCommand.Parameters.AddWithValue("@name", newLec.Name);
                        lecCommand.Parameters.AddWithValue("@DOB", newLec.DOB);
                        lecCommand.Parameters.AddWithValue("@contact", newLec.ContactNumber);
                        lecCommand.Parameters.AddWithValue("@address", newLec.Address);

                        lecCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return "Success";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return "Error: " + ex.Message;
                }
            }
        }

        public User getLecturerDetails(string userID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "select l.Name, l.DateOfBirth, u.Email, l.ContactNumber, l.Address from Lecturer l inner join Users u on l.UserID = u.UserID where l.UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string name = reader["Name"].ToString();
                            string email = reader["Email"].ToString();
                            string contact = reader["ContactNumber"].ToString();
                            string address = reader["Address"].ToString();

                            string dob = Convert.ToDateTime(reader["DateOfBirth"]).ToString("dd MMM yyyy");

                            return new User(name, email, contact, address, dob);
                        }
                    }
                }
            }
            return null;
        }
    }
}
