using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.HR.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Recruitment
{
	public class InterviewPanelMember : IAuditEntity, ISoftDeletedEntity
	{
		public int InterviewPanelMemberId { get; set; }
		public int InterviewRoundId { get; set; }	
		public Int64 EmployeeId { get; set; }


		public Int64 CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public Int64? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }


		[ForeignKey("EmployeeId")]
		public Employee Employee{ get; set; }


		[ForeignKey("InterviewRoundId")]
		public InterviewRound InterviewRound { get; set; }

	}
}
