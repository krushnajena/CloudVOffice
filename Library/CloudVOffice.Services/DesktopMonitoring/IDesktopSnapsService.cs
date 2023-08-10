using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Data.DTO.DesktopMonitoring;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public interface IDesktopSnapsService
    {
        public MessageEnum CreateDesktopSnaps(DesktopSnapsDTO desktopSnapsDTO);
        public List<DesktopSnapshot> GetSnapsByActivityId(Int64 ActivityId);
        public List<DesktopSnapshot> GetSnapsBySessionId(Int64 SessionId);

        public List<DesktopSnapshot> GetSnapsForFileLog(Int64 ActivityId);
    }
}
