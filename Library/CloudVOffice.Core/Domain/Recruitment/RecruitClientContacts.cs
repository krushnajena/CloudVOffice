using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Recruitment
{
    public class RecruitClientContact : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 RecruitClientContactId { get; set; }
        public int RecruitClientId { get; set; }
        public string ContactName { get; set;}
        public string ContactEmail { get; set;}
        public string ContactPhone { get; set;}
        public string DepartmentName { get; set;}
        public string JobTitle { get; set;}

        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("RecruitClientId")]
        public RecruitClient RecruitClient { get; set; }
    }
}
