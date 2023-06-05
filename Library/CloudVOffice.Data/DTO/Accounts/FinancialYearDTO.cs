using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Accounts
{
    public class FinancialYearDTO
    {
		public int FinancialYearId { get; set; }
		public string FinancialYearName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
