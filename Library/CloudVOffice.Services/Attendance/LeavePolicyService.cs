using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Newtonsoft.Json;
using Pipelines.Sockets.Unofficial.Arenas;

namespace CloudVOffice.Services.Attendance
{
	public class LeavePolicyService : ILeavePolicyService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<LeavePolicy> _leavePolicyRepo;
        private readonly ILeavePolicyDetailsService _leavePolicyDetailsService;
        public LeavePolicyService(ApplicationDBContext Context, ISqlRepository<LeavePolicy> leavePolicyRepo, ILeavePolicyDetailsService leavePolicyDetailsService)
        {

            _Context = Context;
            _leavePolicyRepo = leavePolicyRepo;
            _leavePolicyDetailsService = leavePolicyDetailsService;

		}
        public MessageEnum LeavePolicyCreate(LeavePolicyDTO leavePolicyDTO)
        {
            var objCheck = _Context.LeavePolicies.SingleOrDefault(opt => opt.LeavePolicyId == leavePolicyDTO.LeavePolicyId && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    LeavePolicy leavePolicy = new LeavePolicy();
                    leavePolicy.LeavePeriodId =int.Parse(leavePolicyDTO.LeavePeriodId.ToString());
                    leavePolicy.EmployeeGradeId = int.Parse(leavePolicyDTO.EmployeeGradeId.ToString());
                   
                    leavePolicy.CreatedBy = leavePolicyDTO.CreatedBy;
                    var obj = _leavePolicyRepo.Insert(leavePolicy);
					var leavePolicyDetails = JsonConvert.DeserializeObject<List<LeavePolicyDetailsDTO>>(leavePolicyDTO.LeavePolicyDetailsString);

					for (int i = 0; i < leavePolicyDetails.Count; i++)
					{
						leavePolicyDetails[i].CreatedBy = leavePolicyDTO.CreatedBy;
						leavePolicyDetails[i].LeavePolicyId = obj.LeavePolicyId;

						_leavePolicyDetailsService.LeavePolicyDetailsCreate(leavePolicyDetails[i]);
					}
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
        public List<LeavePolicy> GetLeavePolicies()
        {
            try
            {
                return _Context.LeavePolicies.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public LeavePolicy GetLeavePolicyByLeavePolicyId(int leavePolicyId)
        {
            try
            {
                return _Context.LeavePolicies.Where(x => x.LeavePolicyId == leavePolicyId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }


        public MessageEnum LeavePolicyDelete(int leavePolicyId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.LeavePolicies.Where(x => x.LeavePolicyId == leavePolicyId).FirstOrDefault();
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

        public MessageEnum LeavePolicyUpdate(LeavePolicyDTO leavePolicyDTO)
        {
            try
            {
                var leavePolicy = _Context.LeavePolicies.Where(x => x.LeavePolicyId != leavePolicyDTO.LeavePolicyId && x.Deleted == false).FirstOrDefault();
                if (leavePolicy == null)
                {
                    var a = _Context.LeavePolicies.Where(x => x.LeavePolicyId == leavePolicyDTO.LeavePolicyId).FirstOrDefault();
                    if (a != null)
                    {
                        a.LeavePeriodId = leavePolicyDTO.LeavePeriodId;
                        a.EmployeeGradeId = leavePolicyDTO.EmployeeGradeId;
                        a.UpdatedBy = leavePolicyDTO.CreatedBy;
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

		public List<LeavePolicy> LeavePolicyByLeavePolicyId(int leavePolicyId)
		{
			try
			{
				return _Context.LeavePolicies.Where(x => x.LeavePolicyId == leavePolicyId && x.Deleted == false).ToList();
						
			}
			catch
			{
				throw;
			}
		}
	}

   
}

