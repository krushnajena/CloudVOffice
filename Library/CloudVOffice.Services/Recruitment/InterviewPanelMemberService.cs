using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
	public class InterviewPanelMemberService : IInterviewPanelMemberService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<InterviewPanelMember> _InterviewPanelMemberRepo;

		public InterviewPanelMemberService(ApplicationDBContext Context, ISqlRepository<InterviewPanelMember> InterviewPanelMemberRepo)
		{
			_Context = Context;
			_InterviewPanelMemberRepo = InterviewPanelMemberRepo;
		}
		public InterviewPanelMember GetInterviewPanelMemberById(int interviewPanelMemberId)
		{
			try
			{
				return _Context.InterviewPanelMembers.Where(x => x.InterviewPanelMemberId == interviewPanelMemberId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;

			}
		}

		public List<InterviewPanelMember> GetInterviewPanelMemberList()
		{
			try
			{
				return _Context.InterviewPanelMembers.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

		public MessageEnum InterviewPanelMemberCreate(InterviewPanelMemberDTO interviewPanelMemberDTO)
		{
			var objCheck = _Context.InterviewPanelMembers.SingleOrDefault(x => x.InterviewPanelMemberId == interviewPanelMemberDTO.InterviewPanelMemberId && x.Deleted == false);
			try
			{
				if (objCheck == null)
				{
					InterviewPanelMember interviewPanelMember = new InterviewPanelMember();
					interviewPanelMember.InterviewRoundId = interviewPanelMemberDTO.InterviewRoundId;
					interviewPanelMember.EmployeeId = interviewPanelMemberDTO.EmployeeId;
					interviewPanelMember.CreatedBy = interviewPanelMemberDTO.CreatedBy;
					var obj = _InterviewPanelMemberRepo.Insert(interviewPanelMember);
					return MessageEnum.Success;
				}
				else if (objCheck != null)
				{
					return MessageEnum.Duplicate;
				}
				return MessageEnum.UnExpectedError;
			}
			catch
			{
				throw;
			}
		}

		public MessageEnum InterviewPanelMemberDelete(int interviewPanelMemberId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.InterviewPanelMembers.Where(x => x.InterviewPanelMemberId == interviewPanelMemberId).FirstOrDefault();
				if (a != null)
				{
					a.Deleted = true;
					a.UpdatedBy = DeletedBy;
					a.UpdatedDate = DateTime.Now;
					_Context.SaveChanges();
					return MessageEnum.Deleted;
				}
				else
					return MessageEnum.Invalid;
			}
			catch
			{
				throw;
			}
		}

		public MessageEnum InterviewPanelMemberUpdate(InterviewPanelMemberDTO interviewPanelMemberDTO)
		{
			try
			{
				var InterviewPanelMember = _Context.InterviewPanelMembers.Where(x => x.InterviewPanelMemberId != interviewPanelMemberDTO.InterviewPanelMemberId && x.Deleted == false).FirstOrDefault();
				if (InterviewPanelMember == null)
				{
					var a = _Context.InterviewPanelMembers.Where(x => x.InterviewPanelMemberId == interviewPanelMemberDTO.InterviewPanelMemberId).FirstOrDefault();
					if (a != null)
					{
						a.InterviewRoundId = interviewPanelMemberDTO.InterviewRoundId;
						a.EmployeeId = interviewPanelMemberDTO.EmployeeId;
						a.UpdatedBy = interviewPanelMemberDTO.CreatedBy;
						a.UpdatedDate = DateTime.Now;

						_Context.SaveChanges();
						return MessageEnum.Updated;
					}
					else
						return MessageEnum.Invalid;
				}
				else
				{
					return MessageEnum.Duplicate;
				}

			}
			catch
			{
				throw;
			}
		}
	}
}
