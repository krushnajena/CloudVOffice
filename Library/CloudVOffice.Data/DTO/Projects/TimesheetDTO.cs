using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Projects
{
    public class TimesheetDTO
    {
        public Int64? TimesheetId { get; set; }
        public Int64 EmployeeId { get; set; }
        public DateTime? TimeSheetForDate { get; set; }
        public int TimesheetActivityType { get; set; }//Project	Work, Meetings,
        public int ActivityId { get; set; }
        public int? ProjectId { get; set; }

        public Int64? TaskId { get; set; }
        public TimeSpan? FromTime { get; set; }
        public TimeSpan? ToTime { get; set; }
        public double? DurationInHours { get; set; }
        public string Description { get; set; }
        public bool IsBillable { get; set; }
        public double? HourlyRate { get; set; }
        public int TimeSheetApprovalStatus { get; set; } //0- Submitted,1- Approved,2-Rejected
        public Int64? TimesheetApprovedBy { get; set; }
        public DateTime? TimeSheetApprovedOn { get; set; }
        public string? TimeSheetApprovalRemarks { get; set; }

        public Int64 CreatedBy { get; set; }
    }
    public class TimesheetApprovalDTO
    {
        public Int64 TimesheetId { get; set; }
        public int TimeSheetApprovalStatus { get; set; }
        public string TimesheetApprovalRemarks { get; set;}
        public Int64 ApprovedBy { get; set; }
        public Int64 UpdatedBy { get; set; }
    }
}
