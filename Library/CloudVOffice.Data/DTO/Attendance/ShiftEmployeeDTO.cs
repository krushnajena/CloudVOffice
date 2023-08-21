using CloudVOffice.Data.DTO.Emp;

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
    }
}
