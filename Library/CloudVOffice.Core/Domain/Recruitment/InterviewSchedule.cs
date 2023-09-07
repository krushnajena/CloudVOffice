
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Recruitment
{
	public class InterviewSchedule : IAuditEntity, ISoftDeletedEntity
	{
		public Int64 InterviewScheduleId { get; set; }
		public int JobId { get; set; }
		public Int64 ApplicationId { get; set; }
		public int RoundId { get; set; }
		public Int64 ScheduledBy { get; set; }
		public DateTime ScheduledOn { get; set; }
		public DateTime ScheduledOff { get; set;}
		public int Status { get; set; } // 1 = Scheduled, 2 = No-Show, 3 = Re-Scheduled By Candidate ,4 = Re-Scheduled By Panel, 5= Canceled, 6 = Present
		public Int64 CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public Int64? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }
	}
}
