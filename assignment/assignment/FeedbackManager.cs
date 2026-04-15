using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class FeedbackManager
    {
        string connectionString = ConfigurationManager.ConnectionStrings["CodeCamp"].ConnectionString;

        public DataTable getAllFeedbackPreview()
        {
            DataTable feedbackTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"select f.FeedbackID, case when len(f.Message) > 50 then left(f.Message, 50) + '...' else f.Message end as Feedback, t.Name as Trainer f.SubmittedAt as 'Date Submitted' 
                                from Feedback f 
                                inner join Users u on f.Email = u.Email 
                                inner join Trainer t on u.UserID = t.UserID 
                                order by f.SubmittedAs desc";
                    
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(feedbackTable);
                        }
                    }
                }
                catch
                {
                    return feedbackTable;
                }
            }
            return feedbackTable;
        }

        public Feedback getFeedbackByID(string feedbackID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "select t.Name, f.Message, f.SubmittedAt from Feedback f inner join Users u on f.Email = u.Email inner join Trainer t on u.UserID = t.UserID where f.FeedbackID = @feedbackID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@feedbackID", feedbackID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["Name"].ToString();
                                string message = reader["Message"].ToString();
                                DateTime submitDate = Convert.ToDateTime(reader["SubmittedAt"]);

                                return new Feedback(name, message, submitDate);
                            }
                        }
                    }
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }
    }
}
