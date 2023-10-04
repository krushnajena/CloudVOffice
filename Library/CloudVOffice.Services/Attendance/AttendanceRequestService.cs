using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Services.Emp;
using LinqToDB;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Math.EC.Rfc7748;

namespace CloudVOffice.Services.Attendance
{
    public class AttendanceRequestService : IAttendanceRequestService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<AttendanceRequest> _attendanceRequestRepo;
        private readonly ISqlRepository<EmployeeCheckIn> _employeeCheckInRepo;
        private readonly IEmployeeAttendanceService _employeeAttendanceService;
        private readonly IEmployeeCheckInService _employeeCheckInService;

        public AttendanceRequestService(ApplicationDBContext Context, ISqlRepository<AttendanceRequest> attendanceRequestRepo, ISqlRepository<EmployeeCheckIn> employeeCheckInRepo, IEmployeeAttendanceService employeeAttendanceService , IEmployeeCheckInService employeeCheckInService)
        {

            _Context = Context;
            _attendanceRequestRepo = attendanceRequestRepo;
            _employeeAttendanceService = employeeAttendanceService;
            _employeeCheckInRepo = employeeCheckInRepo;
            _employeeCheckInService = employeeCheckInService;
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
                var AttendanceRequest = _Context.AttendanceRequests.Where(x => x.AttendanceRequestId != attendanceRequestDTO.AttendanceRequestId && x.Deleted == false).FirstOrDefault();
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

                    var a = attendanceApprovedDTO.ApprovalStatus == 1 ? MessageEnum.Approved : MessageEnum.Rejected;
                    if (attendanceApprovedDTO.ApprovalStatus == 1)
                    {
                        var b = _employeeAttendanceService.GetEmployeeAttendanceUpdate(attendances.EmployeeId, DateTime.Parse(attendances.ForDate.ToString()), attendances.CheckInTime, attendances.CheckOutTime);
                        
                        var c = _employeeCheckInService.GetEmployeeCheckInUpdate(attendances.EmployeeId, DateTime.Parse(attendances.ForDate.ToString()), attendances.CheckInTime, attendances.CheckOutTime);
                        var d = _employeeCheckInService.GetEmployeeCheckInUpdate(attendances.EmployeeId, DateTime.Parse(attendances.ForDate.ToString()),attendances.CheckInTime,attendances.CheckOutTime);

                        return b;
                        
                    }
                    return a;
                   
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
        public List<AttendanceRequest> GetAttendanceToValidate(Int64 EmployeeId)
        {
            try
            {
                var attendanceRequest = _Context.AttendanceRequests
                                                .Include(x => x.Employee)
                                                .Where(x => x.ApprovalStatus == 0
                                                        && x.Deleted == false
                                                        && x.Employee.ReportingAuthority == EmployeeId)
                                                .ToList();

                return attendanceRequest;
            }
            catch
            {
                throw;
            }
        }

        public List<AttendanceRequest> GetAttendanceRequests(Int64 EmployeeId)
        {
            try
            {
                var attendance = _Context.AttendanceRequests.Where(x => x.EmployeeId ==  EmployeeId).ToList();
                return attendance;
            }
            catch
            {
                throw;
            }
        }
    }

    }

