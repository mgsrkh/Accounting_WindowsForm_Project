using Accounting_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Project.IRepositories
{
    public interface IUsersRepository
    {
        DataTable GetAll();
        DataTable GetAllByProcedure();
        Users GetById(int id);
        int Insert(Users users);
        int Update(Users users);
        int Delete(int id);
        Users Login(string UserName,string Password);
    }
}
