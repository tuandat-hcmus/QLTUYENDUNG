using QLTUYENDUNG.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTUYENDUNG.DAO
{
    internal class AccountDAO
    {
        public static readonly string connectionString = "Server=DESKTOP-MRCC8U2;Database=QLTUYENDUNG;Integrated Security=True;";
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
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
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
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
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

        public string getUserFullName(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Ten FROM NHANVIEN WHERE IDNV = (SELECT IDNV FROM ACCOUNT WHERE username = @Username)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    string fullName = command.ExecuteScalar().ToString();
                    return fullName;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error at getUserFullName(): " + ex.Message);
                    return null;
                }
            }
        }

        public static DataTable getAll()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM NHANVIEN";
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        connection.Close();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error at AccountDAO: getAll():" + ex.Message);
                }
                return dataTable;
            }
        }
    }
}
