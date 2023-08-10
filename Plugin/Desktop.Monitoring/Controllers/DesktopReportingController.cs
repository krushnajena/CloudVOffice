using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Services.DesktopMonitoring;
using CloudVOffice.Services.Emp;
using CloudVOffice.Web.Framework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Desktop.Monitoring.Controllers
{
    [Area(AreaNames.DesktopMonitoring)]
    public class DesktopReportingController : Controller
    {
        private readonly IDesktopActivityLogService _desktopActivityLogSerive;
        private readonly IEmployeeService _employeeService;
        private readonly IDesktoploginSevice _desktoplogin;

        public DesktopReportingController(
            IDesktopActivityLogService desktopActivityLogSerive,
            IEmployeeService employeeService,
            IDesktoploginSevice desktoplogin
        )
        {
            _desktopActivityLogSerive = desktopActivityLogSerive;
            _employeeService = employeeService;
            _desktoplogin = desktoplogin;
        }
        [Authorize(Roles = "Desktop Monitoring User, Desktop Monitoring Manager, Employee")]
        public IActionResult SuspesiosActivityLog()
        {
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopReporting/SuspesiosActivityLog.cshtml");
        }
        [Authorize(Roles = "Desktop Monitoring User, Desktop Monitoring Manager, Employee")]
        public IActionResult SuspesiosWebActivityLog()
        {
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopReporting/SuspesiosWebActivityLog.cshtml");
        }
        [Authorize(Roles = "Desktop Monitoring User, Desktop Monitoring Manager, Employee")]
        public IActionResult SuspesiosApplicationActivityLog()
        {
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopReporting/SuspesiosApplicationActivityLog.cshtml");
        }
        [Authorize(Roles = "Desktop Monitoring User, Desktop Monitoring Manager, Employee")]
        public IActionResult EffortAnalysReport()
        {
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopReporting/EffortAnalysReport.cshtml");
        }
        [Authorize(Roles = "Desktop Monitoring User, Desktop Monitoring Manager, Employee")]
        public IActionResult EmployeeDayWiseEffortAnalysReport()
        {
            Int64 userId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Employee employee = _employeeService.GetEmployeeDetailsByUserId(userId);
            ViewBag.Employees = _employeeService.GetEmployeeSubContinent(employee.EmployeeId);
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopReporting/EmployeeDayWiseEffortAnalysReport.cshtml");
        }
        [HttpPost]
        public IActionResult GetSuspesiosActivityLog(SuspesiosActivityLogDTO suspesiosActivityLogDTO)
        {
            Int64 userId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Employee employee = _employeeService.GetEmployeeDetailsByUserId(userId);
            suspesiosActivityLogDTO.EmployeeId = employee.EmployeeId;
            return Json(_desktopActivityLogSerive.SuspesiosActivityLog(suspesiosActivityLogDTO));

        }

        [HttpPost]
        public IActionResult GetSuspesiosWebActivityLog(DesktopLoginFilterDTO suspesiosActivityLogDTO)
        {
            Int64 userId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Employee employee = _employeeService.GetEmployeeDetailsByUserId(userId);
            suspesiosActivityLogDTO.EmployeeId = employee.EmployeeId;
            return Json(_desktopActivityLogSerive.SuspesiosWebActivityLog(suspesiosActivityLogDTO));

        }

        [HttpPost]
        public IActionResult GetSuspesiosApplicationActivityLog(DesktopLoginFilterDTO suspesiosActivityLogDTO)
        {
            Int64 userId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Employee employee = _employeeService.GetEmployeeDetailsByUserId(userId);
            suspesiosActivityLogDTO.EmployeeId = employee.EmployeeId;
            return Json(_desktopActivityLogSerive.SuspesiosApplicationActivityLog(suspesiosActivityLogDTO));

        }






        [HttpPost]
        public IActionResult GetEffortAnalysReport(DesktopLoginFilterDTO suspesiosActivityLogDTO)
        {
            Int64 userId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Employee employee = _employeeService.GetEmployeeDetailsByUserId(userId);
            suspesiosActivityLogDTO.EmployeeId = employee.EmployeeId;
            return Json(_desktopActivityLogSerive.EffortAnalysReport(suspesiosActivityLogDTO));

        }



        [HttpPost]
        public IActionResult GetEmployeeDayWiseEffortAnalysReport(DesktopLoginFilterDTO suspesiosActivityLogDTO)
        {

            return Json(_desktopActivityLogSerive.EmployeeDayWiseEffortAnalysReport(suspesiosActivityLogDTO));

        }



    }
}
