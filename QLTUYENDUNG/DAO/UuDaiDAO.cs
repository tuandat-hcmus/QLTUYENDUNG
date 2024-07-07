using QLTUYENDUNG.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLTUYENDUNG.DAO
{
    internal class UuDaiDAO
    {
        public static DataTable getAllUuDai()
        {
            try
            {
                string query = "SELECT * FROM UUDAI";
                return QueryHelper.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error at UuDaiDAO: getAllUuDai(): " + ex.Message);
                return null;
            }
        }

        public static DataTable getIdUuDaibyIDTTDTDataTable(string id)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT IDUuDai FROM CTUUDAI WHERE IDTTDT = @ID ";
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
                    Console.WriteLine("Error at UuDaiDAO: getUuDaibyIDTTDT(): " + ex.Message);
                    return null;
                }
            }
            return dataTable;
        }

        public static int insertCTUuDaibyIDTTDT(string idTTDT, List<string> idUuDai)
        {
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO CTUUDAI (IDTTDT, IDUUDAI) VALUES ";

                    List<string> values = new List<string>();
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    for (int i = 0; i < idUuDai.Count; i++)
                    {
                        string paramName1 = $"@idTTDT{i}";
                        string paramName2 = $"@idUuDai{i}";

                        values.Add($"({paramName1}, {paramName2})");

                        parameters.Add(new SqlParameter(paramName1, idTTDT));
                        parameters.Add(new SqlParameter(paramName2, idUuDai[i]));
                    }

                    query += string.Join(", ", values);

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddRange(parameters.ToArray());

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} rows inserted into CTUUDAI");
                        return rowsAffected;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at UuDaiDAO: insertCTUuDaibyIDTTDT(): " + ex.Message);
                    return -1;
                }
            }
        }

        public static int deleteCTUuDaibyIDTTDT(string idTTDT, List<string> idUuDai)
        {
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"DELETE FROM CTUUDAI WHERE IDTTDT = @IdTTDT ";

                    List<string> values = new List<string>();
                    List<SqlParameter> parameters = new List<SqlParameter>();

                    for (int i = 0; i < idUuDai.Count; i++)
                    {
                        string paramName = $"@idUuDai{i}";

                        values.Add($"{paramName}");

                        parameters.Add(new SqlParameter(paramName, idUuDai[i]));
                    }

                    query += $" AND IDUuDai IN ({string.Join(", ", values)});";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IdTTDT", idTTDT);
                    command.Parameters.AddRange(parameters.ToArray());

                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();
                    Console.WriteLine($"{rowsAffected} rows deleted from CTUUDAI");
                    return rowsAffected;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error at UuDaiDAO: deleteCTUuDaibyIDTTDT(): " + ex.Message);
                    return -1;
                }
            }
        }

        public static DataTable getUuDaibyIDTTDDataTable(string id)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(AccountDAO.connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT UUDAI.IDUuDai, Mota, Ten FROM UUDAI JOIN CTUUDAI ON UUDAI.IDUuDai = CTUUDAI.IDUuDai " +
                        "WHERE IDTTDT = @ID ";
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
                    Console.WriteLine("Error at UuDaiDAO: getUuDaibyIDTTDT(): " + ex.Message);
                    return null;
                }
            }
            return dataTable;
        }
    }
}
