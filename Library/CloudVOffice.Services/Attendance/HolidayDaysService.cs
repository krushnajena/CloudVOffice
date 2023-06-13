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
    public class HolidayDaysService : IHolidayDaysService
    {
        public MessageEnum CreateHolidayDays(HolidayDaysDTO holidayDaysDTO)
        {
            throw new NotImplementedException();
        }

        public HolidayDays GetHolidayDaysById(long HolidayDaysId)
        {
            throw new NotImplementedException();
        }

        public List<HolidayDays> GetHolidayDaysList()
        {
            throw new NotImplementedException();
        }

        public MessageEnum HolidayDaysDelete(long holidayId, long DeletedBy)
        {
            throw new NotImplementedException();
        }

        public MessageEnum HolidayDaysUpdate(HolidayDTO holidayDTO)
        {
            throw new NotImplementedException();
        }
    }
}
