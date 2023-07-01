using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Core.Domain.HR.Attendance;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Data.ViewModel.DesktopMonitering;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Services.Emp;
using CloudVOffice.Services.HR;
using Microsoft.EntityFrameworkCore;
using StackExchange.Profiling.Internal;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public class DesktopActivityLogService : IDesktopActivityLogService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<DesktopActivityLog> _desktopactivitylogRepo;
        private readonly IEmployeeService _employeeService;
        private readonly IRestrictedWebsiteService _restrictedWebsiteService;
        private readonly IHolidayService _holiDayService;
        private readonly IHRSettingsService _hrSettingsService;
        private readonly IDesktoploginSevice _desktopLoginService;
        private readonly IRestrictedApplicationService _restrictedApplicationService;
        public DesktopActivityLogService(ApplicationDBContext Context,
            ISqlRepository<DesktopActivityLog> desktopactivitylogRepo,
            IEmployeeService employeeService,
            IRestrictedWebsiteService restrictedWebsiteService,
            IHolidayService holiDayService,
            IHRSettingsService hrSettingsService,
            IDesktoploginSevice desktoploginSevice,
            IRestrictedApplicationService restrictedApplicationService
            )
        {

            _Context = Context;
            _desktopactivitylogRepo = desktopactivitylogRepo;
            _employeeService = employeeService;
            _restrictedWebsiteService = restrictedWebsiteService;
            _holiDayService=holiDayService;
            _hrSettingsService= hrSettingsService;
            _desktopLoginService = desktoploginSevice;
            _restrictedApplicationService = restrictedApplicationService;
        }
        public DesktopActivityLog DesktopActivityLogCreate(DesktopActivityLogDTO desktopactivitylogDTO)
        {
            try
            {
                var b = _Context.DesktopLogins.Where(x => x.DesktopLoginId == desktopactivitylogDTO.DesktopLoginId).FirstOrDefault();
                if (b != null)
                {
                    b.LogOutDateTime = desktopactivitylogDTO.Todatetime;
                    _Context.SaveChanges();
                   
                }

                var a=     _desktopactivitylogRepo.Insert(new DesktopActivityLog()
                    {
                        EmployeeId = desktopactivitylogDTO.EmployeeId,
                        LogType = desktopactivitylogDTO.LogType,
                        DesktopLoginId = desktopactivitylogDTO.DesktopLoginId,
                        LogDateTime = desktopactivitylogDTO.LogDateTime,
                        ComputerName = desktopactivitylogDTO.ComputerName,
                        ProcessOrUrl=desktopactivitylogDTO.ProcessOrUrl,
                        AppOrWebPageName=desktopactivitylogDTO.AppOrWebPageName,
                        TypeOfApp=desktopactivitylogDTO.TypeOfApp,
                        SyncedOn = desktopactivitylogDTO.SyncedOn,
                        Action=desktopactivitylogDTO.Action,
                        Source=desktopactivitylogDTO.Source,
                        Folder=desktopactivitylogDTO.Folder,
                        FileName=desktopactivitylogDTO.FileName,
                        PrinterName=desktopactivitylogDTO.PrinterName,
                        Todatetime=desktopactivitylogDTO.Todatetime,
                        CreatedBy = desktopactivitylogDTO.CreatedBy,
                        CreatedDate = DateTime.Now,
                        Deleted = false
                    });
                    return a;
               
            }
            catch
            {
                throw;
            }
        }

        public MessageEnum DesktopActivityLogDelete(Int64 DesktopActivityLogId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.DesktopActivityLogs.Where(x => x.DesktopActivityLogId == DesktopActivityLogId).FirstOrDefault();
                if (a != null)
                {
                    a.Deleted = true;
                    a.UpdatedBy = DeletedBy;
                    a.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();
                    return MessageEnum.Deleted;
                }
                else
                    return MessageEnum.Invalid;
            }
            catch
            {
                throw;
            }
        }

        public MessageEnum DesktopActivityLogUpdate(DesktopActivityLogDTO desktopactivitylogDTO)
        {
            try
            {
                var desktopActivityLog = _Context.DesktopActivityLogs.Where(x => x.DesktopActivityLogId != desktopactivitylogDTO.DesktopActivityLogId && x.EmployeeId == desktopactivitylogDTO.EmployeeId && x.Deleted == false).FirstOrDefault();
                if (desktopActivityLog == null)
                {
                    var a = _Context.DesktopActivityLogs.Where(x => x.DesktopActivityLogId == desktopactivitylogDTO.DesktopActivityLogId).FirstOrDefault();
                    if (a != null)
                    {
                        a.EmployeeId = desktopactivitylogDTO.EmployeeId;
                        a.LogType = desktopactivitylogDTO.LogType;
                        a.DesktopLoginId = desktopactivitylogDTO.DesktopLoginId;
                        a.LogDateTime = desktopactivitylogDTO.LogDateTime;
                        a.ComputerName = desktopactivitylogDTO.ComputerName;
                        a.ProcessOrUrl = desktopactivitylogDTO.ProcessOrUrl;
                        a.AppOrWebPageName= desktopactivitylogDTO.AppOrWebPageName;
                        a.TypeOfApp= desktopactivitylogDTO.TypeOfApp;                        
                        a.SyncedOn = desktopactivitylogDTO.SyncedOn;
                        a.Action= desktopactivitylogDTO.Action;
                        a.Source= desktopactivitylogDTO.Source;
                        a.Folder= desktopactivitylogDTO.Folder;
                        a.FileName= desktopactivitylogDTO.FileName;
                        a.PrinterName= desktopactivitylogDTO.PrinterName;
                        a.Todatetime= desktopactivitylogDTO.Todatetime;
                        a.UpdatedBy = desktopactivitylogDTO.CreatedBy;
                        a.UpdatedDate = DateTime.Now;
                        _Context.SaveChanges();
                        return MessageEnum.Updated;
                    }
                    else
                        return MessageEnum.Invalid;
                }
                else
                {
                    return MessageEnum.Duplicate;
                }

            }
            catch
            {
                throw;
            }
        }

        public List<DesktopActivityLog> GetAcivityLogsWithFilter(DesktopLoginFilterDTO desktopLoginFilterDTO)
        {
         return   _Context.DesktopActivityLogs.Include(x => x.DesktopSnapshots)
                .Where(x => x.Deleted == false && x.EmployeeId == desktopLoginFilterDTO.EmployeeId && x.LogType == "ActivityLog" 
                && (x.LogDateTime >= desktopLoginFilterDTO.FromDate && x.LogDateTime <= desktopLoginFilterDTO.ToDate)
                
                ).OrderByDescending(l => l.LogDateTime).ToList();
        }

        public DesktopActivityLog GetDesktopActivityLogByDesktopActivityLogId(Int64 DesktopActivityLogId)
        {
            try
            {
                return _Context.DesktopActivityLogs.Where(x => x.DesktopActivityLogId == DesktopActivityLogId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<DesktopActivityLog> GetDesktopActivityLogs()
        {
            try
            {
                return _Context.DesktopActivityLogs.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }
        public List<DesktopActivityLog> SuspesiosActivityLog(SuspesiosActivityLogDTO suspesiosActivityLogDTO)
        {
            try
            {
                var employees = _employeeService.GetEmployeeSubContinent((Int64)suspesiosActivityLogDTO.EmployeeId).ToList();
                var dmsLogs = _Context.DesktopActivityLogs
                     .Include(r => r.Employee)
                     .Where(x => x.Deleted == false
                    &&   (x.LogDateTime >= suspesiosActivityLogDTO.FromDate && x.LogDateTime <= suspesiosActivityLogDTO.ToDate)
               
                     ).ToList();
                return dmsLogs.Where(x => (TimeSpan.Parse(x.Duration).TotalMinutes >= suspesiosActivityLogDTO.Duration) && employees.Any(v => v.EmployeeId == x.EmployeeId)).ToList();

            }
            catch
            {
                throw;
            }
        }

        public List<DesktopActivityLog> SuspesiosWebActivityLog(DesktopLoginFilterDTO suspesiosActivityLogDTO)
        {
            try
            {
                var restrictedWbsiteList = _restrictedWebsiteService.GetRestrictedWebsites().ToList();
                var employees = _employeeService.GetEmployeeSubContinent((Int64)suspesiosActivityLogDTO.EmployeeId).ToList();
                var dmsLogs = _Context.DesktopActivityLogs
                     .Include(r => r.Employee)
                     .Where(x => x.Deleted == false
                    && (x.LogDateTime >= suspesiosActivityLogDTO.FromDate && x.LogDateTime <= suspesiosActivityLogDTO.ToDate)&& x.AppOrWebPageName!=null && x.AppOrWebPageName!=""

                     ).ToList();
                var newDmsLogs = dmsLogs.Where(x => employees.Any(v => v.EmployeeId == x.EmployeeId)).ToList();
                List <DesktopActivityLog> ret = new List<DesktopActivityLog>();
                for(int i=0; i< newDmsLogs.GroupBy(x=>x.EmployeeId).ToList().Count; i++)
                {
                    var myRestrictedWebsites = restrictedWbsiteList.Where(x=> (x.DepartmentId == null || x.DepartmentId == newDmsLogs[i].Employee.DepartmentId) && x.Deleted == false ).ToList();
                    for(int j=0;j< myRestrictedWebsites.Count; j++)
                    {
                        var check = newDmsLogs.Where(x => x.AppOrWebPageName.Contains(myRestrictedWebsites[j].RestrictedWebsiteName)).ToList();
                        if (check.Count > 0)
                        {
                            ret.AddRange(check);
                        }
                    }
                }
                return ret;

            }
            catch
            {
                throw;
            }
        }

        public List<EffortAnalysReportViewModel> EffortAnalysReport(DesktopLoginFilterDTO suspesiosActivityLogDTO)
        {
            List<EffortAnalysReportViewModel> effortAnalysReportViewModels= new List<EffortAnalysReportViewModel>();
            var holidays = _holiDayService.GetHolidayByDates(DateTime.Parse(suspesiosActivityLogDTO.FromDate.ToString()), DateTime.Parse(suspesiosActivityLogDTO.ToDate.ToString()));
            var holiday = new List<HolidayDays>();
            if(holidays!=null)
                holidays.HolidayDays.Where(x=> (x.ForDate >= suspesiosActivityLogDTO.FromDate && x.ForDate <= suspesiosActivityLogDTO.ToDate) && x.Deleted == false).ToList();
            int NoOfDays = (DateTime.Parse(suspesiosActivityLogDTO.ToDate.ToString()) - DateTime.Parse(suspesiosActivityLogDTO.FromDate.ToString())).Days;
            int NoOfWorkingDays = NoOfDays - holiday.Count;
            var employees = _employeeService.GetEmployeeSubContinent((Int64)suspesiosActivityLogDTO.EmployeeId).ToList();
            var hrsettings = _hrSettingsService.GetHrSettings();
            double workingHours = (double) hrsettings.StandardWorkingHours * 60;
            double breakeHour = (double)hrsettings.BreakHours ;
            double systemHour = (workingHours - breakeHour)/60;
            double totalEffortHourRequired = NoOfWorkingDays * systemHour;
            for(int i=0; i < employees.Count; i++)
            {
                var desktopSessions = _desktopLoginService.GetDesktoploginsWithDateRange(new DesktopLoginFilterDTO { EmployeeId = employees[i].EmployeeId, FromDate = suspesiosActivityLogDTO.FromDate, ToDate = suspesiosActivityLogDTO.ToDate });
                double sumOfEffortHour = desktopSessions.Sum(x => TimeSpan.Parse(x.Duration).Hours);
                double sumOfIdelHours = desktopSessions.Sum(x => (x.IdelTime == null ? TimeSpan.Parse("00:00:00") : TimeSpan.Parse(x.IdelTime.ToString())).Hours);
                double actualEffort = sumOfEffortHour - sumOfIdelHours;
                effortAnalysReportViewModels.Add(new EffortAnalysReportViewModel
                {
                    EmployeeName = employees[i].FullName,
                    TotalNoOfDaysInMonth = NoOfDays,
                    TotalNoOfWorkingDays = NoOfWorkingDays,
                    EffortHourRequired = totalEffortHourRequired,
                    EffortHours = sumOfEffortHour,
                    IdelHours = sumOfIdelHours,
                    ActualEffortHours = actualEffort,
                    EffortPercentage = (actualEffort / totalEffortHourRequired) * 100
                }) ;
            }
            return effortAnalysReportViewModels;
        }


        public List<EmployeeDayWiseEffortAnalysViewModel> EmployeeDayWiseEffortAnalysReport(DesktopLoginFilterDTO suspesiosActivityLogDTO)
        {
            List<EmployeeDayWiseEffortAnalysViewModel> effortAnalysReportViewModels = new List<EmployeeDayWiseEffortAnalysViewModel>();
           
            var hrsettings = _hrSettingsService.GetHrSettings();
            double workingHours = (double)hrsettings.StandardWorkingHours * 60;
            double breakeHour = (double)hrsettings.BreakHours;
            double systemHour = (workingHours - breakeHour) / 60;
            var alldesktopSessions = _desktopLoginService.GetDesktoploginsWithDateRange(new DesktopLoginFilterDTO { EmployeeId = suspesiosActivityLogDTO.EmployeeId, FromDate = suspesiosActivityLogDTO.FromDate, ToDate = suspesiosActivityLogDTO.ToDate });

            for (DateTime date = (DateTime)suspesiosActivityLogDTO.FromDate; date<= suspesiosActivityLogDTO.ToDate; date = date.AddDays(1))
            {
                var desktopSessions = alldesktopSessions.Where(x => x.LoginDateTime.Value.ToString("dd-MM-yyyy") == date.ToString("dd-MM-yyyy")).ToList();
                if (desktopSessions.Count > 0)
                {
                    double sumOfEffortHour = desktopSessions.Sum(x => TimeSpan.Parse(x.Duration).Hours);
                    double sumOfIdelHours = desktopSessions.Sum(x => (x.IdelTime == null ? TimeSpan.Parse("00:00:00") : TimeSpan.Parse(x.IdelTime.ToString())).Hours);
                    double actualEffort = sumOfEffortHour - sumOfIdelHours;


                    effortAnalysReportViewModels.Add(new EmployeeDayWiseEffortAnalysViewModel
                    {
                        EmployeeName = desktopSessions[0].Employee.FullName,
                        Date = date,
                        EffortHourRequired = systemHour,
                        EffortHours = sumOfEffortHour,
                        IdelHours = sumOfIdelHours,
                        ActualEffortHours = actualEffort,
                        EffortPercentage = (actualEffort / systemHour) * 100
                    });
                }
               

            }

            return effortAnalysReportViewModels;
        }

        public List<DesktopActivityLog> SuspesiosApplicationActivityLog(DesktopLoginFilterDTO suspesiosActivityLogDTO)
        {
            try
            {
                var restrictedApplicationList = _restrictedApplicationService.GetRestrictedApplication().ToList();
                var employees = _employeeService.GetEmployeeSubContinent((Int64)suspesiosActivityLogDTO.EmployeeId).ToList();
                var dmsLogs = _Context.DesktopActivityLogs
                     .Include(r => r.Employee)
                     .Where(x => x.Deleted == false
                    && (x.LogDateTime >= suspesiosActivityLogDTO.FromDate && x.LogDateTime <= suspesiosActivityLogDTO.ToDate) && x.AppOrWebPageName != null && x.AppOrWebPageName != ""

                     ).ToList();
                var newDmsLogs = dmsLogs.Where(x => employees.Any(v => v.EmployeeId == x.EmployeeId)).ToList();
                List<DesktopActivityLog> ret = new List<DesktopActivityLog>();
                for (int i = 0; i < newDmsLogs.GroupBy(x => x.EmployeeId).ToList().Count; i++)
                {
                    var myRestrictedApplication = restrictedApplicationList.Where(x => (x.DepartmentId == null || x.DepartmentId == newDmsLogs[i].Employee.DepartmentId) && x.Deleted == false).ToList();
                    for (int j = 0; j < myRestrictedApplication.Count; j++)
                    {
                        var check = newDmsLogs.Where(x => x.ProcessOrUrl.Contains(myRestrictedApplication[j].RestrictedApplicationName)).ToList();
                        if (check.Count > 0)
                        {
                            ret.AddRange(check);
                        }
                    }
                }
                return ret;

            }
            catch
            {
                throw;
            }
        }


        public List<DesktopActivityLog> WebActivityLog(DesktopLoginFilterDTO desktopLoginFilterDTO)
        {
            return _Context.DesktopActivityLogs.Include(x => x.DesktopSnapshots)
            .Where(x => x.Deleted == false && x.EmployeeId == desktopLoginFilterDTO.EmployeeId && x.LogType == "ActivityLog"
            && (x.LogDateTime >= desktopLoginFilterDTO.FromDate && x.LogDateTime <= desktopLoginFilterDTO.ToDate && x.ProcessOrUrl.Contains("chrome"))

            ).OrderByDescending(l => l.LogDateTime).ToList();
        }
    }
}
