using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Accounts
{
    public class BankAccountDTO
    {
        public Int64? BankAccountId { get; set; }
        public string BankAccountName { get; set; }
        public Int64 BankId { get; set; }
        public string? AccountType { get; set; }
        public bool IsDefaultAccount { get; set; }
        public bool IsCompanyAccount { get; set; }
        public string? IBAN { get; set; }
        public string? BranchCode { get; set; }
        public int? BankAccountNo { get; set; }
        public DateTime? LastIntegrationDate { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
