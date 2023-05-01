using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
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
        public DesktopActivityLogService(ApplicationDBContext Context, ISqlRepository<DesktopActivityLog> desktopactivitylogRepo)
        {

            _Context = Context;
            _desktopactivitylogRepo = desktopactivitylogRepo;
        }
        public MennsageEnum DesktopActivityLogCreate(DesktopActivityLogDTO desktopactivitylogDTO)
        {
            try
            {
                var desktopactivitylogcreate = _Context.DesktopActivityLogs.Where(x => x.EmployeeId == desktopactivitylogDTO.EmployeeId && x.Deleted == false).FirstOrDefault();
                if (desktopactivitylogcreate == null)
                {
                    _desktopactivitylogRepo.Insert(new DesktopActivityLog()
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
                    return MennsageEnum.Success;
                }
                else
                    return MennsageEnum.Duplicate;
            }
            catch
            {
                throw;
            }
        }

        public MennsageEnum DesktopActivityLogDelete(Int64 DesktopActivityLogId, Int64 DeletedBy)
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
                    return MennsageEnum.Deleted;
                }
                else
                    return MennsageEnum.Invalid;
            }
            catch
            {
                throw;
            }
        }

        public MennsageEnum DesktopActivityLogUpdate(DesktopActivityLogDTO desktopactivitylogDTO)
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
                        return MennsageEnum.Updated;
                    }
                    else
                        return MennsageEnum.Invalid;
                }
                else
                {
                    return MennsageEnum.Duplicate;
                }

            }
            catch
            {
                throw;
            }
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
    }
}
