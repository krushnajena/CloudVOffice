
using CloudVOffice.Core.Domain.HR.Emp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Attendance
{
    public class AttendanceRequest:IAuditEntity, ISoftDeletedEntity
    {
        public Int64 AttendanceRequestId { get; set; }
        public Int64 EmployeeId { get; set; }
        public DateTime? ForDate { get; set; }
        public TimeSpan CheckInTime { get; set; }
        public TimeSpan CheckOutTime { get; set; }  
        public string Reason { get; set; }
        public int ApprovalStatus { get; set; }//0=Submitted ,1 = Approved,2= Rejected
        public Int64? ApprovedBy { get; set; }
        public string? ApprovalRemarks { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [ForeignKey("ApprovedBy")]
        public Employee Approver { get; set; }
    }
}
