namespace CloudVOffice.Core.Domain.Accounts
{
    public class AccountType : IAuditEntity, ISoftDeletedEntity
    {
        public int AccountTypeId { get; set; }
        public string AccountTypeName { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
