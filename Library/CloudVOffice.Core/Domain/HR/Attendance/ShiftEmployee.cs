using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.Projects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.HR.Attendance
{
    public class ShiftEmployee : IAuditEntity, ISoftDeletedEntity
    {
        public Int64 ShiftEmployeeId { get; set; }
        public Int64 EmployeeId { get; set;}
        public int ShiftId { get; set; }
        public DateTime? FromDate { get; set; }  
        public DateTime? ToDate { get; set; }

        public Int64 CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }


        [ForeignKey("ShiftId")]
        public ShiftType ShiftType { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
