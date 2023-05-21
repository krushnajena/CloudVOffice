using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Company;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Company;
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
		public List<LetterHead> GetLetterHeads();
		public LetterHead GetLetter();
		
	}
}
