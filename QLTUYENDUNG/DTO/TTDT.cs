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
        private string idTTDT {  get; set; }
        private DateTime thoiGianDt { get; set; }
        private string hinhThucDT { get; set; }
        private DateTime ngayHetHan { get; set; }
        private string tinhTrang { get; set; }
        private string ghiChu {  get; set; }
        private string idDoanhNghiep {  get; set; }
        private string nhanVienDuyet { get; set; }

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

        public static DataTable getTTDTHetHanDataTable(int ngay)
        {
            return TTDTDAO.getTTDTHetHanDataTable(ngay);
        }
    }
}
