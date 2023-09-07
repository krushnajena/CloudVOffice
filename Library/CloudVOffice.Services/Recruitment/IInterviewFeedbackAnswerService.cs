using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
	public interface IInterviewFeedbackAnswerService
	{
		public MessageEnum InterviewFeedbackAnswerCreate(InterviewFeedbackAnswerDTO interviewFeedbackAnswerDTO);
		public List<InterviewFeedbackAnswer> GetInterviewFeedbackAnswerList();
		public InterviewFeedbackAnswer GetInterviewFeedbackAnswerById(Int64 interviewFeedbackAnswerId);
		public MessageEnum InterviewFeedbackAnswerUpdate(InterviewFeedbackAnswerDTO interviewFeedbackAnswerDTO);
		public MessageEnum InterviewFeedbackAnswerDelete(Int64 interviewFeedbackAnswerId, Int64 DeletedBy);
	}
}
