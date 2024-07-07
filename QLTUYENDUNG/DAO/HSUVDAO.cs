using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DAO
{
    internal class HSUVDAO
    {
        public static string getNextID()
        {
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(IDHoSo, 3, LEN(IDHoSo) - 2) AS INT)), 0) + 1 FROM HOSOUNGVIEN";
                    SqlCommand command = new SqlCommand(query, connection);
                    int id = (int)command.ExecuteScalar();
                    return $"HS{id:D3}";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at getNextID(): " + ex.Message);
                    return null;
                }
            }
        }

        public static int insertHoSoUngVien(string IDHoSo, string HocVan, string KinhNghiem, string KiNang, string IDUngVien)
        {
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO HOSOUNGVIEN VALUES (@IDHoSo, @HocVan, @KinhNghiem, @KiNang, 'anh', @IDUngVien)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDHoSo", IDHoSo);
                    command.Parameters.AddWithValue("@HocVan", HocVan);
                    command.Parameters.AddWithValue("@KinhNghiem", KinhNghiem);
                    command.Parameters.AddWithValue("@KiNang", KiNang);
                    command.Parameters.AddWithValue("@IDUngVien", IDUngVien);
                    int rowCount = command.ExecuteNonQuery();
                    return rowCount;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at insertUngVien: " + ex.Message);
                    return 0;
                }
            }
        }
    }
}
