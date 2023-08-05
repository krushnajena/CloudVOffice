using CloudVOffice.Data.DTO.Emp;
using CloudVOffice.Data.DTO.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Attendance
{
    public class ShiftEmployeeDTO
    {
        public Int64? ShiftEmployeeId { get; set; }
        public Int64 EmployeeId { get; set; }
        public int ShiftId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        public Int64 CreatedBy { get; set; }

        public List<EmployeeCreateDTO>? EmployeeShift { get; set; }
        public string EmployeesString { get; set; }

       /* public class EmployeeShiftDTO
        {

            public Int64 EmployeeId { get; set; }
            public int? ProjectId { get; set; }
            public string FullName { get; set; }
            public Int64? CreatedBy { get; set; }
        }*/
    }
}
