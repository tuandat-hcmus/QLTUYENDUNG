using QLTUYENDUNG.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DAO
{
    internal class HoaDonDAO
    {
        public static DataTable getAll()
        {
            try
            {
                return QueryHelper.ExecuteQuery("SELECT * FROM HOADON");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at HoaDonDAO: getAll(): " + ex.Message);
            }
            return null;
        }
    }
}
