using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.HR.Master
{
    public class DepartmentDTO
    {
        public int? DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? Parent { get; set; }
        public bool IsGroup { get; set; }
        public int CreatedBy { get; set; }
    }
}
