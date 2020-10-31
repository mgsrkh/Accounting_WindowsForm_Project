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
    public partial class NewUserForm : MetroFramework.Forms.MetroForm
    {
        private readonly IUsersRepository _repository;
        public NewUserForm()
        {
            InitializeComponent();
            _repository = new UsersRepository();
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void Save_ti_Click(object sender, EventArgs e)
        {
            Users users = new Users()
            {
                UserName = UserName_txbox.Text,
                Password = Password_txbox.Text,
                Type = Type_txbox.Text
            };

            int result = _repository.Insert(users);
            if (result > 0)
            {
                MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
                this.Close();
            }
            else
            {
                MessageBox.Show("خطا");
            }
        }

        private void NewUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserManagement um = new UserManagement();
            um.Show();
            //Application.Run(new UserManagement());
            
        }
    }
}
