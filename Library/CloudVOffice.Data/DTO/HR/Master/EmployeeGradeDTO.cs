using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.HR.Master
{
   public class EmployeeGradeDTO
    {
        public int? EmployeeGradeId { get; set; }
        public string EmployeeGradeName { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
