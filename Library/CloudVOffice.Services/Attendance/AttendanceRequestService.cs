using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Services.Emp;
using Microsoft.EntityFrameworkCore;
using StackExchange.Profiling.Internal;

namespace CloudVOffice.Services.Attendance
{
    public class AttendanceRequestService : IAttendanceRequestService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<AttendanceRequest> _attendanceRequestRepo;
        private readonly ISqlRepository<EmployeeCheckIn> _employeeCheckInRepo;
        private readonly IEmployeeAttendanceService _employeeAttendanceService;

        public AttendanceRequestService(ApplicationDBContext Context, ISqlRepository<AttendanceRequest> attendanceRequestRepo, ISqlRepository<EmployeeCheckIn> employeeCheckInRepo, IEmployeeAttendanceService employeeAttendanceService)
        {

            _Context = Context;
            _attendanceRequestRepo = attendanceRequestRepo;
            _employeeCheckInRepo = employeeCheckInRepo;
            _employeeAttendanceService = employeeAttendanceService;


        }

        public MessageEnum AttendanceApproved(AttendanceApprovedDTO attendanceApprovedDTO)
        {
            try
            {
                var attendances = _Context.AttendanceRequests.Where(x => x.AttendanceRequestId == attendanceApprovedDTO.AttendanceRequestId && x.Deleted == false).FirstOrDefault();

                if (attendances != null)
                {

                    attendances.ApprovalStatus = attendanceApprovedDTO.ApprovalStatus;
                    attendances.ApprovalRemarks = attendanceApprovedDTO.ApprovalRemarks;
                    attendances.ApprovedOn = DateTime.Now;
                    attendances.ApprovedBy = attendanceApprovedDTO.AttendanceApprovedBy;
                    attendances.UpdatedBy = attendanceApprovedDTO.UpdatedBy;
                    attendances.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();

                    return attendanceApprovedDTO.ApprovalStatus == 1 ? MessageEnum.Approved : MessageEnum.Rejected;
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

        public MessageEnum AttendanceRequestCreate(AttendanceRequestDTO attendanceRequestDTO)
        {
            var objCheck = _Context.AttendanceRequests.SingleOrDefault(opt => opt.AttendanceRequestId == attendanceRequestDTO.AttendanceRequestId && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    AttendanceRequest attendanceRequest = new AttendanceRequest();
                    attendanceRequest.EmployeeId = attendanceRequestDTO.EmployeeId;
                    attendanceRequest.ForDate = attendanceRequestDTO.ForDate;
                    attendanceRequest.CheckInTime = attendanceRequestDTO.CheckInTime;
                    attendanceRequest.CheckOutTime = attendanceRequestDTO.CheckOutTime;
                    attendanceRequest.ApprovalStatus = attendanceRequestDTO.ApprovalStatus;
                    attendanceRequest.Reason = attendanceRequestDTO.Reason;
                    attendanceRequest.ApprovedBy = attendanceRequestDTO.ApprovedBy;
                    attendanceRequest.ApprovalRemarks = attendanceRequestDTO.ApprovalRemarks;
                    attendanceRequest.ApprovedOn = attendanceRequestDTO.ApprovedOn;
                    attendanceRequest.CreatedBy = attendanceRequestDTO.CreatedBy;
                    var obj = _attendanceRequestRepo.Insert(attendanceRequest);

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
        public MessageEnum AttendanceRequestDelete(Int64 attendanceRequestId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.AttendanceRequests.Where(x => x.AttendanceRequestId == attendanceRequestId).FirstOrDefault();
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

        public MessageEnum AttendanceRequestUpdate(AttendanceRequestDTO attendanceRequestDTO)
        {
            try
            {
                var AttendanceRequest = _Context.AttendanceRequests.Where(x => x.AttendanceRequestId != attendanceRequestDTO.AttendanceRequestId && x.ForDate == attendanceRequestDTO.ForDate && x.Deleted == false).FirstOrDefault();
                if (AttendanceRequest == null)
                {
                    var a = _Context.AttendanceRequests.Where(x => x.AttendanceRequestId == attendanceRequestDTO.AttendanceRequestId).FirstOrDefault();
                    if (a != null)
                    {
                        a.EmployeeId = attendanceRequestDTO.EmployeeId;
                        a.ForDate = attendanceRequestDTO.ForDate;
                        a.CheckInTime = attendanceRequestDTO.CheckInTime;
                        a.CheckOutTime = attendanceRequestDTO.CheckOutTime;
                        a.ApprovalStatus = attendanceRequestDTO.ApprovalStatus;
                        a.Reason = attendanceRequestDTO.Reason;
                        a.ApprovedBy = attendanceRequestDTO.ApprovedBy;
                        a.ApprovalRemarks = attendanceRequestDTO.ApprovalRemarks;
                        a.ApprovedOn = attendanceRequestDTO.ApprovedOn;
                        a.UpdatedBy = attendanceRequestDTO.CreatedBy;
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



        public List<AttendanceRequest> GetAttendanceRequest()
        {
            try
            {
                return _Context.AttendanceRequests.Include(x => x.Employee).Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public AttendanceRequest GetAttendanceRequestById(Int64 attendanceRequestId)
        {
            try
            {
                return _Context.AttendanceRequests.Where(x => x.AttendanceRequestId == attendanceRequestId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<AttendanceRequest> GetAttendanceToValidate(Int64 EmployeeId)
        {
            try
            {
                var attendanceRequests = _Context.AttendanceRequests
                                                .Include(x => x.Employee)
                                                .Where(x => x.ApprovalStatus == 0
                                                        && x.Deleted == false
                                                        && x.Employee.ReportingAuthority == EmployeeId)
                                                .ToList();

                return attendanceRequests;
            }
            catch
            {
                throw;
            }
        }
    }
}