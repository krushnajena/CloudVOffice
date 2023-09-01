using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Recruitment
{
	public class InterviewPanelMemberDTO
	{
		public int? InterviewPanelMemberId { get; set; }
		public int InterviewRoundId { get; set; }
		public Int64 EmployeeId { get; set; }


		public Int64 CreatedBy { get; set; }
	}
}
