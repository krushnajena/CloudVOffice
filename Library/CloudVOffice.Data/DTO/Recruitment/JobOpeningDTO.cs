using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Recruitment
{
    public class JobOpeningDTO
    {
        public int? JobOpeningId { get; set; }
        public string JobTitle { get; set; }
        public int? DepartmentId { get; set; }
        public int? DesignationId { get; set; }
		public int SkillSetId { get; set; }
		public int Status { get; set; }
        public string Description { get; set; }
        public double? SalaryLowerRange { get; set; }
        public double? SalaryUpperRange { get; set; }

        public Int64 CreatedBy { get; set; }
    }
}
