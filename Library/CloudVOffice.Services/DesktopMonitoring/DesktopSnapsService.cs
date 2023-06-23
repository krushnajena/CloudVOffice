using Azure.Storage.Blobs.Models;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public class DesktopSnapsService : IDesktopSnapsService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<DesktopSnapshot> _desktopSnapShotRepo;
        public DesktopSnapsService(ApplicationDBContext Context, ISqlRepository<DesktopSnapshot> desktopSnapRepo)
        {

            _Context = Context;
            _desktopSnapShotRepo = desktopSnapRepo;
        }
        public MessageEnum CreateDesktopSnaps(DesktopSnapsDTO desktopSnap)
        {
            try
            {
                _desktopSnapShotRepo.Insert(new DesktopSnapshot
                {
                    DesktopActivityLogId = desktopSnap.DesktopActivityLogId,
                    DesktopLoginId = desktopSnap.DesktopLoginId,
                    EmployeeId = desktopSnap.EmployeeId,
                    LogType=  desktopSnap.LogType,
                    SnapShot = desktopSnap.SnapShot,
                    SnapshotDateTime = desktopSnap.SnapshotDateTime,
                    FileSize = desktopSnap.FileSize,
                    CreatedBy = desktopSnap.CreatedBy,
                });
                return MessageEnum.Success;
            }
            catch
            {
                throw;
            }
        }

        public List<DesktopSnapshot> GetSnapsByActivityId(Int64 ActivityId)
        {
            try
            {
                return _Context.DesktopSnapshots.Where(x=>x.DesktopActivityLogId== ActivityId && x.Deleted == false).OrderBy(x=>x.SnapshotDateTime).ToList();
            }
            catch
            {
                throw;
            }
        }
        public List<DesktopSnapshot> GetSnapsBySessionId(Int64 SessionId)
        {
            try
            {
                return _Context.DesktopSnapshots.Where(x => x.DesktopLoginId == SessionId && x.Deleted == false).OrderBy(x => x.SnapshotDateTime).ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
