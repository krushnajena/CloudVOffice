using CloudVOffice.Core.Domain.HR.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.HR.Emp
{
    public class EmployeeEducationalQualification : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 EmployeeEducationalQualificationId { get; set; }
        public Int64 EmployeeId { get; set; }
        public string SchoolOrUniversityName { get; set; }
        public string Qualification { get; set; }
        public string Level { get; set; }
        public string YearOfPassing { get; set; }
        public string Percentage { get; set; }

        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }


        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
