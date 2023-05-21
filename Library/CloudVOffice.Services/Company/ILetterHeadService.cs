using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Company;
using CloudVOffice.Core.Domain.Comunication;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Company;
using CloudVOffice.Data.DTO.Comunication;
using CloudVOffice.Data.DTO.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Company
{
	public interface ILetterHeadService
	{
		public MennsageEnum LetterHeadCreate(LetterHeadDTO letterHeadDTO);
		public LetterHead GetLetterHeadByLetterHeadId(int letterHeadId);
		public List<LetterHead> GetLetterHeads();
		public LetterHead GetLetter();
		public MennsageEnum LetterHeadUpdate(LetterHeadDTO letterHeadDTO);
		public MennsageEnum LetterHeadDelete(int letterHeadId, int DeletedBy);
	}
}
