using CloudVOffice.Services.Attendance;
using CloudVOffice.Services.Emp;
using CloudVOffice.Web.Framework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Attendance.Controllers
{
    [Area(AreaNames.Attendance)]
    public class AttendanceController : Controller
    {
        private readonly IAttendanceRequestService _attendanceRequestService;
        public AttendanceController(IAttendanceRequestService attendanceRequestService)
        {
            _attendanceRequestService = attendanceRequestService;
        }
        [HttpGet]
        [Authorize(Roles = "HR Manager, HR User, Employee")]
        public IActionResult Dashboard()
        {
           
            return View("~/Plugins/HR.Attendance/Views/AttendanceDashboard/Dashboard.cshtml");
        }

    }
}
