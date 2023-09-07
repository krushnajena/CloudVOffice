using CloudVOffice.Core.Domain.Projects;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudVOffice.Core.Domain.HR.Attendance
{
    public class LeavePolicyDetails : IAuditEntity, ISoftDeletedEntity
    {
        public int? LeavePolicyDetailsId { get; set; }
        public int LeavePolicyId { get; set; }
        public int LeaveTypeId { get; set; }
        public int NoOfLeaves { get; set; }
        public int AllocationMode { get; set; } //1=Annual ,2=Monthly
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

      
      
    }
}
