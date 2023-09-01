using CloudVOffice.Core.Domain.HR.Master;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudVOffice.Core.Domain.Recruitment
{
    public class JobOpening : IAuditEntity, ISoftDeletedEntity
    {

        public int JobOpeningId { get; set; }
        public string JobTitle { get; set; }
        public int? DepartmentId { get; set; }
        public int? DesignationId { get; set; }
        public int? SkillSetId { get; set; }    
        public int Status { get; set; }
        public string Description { get; set; }
        public double? SalaryLowerRange { get; set; }
        public double? SalaryUpperRange { get; set; }

        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        [ForeignKey("DesignationId")]
        public Designation Designation { get; set; }

        [ForeignKey("SkillSetId")]
        public SkillSet SkillSet { get; set; }


    }
}
