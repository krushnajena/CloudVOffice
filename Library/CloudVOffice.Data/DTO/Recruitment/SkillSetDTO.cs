using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Recruitment
{
	public class SkillSetDTO
	{
		public int? SkillSetId { get; set; }
		public string SkillName { get; set; }
		public string SkillDescription { get; set; }
		public Int64 CreatedBy { get; set; }
	}
}
