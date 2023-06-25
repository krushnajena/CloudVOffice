using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Attendance
{
    public class HolidayDaysDTO
    {
  
        public int? HolidayId { get; set; }
        public DateTime? ForDate { get; set; }
        public string Description { get; set; }
       
    }
}
