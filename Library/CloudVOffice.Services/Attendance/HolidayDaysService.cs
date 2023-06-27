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
	public class HolidayDaysService : IHolidayDaysService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<HolidayDays> _holidayDaysRepo;
		public HolidayDaysService(ApplicationDBContext Context, ISqlRepository<HolidayDays> holidayDaysRepo)
		{

			_Context = Context;
			_holidayDaysRepo = holidayDaysRepo;
		}
		public MessageEnum CreateHolidayDays(HolidayDaysDTO holidayDaysDTO)
		{

			var objCheck = _Context.HolidayDays.SingleOrDefault(opt => opt.HolidayDaysId == holidayDaysDTO.HolidayDaysId && opt.Deleted == false);
			try
			{
				if (objCheck == null)
				{

					HolidayDays holidayDays = new HolidayDays();
					holidayDays.HolidayId = holidayDaysDTO.HolidayId;
					holidayDays.ForDate = holidayDaysDTO.ForDate;
					holidayDays.Description = holidayDaysDTO.Description;
					holidayDays.CreatedBy = holidayDaysDTO.CreatedBy;
					var obj = _holidayDaysRepo.Insert(holidayDays);

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

		public HolidayDays GetHolidayDaysById(Int64 HolidayDaysId)
		{
			try
			{
				return _Context.HolidayDays.Where(x => x.HolidayDaysId == HolidayDaysId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public List<HolidayDays> GetHolidayDaysList()
		{
			try
			{
				return _Context.HolidayDays.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

		public MessageEnum HolidayDaysDelete(Int64 HolidayDaysId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.HolidayDays.Where(x => x.HolidayDaysId == HolidayDaysId).FirstOrDefault();
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

		public MessageEnum HolidayDaysUpdate(HolidayDaysDTO holidayDaysDTO)
		{
			try
			{
                var holidayDays = _Context.HolidayDays.Where(x => x.HolidayDaysId != holidayDaysDTO.HolidayDaysId && x.Deleted == false).FirstOrDefault();
				if (holidayDays == null)
				{
					var a = _Context.HolidayDays.Where(x => x.HolidayDaysId == holidayDaysDTO.HolidayDaysId).FirstOrDefault();
					if (a != null)
					{
						a.HolidayId = holidayDaysDTO.HolidayId;
						a.ForDate = holidayDaysDTO.ForDate;
						a.Description = holidayDaysDTO.Description;
					
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
	}
}
