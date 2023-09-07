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
	public class InterviewFeedbackAnswerService : IInterviewFeedbackAnswerService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<InterviewFeedbackAnswer> _InterviewFeedbackAnswerRepo;

		public InterviewFeedbackAnswerService(ApplicationDBContext Context, ISqlRepository<InterviewFeedbackAnswer> InterviewFeedbackAnswerRepo)
		{
			_Context = Context;
			_InterviewFeedbackAnswerRepo = InterviewFeedbackAnswerRepo;
		}

		public MessageEnum InterviewFeedbackAnswerCreate(InterviewFeedbackAnswerDTO interviewFeedbackAnswerDTO)
		{
			var objCheck = _Context.InterviewFeedbackAnswers.SingleOrDefault(x => x.InterviewFeedbackAnswerId == interviewFeedbackAnswerDTO.InterviewFeedbackAnswerId && x.Deleted == false);
			try
			{
				if (objCheck == null)
				{
					InterviewFeedbackAnswer interviewFeedbackAnswer = new InterviewFeedbackAnswer();
					interviewFeedbackAnswer.InterviewPanelId = interviewFeedbackAnswerDTO.InterviewPanelId;
					interviewFeedbackAnswer.InterFeedBackQuestionsId = interviewFeedbackAnswerDTO.InterFeedBackQuestionsId;
					interviewFeedbackAnswer.Mark = interviewFeedbackAnswerDTO.Mark;
					interviewFeedbackAnswer.CreatedBy = interviewFeedbackAnswerDTO.CreatedBy;
					var obj = _InterviewFeedbackAnswerRepo.Insert(interviewFeedbackAnswer);
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
		public InterviewFeedbackAnswer GetInterviewFeedbackAnswerById(Int64 interviewFeedbackAnswerId)
		{
			try
			{
				return _Context.InterviewFeedbackAnswers.Where(x => x.InterviewFeedbackAnswerId == interviewFeedbackAnswerId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;

			}
		}

		public List<InterviewFeedbackAnswer> GetInterviewFeedbackAnswerList()
		{
			try
			{
				return _Context.InterviewFeedbackAnswers.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

		public MessageEnum InterviewFeedbackAnswerDelete(Int64 interviewFeedbackAnswerId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.InterviewFeedbackAnswers.Where(x => x.InterviewFeedbackAnswerId == interviewFeedbackAnswerId).FirstOrDefault();
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

		public MessageEnum InterviewFeedbackAnswerUpdate(InterviewFeedbackAnswerDTO interviewFeedbackAnswerDTO)
		{
			try
			{
				var interviewFeedbackAnswer = _Context.InterviewFeedbackAnswers.Where(x => x.InterviewFeedbackAnswerId != interviewFeedbackAnswerDTO.InterviewFeedbackAnswerId && x.Deleted == false).FirstOrDefault();
				if (interviewFeedbackAnswer == null)
				{
					var a = _Context.InterviewFeedbackAnswers.Where(x => x.InterviewFeedbackAnswerId == interviewFeedbackAnswerDTO.InterviewFeedbackAnswerId).FirstOrDefault();
					if (a != null)
					{
						a.InterviewPanelId = interviewFeedbackAnswerDTO.InterviewPanelId;
						a.InterFeedBackQuestionsId = interviewFeedbackAnswerDTO.InterFeedBackQuestionsId;
						a.Mark = interviewFeedbackAnswerDTO.Mark;
						a.UpdatedBy = interviewFeedbackAnswerDTO.CreatedBy;
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

