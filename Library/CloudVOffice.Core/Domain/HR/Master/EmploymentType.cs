namespace CloudVOffice.Core.Domain.HR.Master
{
    public class EmploymentType : IAuditEntity, ISoftDeletedEntity
    {

        public int EmploymentTypeId { get; set; }
        public string EmploymentTypeName { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
