using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;

namespace CloudVOffice.Services.Attendance
{
    public interface IShiftTypeService
    {
        public MessageEnum CreateShiftType(ShiftTypeDTO shiftTypeDTO);
        public List<ShiftType> GetShiftTypeList();
        public ShiftType GetShiftTypeById(Int64 shiftTypeId);
        public MessageEnum ShiftTypeUpdate(ShiftTypeDTO shiftTypeDTO);
        public MessageEnum ShiftTypeDelete(Int64 shiftTypeId, Int64 DeletedBy);
        public ShiftType GetDefaultShiftType();
    }
}
