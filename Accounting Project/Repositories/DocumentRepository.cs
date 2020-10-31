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
    class DocumentRepository : IDocumentRepository
    {
        readonly private string connectionString;
        public DocumentRepository()
        {
            connectionString = @"data source=MGSRKH\SQLEXPRESS2019; initial catalog=Hesabdari; integrated security=true";
        }
        public DataTable GetAllByProcedure()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Document_GetAll", connection);

            command.CommandType = CommandType.StoredProcedure;

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            dt.Load(reader);

            connection.Close();
            return dt;
        }
        public Document GetById(int id)
        {
            Document document = new Document();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Document_GetById", connection);
            command.Parameters.AddWithValue("@Id", id);

            command.CommandType = CommandType.StoredProcedure;

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    //var result = reader.GetValue(1);
                    document.Id = (int)reader["Id"];
                    document.DocumentName = reader["DocumentName"].ToString();
                    document.DocumentNumber = (int)reader["DocumentNumber"];
                    document.DocumentDate = (DateTime)reader["DocumentDate"];
                    document.DocumentPage = (int)reader["DocumentPage"];
                    document.MoaienCode = (int)reader["MoaienCode"];
                    document.ColCode = (int)reader["ColCode"];
                    document.Bedehkar = (int)reader["Bedehkar"];
                    document.Bestankar = (int)reader["Bestankar"];
                    document.TotalBedehkar = (int)reader["TotalBedehkar"];
                    document.TotalBestankar = (int)reader["TotalBestankar"];
                }
            }

            connection.Close();

            return document;
        }

        public int Insert(Document document)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Document_Insert", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@DocumentName", document.DocumentName);
            command.Parameters.AddWithValue("@DocumentNumber", document.DocumentNumber);
            command.Parameters.AddWithValue("@DocumentDate", document.DocumentDate);
            command.Parameters.AddWithValue("@DocumentPage", document.DocumentPage);
            command.Parameters.AddWithValue("@MoaienCode", document.MoaienCode);
            command.Parameters.AddWithValue("@ColCode", document.ColCode);
            command.Parameters.AddWithValue("@Bedehkar", document.Bedehkar);
            command.Parameters.AddWithValue("@Bestankar", document.Bestankar);
            command.Parameters.AddWithValue("@TotalBedehkar", document.TotalBedehkar);
            command.Parameters.AddWithValue("@TotalBestankar", document.TotalBestankar);

            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }
        public int Update(Document document)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Document_Update", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Id", document.Id);
            command.Parameters.AddWithValue("@DocumentName", document.DocumentName);
            command.Parameters.AddWithValue("@DocumentNumber", document.DocumentNumber);
            command.Parameters.AddWithValue("@DocumentDate", document.DocumentDate);
            command.Parameters.AddWithValue("@DocumentPage", document.DocumentPage);
            command.Parameters.AddWithValue("@MoaienCode", document.MoaienCode);
            command.Parameters.AddWithValue("@ColCode", document.ColCode);
            command.Parameters.AddWithValue("@Bedehkar", document.Bedehkar);
            command.Parameters.AddWithValue("@Bestankar", document.Bestankar);
            command.Parameters.AddWithValue("@TotalBedehkar", document.TotalBedehkar);
            command.Parameters.AddWithValue("@TotalBestankar", document.TotalBestankar);

            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }
        public int Delete(int id)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Document_Delete", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Id", id);
            
            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }
    }
}
