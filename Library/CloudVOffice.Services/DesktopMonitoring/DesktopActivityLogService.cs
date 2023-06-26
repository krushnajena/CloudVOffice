using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Services.Emp;
using Microsoft.EntityFrameworkCore;
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
        public DesktopActivityLogService(ApplicationDBContext Context,
            ISqlRepository<DesktopActivityLog> desktopactivitylogRepo,
            IEmployeeService employeeService,
            IRestrictedWebsiteService restrictedWebsiteService)
        {

            _Context = Context;
            _desktopactivitylogRepo = desktopactivitylogRepo;
            _employeeService = employeeService;
            _restrictedWebsiteService = restrictedWebsiteService;
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
                    && (x.LogDateTime >= suspesiosActivityLogDTO.FromDate && x.LogDateTime <= suspesiosActivityLogDTO.ToDate)

                     ).ToList();
                return dmsLogs.Where(x => restrictedWbsiteList.Any(v =>( v.RestrictedWebsiteName.StartsWith(x.AppOrWebPageName == null?"": x.AppOrWebPageName)) || v.RestrictedWebsiteName.Contains(x.AppOrWebPageName == null ? "" : x.AppOrWebPageName)) && employees.Any(v => v.EmployeeId == x.EmployeeId)).ToList();

            }
            catch
            {
                throw;
            }
        }
    }
}
