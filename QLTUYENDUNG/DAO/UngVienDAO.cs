using QLTUYENDUNG.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DAO
{
    internal class UngVienDAO
    {
        public static DataTable getAllUngVien()
        {
            try
            {
                return QueryHelper.ExecuteQuery("SELECT * FROM UNGVIEN");
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Error at getAllUngVien(): " + ex.Message);
                return null;
            }
        }

        public static string getNextID()
        {
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ISNULL(MAX(CAST(SUBSTRING(IDUngVien, 3, LEN(IDUngVien) - 2) AS INT)), 0) + 1 FROM UNGVIEN";
                    SqlCommand command = new SqlCommand(query, connection);
                    int id = (int)command.ExecuteScalar();
                    return  $"UV{id:D3}";
                } catch (Exception ex)
                {
                    Console.WriteLine("Error at getNextID(): " + ex.Message);
                    return null;
                }
            }
        }

        public static bool checkExist(string column, string value)
        {
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                    {
                    connection.Open();
                    string query = $"SELECT COUNT(*) FROM UNGVIEN WHERE {column} = @value";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@value", value);
                    int count = (int)command.ExecuteScalar();
                    connection.Close();
                    return count > 0;
                    }
                catch (Exception ex)
                    {
                    Console.WriteLine("Error at checkExist" + ex.Message);
                    return false;
                    }
                }
        }

        public static int insertUngVien(string Ten, string Email, string DT, string CCCD, string DiaChi, string GioiTinh)
        {
            if (checkExist("CCCD", CCCD))
            {
                return 0;
            }
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO UNGVIEN VALUES (@IDUngVien, @Ten, @Email, @DT, @CCCD, @DiaChi, @GioiTinh)";
                    string IDUngVien = getNextID();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDUngVien", IDUngVien);
                    command.Parameters.AddWithValue("@Ten", Ten);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@DT", DT);
                    command.Parameters.AddWithValue("@CCCD", CCCD);
                    command.Parameters.AddWithValue("@DiaChi", DiaChi);
                    command.Parameters.AddWithValue("@GioiTinh", GioiTinh);
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

        public static string getIdUngVienByCCCD(string cccd)
        {
            using (SqlConnection conn = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"SELECT IDUngVien FROM UNGVIEN WHERE CCCD = {cccd}";


                    SqlCommand command = new SqlCommand(query, conn);

                    object idResult = command.ExecuteScalar();

                    if (idResult != null)
                    {
                        string id = idResult.ToString();
                        return id;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at UngVienDAO: getIdUngVienByCCCD(): " + ex.Message);
                    return null;
                }
            }
        }
    }
}
