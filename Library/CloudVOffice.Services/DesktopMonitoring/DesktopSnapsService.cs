using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public class DesktopSnapsService : IDesktopSnapsService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<DesktopSnapshot> _desktopSnapShotRepo;
        private readonly IDesktopActivityLogService _desktopActivityLogService;
        public DesktopSnapsService(ApplicationDBContext Context, ISqlRepository<DesktopSnapshot> desktopSnapRepo,
            IDesktopActivityLogService desktopActivityLogService
            )
        {

            _Context = Context;
            _desktopSnapShotRepo = desktopSnapRepo;
            _desktopActivityLogService = desktopActivityLogService;

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
                    LogType = desktopSnap.LogType,
                    SnapShot = desktopSnap.SnapShot,
                    SnapshotDateTime = desktopSnap.SnapshotDateTime,
                    FileSize = desktopSnap.FileSize,
                    CreatedBy = desktopSnap.CreatedBy,
                    Deleted = false,
                    CreatedDate = DateTime.Now
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
                return _Context.DesktopSnapshots.Where(x => x.DesktopActivityLogId == ActivityId && x.Deleted == false).OrderBy(x => x.SnapshotDateTime).ToList();
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


        public List<DesktopSnapshot> GetSnapsForFileLog(Int64 ActivityId)
        {
            try
            {
                var activity = _desktopActivityLogService.GetDesktopActivityLogByDesktopActivityLogId(ActivityId);
                return _Context.DesktopSnapshots.Where(x => (x.SnapshotDateTime >= activity.LogDateTime.Value.AddMinutes(-2) && x.SnapshotDateTime <= activity.LogDateTime.Value.AddMinutes(2)) && x.Deleted == false).OrderBy(x => x.SnapshotDateTime).ToList();
            }
            catch
            {
                throw;
            }
        }

    }
}
