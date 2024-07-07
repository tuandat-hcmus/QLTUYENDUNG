using QLTUYENDUNG.DAO;
using QLTUYENDUNG.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DTO
{
    internal class UserService
    {
        private static bool isLogedIn = false;

        public static bool login(string username, string password)
        {
            string storedHash = AccountDAO.getInstance().GetPasswordHash(username);
            if (storedHash == null)
            {
                return false;
            }
            if(PasswordHasher.VerifyPassword(password, storedHash, username)) {
                isLogedIn = true;
                return true;
            }
            return false;
        }

        public static string getAccountType(string username)
        {
            if (isLogedIn) {
                return AccountDAO.getInstance().getAccountType(username);
            }
            return null;
        }

        public static DataTable getAllNV()
        {
            return AccountDAO.getAll();
        }
    }
}
