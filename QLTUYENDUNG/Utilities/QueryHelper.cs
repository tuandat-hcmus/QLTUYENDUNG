using QLTUYENDUNG.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.Utilities
{
    internal class QueryHelper
    {
        public static int ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();
                        return rowsAffected;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at QueryHelper: ExecuteNonQuery(): " + ex.Message);
                    return -1;
                }
            }
        }
    }
}
