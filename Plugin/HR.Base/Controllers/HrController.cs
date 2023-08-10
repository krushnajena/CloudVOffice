using CloudVOffice.Services.Emp;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HR.Base.Controllers
{
    [Area(AreaNames.HR)]
    public class HrController : BasePluginController
    {
        private readonly IEmployeeService _employeeService;
        public HrController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        [Authorize(Roles = "HR Manager, HR User")]
        public IActionResult Dashboard()
        {
            ViewBag.employees = _employeeService.GetEmployees();
            return View("~/Plugins/HR.Base/Views/Hr/Dashboard.cshtml");
        }
    }
}
