using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Attendance
{
    public class LeaveTypeService : ILeaveTypeService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<LeaveType> _leaveTypeRepo;
        public LeaveTypeService(ApplicationDBContext Context, ISqlRepository<LeaveType> leaveTypeRepo)
        {

            _Context = Context;
            _leaveTypeRepo = leaveTypeRepo;
        }
        public MessageEnum LeaveTypeCreate(LeaveTypeDTO leaveTypeDTO)
        {
            var objCheck = _Context.LeaveTypes.SingleOrDefault(opt => opt.LeaveTypeId == leaveTypeDTO.LeaveTypeId && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    LeaveType leaveType = new LeaveType();
                    leaveType.LeaveTypeName = leaveTypeDTO.LeaveTypeName;
                    leaveType.MaximumLeaveAllocationAllowed = leaveTypeDTO.MaximumLeaveAllocationAllowed;
                    leaveType.ApplicableAfterWorkingDays = leaveTypeDTO.ApplicableAfterWorkingDays;
                    leaveType.MaximumConsecutiveLeavesAllowed = leaveTypeDTO.MaximumConsecutiveLeavesAllowed;
                    leaveType.IsCarryForward = leaveTypeDTO.IsCarryForward;
                    leaveType.MaximumCarryForwardedLeaves = leaveTypeDTO.MaximumCarryForwardedLeaves;
                    leaveType.ExpireCarryForwardedLeaves = leaveTypeDTO.ExpireCarryForwardedLeaves;
                    leaveType.IsLeaveWithoutPay = leaveTypeDTO.IsLeaveWithoutPay;
                    leaveType.IsPartiallyPaidLeave = leaveTypeDTO.IsPartiallyPaidLeave;
                    leaveType.IsOptionalLeave = leaveTypeDTO.IsOptionalLeave;
                    leaveType.AllowNegativeBalance = leaveTypeDTO.AllowNegativeBalance;
                    leaveType.AllowOverAllocation = leaveTypeDTO.AllowOverAllocation;
                    leaveType.IsCompensatory = leaveTypeDTO.IsCompensatory;
                    leaveType.AllowEncashment = leaveTypeDTO.AllowEncashment;
                    leaveType.EncashmentThresholdDays = leaveTypeDTO.EncashmentThresholdDays;
                    leaveType.EarningSalaryComponentId = leaveTypeDTO.EarningSalaryComponentId;
                    leaveType.IsEarnedLeave = leaveTypeDTO.IsEarnedLeave;
                    leaveType.EarnedLeaveFrequency = leaveTypeDTO.EarnedLeaveFrequency;
                    leaveType.BasedOnDateOfJoining = leaveTypeDTO.BasedOnDateOfJoining;
                    leaveType.Rounding = leaveTypeDTO.Rounding;
                    leaveType.CreatedBy = leaveTypeDTO.CreatedBy;
                    var obj = _leaveTypeRepo.Insert(leaveType);

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
        public List<LeaveType> GetLeaveTypeList()
        {
            try
            {
                return _Context.LeaveTypes.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }
        public LeaveType GetLeaveTypeById(Int64 leaveTypeId)
        {
            try
            {
                return _Context.LeaveTypes.Where(x => x.LeaveTypeId == leaveTypeId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }
        public MessageEnum LeaveTypeUpdate(LeaveTypeDTO leaveTypeDTO)
        {
            try
            {
                var leaveType = _Context.LeaveTypes.Where(x => x.LeaveTypeId != leaveTypeDTO.LeaveTypeId && x.LeaveTypeName == leaveTypeDTO.LeaveTypeName && x.Deleted == false).FirstOrDefault();
                if (leaveType == null)
                {
                    var a = _Context.LeaveTypes.Where(x => x.LeaveTypeId == leaveTypeDTO.LeaveTypeId).FirstOrDefault();
                    if (a != null)
                    {
                        a.LeaveTypeName = leaveTypeDTO.LeaveTypeName;                       
                        a.MaximumLeaveAllocationAllowed = leaveTypeDTO.MaximumLeaveAllocationAllowed;                       
                        a.ApplicableAfterWorkingDays = leaveTypeDTO.ApplicableAfterWorkingDays;                       
                        a.MaximumConsecutiveLeavesAllowed = leaveTypeDTO.MaximumConsecutiveLeavesAllowed;                       
                        a.IsCarryForward = leaveTypeDTO.IsCarryForward;                       
                        a.MaximumCarryForwardedLeaves = leaveTypeDTO.MaximumCarryForwardedLeaves;                       
                        a.ExpireCarryForwardedLeaves = leaveTypeDTO.ExpireCarryForwardedLeaves;                       
                        a.IsLeaveWithoutPay = leaveTypeDTO.IsLeaveWithoutPay;                       
                        a.IsPartiallyPaidLeave = leaveTypeDTO.IsPartiallyPaidLeave;                       
                        a.IsOptionalLeave = leaveTypeDTO.IsOptionalLeave;                       
                        a.AllowNegativeBalance = leaveTypeDTO.AllowNegativeBalance;                       
                        a.AllowOverAllocation = leaveTypeDTO.AllowOverAllocation;                       
                        a.IsCompensatory = leaveTypeDTO.IsCompensatory;                       
                        a.AllowEncashment = leaveTypeDTO.AllowEncashment;                       
                        a.EncashmentThresholdDays = leaveTypeDTO.EncashmentThresholdDays;                       
                        a.EarningSalaryComponentId = leaveTypeDTO.EarningSalaryComponentId;                       
                        a.IsEarnedLeave = leaveTypeDTO.IsEarnedLeave;                       
                        a.EarnedLeaveFrequency = leaveTypeDTO.EarnedLeaveFrequency;                       
                        a.BasedOnDateOfJoining = leaveTypeDTO.BasedOnDateOfJoining;                       
                        a.Rounding = leaveTypeDTO.Rounding;
                        a.UpdatedBy = leaveTypeDTO.CreatedBy;
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
        public MessageEnum LeaveTypeDelete(Int64 leaveTypeId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.LeaveTypes.Where(x => x.LeaveTypeId == leaveTypeId).FirstOrDefault();
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

    }
}
