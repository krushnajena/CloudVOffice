using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;

using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace CloudVOffice.Services.Recruitment
{
    public class StaffingPlanDetailsService : IStaffingPlanDetailsService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<StaffingPlanDetails> _StaffingPlanDetailsRepo;
        public StaffingPlanDetailsService(ApplicationDBContext Context, ISqlRepository<StaffingPlanDetails> StaffingPlanDetailsRepo)
        {

            _Context = Context;
            _StaffingPlanDetailsRepo = StaffingPlanDetailsRepo;
        }
        public MessageEnum CreateStaffingPlanDetails(StaffingPlanDetailsDTO staffingPlanDetailsDTO)
        {
            var objCheck = _Context.StaffingPlanDetails.SingleOrDefault(opt => opt.StaffingPlanDetailsId == staffingPlanDetailsDTO.StaffingPlanDetailsId && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    StaffingPlanDetails staffingPlanDetails = new StaffingPlanDetails();
                    staffingPlanDetails.DesignationId = staffingPlanDetailsDTO.DesignationId;
                    staffingPlanDetails.NoOfVacancies = staffingPlanDetailsDTO.NoOfVacancies;
                    staffingPlanDetails.EstimatedCostPerPosition = staffingPlanDetailsDTO.EstimatedCostPerPosition;
                    staffingPlanDetails.CreatedBy = staffingPlanDetailsDTO.CreatedBy;
                    var obj = _StaffingPlanDetailsRepo.Insert(staffingPlanDetails);

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

        public List<StaffingPlanDetails> GetStaffingPlanDetailsList()
        {
            try
            {
                return _Context.StaffingPlanDetails.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public StaffingPlanDetails GetStaffingPlanDetailsById(long staffingPlanDetailsId)
        {
            try
            {
                return _Context.StaffingPlanDetails.Where(x => x.StaffingPlanDetailsId == staffingPlanDetailsId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public MessageEnum StaffingPlanDetailsDelete(long staffingPlanDetailsId, long DeletedBy)
        {
            try
            {
                var a = _Context.StaffingPlanDetails.Where(x => x.StaffingPlanDetailsId == staffingPlanDetailsId).FirstOrDefault();
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

        public MessageEnum StaffingPlanDetailsUpdate(StaffingPlanDetailsDTO staffingPlanDetailsDTO)
        {
            try
            {
                var StaffingPlanDetails = _Context.StaffingPlanDetails.Where(x => x.StaffingPlanDetailsId != staffingPlanDetailsDTO.StaffingPlanId && x.Deleted == false).FirstOrDefault();
                if (StaffingPlanDetails == null)
                {
                    var a = _Context.StaffingPlanDetails.Where(x => x.StaffingPlanDetailsId == staffingPlanDetailsDTO.StaffingPlanId).FirstOrDefault();
                    if (a != null)
                    {
                        a.DesignationId = staffingPlanDetailsDTO.DesignationId;
                        a.NoOfVacancies = staffingPlanDetailsDTO.NoOfVacancies;
                        a.EstimatedCostPerPosition = staffingPlanDetailsDTO.EstimatedCostPerPosition;
                        a.UpdatedBy = staffingPlanDetailsDTO.CreatedBy;
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

        public List<StaffingPlanDetails> StaffingPlanDetailsByStaffingPlanId(int StaffingPlanId)
        {
            try
            {
                return _Context.StaffingPlanDetails.Where(X => X.StaffingPlanId == StaffingPlanId && X.Deleted == false).ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
