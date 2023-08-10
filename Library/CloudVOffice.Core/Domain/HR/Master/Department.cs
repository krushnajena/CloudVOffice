namespace CloudVOffice.Core.Domain.HR.Master
{
    public class Department : IAuditEntity, ISoftDeletedEntity
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? Parent { get; set; }
        public bool IsGroup { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
        public List<Department> Children { get; set; }
    }
}
