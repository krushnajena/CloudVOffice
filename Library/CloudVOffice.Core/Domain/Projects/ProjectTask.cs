using CloudVOffice.Core.Domain.HR.Emp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Projects
{
	public class ProjectTask : IAuditEntity, ISoftDeletedEntity
	{
		public Int64? ProjectTaskId { get; set; }
		public int ProjectId { get; set; }
		public Int64? EmployeeId { get; set; }
		public Int64? AssignedBy { get; set; }
		public DateTime? AssignedOn { get; set; }
		
		public string TaskName { get; set; }
		public string? Priority { get; set; }
		public Int64? ParentTaskId { get; set; }
		public bool IsGroup { get; set; }
		public DateTime? ExpectedStartDate { get; set; }
		public DateTime? ExpectedEndDate { get; set;}
		public double? ExpectedTimeInHours { get; set; }
		public double? Progress { get;set; }
		public string? TaskDescription { get; set; }
		public string TaskStatus { get; set; }
		public Int64? ComplitedBy { get; set; }
		public DateTime? ComplitedOn { get; set; }

		public string TaskComplitedByOthersReasonByAssign { get; set; }
		public string TaskComplitedByOthersReasonByComplitedBy { get; set; }
		
		public bool? IsDelayApproved { get; set; }
		public string? DelayReason { get; set; }
		public Int64? DelayApprovedBy { get; set; }
		public DateTime? DelayApprovedOn { get; set; }
		public string? DelayApprovalReason { get; set; }
		public double? TotalHoursByTimeSheet { get; set; }
		public double? TotalBillableHourByTimeSheet { get; set; }

		public Int64 CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public Int64? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }



        [ForeignKey("ProjectId")]
        public Project Project { get; set; }

		[ForeignKey("EmployeeId")]
		public Employee AssignedTo { get; set; }

		[ForeignKey("ComplitedBy")]
        public Employee Employee { get; set; }

		public virtual ICollection<TaskAssignment> TaskAssignments { get; set; }


    }
}
