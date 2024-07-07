using QLTUYENDUNG.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DTO
{
    internal class HoaDon
    {

        public static DataTable getAllHoaDon()
        {
            return HoaDonDAO.getAll();
        }
    }
}
