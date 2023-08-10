namespace CloudVOffice.Data.DTO.Attendance
{
    public class HolidayDaysDTO
    {
        public Int64? HolidayDaysId { get; set; }
        public int? HolidayId { get; set; }
        public DateTime? ForDate { get; set; }
        public string Description { get; set; }
        public Int64 CreatedBy { get; set; }

    }
}
