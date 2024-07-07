using QLTUYENDUNG.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DTO
{
    internal class HoSoUngVien
    {
        public string idHoSo { get; set; }
        public string hocVan { get; set; }
        public string kinhNghiem { get; set; }
        public string kiNang {  get; set; }
        public string cccd { get; set; }
        public string idCTTTDT { get; set; }
        public string idTTDT { get; set; }
        public HoSoUngVien() { }
        
        public HoSoUngVien(string idHoSo, string hocVan, string kinhNghiem, string kiNang, string cccd, string idCTTTDT, string idTTDT)
        {
            this.idHoSo = idHoSo;
            this.hocVan = hocVan;
            this.kinhNghiem = kinhNghiem;
            this.kiNang = kiNang;
            this.cccd = cccd;
            this.idCTTTDT = idCTTTDT;
        }

        public static int addHoSoUngVien(string hocVan, string kinhNghiem, string kiNang, string cccd, string idCTTTDT, string idTTDT)
        {
            string idUngVien = UngVienDAO.getIdUngVienByCCCD(cccd);
            if (idUngVien == null)
            {
                return 0;
            }

            string idHoSo = HSUVDAO.getNextID();
            if (idHoSo == null)
            {
                return 0;
            }

            int insertHoSo = HSUVDAO.insertHoSoUngVien(idHoSo, hocVan, kinhNghiem, kiNang, idUngVien);
            if (insertHoSo == 0)
            {
                return 0;
            }

            int insertPDK = PhieuDKDAO.insertPhieuDangKy(idHoSo, idTTDT, idCTTTDT);
            if (insertPDK == 0)
            {
                return 0;
            }

            return 1;
        }

    }
}
