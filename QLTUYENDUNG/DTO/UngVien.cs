using QLTUYENDUNG.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DTO
{
    internal class UngVien
    {
        public string IDUngVien { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string DT { get; set; }
        public string CCCD { get; set; }
        public string DiaChi { get; set; }
        public string GioiTinh { get; set; }

        public UngVien(string iDUngVien, string ten, string email, string dT, string cCCD, string diaChi, string gioiTinh)
        {
            IDUngVien = iDUngVien;
            Ten = ten;
            Email = email;
            DT = dT;
            CCCD = cCCD;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
        }

        public UngVien(DataRow row)
        {
            this.IDUngVien = row["IDUngVien"].ToString();
            this.Ten = row["Ten"].ToString();
            this.Email = row["email"].ToString();
            this.DT = row["DT"].ToString();
            this.CCCD = row["CCCD"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
        }

        public static DataTable getAllUV()
        {
            return UngVienDAO.getAllUngVien();
        }

        public static DataTable GetUngVienData(string doanhNghiepId)
        {
            return UngVienDAO.GetUngVienData(doanhNghiepId);
        }

        public static void UpdateTinhTrang(string idUngVien, string tinhTrang)
        {
            UngVienDAO.UpdateTinhTrang(idUngVien, tinhTrang);
        }
    }
}
