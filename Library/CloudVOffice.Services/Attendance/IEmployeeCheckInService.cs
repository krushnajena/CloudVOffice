using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;

namespace CloudVOffice.Services.Attendance
{
    public interface IEmployeeCheckInService
    {   
        public MessageEnum EmployeeCheckInCreate(EmployeeCheckInDTO employeeCheckInDTO);
        public List<EmployeeCheckIn> GetEmployeeCheckIn();
        public EmployeeCheckIn GetEmployeeCheckInById(Int64 employeeCheckInId);
        public MessageEnum EmployeeCheckInUpdate(EmployeeCheckInDTO employeeCheckInDTO);
        public MessageEnum EmployeeCheckInDelete(Int64 employeeCheckInId, Int64 DeletedBy);
        public MessageEnum GetEmployeeCheckInUpdate(Int64 EmployeeId, DateTime ForDate, TimeSpan CheckInTime, TimeSpan CheckOutTime);
        
    }
}
