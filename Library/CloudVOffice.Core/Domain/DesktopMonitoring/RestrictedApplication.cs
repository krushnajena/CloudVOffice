using CloudVOffice.Core.Domain.HR.Master;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudVOffice.Core.Domain.DesktopMonitoring
{
    public class RestrictedApplication : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 RestrictedApplicationId { get; set; }
        public string RestrictedApplicationName { get; set; }
        public int? DepartmentId { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }
    }
}
