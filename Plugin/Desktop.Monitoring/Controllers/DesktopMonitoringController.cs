using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Infrastructure.Http;
using CloudVOffice.Services.Applications;
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
       

        public DesktopMonitoringController(IEmployeeService employeeService
        )
        {
            _employeeService = employeeService;

        }
        public IActionResult MonitorUsers()
        {
            Int64 userId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Employee employee = _employeeService.GetEmployeeDetailsByUserId(userId);
            ViewBag.Employees = _employeeService.GetEmployeeSubContinent(employee.EmployeeId);
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoringUser/MonitorUsers.cshtml");
        }

        public IActionResult Track(Int64 EmployeeId)
        {
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoringUser/MonitorUsers.cshtml");
        }
    }
}
