using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Accounts
{
    public class GeneralLedger : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 GeneralLedgerId { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? TranscationDate { get; set; }
        public int? ChartOfAccountsId { get; set; }
        public string PartyType { get; set; }
        public int PartyId { get; set; }
        public int? CostCenterId { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public int? CurrencyId { get; set; }
        public double? DebitInAccountCurrency { get; set; }
        public double? CreditInAccountCurrency { get; set; }
        public string VoucherType { get; set; }
        public Int64? VoucherNoId { get; set; }
        public string Remarks { get; set; }
        public bool IsOpeining { get; set; }
        public bool IsAdvance { get; set; }
        public int FinancialYearId { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsCanceled { get; set; }

        public int DocStatus { get; set; } //0=Draft,1=Submitted,2=Approved,3=Rejected,4=Canceled
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
