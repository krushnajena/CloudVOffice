using CloudVOffice.Core.Domain.Common;

using CloudVOffice.Core.Domain.Recruitment;

using CloudVOffice.Data.DTO.Recruitment;

namespace CloudVOffice.Services.Recruitment
{
    public interface IStaffingPlanDetailsService
    {
        public MessageEnum CreateStaffingPlanDetails(StaffingPlanDetailsDTO staffingPlanDetailsDTO);
        public List<StaffingPlanDetails> GetStaffingPlanDetailsList();
        public StaffingPlanDetails GetStaffingPlanDetailsById(Int64 staffingPlanDetailsId);
        public MessageEnum StaffingPlanDetailsUpdate(StaffingPlanDetailsDTO staffingPlanDetailsDTO);
        public MessageEnum StaffingPlanDetailsDelete(Int64 staffingPlanDetailsId, Int64 DeletedBy);
        public List<StaffingPlanDetails> StaffingPlanDetailsByStaffingPlanId(int StaffingPlanId);
    }
}
