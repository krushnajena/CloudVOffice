using CloudVOffice.Core.Domain.HR.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Recruitment
{
	public class InterviewRound : IAuditEntity, ISoftDeletedEntity
	{
		public int InterviewRoundId { get; set; }
		public string InterviewRoundName { get; set;}
		public int InterviewTypeId { get; set; }
		public int DesignationId { get; set; }
		public int InterviewRoundOrder { get; set; }

		public Int64 CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public Int64? UpdatedBy { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public bool Deleted { get; set; }


		[ForeignKey("DesignationId")]
		public Designation Designation { get; set; }


		[ForeignKey("InterviewTypeId")]
		public InterviewType InterviewType { get; set; }


	}
}
