using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Recruitment
{
    public class RecruitClientContactDTO
    {
        public Int64? RecruitClientContactId { get; set; }
        public int RecruitClientId { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string DepartmentName { get; set; }
        public string JobTitle { get; set; }

        public Int64 CreatedBy { get; set; }
    }
}
