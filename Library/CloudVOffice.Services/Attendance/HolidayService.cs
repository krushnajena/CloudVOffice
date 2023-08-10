using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace CloudVOffice.Services.Attendance
{
    public class HolidayService : IHolidayService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<Holiday> _holidayRepo;
        private readonly IHolidayDaysService _holidayDaysService;
        public HolidayService(ApplicationDBContext Context, ISqlRepository<Holiday> holidayRepo, IHolidayDaysService holidayDaysService)
        {

            _Context = Context;
            _holidayRepo = holidayRepo;
            _holidayDaysService = holidayDaysService;
        }
        public MessageEnum CreateHoliday(HolidayDTO holidayDTO)
        {

            try
            {
                Holiday holiday = new Holiday();
                holiday.HolidayName = holidayDTO.HolidayName;
                holiday.FromDate = holidayDTO.FromDate;
                holiday.ToDate = holidayDTO.ToDate;
                holiday.CreatedBy = holidayDTO.CreatedBy;
                var obj = _holidayRepo.Insert(holiday);
                for (int i = 0; i < holidayDTO.HolidayDays.Count; i++)
                {
                    _holidayDaysService.CreateHolidayDays(new HolidayDaysDTO
                    {
                        Description = holidayDTO.HolidayDays[i].Description,
                        ForDate = holidayDTO.HolidayDays[i].ForDate,
                        HolidayId = obj.HolidayId

                    }, holidayDTO.CreatedBy);
                }
                return MessageEnum.Success;
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
                        var holidayDyas = _holidayDaysService.GetHolidaysByHolidayId(a.HolidayId);

                        var deletedHolidayList = holidayDyas.Where(x => !holidayDTO.HolidayDays.Any(a => a.ForDate == x.ForDate && a.Description == x.Description)).ToList();
                        for (int i = 0; i < deletedHolidayList.Count; i++)
                        {
                            _holidayDaysService.HolidayDaysDelete(deletedHolidayList[i].HolidayDaysId, holidayDTO.CreatedBy);
                        }
                        List<HolidayDays> holidayDaysDTO = new List<HolidayDays>();

                        for (var i = 0; i < holidayDTO.HolidayDays.Count; i++)
                        {
                            HolidayDays holidayDays = new HolidayDays();
                            holidayDays.HolidayId = holidayDaysDTO[i].HolidayId;
                            holidayDays.ForDate = holidayDaysDTO[i].ForDate;
                            holidayDays.Description = holidayDaysDTO[i].Description;
                            holidayDays.Deleted = true;
                            holidayDays.UpdatedBy = holidayDTO.CreatedBy;
                            holidayDaysDTO.Add(holidayDays);
                        }

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

        public Holiday GetHolidayByDates(DateTime startDate, DateTime endDate)
        {
            try
            {
                return _Context.Holidays.Include(a => a.HolidayDays).Where(x => x.Deleted == false && (x.FromDate >= startDate && x.ToDate <= endDate)).FirstOrDefault();
            }
            catch { throw; }
        }
    }
}
