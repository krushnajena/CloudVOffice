using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Recruitment
{
    public class CandidateSkill : IAuditEntity, ISoftDeletedEntity
    {
        public int CandidateSkillId { get; set; }
        public Int64 CandidateId { get; set; }
        public int SkillId { get; set; }
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

      

        [ForeignKey("SkillId")]
        public SkillSet SkillSet { get; set; }

    }
}
