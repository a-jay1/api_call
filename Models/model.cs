using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WebApplication11.Models
{
    public class Model
    {
        private static string cs = "Data Source=DESKTOP-3EIFCQR;Initial Catalog=expenseDB;Integrated Security=True";
            //= WebConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public SqlConnection getConnection()
        {
            return new SqlConnection(cs);
        }

        public static int getExpense(string name)
        {
            Model db = new Model();
            using (var connection = db.getConnection())
            {
                try
                {
                    connection.Open();

                    string query = "SELECT SUM(cost_) FROM expense WHERE name_ = @name ";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);
                    return (int)command.ExecuteScalar();

                }
                catch
                {
                    return 0;
                }
            }
        }

    }
}