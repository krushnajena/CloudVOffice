using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Recruitment
{
    public class JobApplicationStatusDTO
    {
        public Int64 JobApplicationId { get; set; }
        public int Status { get; set; }
        public int StatusUpBy { get; set; }
        public string Comment { get; set; }
        public Int64? ClientContactId { get; set; }
        public Int64? EmployeeId { get; set; }
        public Int64 CreatedBy { get; set; }
    }
}
