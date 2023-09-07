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
    public interface ILeavePolicyService
    {
        public MessageEnum LeavePolicyCreate(LeavePolicyDTO leavePolicyDTO);
        public List<LeavePolicy>GetLeavePolicies();
        public LeavePolicy GetLeavePolicyByLeavePolicyId(int leavePolicyId);
        public List<LeavePolicy> LeavePolicyByLeavePolicyId(int leavePolicyId);       
        public MessageEnum LeavePolicyUpdate(LeavePolicyDTO leavePolicyDTO);
        public MessageEnum LeavePolicyDelete(int leavePolicyId, Int64 DeletedBy);
    }
}
