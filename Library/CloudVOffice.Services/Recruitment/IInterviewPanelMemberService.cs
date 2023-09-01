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
	public interface IInterviewPanelMemberService
	{
		public MessageEnum InterviewPanelMemberCreate(InterviewPanelMemberDTO interviewPanelMemberDTO);
		public List<InterviewPanelMember> GetInterviewPanelMemberList();
		public InterviewPanelMember GetInterviewPanelMemberById(int interviewPanelMemberId);
		public MessageEnum InterviewPanelMemberUpdate(InterviewPanelMemberDTO interviewPanelMemberDTO);
		public MessageEnum InterviewPanelMemberDelete(int interviewPanelMemberId, Int64 DeletedBy);
	}
}
