namespace CloudVOffice.Core.Domain.Projects
{
    public class ProjectType : IAuditEntity, ISoftDeletedEntity
    {
        public int ProjectTypeId { get; set; }
        public string ProjectTypeName { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
    }
}
