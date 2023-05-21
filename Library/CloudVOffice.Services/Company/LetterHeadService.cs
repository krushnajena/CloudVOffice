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
	}
}
