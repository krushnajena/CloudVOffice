using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Recruitment
{
    public class InterviewTypeDTO
    {
        public int? InterviewTypeId { get; set; }
        public string InterviewTypeName { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
