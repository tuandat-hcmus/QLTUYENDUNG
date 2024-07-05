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

        public static DataTable getTTDTHetHanDataTable(int ngay, int tt)
        {
            return TTDTDAO.getTTDTHetHanDataTable(ngay, tt);
        }

        public static List<TTDT> getTTDTHetHanList(int ngay, int tt) {
            DataTable dataTable = TTDTDAO.getTTDTHetHanDataTable(ngay, tt);
            List<TTDT> TTDTs = new List<TTDT>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                TTDTs.Add(new TTDT(dataRow));
            }
            return TTDTs;
        }

        public static int updateTinhTrangTTDT(List<string> TTDTs)
        {
            return TTDTDAO.updateTinhTrangTTDT(TTDTs);
        }
    }
}
