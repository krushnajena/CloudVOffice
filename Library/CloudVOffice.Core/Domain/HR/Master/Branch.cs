namespace CloudVOffice.Core.Domain.HR.Master
{
    public class Branch : IAuditEntity, ISoftDeletedEntity
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

    }
}
