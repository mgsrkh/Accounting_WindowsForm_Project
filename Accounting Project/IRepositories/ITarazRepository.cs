using Accounting_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Project.IRepositories
{
    public interface ITarazRepository
    {
        DataTable GetAllByProcedure();
        int Insert(Taraz taraz);
        Taraz GetById(int id);
        int Update(Taraz taraz);
        int Delete(int id);
    }
}
