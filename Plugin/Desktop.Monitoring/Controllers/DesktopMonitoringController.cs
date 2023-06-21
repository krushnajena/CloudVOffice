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
        private readonly IDesktopActivityLogService _desktopActivityLogSerive;
        private readonly IDesktopSnapsService _desktopSnapshotSerive;

        public DesktopMonitoringController(IEmployeeService employeeService,
            IDesktoploginSevice desktopLoginService,
            IDesktopActivityLogService desktopActivityLogSerive,
             IDesktopSnapsService desktopSnapshotSerive
        )
        {
            _employeeService = employeeService;
            _desktopLoginService = desktopLoginService;
            _desktopActivityLogSerive = desktopActivityLogSerive;
            _desktopSnapshotSerive = desktopSnapshotSerive;

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

       
            ViewBag.EmployeeeId = EmployeeId;
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoring/Track.cshtml");
        }

        public IActionResult ActivityLog(Int64 EmployeeId)
        {
            ViewBag.EmployeeeId = EmployeeId;
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoring/ActivityLog.cshtml");
        }

        public IActionResult GetSnaps(string type, string logid)
        {
            ViewBag.ActivityId = logid;
            ViewBag.type = type;
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoring/GetSnaps.cshtml");
        }

        [HttpPost]

        public IActionResult LoginSessionWithDateRange(DesktopLoginFilterDTO desktopLoginDTO)
        {
            try
            {
               

                var list = _desktopLoginService.GetDesktoploginsWithDateRange(desktopLoginDTO);



                return Ok(list);
            }
            catch (Exception ex)
            {
                return Accepted(new { Status = "error", ResponseMsg = ex.Message });
            }
        }



        [HttpPost]

        public IActionResult GetAcivityLogsWithFilter(DesktopLoginFilterDTO desktopLoginDTO)
        {
            try
            {

                var list = _desktopActivityLogSerive.GetAcivityLogsWithFilter(desktopLoginDTO);




                return Ok(list);
            }
            catch (Exception ex)
            {
                return Accepted(new { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult GetDesktopSnaps(Int64 Id, string logType)
        {
            try
            {
                if(logType == "Session")
                {
                    var list = _desktopSnapshotSerive.GetSnapsBySessionId(Id);




                    return Ok(list);
                }
                else
                {
                    var list = _desktopSnapshotSerive.GetSnapsByActivityId(Id);




                    return Ok(list);

                }
                
            }
            catch (Exception ex)
            {
                return Accepted(new { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
