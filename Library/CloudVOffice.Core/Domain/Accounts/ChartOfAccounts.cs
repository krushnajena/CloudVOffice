using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Accounts
{
    public class ChartOfAccounts : IAuditEntity, ISoftDeletedEntity
    {
        public int ChartOfAccountsId { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public bool IsGroup { get; set; }
        public string RootType { get; set; } // Asset, Income, Expense , Liab
        public string ReportType { get; set; } // Balance Sheet, PL
        public int? ParentAccountGroupId { get; set; }
        public string AccountType { get; set; }
        public double? TaxRate { get; set; }
        public string BalanceMustBe { get; set; }//Cr Dr

        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
        public ICollection<ChartOfAccounts> Children { get; set; }
    }
}
