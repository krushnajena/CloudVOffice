using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Attendance
{
    public class WorkFromHomeRequestDTO
    {
        public Int64 WorkFromHomeRequestId { get; set; }
        public Int64 EmployeeId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Reason { get; set; }
        public int ApprovalStatus { get; set; } //0 - Submitted, 1- Approved , 2- Rejected
        public Int64 ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovalRemark { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
