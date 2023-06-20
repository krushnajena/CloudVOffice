using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Infrastructure.Http;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Services.Applications;
using CloudVOffice.Services.DesktopMonitoring;
using CloudVOffice.Services.Emp;
using CloudVOffice.Services.Roles;
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
    public class DesktopMonitoringController : Controller
    {

        private readonly IEmployeeService _employeeService;

        private readonly IDesktoploginSevice _desktopLoginService;

        public DesktopMonitoringController(IEmployeeService employeeService,
            IDesktoploginSevice desktopLoginService
        )
        {
            _employeeService = employeeService;
            _desktopLoginService = desktopLoginService;

        }
        public IActionResult Dashboard()
        {
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoring/Dashboard.cshtml");  
        }
        public IActionResult MonitorUsers()
        {
            Int64 userId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Employee employee = _employeeService.GetEmployeeDetailsByUserId(userId);
            ViewBag.Employees = _employeeService.GetEmployeeSubContinent(employee.EmployeeId);
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoring/MonitorUsers.cshtml");
        }

        public IActionResult Track(Int64 EmployeeId)
        {

            ViewBag.LoginSession = _desktopLoginService.GetDesktoploginsWithDateRange(new DesktopLoginFilterDTO
            {
                EmployeeId = EmployeeId
            });
            ViewBag.EmployeeeId = EmployeeId;
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoring/Track.cshtml");
        }

        public IActionResult ActivityLog(Int64 EmployeeId)
        {
            ViewBag.EmployeeeId = EmployeeId;
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoring/ActivityLog.cshtml");
        }
    }
}
