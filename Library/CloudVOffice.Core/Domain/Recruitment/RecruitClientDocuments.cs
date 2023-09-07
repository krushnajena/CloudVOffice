using CloudVOffice.Core.Domain.HR.Emp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Recruitment
{
    public  class RecruitClientDocument : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 RecruitClientDocumentId { get; set; }
        public int RecruitClientId { get; set; }
        public string DocumentType { get; set; }
        public string Document { get; set; }

        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("RecruitClientId")]
        public RecruitClient RecruitClient { get; set; }

    }
}
