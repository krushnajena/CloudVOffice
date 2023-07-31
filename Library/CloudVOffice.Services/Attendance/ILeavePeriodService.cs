using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;

namespace CloudVOffice.Services.Attendance
{
    public interface ILeavePeriodService
    {
        public MessageEnum CreateLeavePeriod(LeavePeriodDTO leavePeriodDTO);
        public List<LeavePeriod> GetLeavePeriodList();
        public LeavePeriod GetLeavePeriodById(int leavePeriodId);
        public MessageEnum LeavePeriodUpdate(LeavePeriodDTO leavePeriodDTO);
        public MessageEnum LeavePeriodDelete(int leavePeriodId, int DeletedBy);
    }
}
