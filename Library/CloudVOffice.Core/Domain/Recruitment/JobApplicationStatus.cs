using CloudVOffice.Core.Domain.HR.Emp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Recruitment
{
    public class JobApplicationStatus:IAuditEntity, ISoftDeletedEntity
    {
        public Int64 JobApplicationStatusId { get; set; }
        public Int64 JobApplicationId { get; set; }
        public int Status { get; set; }
        public int StatusUpBy { get; set; } //1=Emp, 2 = Client
        public string Comment { get; set; }
        public Int64? ClientContactId { get; set; }
        public Int64? EmployeeId { get; set; }

        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }

        [ForeignKey("JobApplicationId")]
        public JobApplication JobApplication{ get; set; }
        [ForeignKey("ClientContactId")]
        public RecruitClientContact RecruitClientContact { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

    }

}
