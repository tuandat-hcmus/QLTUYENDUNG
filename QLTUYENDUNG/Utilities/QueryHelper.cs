using QLTUYENDUNG.DAO;
using System;
using System.Collections.Generic;
using System.Data;
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
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                    return rowsAffected;
                }
            }
        }

        // Dùng cho các câu query select *, không điều kiện gì thêm 
        public static DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                    connection.Close();
                }
            }
            return dataTable;
        }
    }
}
