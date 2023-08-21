using CloudVOffice.Core.Domain.HR.Emp;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudVOffice.Core.Domain.Attendance
{
    public class EmployeeCheckIn : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 EmployeeCheckInId { get; set; }
        public Int64 EmployeeId { get; set; }
        public DateTime? ForDate { get; set; }
        public int LogType { get; set; } // 1=In , 2= Out
        public int? DeviceId { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
