using QLTUYENDUNG.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DAO
{
    internal class AccountDAO
    {
        public readonly string connectionString = "Server=DESKTOP-MRCC8U2;Database=QLTUYENDUNG;Integrated Security=True;";
        private static AccountDAO instance = null;

        public static AccountDAO getInstance()
        {
            if (instance == null)
            {
                instance = new AccountDAO();
            }
            return instance;
        }

        public string GetPasswordHash(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT psw FROM ACCOUNT WHERE username = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader["psw"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at GetPasswordHash(): " + ex.Message);
                    return null;
                }
            }
            return null;
        }

        public string getAccountType(string username) {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT accountType FROM ACCOUNT WHERE username = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return reader["accountType"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at getAccountType(): " + ex.Message);
                    return null;
                }
            }
            return null;
        }
    }
}
