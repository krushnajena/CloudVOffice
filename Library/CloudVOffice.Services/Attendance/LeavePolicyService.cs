using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Migrations;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Data.ViewModel.Attendance;
using CloudVOffice.Data.ViewModel.Projects;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pipelines.Sockets.Unofficial.Arenas;
using System.Transactions;

namespace CloudVOffice.Services.Attendance
{
    public class LeavePolicyService : ILeavePolicyService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<LeavePolicy> _leavePolicyRepo;
        private readonly ILeavePolicyDetailsService _leavePolicyDetailsService;
        private readonly ILeavePeriodService _leavePeriodService;
        public LeavePolicyService(ApplicationDBContext Context, ISqlRepository<LeavePolicy> leavePolicyRepo, ILeavePolicyDetailsService leavePolicyDetailsService, ILeavePeriodService leavePeriodService)
        {

            _Context = Context;
            _leavePolicyRepo = leavePolicyRepo;
            _leavePolicyDetailsService = leavePolicyDetailsService;
            _leavePeriodService = leavePeriodService;
        }
        public MessageEnum LeavePolicyCreate(LeavePolicyDTO leavePolicyDTO)
        {
            var objCheck = _Context.LeavePolicies.SingleOrDefault(opt => opt.EmployeeGradeId == leavePolicyDTO.EmployeeGradeId && opt.LeavePeriodId == leavePolicyDTO.LeavePeriodId && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    LeavePolicy leavePolicy = new LeavePolicy();
                    leavePolicy.LeavePeriodId = int.Parse(leavePolicyDTO.LeavePeriodId.ToString());
                    leavePolicy.EmployeeGradeId = int.Parse(leavePolicyDTO.EmployeeGradeId.ToString());

                    leavePolicy.CreatedBy = leavePolicyDTO.CreatedBy;
                    var obj = _leavePolicyRepo.Insert(leavePolicy);

                    for (int i = 0; i < leavePolicyDTO.LeavePolicyDetails.Count; i++)
                    {
                        leavePolicyDTO.LeavePolicyDetails[i].CreatedBy = leavePolicyDTO.CreatedBy;
                        leavePolicyDTO.LeavePolicyDetails[i].LeavePolicyId = obj.LeavePolicyId;

                        _leavePolicyDetailsService.LeavePolicyDetailsCreate(leavePolicyDTO.LeavePolicyDetails[i]);
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
                return _Context.LeavePolicies
                    .Include(x => x.LeavePeriod)
                    .Include(x => x.EmployeeGrade)
                    .Where(x => x.Deleted == false).ToList();

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

        public List<LeavePolicyDetails> GetLeavePolicyDetailsByLeavePolicyId(int leavePolicyId)
        {
            try
            {
                return _Context.LeavePolicyDetails.Where(x => x.LeavePolicyId == leavePolicyId && x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public List<LeavePolicyReportViewModel> LeavePolicyReport()
        {
            var leavePolicy = GetLeavePolicies();
            List<LeavePolicyReportViewModel> report = new List<LeavePolicyReportViewModel>();


            for (int i = 0; i < leavePolicy.Count; i++)
            {

                LeavePolicyReportViewModel leavePolicyReportViewModel = new LeavePolicyReportViewModel();
                leavePolicyReportViewModel.LeavePolicyId = leavePolicy[i].LeavePolicyId;
                leavePolicyReportViewModel.LeavePeriodName = leavePolicy[i].LeavePeriod.LeavePeriodName.ToString();
                leavePolicyReportViewModel.EmployeeGradeName = leavePolicy[i].EmployeeGrade.EmployeeGradeName.ToString();
                leavePolicyReportViewModel.Leaves = new List<LeavePolicyReportViewModel>();
                var leavePolicyDetails = _leavePolicyDetailsService.GetLeavePolicyDetailsByLeavePolicyId(leavePolicy[i].LeavePolicyId);
                for (int j = 0; j < leavePolicyDetails.Count; j++)
                {
                    LeavePolicyReportViewModel leavePolicyReportViewModel1 = new LeavePolicyReportViewModel();

                    leavePolicyReportViewModel1.LeaveTypeName = leavePolicyDetails[j].LeaveType.LeaveTypeName.ToString();


                    leavePolicyReportViewModel1.AllocationMode = leavePolicyDetails[j].AllocationMode;
                    leavePolicyReportViewModel1.NoOfLeaves = leavePolicyDetails[j].NoOfLeaves;
                    leavePolicyReportViewModel.Leaves.Add(leavePolicyReportViewModel1);
                }

                report.Add(leavePolicyReportViewModel);

            }
            return report;
        }

        public MessageEnum LeavePolicyDelete(int leavePolicyId, Int64 DeletedBy)
        {

        	try
        	{
               

                var leavePolicy = _Context.LeavePolicies
        			.Include(x => x.LeavePolicyDetails)
        			.FirstOrDefault(x => x.LeavePolicyId == leavePolicyId);

        		if (leavePolicy != null)
        		{
        			leavePolicy.Deleted = true;
        			leavePolicy.UpdatedBy = DeletedBy;
        			leavePolicy.UpdatedDate = DateTime.Now;

        			foreach (var leavePolicyDetail in leavePolicy.LeavePolicyDetails)
        			{
        				leavePolicyDetail.Deleted = true;
        				leavePolicyDetail.UpdatedBy = DeletedBy;
        				leavePolicyDetail.UpdatedDate = DateTime.Now;
        			}

        			_Context.SaveChanges();
        			return MessageEnum.Deleted;
        		}
        		else
        		{
        			return MessageEnum.Invalid;
        		}
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
               
                var leavePolicy = _Context.LeavePolicies
                    .Include(x => x.LeavePolicyDetails)
                    .Where(x => x.LeavePolicyId == leavePolicyDTO.LeavePolicyId && x.Deleted == false).FirstOrDefault();

                if (leavePolicy != null)
                {

                    leavePolicy.LeavePeriodId = leavePolicyDTO.LeavePeriodId;
                    leavePolicy.EmployeeGradeId = leavePolicyDTO.EmployeeGradeId;
                    leavePolicy.UpdatedBy = leavePolicyDTO.CreatedBy;
                    leavePolicy.UpdatedDate = DateTime.Now;
                }
                else
                {
                    return MessageEnum.Invalid;

                }

               

                if (leavePolicyDTO.LeavePolicyDetails != null)
                {
                    foreach (var detailsDTO in leavePolicyDTO.LeavePolicyDetails)
                    {
                        var leavePolicyDetail = leavePolicy.LeavePolicyDetails
                            .Where(d => d.LeavePolicyId == detailsDTO.LeavePolicyId).FirstOrDefault();

                        if (leavePolicyDetail != null)
                        {
                           
                            leavePolicyDetail.LeaveTypeId = detailsDTO.LeaveTypeId;
                            leavePolicyDetail.AllocationMode = detailsDTO.AllocationMode;
                            leavePolicyDetail.NoOfLeaves = detailsDTO.NoOfLeaves;
                            leavePolicyDetail.UpdatedBy = detailsDTO.CreatedBy;
                            leavePolicyDetail.UpdatedDate = DateTime.Now;
                        }
                        else
                        {
                            return MessageEnum.Invalid;
                        }
                    }
                }

               
                _Context.SaveChanges();

                return MessageEnum.Updated;
            }
            catch
            {
               
                throw;
            }
        }

    }
}



