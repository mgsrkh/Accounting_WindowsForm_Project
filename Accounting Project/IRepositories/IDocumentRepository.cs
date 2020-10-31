using Accounting_Project.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Project.IRepositories
{
    public interface IDocumentRepository
    {
        DataTable GetAllByProcedure();
        int Insert(Document document);
        Document GetById(int id);
        int Update(Document document);
        int Delete(int id);
    }
}
