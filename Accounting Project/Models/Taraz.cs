using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_Project.Models
{
    public class Taraz
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public int GardeshBedehkar { get; set; }
        public int GardeshBestankar { get; set; }
        public int MandeBedehkar { get; set; }
        public int MandeBestankar { get; set; }
        public int TotalGardeshBedehkar { get; set; }
        public int TotalGardeshBestankar { get; set; }
        public int TotalMandeBedehkar { get; set; }
        public int TotalMandeBestankar { get; set; }
    }
}
