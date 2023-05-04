using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Data.ViewModel.DesktopMonitering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public interface IDesktopActivityLogService
    {
        public MennsageEnum DesktopActivityLogCreate(DesktopActivityLogDTO desktopactivitylogDTO);
        public List<DesktopActivityLog> GetDesktopActivityLogs();
        public DesktopActivityLog GetDesktopActivityLogByDesktopActivityLogId(Int64 DesktopActivityLogId);
        public MennsageEnum DesktopActivityLogUpdate(DesktopActivityLogDTO desktopactivitylogDTO);
        public MennsageEnum DesktopActivityLogDelete(Int64 DesktopActivityLogId, Int64 DeletedBy);

        public List<DesktopActivityLog> GetAcivityLogsWithFilter(DesktopLoginFilterDTO desktopLoginFilterDTO);
    }
}
