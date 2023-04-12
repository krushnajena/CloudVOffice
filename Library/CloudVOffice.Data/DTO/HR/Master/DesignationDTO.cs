using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.HR.Master
{
    public class DesignationDTO
    {
        public int? DesignationId { get; set; }
        public string DesignationName { get; set; }
        public string Description { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
