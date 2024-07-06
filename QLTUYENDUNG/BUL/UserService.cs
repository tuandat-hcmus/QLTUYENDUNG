using QLTUYENDUNG.DAO;
using QLTUYENDUNG.Util;

namespace QLTUYENDUNG.DTO
{
    internal class UserService
    {
        private static bool isLoggedIn = false;

        public static bool login(string username, string password)
        {
            string storedHash = AccountDAO.getInstance().GetPasswordHash(username);
            if (storedHash == null)
            {
                return false;
            }
            if(PasswordHasher.VerifyPassword(password, storedHash, username)) {
                isLoggedIn = true;
                return true;
            }
            return false;
        }

        public static string getAccountType(string username)
        {
            if (isLoggedIn) {
                return AccountDAO.getInstance().getAccountType(username);
            }
            return null;
        }
    }
}
