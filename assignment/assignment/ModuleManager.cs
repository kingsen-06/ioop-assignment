using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class ModuleManager
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public string addModule(string moduleName, string classLevel)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkQuery = "select count(*) from Modules where ModuleName = @moduleName";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@moduleName", moduleName);

                        int exists = int.Parse(checkCommand.ExecuteScalar().ToString());
                        if (exists > 0)
                        {
                            return "Exists";
                        }
                    }

                    string insertQuery = "insert into Modules (ModuleName, ClassLevel) values (@moduleName, @classLevel)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@moduleName", moduleName);
                        insertCommand.Parameters.AddWithValue("@classLevel", classLevel);

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
    }
}
