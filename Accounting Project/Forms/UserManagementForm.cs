using Accounting_Project.Forms;
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
using Accounting_Project.Repositories;
using Accounting_Project.IRepositories;
using MetroFramework;

namespace Accounting_Project
{
    public partial class UserManagement : MetroFramework.Forms.MetroForm
    {
        private readonly IUsersRepository repository;

        //private static UserManagement Singletone = null; // I have Error In Single Tone Pattern
        public UserManagement()
        {
            InitializeComponent();
            repository = new UsersRepository();
        }

        //public static UserManagement CreateInstance()
        //{
        //    if (Singletone == null)
        //    {
        //        Singletone = new UserManagement();
        //    }
        //    return Singletone;
        //}

        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadGrid();
            metroGrid1.Columns[2].HeaderText = "ردیف";
            metroGrid1.Columns[3].HeaderText = "نام کاربری";
            metroGrid1.Columns[4].HeaderText = "نوع کاربر";
        }
        public void LoadGrid()
        {
            metroGrid1.DataSource = repository.GetAllByProcedure();
        }
        private void NewUser_bt_Click(object sender, EventArgs e)
        {
            NewUserForm uf = new NewUserForm();
            uf.Show();
            this.Close();
        }
        
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int Id = (int)metroGrid1.Rows[e.RowIndex].Cells["Id"].Value;
                UpdateUser f = new UpdateUser(Id);
                f.Show();
            }
            else if (e.ColumnIndex == 1)
            {
                int Id = (int)metroGrid1.Rows[e.RowIndex].Cells["Id"].Value;
                var result = MetroFramework.MetroMessageBox.Show(this, "آیا مطمئن هستید این آیتم حذف شود؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    repository.Delete(Id);
                    UserManagement userManagement = (UserManagement)Application.OpenForms["UserManagement"];
                    userManagement.LoadGrid();
                }
                else
                {
                    UserManagement userManagement = (UserManagement)Application.OpenForms["UserManagement"];
                    userManagement.LoadGrid();
                }
            }
        }
    }
}
