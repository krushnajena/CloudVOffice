using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;

namespace CloudVOffice.Services.Attendance
{
    public class EmployeeAttendanceService : IEmployeeAttendanceService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<EmployeeAttendance> _employeeAttendanceRepo;
        public EmployeeAttendanceService(ApplicationDBContext Context, ISqlRepository<EmployeeAttendance> employeeAttendanceRepo)
        {

            _Context = Context;
            _employeeAttendanceRepo = employeeAttendanceRepo;
        }
        public MessageEnum CreateEmployeeAttendance(EmployeeAttendanceDTO employeeAttendanceDTO)
        {
            var objCheck = _Context.EmployeeAttendances.SingleOrDefault(opt => opt.EmployeeAttendanceId == employeeAttendanceDTO.EmployeeAttendanceId && opt.Deleted == false);
            try
            {
                if (objCheck == null)
                {

                    EmployeeAttendance employeeAttendance = new EmployeeAttendance();
                    employeeAttendance.EmployeeId = employeeAttendanceDTO.EmployeeId;
                    employeeAttendance.AttendanceDate = employeeAttendanceDTO.AttendanceDate;
                    employeeAttendance.Status = employeeAttendanceDTO.Status;
                    employeeAttendance.IsLateEntry = employeeAttendanceDTO.IsLateEntry;
                    employeeAttendance.IsEarlyExit = employeeAttendanceDTO.IsEarlyExit;
                    employeeAttendance.CreatedBy = employeeAttendanceDTO.CreatedBy;
                    var obj = _employeeAttendanceRepo.Insert(employeeAttendance);

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

        public MessageEnum EmployeeAttendanceDelete(Int64 employeeAttendanceId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.EmployeeAttendances.Where(x => x.EmployeeAttendanceId == employeeAttendanceId).FirstOrDefault();
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

        public MessageEnum EmployeeAttendanceUpdate(EmployeeAttendanceDTO employeeAttendanceDTO)
        {
            try
            {
                var EmployeeAttendance = _Context.EmployeeAttendances.Where(x => x.EmployeeAttendanceId != employeeAttendanceDTO.EmployeeAttendanceId && x.AttendanceDate == employeeAttendanceDTO.AttendanceDate && x.Deleted == false).FirstOrDefault();
                if (EmployeeAttendance == null)
                {
                    var a = _Context.EmployeeAttendances.Where(x => x.EmployeeAttendanceId == employeeAttendanceDTO.EmployeeAttendanceId).FirstOrDefault();
                    if (a != null)
                    {
                        a.EmployeeId = employeeAttendanceDTO.EmployeeId;
                        a.AttendanceDate = employeeAttendanceDTO.AttendanceDate;
                        a.Status = employeeAttendanceDTO.Status;
                        a.IsLateEntry = employeeAttendanceDTO.IsLateEntry;
                        a.IsEarlyExit = employeeAttendanceDTO.IsEarlyExit;

                        a.UpdatedBy = employeeAttendanceDTO.CreatedBy;
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

        public EmployeeAttendance GetEmployeeAttendanceById(Int64 employeeAttendanceId)
        {
            try
            {
                return _Context.EmployeeAttendances.Where(x => x.EmployeeAttendanceId == employeeAttendanceId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<EmployeeAttendance> GetEmployeeAttendanceList()
        {
            try
            {
                return _Context.EmployeeAttendances.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }
    }
}
