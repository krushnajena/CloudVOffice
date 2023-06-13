using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;

namespace CloudVOffice.Services.Attendance
{
	public class ShiftTypeService : IShiftTypeService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<ShiftType> _shiftTypeRepo;
		public ShiftTypeService(ApplicationDBContext Context, ISqlRepository<ShiftType> shiftTypeRepo)
		{

			_Context = Context;
			_shiftTypeRepo = shiftTypeRepo;
		}
        public MessageEnum CreateShiftType(ShiftTypeDTO shiftTypeDTO)
        {         
           var objCheck = _Context.ShiftTypes.SingleOrDefault(opt => opt.ShiftTypeId == shiftTypeDTO.ShiftTypeId && opt.Deleted == false);
           try
           {
               if (objCheck == null)
               {

                   ShiftType shiftType = new ShiftType();
                   shiftType.ShiftTypeName = shiftTypeDTO.ShiftTypeName;
                   shiftType.StartTime = shiftTypeDTO.StartTime;
                   shiftType.EndTime = shiftTypeDTO.EndTime;
                   shiftType.LateEntryGracePeriodInMinutes = shiftTypeDTO.LateEntryGracePeriodInMinutes;
                   shiftType.EarlyExitGracePeriodInMinutes = shiftTypeDTO.EarlyExitGracePeriodInMinutes;
                   shiftType.ThresholdforAbsentInHours = shiftTypeDTO.ThresholdforAbsentInHours;
                   shiftType.ThresholdforHalfDayInHours = shiftTypeDTO.ThresholdforHalfDayInHours;
                   shiftType.CreatedBy = shiftTypeDTO.CreatedBy;
                   var obj = _shiftTypeRepo.Insert(shiftType);

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

        public ShiftType GetShiftTypeById(Int64 shiftTypeId)
		{
			try
			{
				return _Context.ShiftTypes.Where(x => x.ShiftTypeId == shiftTypeId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public List<ShiftType> GetShiftTypeList()
		{
			try
			{
				return _Context.ShiftTypes.Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}

		public MessageEnum ShiftTypeDelete(Int64 shiftTypeId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.ShiftTypes.Where(x => x.ShiftTypeId == shiftTypeId).FirstOrDefault();
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

		public MessageEnum ShiftTypeUpdate(ShiftTypeDTO shiftTypeDTO)
		{
			try
			{
				var shiftType = _Context.ShiftTypes.Where(x => x.ShiftTypeId != shiftTypeDTO.ShiftTypeId && x.ShiftTypeName == shiftTypeDTO.ShiftTypeName && x.Deleted == false).FirstOrDefault();
				if (shiftType == null)
				{
					var a = _Context.ShiftTypes.Where(x => x.ShiftTypeId == shiftTypeDTO.ShiftTypeId).FirstOrDefault();
					if (a != null)
					{
						a.ShiftTypeName = shiftTypeDTO.ShiftTypeName;
						a.StartTime = shiftTypeDTO.StartTime;
						a.EndTime = shiftTypeDTO.EndTime;
						a.LateEntryGracePeriodInMinutes = shiftTypeDTO.LateEntryGracePeriodInMinutes;
						a.EarlyExitGracePeriodInMinutes = shiftTypeDTO.EarlyExitGracePeriodInMinutes;
						a.ThresholdforHalfDayInHours = shiftTypeDTO.ThresholdforHalfDayInHours;
						a.ThresholdforAbsentInHours = shiftTypeDTO.ThresholdforAbsentInHours;
						a.UpdatedBy = shiftTypeDTO.CreatedBy;
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
