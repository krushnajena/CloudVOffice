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
	public interface ICandidateService
	{
		public MessageEnum CandidateCreate(CandidateDTO candidateDTO);
		public List<Candidate> GetCandidateList();
		public Candidate GetCandidateById(Int64 candidateId);
		public MessageEnum CandidateUpdate(CandidateDTO candidateDTO);
		public MessageEnum CandidateDelete(Int64 candidateId, Int64 DeletedBy);
		public List<Candidate> GetCandidateListBySkillSetAndExpLevel(List<int> SkillSet, int ExpLevel);
	}
}
