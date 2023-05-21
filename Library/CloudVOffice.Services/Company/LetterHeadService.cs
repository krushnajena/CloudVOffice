using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Company;
using CloudVOffice.Core.Domain.Comunication;
using CloudVOffice.Data.DTO.Company;
using CloudVOffice.Data.DTO.Comunication;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Company
{
	public class LetterHeadService : ILetterHeadService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<LetterHead> _letterHeadRepo;
		public LetterHeadService(ApplicationDBContext Context, ISqlRepository<LetterHead> letterHeadRepo)
		{

			_Context = Context;
			_letterHeadRepo = letterHeadRepo;
		}
		public LetterHead GetLetter()
		{
			try
			{
				return _Context.LetterHeads.Where(c=>c.Deleted==false).FirstOrDefault();
			}
			catch
			{
				throw;
			}
		}

		public LetterHead GetLetterHeadByLetterHeadId(int letterHeadId)
		{

			try
			{
				return _Context.LetterHeads.Where(x => x.LetterHeadId == letterHeadId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public List<LetterHead> GetLetterHeads()
		{
			try
			{
				return _Context.LetterHeads.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

		public MennsageEnum LetterHeadCreate(LetterHeadDTO letterHeadDTO)
		{
			var objCheck = _Context.LetterHeads.SingleOrDefault(opt => opt.LetterHeadId == letterHeadDTO.LetterHeadId && opt.Deleted == false);
			try
			{
				if (objCheck == null)
				{

					LetterHead letterHead = new LetterHead();
					letterHead.LetterHeadName = letterHeadDTO.LetterHeadName;
					letterHead.LetterHeadImage = letterHeadDTO.LetterHeadImage;
					letterHead.LetterHeadImageHeight = letterHeadDTO.LetterHeadImageHeight;
					letterHead.LetterHeadImageWidth = letterHeadDTO.LetterHeadImageWidth;
					letterHead.LetterHeadAlign = letterHeadDTO.LetterHeadAlign;
					letterHead.LetterHeadFooterImage = letterHeadDTO.LetterHeadFooterImage;
					letterHead.LetterHeadImageFooterHeight = letterHeadDTO.LetterHeadImageFooterHeight;
					letterHead.LetterHeadImageFooterWidth = letterHeadDTO.LetterHeadImageFooterWidth;
					letterHead.LetterHeadFooterAlign = letterHeadDTO.LetterHeadFooterAlign;
					letterHead.CreatedBy = letterHeadDTO.CreatedBy;
					var obj = _letterHeadRepo.Insert(letterHead);

					return MennsageEnum.Success;
				}
				else if (objCheck != null)
				{
					return MennsageEnum.Duplicate;
				}

				return MennsageEnum.UnExpectedError;
			}
			catch
			{
				throw;
			}
		}

		public MennsageEnum LetterHeadDelete(int letterHeadId, int DeletedBy)
		{
			try
			{
				var a = _Context.LetterHeads.Where(x => x.LetterHeadId == letterHeadId).FirstOrDefault();
				if (a != null)
				{
					a.Deleted = true;
					a.UpdatedBy = DeletedBy;
					a.UpdatedDate = DateTime.Now;
					_Context.SaveChanges();
					return MennsageEnum.Deleted;
				}
				else
					return MennsageEnum.Invalid;
			}
			catch
			{
				throw;
			}
		}

		public MennsageEnum LetterHeadUpdate(LetterHeadDTO letterHeadDTO)
		{
			try
			{
				var letterHead = _Context.LetterHeads.Where(x => x.LetterHeadId == letterHeadDTO.LetterHeadId && x.Deleted == false).FirstOrDefault();
				if (letterHead == null)
				{
					var a = _Context.LetterHeads.Where(x => x.LetterHeadId == letterHeadDTO.LetterHeadId).FirstOrDefault();
					if (a != null)
					{
						a.LetterHeadName = letterHeadDTO.LetterHeadName;
						a.LetterHeadImage = letterHeadDTO.LetterHeadImage;
						a.LetterHeadImageHeight = letterHeadDTO.LetterHeadImageHeight;
						a.LetterHeadImageWidth = letterHeadDTO.LetterHeadImageWidth;
						a.LetterHeadImageWidth = letterHeadDTO.LetterHeadImageWidth;
						a.LetterHeadAlign = letterHeadDTO.LetterHeadAlign;
						a.LetterHeadFooterImage = letterHeadDTO.LetterHeadFooterImage;
						a.LetterHeadImageFooterHeight = letterHeadDTO.LetterHeadImageFooterHeight;
						a.LetterHeadImageFooterWidth = letterHeadDTO.LetterHeadImageFooterWidth;
						a.LetterHeadFooterAlign = letterHeadDTO.LetterHeadFooterAlign;
						a.UpdatedDate = DateTime.Now;
						_Context.SaveChanges();
						return MennsageEnum.Updated;
					}
					else
						return MennsageEnum.Invalid;
				}
				else
				{
					return MennsageEnum.Duplicate;
				}

			}
			catch
			{
				throw;
			}
		}
	}
}
