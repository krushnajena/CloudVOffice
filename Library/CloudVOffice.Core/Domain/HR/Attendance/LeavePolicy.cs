using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Core.Domain.Projects;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudVOffice.Core.Domain.HR.Attendance
{
    public class LeavePolicy : IAuditEntity, ISoftDeletedEntity
    {
        public int LeavePolicyId { get; set; }
        public int LeavePeriodId { get; set; }
        public int EmployeeGradeId { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
        [ForeignKey("LeavePeriodId")]
        public LeavePeriod LeavePeriod { get; set; }

        [ForeignKey("EmployeeGradeId")]
        public EmployeeGrade EmployeeGrade { get; set; }
		public ICollection<LeavePolicyDetails> LeavePolicyDetails { get; set; }
	}
}
