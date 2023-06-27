using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Services.DesktopMonitoring;
using CloudVOffice.Services.Emp;
using CloudVOffice.Web.Framework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Monitoring.Controllers
{
    [Area(AreaNames.DesktopMonitoring)]
    public class DesktopReportingController : Controller
    {
        private readonly IDesktopActivityLogService _desktopActivityLogSerive;
        private readonly IEmployeeService _employeeService;

        public DesktopReportingController(
            IDesktopActivityLogService desktopActivityLogSerive,
            IEmployeeService employeeService
        )
        {
            _desktopActivityLogSerive = desktopActivityLogSerive;
            _employeeService = employeeService;
        }
        
        public IActionResult SuspesiosActivityLog()
        {
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopReporting/SuspesiosActivityLog.cshtml");
        }

        public IActionResult SuspesiosWebActivityLog()
        {
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopReporting/SuspesiosWebActivityLog.cshtml");
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
    }
}
