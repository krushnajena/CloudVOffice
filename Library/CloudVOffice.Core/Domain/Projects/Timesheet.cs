using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
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
		
		public int ProjectId { get; set; }
		public int ActivityId { get; set; }
		public Int64 TaskId { get; set; }
		public DateTime? FromTime { get; set; }
		public DateTime? ToTime { get; set; }
		public double? DurationInHours { get; set; }
		public bool IsBillable { get; set; }

		public int TimeSheetApprovalStatus { get; set; }

		public Int64 CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public Int64? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }

	}
}
