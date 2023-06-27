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
    public interface IHolidayDaysService
    {
        public MessageEnum CreateHolidayDays(HolidayDaysDTO holidayDaysDTO, Int64 CreatedBy);
        public List<HolidayDays> GetHolidayDaysList();
        public HolidayDays GetHolidayDaysById(Int64 HolidayDaysId);
        public MessageEnum HolidayDaysUpdate(HolidayDaysDTO holidayDaysDTO);
        public MessageEnum HolidayDaysDelete(Int64 HolidayDaysId, Int64 DeletedBy);
    }
}
