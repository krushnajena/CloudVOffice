namespace CloudVOffice.Data.DTO.Attendance
{
    public class AttendanceDeviceDTO
    {
        public int? AttendanceDeviceId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceSlNo { get; set; }

        public Int64 CreatedBy { get; set; }
    }
}
