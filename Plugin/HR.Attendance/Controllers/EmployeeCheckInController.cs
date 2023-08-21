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
    public class EmployeeCheckInController : BasePluginController
    {
        private readonly IEmployeeCheckInService _employeeCheckInService;
        private readonly IEmployeeService _employeeService;
        public EmployeeCheckInController(IEmployeeCheckInService employeeCheckInService, IEmployeeService employeeService)
        {

            _employeeCheckInService = employeeCheckInService;
            _employeeService = employeeService;
        }
        [HttpGet]
        public IActionResult EmployeeCheckInCreate(Int64? employeeCheckInId)
        {
            EmployeeCheckInDTO employeeCheckInDTO = new ();


            var employees = _employeeService.GetEmployees();
            ViewBag.Employees = employees;

            if (employeeCheckInId != null)
            {

                var d = _employeeCheckInService.GetEmployeeCheckInById(int.Parse(employeeCheckInId.ToString()));

                employeeCheckInDTO.EmployeeId = d.EmployeeId;
                employeeCheckInDTO.ForDate = d.ForDate;
                employeeCheckInDTO.LogType = d.LogType;
                employeeCheckInDTO.DeviceId = d.DeviceId;
                


            }

            return View("~/Plugins/HR.Attendance/Views/EmployeeCheckIn/EmployeeCheckInCreate.cshtml", employeeCheckInDTO);


        }
		[HttpPost]

		public IActionResult EmployeeCheckInCreate(EmployeeCheckInDTO employeeCheckInDTO)
		{
			employeeCheckInDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
			{
				if (employeeCheckInDTO.EmployeeCheckInId == null)
				{
					var a = _employeeCheckInService.EmployeeCheckInCreate(employeeCheckInDTO);
					if (a == MessageEnum.Success)
					{
						TempData["msg"] = MessageEnum.Success;
						return Redirect("/Attendance/EmployeeCheckIn/EmployeeCheckInView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "EmployeeCheckIn Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _employeeCheckInService.EmployeeCheckInUpdate(employeeCheckInDTO);
					if (a == MessageEnum.Updated)
					{
						TempData["msg"] = MessageEnum.Updated;
						return Redirect("/Attendance/EmployeeCheckIn/EmployeeCheckInView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "EmployeeCheckIn Already Exists");
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

			return View("~/Plugins/HR.Attendance/Views/EmployeeCheckIn/EmployeeCheckInCreate.cshtml", employeeCheckInDTO);

		}
		public IActionResult EmployeeCheckInView()
		{
			ViewBag.EmployeeCheckIn = _employeeCheckInService.GetEmployeeCheckIn();

			return View("~/Plugins/HR.Attendance/Views/EmployeeCheckIn/EmployeeCheckInView.cshtml");
		}
		[HttpGet]
		public IActionResult EmployeeCheckInDelete(int employeeCheckInId)
		{
			Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			var a = _employeeCheckInService.EmployeeCheckInDelete(employeeCheckInId, DeletedBy);
			TempData["msg"] = a;
			return Redirect("/Attendance/EmployeeCheckIn/EmployeeCheckInView");
		}
	}
}
