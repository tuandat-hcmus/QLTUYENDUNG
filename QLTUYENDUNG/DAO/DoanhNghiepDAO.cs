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
        private readonly string connectionString;

        public DoanhNghiepDAO()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
        }

        // Generate the next ID for DoanhNghiep
        private string GetNextId()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT ISNULL(MAX(CAST(SUBSTRING(IDDoanhNghiep, 3, LEN(IDDoanhNghiep) - 2) AS INT)), 0) + 1 FROM DOANHNGHIEP";
                var nextId = (int)command.ExecuteScalar();
                return $"DN{nextId:D3}";
            }
        }

        // Check if a value exists in the specified column of DOANHNGHIEP table
        private bool CheckExists(string column, string value)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = $"SELECT COUNT(*) FROM DOANHNGHIEP WHERE {column} = @value";
                command.Parameters.AddWithValue("@value", value);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        // Validate email format using Regex
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize domain name
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        // Add a new DoanhNghiep to the database
        public bool AddDoanhNghiep(DoanhNghiep doanhNghiep)
        {
            // Check if company name already exists
            if (CheckExists("Ten", doanhNghiep.Name))
            {
                MessageBox.Show("Tên công ty đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if tax number already exists
            if (CheckExists("TaxID", doanhNghiep.TaxNumber))
            {
                MessageBox.Show("Mã số thuế đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if email is valid and already exists
            if (!IsValidEmail(doanhNghiep.Email) || CheckExists("Email", doanhNghiep.Email))
            {
                MessageBox.Show("Email không hợp lệ hoặc đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO DOANHNGHIEP (IDDoanhNghiep, Ten, Email, DiaChi, TaxID, NguoiDaiDien) VALUES (@IDDoanhNghiep, @Ten, @Email, @DiaChi, @TaxID, @NguoiDaiDien)";
                    command.Parameters.AddWithValue("@IDDoanhNghiep", GetNextId());
                    command.Parameters.AddWithValue("@Ten", doanhNghiep.Name);
                    command.Parameters.AddWithValue("@Email", doanhNghiep.Email);
                    command.Parameters.AddWithValue("@DiaChi", doanhNghiep.Address);
                    command.Parameters.AddWithValue("@TaxID", doanhNghiep.TaxNumber);
                    command.Parameters.AddWithValue("@NguoiDaiDien", doanhNghiep.Representative);

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

        public DataTable GetDoanhNghiepById(string id)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM DOANHNGHIEP WHERE IDDoanhNghiep = @ID";
                command.Parameters.AddWithValue("@ID", id);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
            }

            return table;
        }

    }
}
