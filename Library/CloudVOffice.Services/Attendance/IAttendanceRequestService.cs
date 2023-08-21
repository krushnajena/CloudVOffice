using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using static CloudVOffice.Data.DTO.Attendance.AttendanceRequestDTO;

namespace CloudVOffice.Services.Attendance
{
    public interface IAttendanceRequestService
    {
        public MessageEnum AttendanceRequestCreate(AttendanceRequestDTO attendanceRequestDTO);
        public List<AttendanceRequest> GetAttendanceRequest();
        public List<AttendanceRequest> GetAttendanceToValidate(Int64 EmployeeId);
        public MessageEnum AttendanceApproved(AttendanceApprovedDTO attendanceApprovedDTO);
        public AttendanceRequest GetAttendanceRequestById(Int64 attendanceRequestId);
        public MessageEnum AttendanceRequestUpdate(AttendanceRequestDTO attendanceRequestDTO);
        public MessageEnum AttendanceRequestDelete(Int64 attendanceRequestId, Int64 DeletedBy);


    }
}