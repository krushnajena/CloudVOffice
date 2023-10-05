using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Services.Emp;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HR.Attendance.Controllers
{
	[Area(AreaNames.Attendance)]
	public class EmployeeAttendanceController : BasePluginController
	{
		private readonly IEmployeeAttendanceService _employeeAttendanceService;
		private readonly IEmployeeService _employeeService;
		private readonly IEmployeeCheckInService _employeeCheckInService;
		public EmployeeAttendanceController(IEmployeeAttendanceService employeeAttendanceService, IEmployeeService employeeService , IEmployeeCheckInService employeeCheckInService)
		{

			_employeeAttendanceService = employeeAttendanceService;
			_employeeService = employeeService;
            _employeeCheckInService = employeeCheckInService;

        }

        [HttpGet]
        public IActionResult CreateEmployeeAttendance(int? EmployeeAttendanceId)
        {
            EmployeeAttendanceDTO employeeAttendanceDTO = new EmployeeAttendanceDTO();


            var employees = _employeeService.GetEmployees();
            ViewBag.Employees = employees;

            if (EmployeeAttendanceId != null)
            {

                var d = _employeeAttendanceService.GetEmployeeAttendanceById(int.Parse(EmployeeAttendanceId.ToString()));

                employeeAttendanceDTO.EmployeeAttendanceId = d.EmployeeAttendanceId;
                employeeAttendanceDTO.AttendanceDate = d.AttendanceDate;
                employeeAttendanceDTO.Status = d.Status;
                employeeAttendanceDTO.IsLateEntry = d.IsLateEntry;
                employeeAttendanceDTO.IsEarlyExit = d.IsEarlyExit;


            }

            return View("~/Plugins/HR.Attendance/Views/EmployeeAttendance/CreateEmployeeAttendance.cshtml", employeeAttendanceDTO);


        }


        [HttpPost]

        public IActionResult CreateEmployeeAttendance(EmployeeAttendanceDTO employeeAttendanceDTO)
        {
            employeeAttendanceDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (employeeAttendanceDTO.EmployeeAttendanceId == null)
                {
                    var a = _employeeAttendanceService.CreateEmployeeAttendance(employeeAttendanceDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Attendance/EmployeeAttendance/EmployeeAttendanceView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "EmployeeAttendance Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _employeeAttendanceService.EmployeeAttendanceUpdate(employeeAttendanceDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Attendance/EmployeeAttendance/EmployeeAttendanceView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "EmployeeAttendance Already Exists");
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

            return View("~/Plugins/HR.Attendance/Views/EmployeeAttendance/CreateEmployeeAttendance.cshtml", employeeAttendanceDTO);
        }
        [Authorize(Roles = "HR Manager , Employee")]
        public IActionResult EmployeeAttendanceView()
        {
            ViewBag.employeeAttendance = _employeeAttendanceService.GetEmployeeAttendanceList();

            return View("~/Plugins/HR.Attendance/Views/EmployeeAttendance/EmployeeAttendanceView.cshtml");
        }
        [HttpGet]
        public IActionResult EmployeeAttendanceDelete(int employeeAttendanceId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _employeeAttendanceService.EmployeeAttendanceDelete(employeeAttendanceId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Attendance/EmployeeAttendance/EmployeeAttendanceView");
        }

    }

}
