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
		public Int64? EmployeeId { get; set; }
		public Int64? AssignedBy { get; set; }
		public string TaskName { get; set; }
		public string? Priority { get; set; }
		public Int64? ParentTaskId { get; set; }
		public bool IsGroup { get; set; }
		public DateTime? ExpectedStartDate { get; set; }
		public DateTime? ExpectedEndDate { get; set; }
		public double? ExpectedTimeInHours { get; set; }
		public double? Progress { get; set; }
		public string? TaskDescription { get; set; }
		public string TaskStatus { get; set; }
	
		public Int64 CreatedBy { get; set; }
	}
	public class ProjectTaskDelayReasonUpdateDTO
    {
        public Int64? ProjectTaskId { get; set; }

        public Int64 CreatedBy { get; set; }
        public string DelayReason { get; set; }

    }

    public class TaskComplitedByOthersReasonUpdateDTO
    {
        public Int64? ProjectTaskId { get; set; }

        public Int64 CreatedBy { get; set; }
		public Int64 EmployeeId { get; set; }
        public string Reason { get; set; }

    }
    public class TaskApprovalDTO
    {
        public Int64 TaskId { get; set; }
        public int IsDelayApproved { get; set; }
        public string DelayApprovalReason { get; set; }
        public Int64 ApprovedBy { get; set; }
        public Int64 UpdatedBy { get; set; }
    }
}
