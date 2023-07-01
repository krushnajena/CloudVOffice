using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Infrastructure.Http;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Services.Applications;
using CloudVOffice.Services.DesktopMonitoring;
using CloudVOffice.Services.Emp;
using CloudVOffice.Services.Roles;
using CloudVOffice.Web.Framework;
using Desktop.Monitoring.Models;
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


        public IActionResult WebActivityLog(Int64 EmployeeId)
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


        [HttpPost]

        public IActionResult GetWebAcivityLogsWithFilter(DesktopLoginFilterDTO desktopLoginDTO)
        {
            try
            {

                var list = _desktopActivityLogSerive.WebActivityLog(desktopLoginDTO);




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


        [HttpPost]
        public ActionResult SessionLogLineChart(DesktopLoginFilterDTO desktopLoginDTO)
        {

            var loginSessionModel = _desktopLoginService.GetDesktoploginsWithDateRange(desktopLoginDTO);




            List<DesktopSessionLineChartData> chartData = new List<DesktopSessionLineChartData>();

            for (int i = 0; i < loginSessionModel.Count; i++)
            {
                bool check = false;
                DateTime dt = loginSessionModel[i].LoginDateTime.Value.Date;
                for (int j = 0; j < chartData.Count; j++)
                {
                    if (chartData[j].Xvalue == dt.Date.ToString("dd-MM-yyyy"))
                    {
                        check = true;
                    }
                }


                if (check == false)
                {
                    TimeSpan t1 = TimeSpan.Parse("0:00:00");
                    if (loginSessionModel[i].Duration != null)
                    {
                        t1 = TimeSpan.Parse(loginSessionModel[i].Duration);
                        for (int k = 1; k < loginSessionModel.Count; k++)
                        {
                            if (loginSessionModel[k].LoginDateTime.Value.Date == dt.Date)
                            {
                                if (loginSessionModel[k].Duration != null)
                                {
                                    TimeSpan t2 = TimeSpan.Parse(loginSessionModel[k].Duration);
                                    t1 = t1.Add(t2);
                                }


                            }

                        }


                    }

                    TimeSpan t3 = TimeSpan.Parse("0:00:00");
                    if (loginSessionModel[i].IdelTime != null )
                    {
                        t3 = TimeSpan.Parse(loginSessionModel[i].IdelTime.ToString());
                        for (int k = 1; k < loginSessionModel.Count; k++)
                        {
                            if (loginSessionModel[k].LoginDateTime.Value.Date == dt.Date)
                            {
                                if (loginSessionModel[k].IdelTime != null)
                                {
                                    TimeSpan t2 = TimeSpan.Parse(loginSessionModel[k].IdelTime.ToString());
                                    t3 = t3.Add(t2);
                                }
                               

                            }

                        }


                    }
                    chartData.Add(new DesktopSessionLineChartData(dt.Date.ToString("dd-MM-yyyy"), t1.TotalHours, t3.TotalHours));

                }
            }



           // ViewBag.dataSource = chartData;
            return Json(chartData);
        }
    }
}
