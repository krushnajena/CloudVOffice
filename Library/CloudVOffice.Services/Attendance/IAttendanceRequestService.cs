using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;


namespace CloudVOffice.Services.Attendance
{
    public interface IAttendanceRequestService
    {
        public MessageEnum AttendanceRequestCreate(AttendanceRequestDTO attendanceRequestDTO);
        public List<AttendanceRequest> GetAttendanceRequest();
        public AttendanceRequest GetAttendanceRequestById(Int64 attendanceRequestId);
        public MessageEnum AttendanceRequestUpdate(AttendanceRequestDTO attendanceRequestDTO);
        public MessageEnum AttendanceRequestDelete(Int64 attendanceRequestId, Int64 DeletedBy);
    }
}
