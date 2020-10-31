using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Project.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string DocumentName { get; set; }
        public int DocumentNumber { get; set; }
        public DateTime DocumentDate { get; set; }
        public int DocumentPage { get; set; }
        public int MoaienCode { get; set; }
        public int ColCode { get; set; }
        public int Bedehkar { get; set; }
        public int Bestankar { get; set; }
        public int TotalBedehkar { get; set; }
        public int TotalBestankar { get; set; }
    }
}
