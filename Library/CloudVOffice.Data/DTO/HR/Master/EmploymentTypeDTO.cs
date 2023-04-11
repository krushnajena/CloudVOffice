using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.HR.Master
{
    public class EmploymentTypeDTO
    {
        public int? EmploymentTypeId { get; set; }
        public string EmploymentTypeName { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
