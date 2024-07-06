using QLTUYENDUNG.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DAO
{
    internal class PhieuDangKyUngTuyenDAO
    {
        public static DataTable getPhieuDKbyIDTTDTDataTable(string id)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM PHIEUDANGKYUNGTUYEN WHERE IDTTDT = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at PhieuDangKyUngTuyenDAO: getPhieuDKbyIDTTDTDataTable(): " + ex.Message);
                    return null;
                }
            }
            return dataTable;
        }
    }
}
