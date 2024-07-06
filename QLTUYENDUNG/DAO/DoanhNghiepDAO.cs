using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DAO
{
    internal class DoanhNghiepDAO
    {
        public static DataTable getDoanhNghiepbyID(string id)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM DOANHNGHIEP WHERE IDDoanhNghiep = @ID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at TTDTDAO: getTTDTbyID(): " + ex.Message);
                    return null;
                }
            }
            if (dataTable.Rows.Count == 0)
            {
                Console.WriteLine("Error at DoanhNghiepDAO: getDoanhNghiepbyID(): return 0 row");
                return null;
            }
            if (dataTable.Rows.Count != 1)
            {
                Console.WriteLine("Error at DoanhNghiepDAO: getDoanhNghiepbyID(): return more than 1 row");
                return null;
            }
            return dataTable;
        }

        public static DataTable getAllDoanhNghiep()
        {
            DataTable dataTable = new DataTable();
            using(SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try {
                    connection.Open();
                    string query = "SELECT * FROM DOANHNGHIEP";
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        connection.Close();
                    }
                }
                catch (SqlException ex) 
                {
                    Console.WriteLine(ex.Message);
                }
                if (dataTable.Rows.Count == 0)
                {
                    Console.WriteLine("Error at DoanhNghiepDAO: getDoanhNghiepbyID(): return 0 row");
                    return null;
                }
                return dataTable;
            }
        }
    }
}