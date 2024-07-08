using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLTUYENDUNG.DAO
{
    public class DoanhNghiepDAO
    {
        private string connectionString = "Data Source=AN;Initial Catalog=QLTUYENDUNG;Integrated Security=True";

        public DataTable GetAllDoanhNghiep()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM DOANHNGHIEP";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable GetDoanhNghiepData(string doanhNghiepId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CTTTDANGTUYEN.IDTTDT, CTTTDANGTUYEN.IDCTTTDT, CTTTDANGTUYEN.ViTri, " +
                               "CTTTDANGTUYEN.SoLuong, CTTTDANGTUYEN.YeuCauUngVien, DOANHNGHIEP.Ten AS TenDoanhNghiep " +
                               "FROM CTTTDANGTUYEN " +
                               "INNER JOIN THONGTINDANGTUYEN ON CTTTDANGTUYEN.IDTTDT = THONGTINDANGTUYEN.IDTTDT " +
                               "INNER JOIN DOANHNGHIEP ON THONGTINDANGTUYEN.IDDoanhNghiep = DOANHNGHIEP.IDDoanhNghiep " +
                               "WHERE DOANHNGHIEP.IDDoanhNghiep = @IDDoanhNghiep";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@IDDoanhNghiep", doanhNghiepId);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}

