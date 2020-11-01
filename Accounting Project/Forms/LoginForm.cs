using Accounting_Project.IRepositories;
using Accounting_Project.Models;
using Accounting_Project.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_Project.Forms
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        private readonly IUsersRepository _repository;
        public LoginForm()
        {
            InitializeComponent();
            _repository = new UsersRepository();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Login_ti_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"data source=MGSRKH\SQLEXPRESS2019; initial catalog=Hesabdari; integrated security=true";

            SqlCommand command = new SqlCommand("Usp_Users_Login", connection);
            {
                command.CommandType = CommandType.StoredProcedure;
            }

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@Username", UserName_tx.Text);
            command.Parameters.AddWithValue("@Password", Password_tx.Text);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            //Users users = new Users()
            //{
            //    UserName = UserName_tx.Text,
            //    Password = Password_tx.Text
            //};

            //Users Users = _repository.Login(users.UserName, users.Password);

            if (reader.HasRows) //Users != null
            {
                MainForm form = new MainForm();
                form.Show();
                form.Login_lbl.Text = UserName_tx.Text;
                this.Hide();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "! نام کاربری و رمز عبور اشتباه است", "اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserName_tx.Clear();
                Password_tx.Clear();
                UserName_tx.Focus();
            }
            connection.Close();
        }

        private void Exit_ti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
