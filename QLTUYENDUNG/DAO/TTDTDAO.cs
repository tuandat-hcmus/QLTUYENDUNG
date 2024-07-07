using QLTUYENDUNG.DTO;
using QLTUYENDUNG.Utilities;
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
                    string query = "SELECT * FROM THONGTINDANGTUYEN ";

                    List<string> whereOptions = new List<string>();
                    if (ngay >= 0)
                    {
                        whereOptions.Add("NgayHetHan BETWEEN CAST(GETDATE() AS DATE) AND DATEADD(DAY, @Ngay, CAST(GETDATE() AS DATE)) ");
                    }
                    else
                    {
                        whereOptions.Add("NgayHetHan > GETDATE() ");
                    }
                    // Trạng thái hợp đồng
                    if (tt == 0)
                    {
                        whereOptions.Add(" TinhTrang NOT LIKE N'Đang chờ xét duyệt' AND TinhTrang NOT LIKE N'Đã xét duyệt' ");
                    }
                    else if (tt == 1)
                    {
                        whereOptions.Add(" TinhTrang LIKE N'Đang chờ xét duyệt' ");
                    }
                    else if (tt == 2)
                    {
                        // tất cả hợp đồng
                    }
                    else if (tt == 3)
                    {
                        whereOptions.Add(" TinhTrang LIKE N'Đã xét duyệt' ");
                    }

                    if (whereOptions.Count > 0)
                    {
                        query += $" WHERE {string.Join(" AND ", whereOptions)}";
                    }


                    SqlCommand command = new SqlCommand(query, connection);
                    if (ngay >= 0) 
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

        public static int updateTinhTrangTTDT(List<string> idsToUpdate, int type)
        {
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                string status = "";
                switch(type)
                {
                    case 0:
                        status = "N'Đang chờ xét duyệt'";
                        break;
                    case 1:
                        status = "N'Đã xét duyệt'";
                        break;
                    default:
                        status = "N'Đang chờ xét duyệt'";
                        break;
                }

                try
                {
                    connection.Open();
                    string query = $"UPDATE THONGTINDANGTUYEN SET TinhTrang = {status} " +
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

        public static DataTable getTTDTHetHanDataTablebyID(string id, int type)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM THONGTINDANGTUYEN WHERE IDTTDT = @ID ";
                    string status = "";
                    switch (type)
                    {
                        case 0:
                            status = "N'Đang chờ xét duyệt'";
                            break;
                        case 1:
                            status = "N'Đã xét duyệt'";
                            break;
                        default:
                            status = "N'Đang chờ xét duyệt'";
                            break;
                    }
                    query += $" AND TinhTrang LIKE {status} AND NgayHetHan > GETDATE() ";

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
                    Console.WriteLine("Error at TTDTDAO: getTTDTDataTablebyID(): " + ex.Message);
                    return null;
                }
            }
            if (dataTable.Rows.Count == 0)
            {
                Console.WriteLine("Error at TTDTDAO: getTTDTDataTablebyID(): return 0 row");
                return null;
            }
            if (dataTable.Rows.Count != 1)
            {
                Console.WriteLine("Error at TTDTDAO: getTTDTDataTablebyID(): return more than 1 row");
                return null;
            }
            return dataTable;
        }

        public static int updateNgayHetHan(string idTTDT, int ngay)
        {
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"UPDATE THONGTINDANGTUYEN SET NgayHetHan = DATEADD(DAY, @Ngay, NgayHetHan), TinhTrang = N'Đã đăng tuyển' " +
                        $"WHERE IDTTDT = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", idTTDT);
                    command.Parameters.AddWithValue("@Ngay", ngay);

                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                    return rowsAffected;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at TTDTDAO: updateNgayHetHan(): " + ex.Message);
                    return -1;
                }
            }
        }
    }
}
