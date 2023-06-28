using CloudVOffice.Core.Domain.HR.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Recruitment
{
    public class InterFeedBackQuestions : IAuditEntity, ISoftDeletedEntity
    {
        public int InterFeedBackQuestionsId { get; set; }
        public int? DesignationId { get; set; }
        public string Question { get; set; }
        public int Mark { get; set; } 
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

		[ForeignKey("DesignationId")]
		public Designation Designation { get; set; }
	}
}
