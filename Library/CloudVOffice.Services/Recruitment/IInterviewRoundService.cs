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
	public interface IInterviewRoundService
	{
		public MessageEnum CreateInterviewRound(InterviewRoundDTO interviewRoundDTO);
		public List<InterFeedBackQuestions> GetInterviewRoundList();
		public InterFeedBackQuestions GetInterviewRoundById(Int64 InterFeedBackQuestionsId);
		public MessageEnum InterviewRoundUpdate(InterviewRoundDTO interviewRoundDTO);
		public MessageEnum InterviewRoundDelete(Int64 InterFeedBackQuestionsId, Int64 DeletedBy);
	}
}
