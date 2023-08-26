using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Attendance;

namespace CloudVOffice.Services.Attendance
{
    public interface ILeaveTypeService
    {
        public MessageEnum LeaveTypeCreate(LeaveTypeDTO leaveTypeDTO);
        public List<LeaveType> GetLeaveTypeList();
        public LeaveType GetLeaveTypeById(Int64 leaveTypeId);
        public MessageEnum LeaveTypeUpdate(LeaveTypeDTO leaveTypeDTO);
        public MessageEnum LeaveTypeDelete(Int64 leaveTypeId, Int64 DeletedBy);
        public List<LeaveType> GetLeaveTypesByAllowEncashment(bool allowEncashment);
    }
}
