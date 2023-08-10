using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;

namespace CloudVOffice.Services.Attendance
{
    public interface IEmployeeAttendanceService
    {


        public MessageEnum CreateEmployeeAttendance(EmployeeAttendanceDTO employeeAttendanceDTO);
        public List<EmployeeAttendance> GetEmployeeAttendanceList();
        public EmployeeAttendance GetEmployeeAttendanceById(Int64 EmployeeAttendanceId);
        public MessageEnum EmployeeAttendanceUpdate(EmployeeAttendanceDTO employeeAttendanceDTO);
        public MessageEnum EmployeeAttendanceDelete(Int64 EmployeeAttendanceId, Int64 DeletedBy);

    }
}

