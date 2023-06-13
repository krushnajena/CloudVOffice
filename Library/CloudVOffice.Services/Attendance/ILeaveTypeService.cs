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
    public interface ILeaveTypeService
    {
        public MessageEnum LeaveTypeCreate(LeaveTypeDTO leaveTypeDTO);
        public List<LeaveType> GetLeaveTypeList();
        public LeaveType GetLeaveTypeById(Int64 leaveTypeId);
        public MessageEnum LeaveTypeUpdate(LeaveTypeDTO leaveTypeDTO);
        public MessageEnum LeaveTypeDelete(Int64 leaveTypeId, Int64 DeletedBy);
    }
}
