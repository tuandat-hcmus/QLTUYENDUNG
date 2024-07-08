using QLTUYENDUNG.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DTO
{
    internal class VTTD
    {
        //CT.IDCTTTDT, DN.Ten, CT.ViTri, CT.SoLuong, CT.YeuCauUngVien, TT.TinhTrang
        public string idCTTTDT { get; set; }
        public string tenDN {  get; set; }
        public string viTri {  get; set; }
        public int soLuong { get; set; }
        public string yeuCauUngVien {  get; set; }
        public string tinhTrang {  get; set; }

        public VTTD() { }

        public VTTD(string idCTTTDT, string tenDN, string viTri, int soLuong, string yeuCauUngVien, string tinhTrang)
        {
            this.idCTTTDT = idCTTTDT;
            this.tenDN = tenDN;
            this.viTri = viTri;
            this.soLuong = soLuong;
            this.yeuCauUngVien = yeuCauUngVien;
            this.tinhTrang = tinhTrang;
        }

        public VTTD(DataRow dataRow)
        {
            this.idCTTTDT = dataRow["IDCTTTDT"].ToString();
            this.tenDN = dataRow["Ten"].ToString();
            this.viTri = dataRow["ViTri"].ToString();
            this.soLuong = Convert.ToInt32(dataRow["SoLuong"]);
            this.yeuCauUngVien = dataRow["YeuCauUngVien"].ToString();
            this.tinhTrang = dataRow["TinhTrang"].ToString();
        }

        public static DataTable getViTriTuyenDungDataTable(string tenDN, string vt)
        {
            return ViTriTuyenDungDAO.getViTriTuyenDung(tenDN, vt);
        }
    }
}
