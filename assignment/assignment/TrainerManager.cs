using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.Common;

namespace assignment
{
    internal class TrainerManager
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public DataTable getAllTrainers()
        {
            DataTable trainerTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select UserID, Name from Trainer";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using(SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                        adapter.Fill(trainerTable);
                    }
                }
            }
            return trainerTable;
        }

        public bool deleteTrainer(string userID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string query1 = "delete from TrainerAssignedModules where UserID = @UserID";
                    using (SqlCommand command1 = new SqlCommand(query1, connection, transaction))
                    {
                        command1.Parameters.AddWithValue("@UserID", userID);

                        command1.ExecuteNonQuery();
                    }

                    string query2 = "delete from Trainer where UserID = @UserID";
                    using (SqlCommand command2 = new SqlCommand(query2, connection, transaction))
                    {
                        command2.Parameters.AddWithValue("@UserID", userID);

                        command2.ExecuteNonQuery();
                    }

                    string query3 = "delete from Users where UserID = @UserID";
                    using (SqlCommand command3 = new SqlCommand(query3, connection, transaction))
                    {
                        command3.Parameters.AddWithValue("@UserID", userID);

                        command3.ExecuteNonQuery();
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

        public DataTable getModules()
        {
            DataTable modules = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select ModuleID, ModuleName, ClassLevel from Modules";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(modules);
                    }
                }
            }
            return modules;
        }

        public string registerTrainer(User newTrainer, string moduleID, string defaultPassword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Check if same email is used
                    string checkQuery = "select count(*) from Users where Email = @email";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection, transaction))
                    {
                        checkCommand.Parameters.AddWithValue("@email", newTrainer.Email);

                        int exists = int.Parse(checkCommand.ExecuteScalar().ToString());
                        if (exists > 0)
                        {
                            transaction.Rollback();
                            return "Email Exists";
                        }
                    }

                    string generatedUserID = "";
                    string userQuery = "insert into Users (Email, Password, Role) output inserted.UserID values (@email, @password, 'Trainer')";
                    using (SqlCommand userCommand = new SqlCommand(userQuery, connection, transaction))
                    {
                        userCommand.Parameters.AddWithValue("@email", newTrainer.Email);
                        userCommand.Parameters.AddWithValue("@password", defaultPassword);

                        generatedUserID = userCommand.ExecuteScalar().ToString();
                    }

                    string trainerQuery = "insert into Trainer (UserID, Name, DateOfBirth, ContactNumber, Address) values (@UserID, @name, @DOB, @contact, @address)";
                    using (SqlCommand trainerCommand = new SqlCommand(trainerQuery, connection, transaction))
                    {
                        trainerCommand.Parameters.AddWithValue("@UserID", generatedUserID);
                        trainerCommand.Parameters.AddWithValue("@name", newTrainer.Name);
                        trainerCommand.Parameters.AddWithValue("@DOB", newTrainer.DOB);
                        trainerCommand.Parameters.AddWithValue("@contact", newTrainer.ContactNumber);
                        trainerCommand.Parameters.AddWithValue("@address", newTrainer.Address);

                        trainerCommand.ExecuteNonQuery();
                    }

                    string assignQuery = "insert into TrainerAssignedModules values (@UserID, @ModuleID)";
                    using (SqlCommand assignCommand = new SqlCommand(assignQuery, connection, transaction))
                    {
                        assignCommand.Parameters.AddWithValue("@UserID", generatedUserID);
                        assignCommand.Parameters.AddWithValue("@ModuleID", moduleID);

                        assignCommand.ExecuteNonQuery();
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

        public User getTrainerDetails(string userID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "select t.Name, t.DateOfBirth, u.Email, t.ContactNumber, t.Address from Trainer t inner join Users u on t.UserID = u.UserID where t.UserID = @UserID";
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

        public DataTable getTrainerModules(string userID)
        {
            DataTable moduleTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select m.ModuleID, m.ModuleName as 'Module Name', m.ClassLevel as 'Class Level' from TrainerAssignedModules tam inner join Modules m on tam.ModuleID = m.ModuleID where tam.UserID = @UserID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(moduleTable);
                    }
                }              
            }
            return moduleTable;
        }

        public bool removeTrainerModule(string userID, string moduleID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "delete from TrainerAssignedModules where UserID = @UserID and ModuleID = @ModuleID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userID);
                        command.Parameters.AddWithValue("@ModuleID", moduleID);

                        command.ExecuteNonQuery();
                    }
                    return true;
                }  
                catch
                {
                    return false;
                }
            }
        }

        public string assignModuleToTrainer(string userID, string moduleID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkQuery = "select count(*) from TrainerAssignedModules where UserID = @UserID and ModuleID = @ModuleID";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@UserID", userID);
                        checkCommand.Parameters.AddWithValue("@ModuleID", moduleID);

                        int exists = int.Parse(checkCommand.ExecuteScalar().ToString());
                        if (exists > 0)
                        {
                            return "Exists";
                        }
                    }

                    string insertQuery = "insert into TrainerAssignedModules (UserID, ModuleID) values (@UserID, @Module)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@UserID", userID);
                        insertCommand.Parameters.AddWithValue("@Module", moduleID);

                        insertCommand.ExecuteNonQuery();
                    }

                    return "Success";
                }
                catch (Exception ex)
                {
                    return "Error: " + ex.Message;
                }
            }
        }

        public IncomeReport generateTrainerIncomeReport(string userID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    
                    int moduleCount = 0;

                    string countQuery = "select count(*) from TrainerAssignedModules where UserID = @UserID";
                    using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                    {
                        countCommand.Parameters.AddWithValue("@UserID", userID);

                        moduleCount = (int)countCommand.ExecuteScalar();
                    }

                    decimal payPerModule = 1500.00m;
                    decimal totalEarnings = moduleCount * payPerModule;
                    decimal taxRate = 0.05m;
                    decimal totalDeductions = totalEarnings * taxRate;
                    decimal netIncome = totalEarnings - totalDeductions;

                    return new IncomeReport(moduleCount, totalEarnings, totalDeductions, netIncome);
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
