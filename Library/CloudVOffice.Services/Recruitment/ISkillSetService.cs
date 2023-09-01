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
	public interface ISkillSetService
	{
		public MessageEnum CreateSkillSet(SkillSetDTO skillSetDTO);
		public List<SkillSet> GetSkillSetList();
		public SkillSet GetSkillSetById(int skillSetId);
		public MessageEnum SkillSetUpdate(SkillSetDTO skillSetDTO);
		public MessageEnum SkillSeteDelete(int skillSetId, Int64 DeletedBy);
	}
}
