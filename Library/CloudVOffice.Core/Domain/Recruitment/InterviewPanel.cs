using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Recruitment
{
	public class InterviewPanel : IAuditEntity, ISoftDeletedEntity
	
	{
		public Int64 InterviewPanelId { get; set; }	
		public Int64 InterviewScheduleId { get; set; }
		public Int64 EmployeeId { get; set; }
		public int InetrviewStatus { get; set; } // 1 = Recommended , 2 = Not-Recommended
		public string? FeedBack { get; set; }
		public DateTime? FeedBackSubmittedOn { get; set; }
		public Int64 CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public Int64? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }



	}
}
