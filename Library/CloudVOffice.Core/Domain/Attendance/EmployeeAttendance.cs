using CloudVOffice.Core.Domain.HR.Emp;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudVOffice.Core.Domain.Attendance
{
    public class EmployeeAttendance : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 EmployeeAttendanceId { get; set; }
        public Int64 EmployeeId { get; set; }
        public DateTime? AttendanceDate { get; set; }
        public int Status { get; set; } //1-Present,2-Absent,3- Leave,4- Halfday Leave,5- Work from Home
        public bool IsLateEntry { get; set; }
        public bool IsEarlyExit { get; set; }

        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
