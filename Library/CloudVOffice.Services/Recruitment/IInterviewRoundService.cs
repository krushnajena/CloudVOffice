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
		public MessageEnum InterviewRoundCreate(InterviewRoundDTO interviewRoundDTO);
		public List<InterviewRound> GetInterviewRoundsList();
		public InterviewRound GetInterviewRoundById(int interviewRoundId);
		public MessageEnum InterviewRoundUpdate(InterviewRoundDTO interviewRoundDTO);
		public MessageEnum InterviewRoundDelete(int interviewRoundId, Int64 DeletedBy);

		public List<InterviewRound> GetInterviewRoundsByDesignationId(int DesignationId);
	}
}
