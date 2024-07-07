using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DAO
{
    internal class PhieuDKDAO
    {
        public static int insertPhieuDangKy(string IDHoSo, string IDTTDT, string IDCTTTDT)
        {
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO PHIEUDANGKYUNGTUYEN VALUES (@IDHoSo, @IDTTDT, @IDCTTTDT, NULL, N'Chưa duyệt')";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDHoSo", IDHoSo);
                    command.Parameters.AddWithValue("@IDTTDT", IDTTDT);
                    command.Parameters.AddWithValue("@IDCTTTDT", IDCTTTDT);
                    int rowCount = command.ExecuteNonQuery();
                    return rowCount;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at insertPhieuDangKy: " + ex.Message);
                    return 0;
                }
            }
        }
    }
}
