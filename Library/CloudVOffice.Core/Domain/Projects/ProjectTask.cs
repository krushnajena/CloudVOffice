using CloudVOffice.Core.Domain.HR.Emp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Projects
{
	public class ProjectTask : IAuditEntity, ISoftDeletedEntity
	{
		public Int64? ProjectTaskId { get; set; }
		public virtual Project ProjectId { get; set; }
		public string TaskName { get; set; }
		public string Priority { get; set; }
		public virtual ProjectTask? ParentTaskId { get; set; }
		public bool IsGroup { get; set; }
		public DateTime? ExpectedStartDate { get; set; }
		public DateTime? ExpectedEndDate { get; set;}
		public double? ExpectedTimeInHours { get; set; }
		public double? Progress { get;set; }
		public string TaskDescription { get; set; }
		public virtual Employee? ComplitedBy { get; set; }
		public DateTime? ComplitedOn { get; set; }
		public double? TotalHoursByTimeSheet { get; set; }
		public double? TotalBillableHourByTimeSheet { get; set; }

		public Int64 CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public Int64? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }



	}
}
