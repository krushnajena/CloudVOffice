using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Attendance
{
    public interface IHolidayService
    {
        public MessageEnum CreateHoliday(HolidayDTO holidayDTO);
        public List<Holiday> GetHolidayList();
        public Holiday GetHolidayById(Int64 holidayId);
        public MessageEnum HolidayUpdate(HolidayDTO holidayDTO);
        public MessageEnum HolidayDelete(Int64 holidayId, Int64 DeletedBy);

        public Holiday GetHolidayByDates(DateTime startDate, DateTime endDate);
    }
}
