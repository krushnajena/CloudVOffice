namespace CloudVOffice.Core.Domain.HR.Master
{
    public class Designation : IAuditEntity, ISoftDeletedEntity
    {
        public int DesignationId { get; set; }
        public string DesignationName { get; set; }
        public string Description { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
