using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;
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
		private readonly ISqlRepository<InterviewRound> _InterviewRoundRepo;

		public InterviewRoundService(ApplicationDBContext Context, ISqlRepository<InterviewRound> InterviewRoundRepo)
		{
			_Context = Context;
			_InterviewRoundRepo = InterviewRoundRepo;
		}

		public MessageEnum InterviewRoundCreate(InterviewRoundDTO interviewRoundDTO)
		{
			var objCheck = _Context.InterviewRounds.SingleOrDefault(x => x.InterviewRoundId == interviewRoundDTO.InterviewRoundId && x.Deleted == false);
			try
			{
				if (objCheck == null)
				{
					InterviewRound interviewRound = new InterviewRound();
					interviewRound.InterviewRoundName = interviewRoundDTO.InterviewRoundName;
					interviewRound.InterviewTypeId = interviewRoundDTO.InterviewTypeId;
					interviewRound.DesignationId = interviewRoundDTO.DesignationId;
					interviewRound.InterviewRoundOrder = interviewRoundDTO.InterviewRoundOrder;
					interviewRound.CreatedBy = interviewRoundDTO.CreatedBy;
					var obj = _InterviewRoundRepo.Insert(interviewRound);
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
		public InterviewRound GetInterviewRoundById(int interviewRoundId)
		{
			try
			{
				return _Context.InterviewRounds.Where(x => x.InterviewRoundId == interviewRoundId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;

			}
		}

		public List<InterviewRound> GetInterviewRoundsList()
		{
			try
			{
				return _Context.InterviewRounds.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

		public MessageEnum InterviewRoundDelete(int interviewRoundId, long DeletedBy)
		{
			try
			{
				var a = _Context.InterviewRounds.Where(x => x.InterviewRoundId == interviewRoundId).FirstOrDefault();
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

		public MessageEnum InterviewRoundUpdate(InterviewRoundDTO interviewRoundDTO)
		{
			try
			{
				var interviewRound = _Context.InterviewRounds.Where(x => x.InterviewRoundId != interviewRoundDTO.InterviewRoundId && x.Deleted == false).FirstOrDefault();
				if (interviewRound == null)
				{
					var a = _Context.InterviewRounds.Where(x => x.InterviewRoundId == interviewRoundDTO.InterviewRoundId).FirstOrDefault();
					if (a != null)
					{
						a.InterviewRoundName = interviewRoundDTO.InterviewRoundName;
						a.InterviewTypeId = interviewRoundDTO.InterviewTypeId;
						a.DesignationId = interviewRoundDTO.DesignationId;
						a.InterviewRoundOrder = interviewRoundDTO.InterviewRoundOrder;
						a.UpdatedBy = interviewRoundDTO.CreatedBy;
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

		public List<InterviewRound> GetInterviewRoundsByDesignationId(int DesignationId)
		{
			return _Context.InterviewRounds.Where(x=>x.DesignationId == DesignationId && x.Deleted == false).OrderBy(a=>a.InterviewRoundOrder).ToList();
		}
	}
}
