using Accounting_Project.IRepositories;
using Accounting_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Project.Repositories
{
    public class TarazRepository : ITarazRepository
    {
        readonly private string connectionString;
        public TarazRepository()
        {
            connectionString = @"data source=MGSRKH\SQLEXPRESS2019; initial catalog=Hesabdari; integrated security=true";
        }
        public DataTable GetAllByProcedure()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Taraz_GetAll", connection);

            command.CommandType = CommandType.StoredProcedure;

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            dt.Load(reader);

            connection.Close();
            return dt;
        }

        public int Insert(Taraz taraz)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Taraz_Insert", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@AccountName", taraz.AccountName);
            command.Parameters.AddWithValue("@GardeshBedehkar", taraz.GardeshBedehkar);
            command.Parameters.AddWithValue("@GardeshBestankar", taraz.GardeshBestankar);
            command.Parameters.AddWithValue("@MandeBedehkar", taraz.MandeBedehkar);
            command.Parameters.AddWithValue("@MandeBestankar", taraz.MandeBestankar);
            command.Parameters.AddWithValue("@TotalGardeshBedehkar", taraz.TotalGardeshBedehkar);
            command.Parameters.AddWithValue("@TotalGardeshBestankar", taraz.TotalGardeshBestankar);
            command.Parameters.AddWithValue("@TotalMandeBedehkar", taraz.TotalMandeBedehkar);
            command.Parameters.AddWithValue("@TotalMandeBestankar", taraz.TotalMandeBestankar);

            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }
        public Taraz GetById(int id)
        {
            Taraz taraz = new Taraz();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Taraz_GetById", connection);
            command.Parameters.AddWithValue("@Id", id);

            command.CommandType = CommandType.StoredProcedure;

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    //var result = reader.GetValue(1);
                    taraz.Id = (int)reader["Id"];
                    taraz.AccountName = reader["AccountName"].ToString();
                    taraz.GardeshBedehkar = (int)reader["GardeshBedehkar"];
                    taraz.GardeshBestankar = (int)reader["GardeshBestankar"];
                    taraz.MandeBedehkar = (int)reader["MandeBedehkar"];
                    taraz.MandeBestankar = (int)reader["MandeBestankar"];
                    taraz.TotalGardeshBedehkar = (int)reader["TotalGardeshBedehkar"];
                    taraz.TotalGardeshBestankar = (int)reader["TotalGardeshBestankar"];
                    taraz.TotalMandeBedehkar = (int)reader["TotalMandeBedehkar"];
                    taraz.TotalMandeBestankar = (int)reader["TotalMandeBestankar"];
                }
            }

            connection.Close();

            return taraz;
        }

        public int Update(Taraz taraz)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Taraz_Update", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Id", taraz.Id);
            command.Parameters.AddWithValue("@AccountName", taraz.AccountName);
            command.Parameters.AddWithValue("@GardeshBedehkar", taraz.GardeshBedehkar);
            command.Parameters.AddWithValue("@GardeshBestankar", taraz.GardeshBestankar);
            command.Parameters.AddWithValue("@MandeBedehkar", taraz.MandeBedehkar);
            command.Parameters.AddWithValue("@MandeBestankar", taraz.MandeBestankar);
            command.Parameters.AddWithValue("@TotalGardeshBedehkar", taraz.TotalGardeshBedehkar);
            command.Parameters.AddWithValue("@TotalGardeshBestankar", taraz.TotalGardeshBestankar);
            command.Parameters.AddWithValue("@TotalMandeBedehkar", taraz.TotalMandeBedehkar);
            command.Parameters.AddWithValue("@TotalMandeBestankar", taraz.TotalMandeBestankar);

            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }
        public int Delete(int id)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Taraz_Delete", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Id", id);

            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }
    }
}
