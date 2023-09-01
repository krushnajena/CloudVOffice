using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Recruitment
{
	public class InterviewRoundDTO
	{
		public int? InterviewRoundId { get; set; }
		public string InterviewRoundName { get; set; }
		public int InterviewTypeId { get; set; }
		public int DesignationId { get; set; }
		public int InterviewRoundOrder { get; set; }
		public Int64 CreatedBy { get; set; }
	}
}
