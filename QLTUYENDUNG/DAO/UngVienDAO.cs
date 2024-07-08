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
    public class UngVienDAO
    {
        private string connectionString = "Data Source=AN;Initial Catalog=QLTUYENDUNG;Integrated Security=True";

        public DataTable GetUngVienData(string doanhNghiepId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UV.IDUngVien, UV.Ten AS TenUngVien, UV.GioiTinh, HS.IDHoSo, " +
                               "CAST(HS.HocVan AS nvarchar(max)) AS HocVan, STRING_AGG(BC.Ten, ', ') AS TenBangCap, " +
                               "CAST(HS.KinhNghiem AS nvarchar(max)) AS KinhNghiem, CAST(HS.KiNang AS nvarchar(max)) AS KiNang, " +
                               "CTTTDANGTUYEN.ViTri, TTDT.ThoiGianDT, TTDT.NgayHetHan, PDK.TinhTrang " +
                               "FROM DOANHNGHIEP DN " +
                               "INNER JOIN THONGTINDANGTUYEN TTDT ON DN.IDDoanhNghiep = TTDT.IDDoanhNghiep " +
                               "INNER JOIN PHIEUDANGKYUNGTUYEN PDK ON TTDT.IDTTDT = PDK.IDTTDT " +
                               "INNER JOIN HOSOUNGVIEN HS ON PDK.IDHoSo = HS.IDHoSo " +
                               "INNER JOIN UNGVIEN UV ON HS.IDUngVien = UV.IDUngVien " +
                               "LEFT JOIN BANGCAP BC ON HS.IDHoSo = BC.IDHoSo " +
                               "INNER JOIN CTTTDANGTUYEN ON TTDT.IDTTDT = CTTTDANGTUYEN.IDTTDT " +
                               "WHERE DN.IDDoanhNghiep = @IDDoanhNghiep " +
                               "GROUP BY UV.IDUngVien, UV.Ten, UV.GioiTinh, HS.IDHoSo, CAST(HS.HocVan AS nvarchar(max)), " +
                               "CAST(HS.KinhNghiem AS nvarchar(max)), CAST(HS.KiNang AS nvarchar(max)), CTTTDANGTUYEN.ViTri, " +
                               "DN.Ten, TTDT.ThoiGianDT, TTDT.HinhThucDT, TTDT.NgayHetHan, PDK.TinhTrang";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@IDDoanhNghiep", doanhNghiepId);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public void UpdateTinhTrang(string idUngVien, string tinhTrang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE PDK SET PDK.TinhTrang = @TinhTrang " +
                               "FROM PHIEUDANGKYUNGTUYEN PDK " +
                               "INNER JOIN HOSOUNGVIEN HS ON PDK.IDHoSo = HS.IDHoSo " +
                               "INNER JOIN UNGVIEN UV ON HS.IDUngVien = UV.IDUngVien " +
                               "WHERE UV.IDUngVien = @IDUngVien";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDUngVien", idUngVien);
                command.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
