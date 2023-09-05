using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;

using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace CloudVOffice.Services.Recruitment
{

    public class StaffingPlanService : IStaffingPlanService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<StaffingPlan> _staffingPlanRepo;
        public StaffingPlanService(ApplicationDBContext Context, ISqlRepository<StaffingPlan> staffingPlanRepo)
        {

            _Context = Context;
            _staffingPlanRepo = staffingPlanRepo;
        }
        public MessageEnum StaffingPlanCreate(StaffingPlanDTO staffingPlanDTO)
        {
            var objCheck = _Context.StaffingPlans.SingleOrDefault(opt => opt.StaffingPlanId == staffingPlanDTO.StaffingPlanId && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    StaffingPlan staffingPlan = new StaffingPlan();
                    staffingPlan.PlanName = staffingPlanDTO.PlanName;
                    staffingPlan.FromDate = staffingPlanDTO.FromDate;
                    staffingPlan.ToDate = staffingPlanDTO.ToDate;
                    staffingPlan.DepartmentId = staffingPlanDTO.DepartmentId;                  
                    staffingPlan.CreatedBy = staffingPlanDTO.CreatedBy;
                    var obj = _staffingPlanRepo.Insert(staffingPlan);

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
        public StaffingPlan GetStaffingPlanByPlanName(string planName)
        {
            try
            {
                return _Context.StaffingPlans.Where(x => x.PlanName == planName && x.Deleted == false).SingleOrDefault();

            }
            catch {
                throw;
            }
        }

        public StaffingPlan GetStaffingPlanByStaffingPlanId(int staffingPlanId)
        {
            try
            {
                return _Context.StaffingPlans.Where(x => x.StaffingPlanId == staffingPlanId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<StaffingPlan> GetStaffingPlans()
        {
            try
            {
                return _Context.StaffingPlans
                    .Include(x => x.Department)
                    .Where(x => x.Deleted == false).ToList();
            }
            catch {
                throw;
            }
        }

       

        public MessageEnum StaffingPlanDelete(int staffingPlanId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.StaffingPlans.Where(x => x.StaffingPlanId == staffingPlanId).FirstOrDefault();
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

        public MessageEnum StaffingPlanUpdate(StaffingPlanDTO staffingPlanDTO)
        {
            try
            {
                var customer = _Context.StaffingPlans.Where(x => x.StaffingPlanId != staffingPlanDTO.StaffingPlanId && x.PlanName == staffingPlanDTO.PlanName && x.Deleted == false).FirstOrDefault();
                if (customer == null)
                {
                    var a = _Context.StaffingPlans.Where(x => x.StaffingPlanId == staffingPlanDTO.StaffingPlanId).FirstOrDefault();
                    if (a != null)
                    {
                        a.PlanName = staffingPlanDTO.PlanName;
                        a.FromDate = staffingPlanDTO.FromDate;
                        a.ToDate = staffingPlanDTO.ToDate;
                        a.DepartmentId = staffingPlanDTO.DepartmentId;
                       
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
