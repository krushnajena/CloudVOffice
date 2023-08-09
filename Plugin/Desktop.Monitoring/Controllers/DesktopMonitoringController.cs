using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Infrastructure.Http;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Services.Applications;
using CloudVOffice.Services.DesktopMonitoring;
using CloudVOffice.Services.Emp;
using CloudVOffice.Services.Roles;
using CloudVOffice.Web.Framework;
using Desktop.Monitoring.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using Syncfusion.EJ2.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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
        [Authorize(Roles = "Desktop Monitoring User, Desktop Monitoring Manager, Employee")]
        public IActionResult Dashboard()
        {
            Int64 userId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Employee employee = _employeeService.GetEmployeeDetailsByUserId(userId);
            ViewBag.palettes = new string[] { "#61EFCD", "#4472c4", "#9e480e", "#CA765A", "#2485FA", "#F57D7D", "#C152D2",
                "#8854D9", "#3D4EB8", "#00BCD7", "#CDDE1F", "#ed7d31", "#ffc000", "#70ad47", "#5b9bd5", "#c1c1c1", "#6f6fe2", "#e269ae",  "#FEC200", "#997300" };
            List<DesktopSessionLineChartData> chartData = new List<DesktopSessionLineChartData>();
            if (employee != null)
            {
                var login = _desktopLoginService.GetTodayLoginData(employee.EmployeeId);
                if(login != null && login.Count>0)
                {
                    ViewBag.loginTime = login.FirstOrDefault().LoginDateTime.Value.ToString("hh:mm");
                    ViewBag.toalDuration = login.Sum(x => TimeSpan.Parse(x.Duration).TotalHours).ToString("00.00");
                    ViewBag.idelDuration = login.Sum(x =>( x.IdelTime==null?TimeSpan.Parse("00:00:00"): TimeSpan.Parse(x.IdelTime.ToString())).TotalHours).ToString("00.00");
                    var list = _desktopActivityLogSerive.UnProductiveActivityLog(new DesktopLoginFilterDTO { EmployeeId = employee.EmployeeId , FromDate = DateTime.Today, ToDate = DateTime.Today.AddDays(1)}).Sum(x=>TimeSpan.Parse( x.Duration).TotalHours);
                    ViewBag.unProuctiveHour = list.ToString("00.00");
                    List<PieChartData> chartDatas = new List<PieChartData>{
                     new PieChartData
                    {
                        Key = "Work Duration",
                        Value = double.Parse(( (login.Sum(x => TimeSpan.Parse(x.Duration).TotalHours) - login.Sum(x => (x.IdelTime == null ? TimeSpan.Parse("00:00:00") : TimeSpan.Parse(x.IdelTime.ToString())).TotalHours)) - list).ToString("00.00"))
                    },
        new PieChartData

        {
            Key = "Idel Duration",
            Value = double.Parse(login.Sum(x => (x.IdelTime == null ? TimeSpan.Parse("00:00:00") : TimeSpan.Parse(x.IdelTime.ToString())).TotalHours).ToString("00.00"))
        },
           new PieChartData

        {
            Key = "Un Productive Duration",
            Value =double.Parse(list.ToString("00.00"))
        }


                    };

                    ViewBag.WorkDurrationPie = chartDatas;







                }
                else
                {
                    ViewBag.loginTime = "--:--";
                    ViewBag.toalDuration = "--:--";
                    ViewBag.idelDuration  = "--:--";
                    ViewBag.unProuctiveHour = "--:--";
                    List<PieChartData> chartDatas = new List<PieChartData>();
                    ViewBag.WorkDurrationPie = chartDatas;
                   
                }


                var loginSessionModel = _desktopLoginService.GetDesktoploginsWithDateRange(new DesktopLoginFilterDTO
                {
                    EmployeeId = employee.EmployeeId,

                    FromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month , 1),
                    ToDate = DateTime.Now.AddMonths(1).AddDays(-1)
                });

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
                        if (loginSessionModel[i].IdelTime != null)
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
                        chartData.Add(new DesktopSessionLineChartData(dt.Date.ToString("dd-MM-yyyy"), double.Parse(t1.TotalHours.ToString("000.00")), double.Parse(t3.TotalHours.ToString("000.00"))));

                    }
                }

                ViewBag.SessionLineChart = chartData;



                var alist = _desktopActivityLogSerive.GetAcivityLogsWithFilter(new DesktopLoginFilterDTO
                {
                    EmployeeId = employee.EmployeeId,

                    FromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month-1, 1),
                    ToDate = DateTime.Now.AddMonths(1).AddDays(-1)
                });
                var acta = alist.GroupBy(r => new { r.ProcessOrUrl })
                              .Select(g => new {
                                  Duration = g.Sum(c => TimeSpan.Parse(c.Duration).TotalHours).ToString(),

                                  g.Key.ProcessOrUrl


                              });

                ViewBag.ActivityColumnChart = acta;




                var wlist = _desktopActivityLogSerive.WebActivityLog(new DesktopLoginFilterDTO
                {
                    EmployeeId = employee.EmployeeId,

                    FromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 1),
                    ToDate = DateTime.Now.AddMonths(1).AddDays(-1)
                });

                var wa = wlist.GroupBy(r => new { r.AppOrWebPageName })
                              .Select(g => new {
                                  Duration = g.Sum(c => TimeSpan.Parse(c.Duration).TotalHours).ToString(),

                                  g.Key.AppOrWebPageName


                              });
                ViewBag.WebColumnChart = wa;

            }
            else
            {
                ViewBag.loginTime = "--:--";
                ViewBag.toalDuration = "--:--";
                ViewBag.idelDuration = "--:--";
                ViewBag.unProuctiveHour = "--:--";
                List<PieChartData> chartDatas = new List<PieChartData>();
                ViewBag.WorkDurrationPie = chartDatas;
                ViewBag.SessionLineChart = chartData;
                ViewBag.ActivityColumnChart = null;
                ViewBag.WebColumnChart = null;
            }

            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoring/Dashboard.cshtml");  
        }
        [Authorize(Roles = "Desktop Monitoring User, Desktop Monitoring Manager, Employee")]
        public IActionResult MonitorUsers()
        {
            Int64 userId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Employee employee = _employeeService.GetEmployeeDetailsByUserId(userId);
            ViewBag.Employees = _employeeService.GetEmployeeSubContinent(employee.EmployeeId);
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoring/MonitorUsers.cshtml");
        }
        [Authorize(Roles = "Desktop Monitoring User, Desktop Monitoring Manager, Employee")]

        public IActionResult Track(Int64 EmployeeId)
        {

       
            ViewBag.EmployeeeId = EmployeeId;
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoring/Track.cshtml");
        }

        [Authorize(Roles = "Desktop Monitoring User, Desktop Monitoring Manager, Employee")]
        public IActionResult ActivityLog(Int64 EmployeeId)
        {
            ViewBag.EmployeeeId = EmployeeId;
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoring/ActivityLog.cshtml");
        }
        [Authorize(Roles = "Desktop Monitoring User, Desktop Monitoring Manager, Employee")]

        public IActionResult WebActivityLog(Int64 EmployeeId)
        {
            ViewBag.EmployeeeId = EmployeeId;
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoring/WebActivityLog.cshtml");
        }
        [Authorize(Roles = "Desktop Monitoring User, Desktop Monitoring Manager, Employee")]
        public IActionResult FileLog(Int64 EmployeeId)
        {
            ViewBag.EmployeeeId = EmployeeId;
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoring/FileLog.cshtml");
        }
        [Authorize(Roles = "Desktop Monitoring User, Desktop Monitoring Manager, Employee")]
        public IActionResult GetSnaps(string type, string logid)
        {
            ViewBag.ActivityId = logid;
            ViewBag.type = type;
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoring/GetSnaps.cshtml");
        }
        [Authorize(Roles = "Desktop Monitoring User, Desktop Monitoring Manager, Employee")]
        public IActionResult UnproductiveLog(Int64 EmployeeId)
        {
            ViewBag.EmployeeeId = EmployeeId;
            return View("~/Plugins/Desktop.Monitoring/Views/DesktopMonitoring/UnproductiveLog.cshtml");
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



        [HttpPost]

        public IActionResult GetFileLogsWithFilter(DesktopLoginFilterDTO desktopLoginDTO)
        {
            try
            {

                var list = _desktopActivityLogSerive.FileActivityLog(desktopLoginDTO);




                return Ok(list);
            }
            catch (Exception ex)
            {
                return Accepted(new { Status = "error", ResponseMsg = ex.Message });
            }
        }



        [HttpPost]

        public IActionResult GetUnProductiveActivityLog(DesktopLoginFilterDTO desktopLoginDTO)
        {
            try
            {

                var list = _desktopActivityLogSerive.UnProductiveActivityLog(desktopLoginDTO);




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
                else if(logType == "file")
                {
					var list = _desktopSnapshotSerive.GetSnapsForFileLog(Id);




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
                    chartData.Add(new DesktopSessionLineChartData(dt.Date.ToString("dd-MM-yyyy"), double.Parse( t1.TotalHours.ToString("000.00")), double.Parse( t3.TotalHours.ToString("000.00"))));

                }
            }

            //for(DateTime date = DateTime.Parse( desktopLoginDTO.FromDate.ToString()); date <= desktopLoginDTO.ToDate; date.AddDays(1))
            //{
            //    if(chartData.Where(x=>x.Xvalue == date.ToString("dd-MM-yyyy")).ToList().Count == 0)
            //    {
            //        chartData.Add(new DesktopSessionLineChartData(
            //        date.ToString("dd-MM-yyyy"),
            //          0,
            //            0
            //        ));
            //    }
            //}

           // ViewBag.dataSource = chartData;
            return Json(chartData.OrderBy(x=>x.Xvalue).ToList());
        }



        [HttpPost]
        public ActionResult ActivityLogChart(DesktopLoginFilterDTO desktopLoginDTO)
        {
            var list = _desktopActivityLogSerive.GetAcivityLogsWithFilter(desktopLoginDTO);
            var a = list.GroupBy(r => new { r.ProcessOrUrl })
                          .Select(g => new{
                              Duration  =   g.Sum(c => TimeSpan.Parse(c.Duration).TotalHours).ToString(),
                                        
                                         g.Key.ProcessOrUrl


                                     });




            return Json(a);
        }


        [HttpPost]
        public ActionResult WebActivityLogChart(DesktopLoginFilterDTO desktopLoginDTO)
        {
            var list = _desktopActivityLogSerive.WebActivityLog(desktopLoginDTO);

            var a = list.GroupBy(r => new { r.AppOrWebPageName })
                          .Select(g => new {
                              Duration = g.Sum(c => TimeSpan.Parse(c.Duration).TotalHours).ToString(),

                              g.Key.AppOrWebPageName


                          });




            return Json(a);
        }
    }
}
