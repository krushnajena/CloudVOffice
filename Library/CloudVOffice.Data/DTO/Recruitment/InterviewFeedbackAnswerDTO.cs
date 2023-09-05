using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Recruitment
{
	public class InterviewFeedbackAnswerDTO
	{
		public Int64? InterviewFeedbackAnswerId { get; set; }
		public Int64 InterviewPanelId { get; set; }
		public Int64 InterFeedBackQuestionsId { get; set; }
		public decimal? Mark { get; set; }

		public Int64 CreatedBy { get; set; }
	}
}
