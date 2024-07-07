using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QLTUYENDUNG.DTO;

namespace QLTUYENDUNG.DAO
{
    internal class DoanhNghiepDAO
    {
        private static string GetNextId()
        {
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT ISNULL(MAX(CAST(SUBSTRING(IDDoanhNghiep, 3, LEN(IDDoanhNghiep) - 2) AS INT)), 0) + 1 FROM DOANHNGHIEP";
                var nextId = (int)command.ExecuteScalar();
                return $"DN{nextId:D3}";
            }
        }

        private static bool CheckExists(string column, string value)
        {
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = $"SELECT COUNT(*) FROM DOANHNGHIEP WHERE {column} = @value";
                command.Parameters.AddWithValue("@value", value);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public static bool AddDoanhNghiep(string Ten, string Email, string DiaChi, string TaxID, string NguoiDaiDien)
        {
            // Check if company name already exists
            if (CheckExists("Ten", Ten))
            {
                MessageBox.Show("Tên công ty đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if tax number already exists
            if (CheckExists("TaxID", TaxID))
            {
                MessageBox.Show("Mã số thuế đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if email is valid and already exists
            if (/*!IsValidEmail(Email) ||*/ CheckExists("Email", Email))
            {
                MessageBox.Show("Email không hợp lệ hoặc đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO DOANHNGHIEP (IDDoanhNghiep, Ten, Email, DiaChi, TaxID, NguoiDaiDien) VALUES (@IDDoanhNghiep, @Ten, @Email, @DiaChi, @TaxID, @NguoiDaiDien)";
                    command.Parameters.AddWithValue("@IDDoanhNghiep", GetNextId());
                    command.Parameters.AddWithValue("@Ten", Ten);
                    command.Parameters.AddWithValue("@Email",Email);
                    command.Parameters.AddWithValue("@DiaChi",DiaChi);
                    command.Parameters.AddWithValue("@TaxID", TaxID);
                    command.Parameters.AddWithValue("@NguoiDaiDien", NguoiDaiDien);

                    var rows = command.ExecuteNonQuery();
                    return rows > 0;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public static DataTable getDoanhNghiepbyID(string id)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM DOANHNGHIEP WHERE IDDoanhNghiep = @ID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", id);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at TTDTDAO: getTTDTbyID(): " + ex.Message);
                    return null;
                }
            }
            if (dataTable.Rows.Count == 0)
            {
                Console.WriteLine("Error at DoanhNghiepDAO: getDoanhNghiepbyID(): return 0 row");
                return null;
            }
            if (dataTable.Rows.Count != 1)
            {
                Console.WriteLine("Error at DoanhNghiepDAO: getDoanhNghiepbyID(): return more than 1 row");
                return null;
            }
            return dataTable;
        }

        public static DataTable getAllDoanhNghiep()
        {
            DataTable dataTable = new DataTable();
            using(SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try {
                    connection.Open();
                    string query = "SELECT * FROM DOANHNGHIEP";
                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        connection.Close();
                    }
                }
                catch (SqlException ex) 
                {
                    Console.WriteLine(ex.Message);
                }
                if (dataTable.Rows.Count == 0)
                {
                    Console.WriteLine("Error at DoanhNghiepDAO: getDoanhNghiepbyID(): return 0 row");
                    return null;
                }
                return dataTable;
            }
        }
    }
}