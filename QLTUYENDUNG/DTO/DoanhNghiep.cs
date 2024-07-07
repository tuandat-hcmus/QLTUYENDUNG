using QLTUYENDUNG.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DTO
{
    internal class DoanhNghiep
    {
        public string IDDoanhNghiep { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string TaxID { get; set; }
        public string NgDaiDien { get; set; }

        public DoanhNghiep(string iDDoanhNghiep, string ten, string email, string diaChi, string taxID, string ngDaiDien)
        {
            IDDoanhNghiep = iDDoanhNghiep;
            Ten = ten;
            Email = email;
            DiaChi = diaChi;
            TaxID = taxID;
            NgDaiDien = ngDaiDien;
        }

        public DoanhNghiep(DataRow row)
        {
            this.IDDoanhNghiep = row["IDDoanhNghiep"].ToString();
            this.Ten = row["Ten"].ToString();
            this.Email = row["Email"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.TaxID = row["TaxID"].ToString();
            this.NgDaiDien = row["NguoiDaiDien"].ToString();
        }

        public static DoanhNghiep getDoanhNghiepbyID(string idDN)
        {
            DataTable dataTable = DoanhNghiepDAO.getDoanhNghiepbyID(idDN);
            if (dataTable != null && dataTable.Rows.Count == 1)
            {
                return new DoanhNghiep(dataTable.Rows[0]);
            }
            return null;
        }
    }
}