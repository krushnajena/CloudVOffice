using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Accounts
{
    public class BankAccount
    {
        public Int64 BankAccountId { get; set; }
        public string BankAccountName { get; set;}
        public Int64 BankId { get; set; }
        public string? AccountType { get; set; }
        public bool IsDefaultAccount { get; set; }
        public bool IsCompanyAccount { get; set; }
        public string? IBAN { get; set;}
        public string? BranchCode { get; set; }
        public int? BankAccountNo { get; set; }
        public DateTime? LastIntegrationDate { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

    }
}
