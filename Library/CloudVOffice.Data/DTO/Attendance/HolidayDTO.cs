namespace CloudVOffice.Data.DTO.Attendance
{
    public class HolidayDTO
    {
        public int? HolidayId { get; set; }
        public string HolidayName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public Int64 CreatedBy { get; set; }

        public List<HolidayDaysDTO>? HolidayDays { get; set; }
        public string holidayDaysString { get; set; }
    }

}
