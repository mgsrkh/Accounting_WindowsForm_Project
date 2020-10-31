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
    public class UsersRepository : IUsersRepository
    {
        readonly private string connectionString;
        public UsersRepository()
        {
            connectionString = @"data source=MGSRKH\SQLEXPRESS2019; initial catalog=Hesabdari; integrated security=true";
        }
        public DataTable GetAll()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("select * from Users", connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            dt.Load(reader);

            connection.Close();
            return dt;

        }
        public DataTable GetAllByProcedure()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Users_GetAll", connection);

            command.CommandType = CommandType.StoredProcedure;

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            dt.Load(reader);

            connection.Close();
            return dt;

        }

        public Users GetById(int id)
        {
            Users users = new Users();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Users_GetById", connection);
            command.Parameters.AddWithValue("@Id", id);

            command.CommandType = CommandType.StoredProcedure;

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    //var result = reader.GetValue(1);
                    users.Id = (int)reader["Id"];
                    users.UserName = reader["UserName"].ToString();
                    users.Password = reader["Password"].ToString();
                    users.Type = reader["Type"].ToString();
                }
            }

            connection.Close();

            return users;
        }

        public int Insert(Users users)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Users_Insert", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@UserName", users.UserName);
            command.Parameters.AddWithValue("@Password", users.Password);
            command.Parameters.AddWithValue("@Type", users.Type);

            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }
        public int Update(Users users)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Users_Update", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Id", users.Id);
            command.Parameters.AddWithValue("@UserName", users.UserName);
            command.Parameters.AddWithValue("@Password", users.Password);
            command.Parameters.AddWithValue("@Type", users.Type);

            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }
        public int Delete(int id)
        {
            int result = 0;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Users_Delete", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Id", id);
            //command.Parameters.AddWithValue("@UserName", users.UserName);
            //command.Parameters.AddWithValue("@Password", users.Password);
            //command.Parameters.AddWithValue("@Type", users.Type);

            connection.Open();
            result = command.ExecuteNonQuery();
            connection.Close();

            return result;
        }
        public Users Login(string UserName, string Password)
        {
            Users users = new Users();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("Usp_Users_Login", connection);

            command.CommandType = CommandType.StoredProcedure;
            
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Username", users.UserName); // not suppiled erro from procedure
            command.Parameters.AddWithValue("@Password", users.Password);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    users.UserName = reader["UserName"].ToString();
                    users.Password = reader["Password"].ToString();
                }
            }

            connection.Close();

            return users;
        }
    }
}
