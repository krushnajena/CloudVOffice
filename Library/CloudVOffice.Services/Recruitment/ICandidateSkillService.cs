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
	public interface ICandidateSkillService
	{
        public MessageEnum CreateCandidateSkill(int CandidateId, int SkillId, Int64 createdBy);

       
    }
}
