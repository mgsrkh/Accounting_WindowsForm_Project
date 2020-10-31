using Accounting_Project.IRepositories;
using Accounting_Project.Models;
using Accounting_Project.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_Project.Forms
{
    public partial class UpdateUser : MetroFramework.Forms.MetroForm
    {
        private readonly IUsersRepository _repository;
        private int _Id = 0;
        public UpdateUser(int id)
        {
            InitializeComponent();
            _repository = new UsersRepository();
            _Id = id;
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            Users users = _repository.GetById(_Id);
            UserName_txbox.Text = users.UserName;
            Password_txbox.Text = users.Password;
            Type_txbox.Text = users.Type;
        }

        private void Save_ti_Click_1(object sender, EventArgs e)
        {
            Users users = new Users()
            {
                Id = _Id,
                UserName = UserName_txbox.Text,
                Password = Password_txbox.Text,
                Type = Type_txbox.Text
            };
            int result = _repository.Update(users);
            if (result > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("خطا");
            }
        }

        private void UpdateUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserManagement userManagement = (UserManagement)Application.OpenForms["UserManagement"];
            userManagement.LoadGrid();
        }
    }
}
