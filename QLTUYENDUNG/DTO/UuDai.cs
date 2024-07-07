using QLTUYENDUNG.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DTO
{
    internal class UuDai
    {
        public string idUuDai {  get; set; }
        public string moTa { get; set; }
        public string ten { get; set; }
        public UuDai(string idUuDai, string moTa, string ten)
        {
            this.idUuDai = idUuDai;
            this.moTa = moTa;
            this.ten = ten;
        }

        public UuDai(DataRow row)
        {
            this.idUuDai = row["IDUuDai"].ToString();
            this.moTa = row["MoTa"].ToString();
            this.ten = row["Ten"].ToString();
        }

        public static DataTable getAllUuDai()
        {
            return UuDaiDAO.getAllUuDai();
        }

        // Hàm trả về mảng các IdUuDai theo IDTTDT
        public static List<string> getIdUuDaibyIDTTDList(string id)
        {
            List<string> list = new List<string>();
            DataTable dt = UuDaiDAO.getIdUuDaibyIDTTDTDataTable(id);
            if (dt == null || dt.Rows.Count <= 0) return null;
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row["IDUuDai"].ToString());
            }
            return list;
        }

        public static DataTable getUuDaibyIDTTDDataTable(string idTTDT)
        {
            return UuDaiDAO.getUuDaibyIDTTDDataTable(idTTDT);
        }

        public static int insertCTUuDaibyIDTTDT(string idTTDT, List<string> idUuDai)
        {
            return UuDaiDAO.insertCTUuDaibyIDTTDT(idTTDT, idUuDai);
        }

        public static int deleteCTUuDaibyIDTTDT(string idTTDT, List<string> idUuDai)
        {
            return UuDaiDAO.deleteCTUuDaibyIDTTDT(idTTDT, idUuDai);
        }
    }
}
