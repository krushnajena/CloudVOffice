using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Customert;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Customert;
using CloudVOffice.Data.DTO.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Recruitment
{
    public interface IStaffingPlanService
    {
        public MessageEnum StaffingPlanCreate(StaffingPlanDTO staffingPlanDTO);
        public List<StaffingPlan> GetStaffingPlans();
        public StaffingPlan GetStaffingPlanByStaffingPlanId(int staffingPlanId);
        public StaffingPlan GetStaffingPlanByPlanName(string planName);
        public MessageEnum StaffingPlanUpdate(StaffingPlanDTO staffingPlanDTO);
        public MessageEnum StaffingPlanDelete(int staffingPlanId, Int64 DeletedBy);
    }
}
