using QLTUYENDUNG.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DTO
{
    internal class TTDT
    {
        public string idTTDT {  get; set; }
        public DateTime thoiGianDt { get; set; }
        public string hinhThucDT { get; set; }
        public DateTime ngayHetHan { get; set; }
        public string tinhTrang { get; set; }
        public string ghiChu {  get; set; }
        public string idDoanhNghiep {  get; set; }
        public string nhanVienDuyet { get; set; }

        public TTDT() { }

        public TTDT (string idTTDT, DateTime thoiGianDt, string hinhThucDT, DateTime ngayHetHan, string tinhTrang, string ghiChu, string idDoanhNghiep, string nhanVienDuyet)
        {
            this.idTTDT = idTTDT;
            this.thoiGianDt = thoiGianDt;
            this.hinhThucDT = hinhThucDT;
            this.ngayHetHan = ngayHetHan;
            this.tinhTrang = tinhTrang;
            this.ghiChu = ghiChu;
            this.idDoanhNghiep = idDoanhNghiep;
            this.nhanVienDuyet = nhanVienDuyet;
        }

        public TTDT(DataRow dataRow)
        {
            this.idTTDT = dataRow["IDTTDT"].ToString();
            this.thoiGianDt = Convert.ToDateTime(dataRow["ThoiGianDT"]);
            this.hinhThucDT = dataRow["HinhThucDT"].ToString();
            this.ngayHetHan = Convert.ToDateTime(dataRow["NgayHetHan"]);
            this.tinhTrang = dataRow["TinhTrang"].ToString();
            this.ghiChu = dataRow["GhiChu"].ToString();
            this.idDoanhNghiep = dataRow["IDDoanhNghiep"].ToString();
            this.nhanVienDuyet = dataRow["NhanVienDuyet"].ToString();
        } 

        // Tìm thông tin đăng tuyển hết hạn theo số ngày còn lại
        public static DataTable getTTDTHetHanDataTable(int ngay, int tt)
        {
            return TTDTDAO.getTTDTHetHanDataTable(ngay, tt);
        }

        // Tìm thông tin đăng tuyển hết han, trả về list
        public static List<TTDT> getTTDTHetHanList(int ngay, int tt) {
            DataTable dataTable = TTDTDAO.getTTDTHetHanDataTable(ngay, tt);
            List<TTDT> TTDTs = new List<TTDT>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                TTDTs.Add(new TTDT(dataRow));
            }
            return TTDTs;
        }

        // Cập nhật cột tình trạng chung cho nhiều thông tin đăng tuyển
        public static int updateTinhTrangTTDT(List<string> TTDTs, int type = 0)
        {
            return TTDTDAO.updateTinhTrangTTDT(TTDTs, type);
        }

        // Lấy thông tin đăng tuyển theo IDTTDT
        public static TTDT getTTDTHetHanbyID(string id, int type = 0)
        {
            DataTable dataTable = TTDTDAO.getTTDTHetHanDataTablebyID(id, type);
            if (dataTable != null && dataTable.Rows.Count == 1)
            {
                return new TTDT(dataTable.Rows[0]);
            }
            return null;
        }

        public static int updateNgayHetHan(string idTTDT, int ngay)
        {
            return TTDTDAO.updateNgayHetHan(idTTDT, ngay);
        }

        public static DataTable getAllTTDT()
        {
            return TTDTDAO.getAll();
        }
    }
}
