using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DAO
{
    internal class UngVienDAO
    {
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
