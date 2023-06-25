using CloudVOffice.Data.DTO.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Attendance
{
    public class HolidayDTO
    {
        public int? HolidayId { get; set; }
        public string HolidayName { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public Int64 CreatedBy { get; set; }

        public List<HolidayDaysDTO>? holidayDays { get; set; }
        public string holidayDaysString { get; set; }
    }

}
