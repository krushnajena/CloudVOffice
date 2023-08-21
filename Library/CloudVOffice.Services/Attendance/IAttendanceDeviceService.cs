using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;

namespace CloudVOffice.Services.Attendance
{
    public interface IAttendanceDeviceService
    {
        public MessageEnum CreateAttendanceDevice(AttendanceDeviceDTO attendanceDeviceDTO);
        public List<AttendanceDevice> GetAttendanceDeviceList();
        public AttendanceDevice GetAttendanceDeviceById(int attendanceDeviceId);
        public MessageEnum AttendanceDeviceUpdate(AttendanceDeviceDTO attendanceDeviceDTO);
        public MessageEnum AttendanceDeviceDelete(int attendanceDeviceId, Int64 DeletedBy);
    }
}
