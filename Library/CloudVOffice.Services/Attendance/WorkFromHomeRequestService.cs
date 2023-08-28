using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace CloudVOffice.Services.Attendance
{
    public class WorkFromHomeRequestService : IWorkFromHomeRequestService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<WorkFromHomeRequest> _workFromHomeRequestRepo;
        public WorkFromHomeRequestService(ApplicationDBContext Context, ISqlRepository<WorkFromHomeRequest> workFromHomeRequestRepo)
        {

            _Context = Context;
            _workFromHomeRequestRepo = workFromHomeRequestRepo;
        }
        public WorkFromHomeRequest GetWorkFromHomeRequestById(Int64 workFromHomeRequestId)
        {
            try
            {
                return _Context.WorkFromHomeRequests.Where(x => x.WorkFromHomeRequestId == workFromHomeRequestId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<WorkFromHomeRequest> GetWorkFromHomeRequestList()
        {
            try
            {
                return _Context.WorkFromHomeRequests.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

       

        public MessageEnum WorkFromHomeRequestCreate(WorkFromHomeRequestDTO workFromHomeRequestDTO)
        {
            var objCheck = _Context.WorkFromHomeRequests.SingleOrDefault(opt => opt.WorkFromHomeRequestId == workFromHomeRequestDTO.WorkFromHomeRequestId && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    WorkFromHomeRequest workFromHomeRequest = new WorkFromHomeRequest();
                    workFromHomeRequest.EmployeeId = workFromHomeRequestDTO.EmployeeId;
                    workFromHomeRequest.FromDate = workFromHomeRequestDTO.FromDate;
                    workFromHomeRequest.ToDate = workFromHomeRequestDTO.ToDate;
                    workFromHomeRequest.Reason = workFromHomeRequestDTO.Reason;
                    workFromHomeRequest.ApprovalStatus = workFromHomeRequestDTO.ApprovalStatus;
                    
                    var obj = _workFromHomeRequestRepo.Insert(workFromHomeRequest);

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

        public MessageEnum WorkFromHomeRequestDelete(Int64 workFromHomeRequestId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.WorkFromHomeRequests.Where(x => x.WorkFromHomeRequestId == workFromHomeRequestId).FirstOrDefault();
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
        public MessageEnum WorkFromHomeRequestUpdate(WorkFromHomeRequestDTO workFromHomeRequestDTO)
        {
            try
            {
                var workFromHomeRequest = _Context.WorkFromHomeRequests.Where(x => x.WorkFromHomeRequestId != workFromHomeRequestDTO.WorkFromHomeRequestId && x.Deleted == false).FirstOrDefault();
                if (workFromHomeRequest == null)
                {
                    var a = _Context.WorkFromHomeRequests.Where(x => x.WorkFromHomeRequestId == workFromHomeRequestDTO.WorkFromHomeRequestId).FirstOrDefault();
                    if (a != null)
                    {
                        a.EmployeeId = workFromHomeRequestDTO.EmployeeId;
                        a.FromDate = workFromHomeRequestDTO.FromDate;
                        a.ToDate = workFromHomeRequestDTO.ToDate;
                        a.Reason = workFromHomeRequestDTO.Reason;
                        a.ApprovalStatus = workFromHomeRequestDTO.ApprovalStatus;
                        a.UpdatedBy = workFromHomeRequestDTO.CreatedBy;
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
        public List<WorkFromHomeRequest> GetWorkFromHomeRequestToValidate(long EmployeeId)
        {
            try
            {
                var workFromHomeRequest = _Context.WorkFromHomeRequests
                                                .Include(x => x.Employee)
                                                .Where(x => x.ApprovalStatus == 0
                                                        && x.Deleted == false
                                                        && x.Employee.ReportingAuthority == EmployeeId)
                                                .ToList();

                return workFromHomeRequest;
            }
            catch
            {
                throw;
            }
        }

        public MessageEnum WorkFromHomeRequestApproved(WorkFromHomeRequestApprovedDTO workFromHomeRequestApprovedDTO)
        {
            try
            {
                var workFromHomeRequest = _Context.WorkFromHomeRequests.Where(x => x.WorkFromHomeRequestId == workFromHomeRequestApprovedDTO.WorkFromHomeRequestId && x.Deleted == false).FirstOrDefault();

                if (workFromHomeRequest != null)
                {

                    workFromHomeRequest.ApprovalStatus = workFromHomeRequestApprovedDTO.ApprovalStatus;
                    workFromHomeRequest.ApprovedBy = workFromHomeRequestApprovedDTO.WorkFromHomeApprovedBy;
                    workFromHomeRequest.UpdatedBy = workFromHomeRequestApprovedDTO.UpdatedBy;
                    workFromHomeRequest.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();

                    return workFromHomeRequestApprovedDTO.ApprovalStatus == 1 ? MessageEnum.Approved : MessageEnum.Rejected;
                   

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
    }
}
