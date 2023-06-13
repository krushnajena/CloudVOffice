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
    public class HolidayService : IHolidayService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<Holiday> _holidayRepo;
        public HolidayService(ApplicationDBContext Context, ISqlRepository<Holiday> holidayRepo)
        {

            _Context = Context;
            _holidayRepo = holidayRepo;
        }
        public MessageEnum CreateHoliday(HolidayDTO holidayDTO)
        {
            var objCheck = _Context.Holidays.SingleOrDefault(opt => opt.HolidayId == holidayDTO.HolidayId && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    Holiday holiday = new Holiday();
                    holiday.HolidayName = holidayDTO.HolidayName;
                    holiday.FromDate = holidayDTO.FromDate;
                    holiday.ToDate = holidayDTO.ToDate;
                    holiday.CreatedBy = holidayDTO.CreatedBy;
                    var obj = _holidayRepo.Insert(holiday);

                    return MessageEnum.Success;
                }
                else if (objCheck != null)
                {
                    return MessageEnum.Duplicate;
                }

                return MessageEnum.UnExpectedError;
            }
            catch
            {
                throw;
            }
        }
        public List<Holiday> GetHolidayList()
        {
            try
            {
                return _Context.Holidays.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public Holiday GetHolidayById(Int64 holidayId)
        {
            try
            {
                return _Context.Holidays.Where(x => x.HolidayId == holidayId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }
        public MessageEnum HolidayUpdate(HolidayDTO holidayDTO)
        {
            try
            {
                var hoiday = _Context.Holidays.Where(x => x.HolidayId != holidayDTO.HolidayId && x.HolidayName == holidayDTO.HolidayName && x.Deleted == false).FirstOrDefault();
                if (hoiday == null)
                {
                    var a = _Context.Holidays.Where(x => x.HolidayId == holidayDTO.HolidayId).FirstOrDefault();
                    if (a != null)
                    {
                        a.HolidayName = holidayDTO.HolidayName;
                        a.FromDate = holidayDTO.FromDate;
                        a.ToDate = holidayDTO.ToDate;
                        a.UpdatedBy = holidayDTO.CreatedBy;
                        a.UpdatedDate = DateTime.Now;
                        _Context.SaveChanges();
                        return MessageEnum.Updated;
                    }
                    else
                        return MessageEnum.Invalid;
                }
                else
                {
                    return MessageEnum.Duplicate;
                }

            }
            catch
            {
                throw;
            }
        }
        public MessageEnum HolidayDelete(Int64 holidayId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.Holidays.Where(x => x.HolidayId == holidayId).FirstOrDefault();
                if (a != null)
                {
                    a.Deleted = true;
                    a.UpdatedBy = DeletedBy;
                    a.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();
                    return MessageEnum.Deleted;
                }
                else
                    return MessageEnum.Invalid;
            }
            catch
            {
                throw;
            }
        }

    }
}
