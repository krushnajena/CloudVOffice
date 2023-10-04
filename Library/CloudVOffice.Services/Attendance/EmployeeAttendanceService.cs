using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace CloudVOffice.Services.Attendance
{
    public class EmployeeAttendanceService : IEmployeeAttendanceService
	{
		private readonly ApplicationDBContext _Context;
		private readonly ISqlRepository<EmployeeAttendance> _employeeAttendanceRepo;
		private readonly IShiftEmployeeService _shiftEmployeeService;
        private readonly IShiftTypeService _shiftTypeService;
		public EmployeeAttendanceService(ApplicationDBContext Context, ISqlRepository<EmployeeAttendance> employeeAttendanceRepo, IShiftEmployeeService shiftEmployeeService,IShiftTypeService shiftTypeService)
		{

			_Context = Context;
			_employeeAttendanceRepo = employeeAttendanceRepo;
            _shiftEmployeeService = shiftEmployeeService;
            _shiftTypeService = shiftTypeService;
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
                return _Context.EmployeeAttendances
                    .Include(s => s.Employee)
                    .Where(x => x.Deleted == false).ToList();

			}
			catch
			{
				throw;
			}
		}
        public MessageEnum GetEmployeeAttendanceUpdate(Int64 EmployeeId, DateTime AttendanceDate, TimeSpan CheckInTime, TimeSpan CheckOutTime)
        {
            try
            {
                var a = _Context.EmployeeAttendances.Where(x => x.EmployeeId == EmployeeId && x.AttendanceDate == AttendanceDate).FirstOrDefault();
                var eshift = _shiftEmployeeService.GetShiftByEmployeeId(EmployeeId, AttendanceDate);
                bool isLateEntry = false;
                bool isEarlyExit = false;
                ShiftType shift;
                if (eshift != null)
                {
                    shift = eshift.ShiftType;
                }
                else
                {
                    shift = _shiftTypeService.GetDefaultShiftType();
                }
                if (shift != null)
                {
                    string graceMints="00:00";
                    if (shift.LateEntryGracePeriodInMinutes != null)
                    {
                        if (shift.LateEntryGracePeriodInMinutes > 60)
                        {
                            int? hour = shift.LateEntryGracePeriodInMinutes / 60;
                            int? mints = shift.LateEntryGracePeriodInMinutes % 60;
                            graceMints = hour.ToString() + ":" + mints.ToString();
                        }
                        else
                        {
                            graceMints = "00:"+shift.LateEntryGracePeriodInMinutes.ToString();
                        }

                    }
                    else
                    {
                        graceMints = "00:00:00";
                    }
                   if(shift.StartTime.Value.Add(TimeSpan.Parse(graceMints)) < CheckInTime){
                        isLateEntry = true;
                    }
                    else
                    {
                        isLateEntry = false;
                    }


                    if (shift.EarlyExitGracePeriodInMinutes != null)
                    {


                        if (shift.EarlyExitGracePeriodInMinutes > 60)
                        {
                            int? hour = shift.EarlyExitGracePeriodInMinutes / 60;
                            int? mints = shift.EarlyExitGracePeriodInMinutes % 60;
                            graceMints = hour.ToString() + ":" + mints.ToString();
                        }
                        else
                        {
                            graceMints = "00:" + shift.EarlyExitGracePeriodInMinutes.ToString();
                        }

                    }
                    else
                    {
                        graceMints = "00:00:00";
                    }


                    if (shift.StartTime.Value.Subtract(TimeSpan.Parse(graceMints)) > CheckOutTime)
                    {
                        isEarlyExit = true;
                    }
                    else
                    {
                        isEarlyExit = false;
                    }


                }

                if (a == null)
                {
                    EmployeeAttendance employeeAttendance = new EmployeeAttendance();
                    employeeAttendance.EmployeeId = EmployeeId;
                    employeeAttendance.AttendanceDate = AttendanceDate;
                    employeeAttendance.Status = 1;
                    employeeAttendance.IsEarlyExit = isEarlyExit;
                    employeeAttendance.IsLateEntry = isLateEntry;
                    var obj = _employeeAttendanceRepo.Insert(employeeAttendance);
                    return MessageEnum.Success;
                }
                else if (a != null)
                {
                                  
                    a.UpdatedDate = DateTime.Now;
                    a.Status = 1;
                    a.IsEarlyExit = isEarlyExit;
                    a.IsLateEntry = isLateEntry;
                    _Context.SaveChanges();
                    return MessageEnum.Updated;
                }
                return MessageEnum.Invalid;

            }
            catch
            {
                throw;
            }
        }

    }
}
