using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Projects
{
	public class ProjectTaskDTO
	{
		public Int64? ProjectTaskId { get; set; }
		public int ProjectId { get; set; }
		public string TaskName { get; set; }
		public string Priority { get; set; }
		public Int64? ParentTaskId { get; set; }
		public bool IsGroup { get; set; }
		public DateTime? ExpectedStartDate { get; set; }
		public DateTime? ExpectedEndDate { get; set; }
		public double? ExpectedTimeInHours { get; set; }
		public double? Progress { get; set; }
		public string TaskDescription { get; set; }
		public Int64? ComplitedBy { get; set; }
		public DateTime? ComplitedOn { get; set; }
		public double? TotalHoursByTimeSheet { get; set; }
		public double? TotalBillableHourByTimeSheet { get; set; }

		public Int64 CreatedBy { get; set; }
	}
}
