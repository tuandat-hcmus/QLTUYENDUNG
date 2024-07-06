using QLTUYENDUNG.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DTO
{
    internal class PhieuDangKyUngTuyen
    {
        public string idHoSo {  get; set; }
        public string idTTDT { get; set; }
        public string idCTTTDT { get; set; }
        public string nhanVienDuyet { get; set; }
        public string tinhTrang { get; set; }

        public PhieuDangKyUngTuyen(string idHoSo, string idTTDT, string idCTTTDT, string nhanVienDuyet, string tinhTrang)
        {
            this.idHoSo = idHoSo;
            this.idTTDT = idTTDT;
            this.idCTTTDT = idCTTTDT;
            this.nhanVienDuyet = nhanVienDuyet;
            this.tinhTrang = tinhTrang;
        }

        public static DataTable getPhieuDKbyIDTTDTDataTable(string id)
        {
            return PhieuDangKyUngTuyenDAO.getPhieuDKbyIDTTDTDataTable(id);
        }
    }
}
