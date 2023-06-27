using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Attendance;
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
	public class InterviewRoundService : IInterviewRoundService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<InterFeedBackQuestions> _interviewRoundRepo;
		public InterviewRoundService(ApplicationDBContext Context, ISqlRepository<InterFeedBackQuestions> interviewRoundRepo)
		{

			_Context = Context;
			_interviewRoundRepo = interviewRoundRepo;
		}
		public MessageEnum CreateInterviewRound(InterFeedBackQuestionsDTO interFeedBackQuestionsDTO)
		{
			var objCheck = _Context.InterFeedBackQuestions.SingleOrDefault(opt => opt.InterFeedBackQuestionsId == interFeedBackQuestionsDTO.InterFeedBackQuestionsId && opt.Deleted == false);
			try
			{
				if (objCheck == null)
				{

					InterFeedBackQuestions interFeedBackQuestions = new InterFeedBackQuestions();
					interFeedBackQuestions.DesignationId = interFeedBackQuestionsDTO.DesignationId;
					interFeedBackQuestions.Question = interFeedBackQuestionsDTO.Question;
					interFeedBackQuestions.Mark = interFeedBackQuestionsDTO.Mark;
					interFeedBackQuestions.CreatedBy = interFeedBackQuestionsDTO.CreatedBy;
					var obj = _interviewRoundRepo.Insert(interFeedBackQuestions);

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

		public InterFeedBackQuestions GetInterviewRoundById(Int64 InterFeedBackQuestionsId)
		{
			try
			{
				return _Context.InterFeedBackQuestions.Where(x => x.InterFeedBackQuestionsId == InterFeedBackQuestionsId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public List<InterFeedBackQuestions> GetInterviewRoundList()
		{
			try
			{
				return _Context.InterFeedBackQuestions.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

		public MessageEnum InterviewRoundDelete(Int64 InterFeedBackQuestionsId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.InterFeedBackQuestions.Where(x => x.InterFeedBackQuestionsId == InterFeedBackQuestionsId).FirstOrDefault();
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




		public MessageEnum InterviewRoundUpdate(InterFeedBackQuestionsDTO interFeedBackQuestionsDTO)
		{
			try
			{
				var shiftType = _Context.InterFeedBackQuestions.Where(x => x.InterFeedBackQuestionsId != interFeedBackQuestionsDTO.InterFeedBackQuestionsId && x.Deleted == false).FirstOrDefault();
				if (shiftType == null)
				{
					var a = _Context.InterFeedBackQuestions.Where(x => x.InterFeedBackQuestionsId == interFeedBackQuestionsDTO.InterFeedBackQuestionsId).FirstOrDefault();
					if (a != null)
					{
						a.DesignationId = interFeedBackQuestionsDTO.DesignationId;
						a.Question = interFeedBackQuestionsDTO.Question;
						a.Mark = interFeedBackQuestionsDTO.Mark;
						a.UpdatedBy = interFeedBackQuestionsDTO.CreatedBy;
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
