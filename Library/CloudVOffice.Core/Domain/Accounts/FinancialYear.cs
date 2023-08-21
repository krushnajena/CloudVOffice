namespace CloudVOffice.Core.Domain.Accounts
{
    public class FinancialYear : IAuditEntity, ISoftDeletedEntity
    {

        public int FinancialYearId { get; set; }
        public string FinancialYearName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
