using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLTUYENDUNG.DAO
{
    internal class TTDTDAO
    {
        public static DataTable getTTDTHetHanDataTable(int ngay)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM THONGTINDANGTUYEN " +
                        "WHERE NgayHetHan BETWEEN CAST(GETDATE() AS DATE) AND DATEADD(DAY, @Ngay, CAST(GETDATE() AS DATE));";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Ngay", ngay);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at getTTDTDataTable(): " + ex.Message);
                    return null;
                }
            }
            return dataTable;
        }
    }
}
