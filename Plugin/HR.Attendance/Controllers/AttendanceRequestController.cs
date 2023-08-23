using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Services.Emp;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HR.Attendance.Controllers
{
    [Area(AreaNames.Attendance)]
    public class AttendanceRequestController : BasePluginController
    {
        private readonly IAttendanceRequestService _attendanceRequestService;
        private readonly IEmployeeService _employeeService;
        public AttendanceRequestController(IAttendanceRequestService attendanceRequestService, IEmployeeService employeeService)
        {

            _attendanceRequestService = attendanceRequestService;
            _employeeService = employeeService;
        }
        [HttpGet]
        public IActionResult AttendanceRequestCreate(int? AttendanceRequestId)
        {
            AttendanceRequestDTO attendanceRequestDTO = new AttendanceRequestDTO();


            var employees = _employeeService.GetEmployees();
            ViewBag.Employees = employees;

            if (AttendanceRequestId != null)
            {

                AttendanceRequest d = _attendanceRequestService.GetAttendanceRequestById(int.Parse(AttendanceRequestId.ToString()));

                attendanceRequestDTO.EmployeeId = d.EmployeeId;
                attendanceRequestDTO.ForDate = d.ForDate;
                attendanceRequestDTO.CheckInTime = d.CheckInTime;
                attendanceRequestDTO.CheckOutTime = d.CheckOutTime;
                attendanceRequestDTO.ApprovalStatus = d.ApprovalStatus;
                attendanceRequestDTO.Reason = d.Reason;
                attendanceRequestDTO.ApprovedBy = d.ApprovedBy;
                attendanceRequestDTO.ApprovedOn = d.ApprovedOn;
                attendanceRequestDTO.ApprovalRemarks = d.ApprovalRemarks;


            }

            return View("~/Plugins/HR.Attendance/Views/AttendanceRequest/AttendanceRequestCreate.cshtml", attendanceRequestDTO);


        }
        [HttpPost]

        public IActionResult AttendanceRequestCreate(AttendanceRequestDTO attendanceRequestDTO)
        {
            attendanceRequestDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (attendanceRequestDTO.AttendanceRequestId == null)
                {
                    var a = _attendanceRequestService.AttendanceRequestCreate(attendanceRequestDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Attendance/AttendanceRequest/AttendanceRequestView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "AttendanceRequest Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _attendanceRequestService.AttendanceRequestUpdate(attendanceRequestDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Attendance/AttendanceRequest/AttendanceRequestView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "AttendanceRequest Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }

            var employees = _employeeService.GetEmployees();
            ViewBag.Employees = employees;

            return View("~/Plugins/HR.Attendance/Views/AttendanceRequest/AttendanceRequestCreate.cshtml", attendanceRequestDTO);

        }
        public IActionResult AttendanceRequestView()
        {
            ViewBag.AttendanceRequest = _attendanceRequestService.GetAttendanceRequest();

            return View("~/Plugins/HR.Attendance/Views/AttendanceRequest/AttendanceRequestView.cshtml");
        }
        [HttpGet]
        public IActionResult AttendanceRequestDelete(int attendanceRequestId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _attendanceRequestService.AttendanceRequestDelete(attendanceRequestId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Attendance/AttendanceRequest/AttendanceRequestView");
        }
       
        [HttpPost]
        public IActionResult AttendanceApproved(AttendanceApprovedDTO attendanceApprovedDTO)
        {
            Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _employeeService.GetEmployeeDetailsByUserId(UserId);
            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;
            }
            else
            {
                EmployeeId = 0;
            }

            attendanceApprovedDTO.AttendanceApprovedBy = EmployeeId;
            attendanceApprovedDTO.UpdatedBy = UserId;
            var a = _attendanceRequestService.AttendanceApproved(attendanceApprovedDTO);
            return Ok(a);
        }

        public IActionResult AttendanceToValidate()
        {
            Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _employeeService.GetEmployeeDetailsByUserId(UserId);
            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;
            }
            else
            {
                EmployeeId = 0;
            }
            var attendance = _attendanceRequestService.GetAttendanceToValidate(EmployeeId);
            var data = from u in attendance
                       select new
                       {
                           AttendanceRequestId = u.AttendanceRequestId,
                           EmployeeName = u.Employee.FullName,
                           AttendanceDate = u.ForDate,
                           CheckInTime = u.CheckInTime,
                           CheckOutTime = u.CheckOutTime,
                           Reason = u.Reason,
                       };
            ViewBag.ToValidates = data;

            return View("~/Plugins/HR.Attendance/Views/AttendanceRequest/AttendanceToValidate.cshtml");
        }
       

        

        
            Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _employeeService.GetEmployeeDetailsByUserId(UserId);
            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;
            }
            else
            {
                EmployeeId = 0;
            }

            attendanceApprovedDTO.AttendanceApprovedBy = EmployeeId;
            attendanceApprovedDTO.UpdatedBy = UserId;
            var a = _attendanceRequestService.AttendanceApproved(attendanceApprovedDTO);
            return Ok(a);
        }

        public IActionResult AttendanceToValidate()
        {
            Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _employeeService.GetEmployeeDetailsByUserId(UserId);
            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;
            }
            else
            {
                EmployeeId = 0;
            }
            var attendance = _attendanceRequestService.GetAttendanceToValidate(EmployeeId);
            var data = from u in attendance
                       select new
                       {
                           AttendanceRequestId = u.AttendanceRequestId,
                           EmployeeName = u.Employee.FullName,
                           AttendanceDate = u.ForDate,
                           CheckInTime = u.CheckInTime,
                           CheckOutTime = u.CheckOutTime,
                           Reason = u.Reason,
                       };
            ViewBag.ToValidates = data;

            return View("~/Plugins/HR.Attendance/Views/AttendanceRequest/AttendanceToValidate.cshtml");
        }
            Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _employeeService.GetEmployeeDetailsByUserId(UserId);
            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;
            }
            else
            {
                EmployeeId = 0;
            }

            attendanceApprovedDTO.AttendanceApprovedBy = EmployeeId;
            attendanceApprovedDTO.UpdatedBy = UserId;
            var a = _attendanceRequestService.AttendanceApproved(attendanceApprovedDTO);
            return Ok(a);
        }

        public IActionResult AttendanceToValidate()
        {
            Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _employeeService.GetEmployeeDetailsByUserId(UserId);
            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;
            }
            else
            {
                EmployeeId = 0;
            }
            var attendance = _attendanceRequestService.GetAttendanceToValidate(EmployeeId);
            var data = from u in attendance
                       select new
                       {
                           AttendanceRequestId = u.AttendanceRequestId,
                           EmployeeName = u.Employee.FullName,
                           AttendanceDate = u.ForDate,
                           CheckInTime = u.CheckInTime,
                           CheckOutTime = u.CheckOutTime,
                           Reason = u.Reason,
                       };
            ViewBag.ToValidates = data;

            return View("~/Plugins/HR.Attendance/Views/AttendanceRequest/AttendanceToValidate.cshtml");
        }
            Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _employeeService.GetEmployeeDetailsByUserId(UserId);
            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;
            }
            else
            {
                EmployeeId = 0;
            }

            attendanceApprovedDTO.AttendanceApprovedBy = EmployeeId;
            attendanceApprovedDTO.UpdatedBy = UserId;
            var a = _attendanceRequestService.AttendanceApproved(attendanceApprovedDTO);
            return Ok(a);
        }

        public IActionResult AttendanceToValidate()
        {
            Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _employeeService.GetEmployeeDetailsByUserId(UserId);
            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;
            }
            else
            {
                EmployeeId = 0;
            }
            var attendance = _attendanceRequestService.GetAttendanceToValidate(EmployeeId);
            var data = from u in attendance
                       select new
                       {
                           AttendanceRequestId = u.AttendanceRequestId,
                           EmployeeName = u.Employee.FullName,
                           AttendanceDate = u.ForDate,
                           CheckInTime = u.CheckInTime,
                           CheckOutTime = u.CheckOutTime,
                           Reason = u.Reason,
                       };
            ViewBag.ToValidates = data;

            return View("~/Plugins/HR.Attendance/Views/AttendanceRequest/AttendanceToValidate.cshtml");
        }
            Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _employeeService.GetEmployeeDetailsByUserId(UserId);
            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;
            }
            else
            {
                EmployeeId = 0;
            }

            attendanceApprovedDTO.AttendanceApprovedBy = EmployeeId;
            attendanceApprovedDTO.UpdatedBy = UserId;
            var a = _attendanceRequestService.AttendanceApproved(attendanceApprovedDTO);
            return Ok(a);
        }

        public IActionResult AttendanceToValidate()
        {
            Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _employeeService.GetEmployeeDetailsByUserId(UserId);
            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;
            }
            else
            {
                EmployeeId = 0;
            }
            var attendance = _attendanceRequestService.GetAttendanceToValidate(EmployeeId);
            var data = from u in attendance
                       select new
                       {
                           AttendanceRequestId = u.AttendanceRequestId,
                           EmployeeName = u.Employee.FullName,
                           AttendanceDate = u.ForDate,
                           CheckInTime = u.CheckInTime,
                           CheckOutTime = u.CheckOutTime,
                           Reason = u.Reason,
                       };
            ViewBag.ToValidates = data;

            return View("~/Plugins/HR.Attendance/Views/AttendanceRequest/AttendanceToValidate.cshtml");
        }
            Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _employeeService.GetEmployeeDetailsByUserId(UserId);
            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;
            }
            else
            {
                EmployeeId = 0;
            }

            attendanceApprovedDTO.AttendanceApprovedBy = EmployeeId;
            attendanceApprovedDTO.UpdatedBy = UserId;
            var a = _attendanceRequestService.AttendanceApproved(attendanceApprovedDTO);
            return Ok(a);
        }

        public IActionResult AttendanceToValidate()
        {
            Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _employeeService.GetEmployeeDetailsByUserId(UserId);
            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;
            }
            else
            {
                EmployeeId = 0;
            }
            var attendance = _attendanceRequestService.GetAttendanceToValidate(EmployeeId);
            var data = from u in attendance
                       select new
                       {
                           AttendanceRequestId = u.AttendanceRequestId,
                           EmployeeName = u.Employee.FullName,
                           AttendanceDate = u.ForDate,
                           CheckInTime = u.CheckInTime,
                           CheckOutTime = u.CheckOutTime,
                           Reason = u.Reason,
                       };
            ViewBag.ToValidates = data;

            return View("~/Plugins/HR.Attendance/Views/AttendanceRequest/AttendanceToValidate.cshtml");
        }
    }

}
