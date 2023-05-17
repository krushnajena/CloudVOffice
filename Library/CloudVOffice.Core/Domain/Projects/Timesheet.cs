using CloudVOffice.Core.Domain.HR.Emp;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Projects
{
	public class Timesheet :  IAuditEntity, ISoftDeletedEntity
	{
		public Int64 TimesheetId { get; set; }
		public Int64 EmployeeId { get; set; }
		public DateTime? TimeSheetForDate { get; set; }
		public string TimesheetActivityType { get; set; }//Project	Work, Meetings,
        public int ActivityId { get; set; }
        public int? ProjectId { get; set; }
		
		public Int64? TaskId { get; set; }
		public	TimeSpan? FromTime { get; set; }
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
		public DateTime CreatedDate { get; set; }
		public Int64? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }

        [ForeignKey("ProjectId")]
        public Project Project { get; set; }


        [ForeignKey("TaskId")]
        public ProjectTask ProjectTask { get; set; }
        [ForeignKey("ActivityId")]
        public ProjectActivityType ProjectActivityType { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }


        [ForeignKey("TimesheetApprovedBy")]
        public Employee TimesheetApprovedByEmployeeId { get; set; }


      
    }
}
