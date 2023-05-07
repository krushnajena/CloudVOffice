using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Projects
{
    public class ProjectTypeDTO
    {
        public int? ProjectTypeId { get; set; }
        public string ProjectTypeName { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
