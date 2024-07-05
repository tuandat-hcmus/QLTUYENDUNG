using QLTUYENDUNG.DTO;
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
        public static DataTable getTTDTHetHanDataTable(int ngay, int tt)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM THONGTINDANGTUYEN " +
                        "WHERE NgayHetHan BETWEEN CAST(GETDATE() AS DATE) AND DATEADD(DAY, @Ngay, CAST(GETDATE() AS DATE)) ";

                    if (tt == 0)
                    {
                        query += " AND TinhTrang NOT LIKE N'Đang chờ xét duyệt' ";
                    }
                    else if (tt == 1)
                    {
                        query += " AND TinhTrang LIKE N'Đang chờ xét duyệt' ";
                    }

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
                    Console.WriteLine("Error at TTDTDAO: getTTDTDataTable(): " + ex.Message);
                    return null;
                }
            }
            return dataTable;
        }

        public static int updateTinhTrangTTDT(List<string> idsToUpdate)
        {
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"UPDATE THONGTINDANGTUYEN SET TinhTrang = N'Đang chờ xét duyệt' " +
                        $"WHERE IDTTDT IN ('{string.Join("', '", idsToUpdate)}')";
                    SqlCommand command = new SqlCommand(query, connection);
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                    return rowsAffected;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at TTDTDAO: updateTinhTrangTTDT(): " + ex.Message);
                    return -1;
                }
            }
        }
    }
}
