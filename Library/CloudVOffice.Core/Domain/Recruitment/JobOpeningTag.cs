using CloudVOffice.Core.Domain.HR.Emp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.Recruitment
{
    public class JobOpeningTag : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 JobOpeningTagId { get; set; }
        public int JobId { get; set; }
        public Int64 TagId { get; set; }

        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }



        [ForeignKey("JobId")]
        public JobOpening JobOpening { get; set; }

        [ForeignKey("TagId")]
        public Employee Employee { get; set; }

    }
}
