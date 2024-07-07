using QLTUYENDUNG.DTO;
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
    internal class ViTriTuyenDungDAO
    {
        public static DataTable getViTriTuyenDung(string tenDN, string vt)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT TT.IDTTDT, CT.IDCTTTDT, DN.Ten, CT.ViTri, CT.SoLuong, CT.YeuCauUngVien, TT.TinhTrang " +
                        "FROM CTTTDANGTUYEN CT " +
                        "JOIN THONGTINDANGTUYEN TT ON CT.IDTTDT = TT.IDTTDT " +
                        "JOIN DOANHNGHIEP DN ON TT.IDDoanhNghiep = DN.IDDoanhNghiep " +
                        $"WHERE TT.TinhTrang = N'Đang tuyển' AND " +
                        $"DN.Ten LIKE '%{tenDN}%' AND CT.ViTri LIKE '%{vt}%'";


                    SqlCommand command = new SqlCommand(query, conn);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at ViTriTuyenDungDAO: getViTriTuyenDung(): " + ex.Message);
                    return null;
                }
            }
            return dataTable;
        }
    }
}
