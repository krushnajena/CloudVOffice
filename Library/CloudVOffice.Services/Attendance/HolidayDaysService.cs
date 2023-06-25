using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Attendance
{
    public class HolidayDaysService : IHolidayDaysService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<HolidayDays> _holidayRepo;
    
        public HolidayDaysService(ApplicationDBContext Context, ISqlRepository<HolidayDays> holidayRepo)
        {

            _Context = Context;
            _holidayRepo = holidayRepo;
            
        }
        public MessageEnum CreateHolidayDays(HolidayDaysDTO holidayDaysDTO , Int64 CreatedBy)
        {
             _holidayRepo.Insert(new HolidayDays
             {
                 ForDate = holidayDaysDTO.ForDate,
                 Description = holidayDaysDTO.Description,
                 HolidayId= int.Parse( holidayDaysDTO.HolidayId.ToString()),
                 Deleted = false,
                 CreatedBy = CreatedBy
             });

            return MessageEnum.Success;
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
