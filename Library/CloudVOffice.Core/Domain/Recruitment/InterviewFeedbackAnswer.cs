using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Recruitment
{
	public class InterviewFeedbackAnswer : IAuditEntity, ISoftDeletedEntity
	{
		public Int64 InterviewFeedbackAnswerId { get; set; }
		public Int64 InterviewPanelId { get; set; }
		public Int64 InterFeedBackQuestionsId { get; set; }
		public decimal? Mark { get; set; }

		public Int64 CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public Int64? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }




	}
}
