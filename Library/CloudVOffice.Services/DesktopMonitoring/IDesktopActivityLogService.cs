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
        public DesktopActivityLog DesktopActivityLogCreate(DesktopActivityLogDTO desktopactivitylogDTO);
        public List<DesktopActivityLog> GetDesktopActivityLogs();
        public DesktopActivityLog GetDesktopActivityLogByDesktopActivityLogId(Int64 DesktopActivityLogId);
        public MessageEnum DesktopActivityLogUpdate(DesktopActivityLogDTO desktopactivitylogDTO);
        public MessageEnum DesktopActivityLogDelete(Int64 DesktopActivityLogId, Int64 DeletedBy);

        public List<DesktopActivityLog> GetAcivityLogsWithFilter(DesktopLoginFilterDTO desktopLoginFilterDTO);
        public List<DesktopActivityLog> SuspesiosActivityLog(SuspesiosActivityLogDTO suspesiosActivityLogDTO);

        public List<DesktopActivityLog> SuspesiosWebActivityLog(DesktopLoginFilterDTO suspesiosActivityLogDTO);
        public List<DesktopActivityLog> SuspesiosApplicationActivityLog(DesktopLoginFilterDTO suspesiosActivityLogDTO);
        public List<EffortAnalysReportViewModel> EffortAnalysReport(DesktopLoginFilterDTO suspesiosActivityLogDTO);
        public List<EmployeeDayWiseEffortAnalysViewModel> EmployeeDayWiseEffortAnalysReport(DesktopLoginFilterDTO suspesiosActivityLogDTO);

        public List<DesktopActivityLog> WebActivityLog(DesktopLoginFilterDTO suspesiosActivityLogDTO);

        public List<DesktopActivityLog> FileActivityLog(DesktopLoginFilterDTO fileActivityLogDTO);

        public List<DesktopActivityLog> UnProductiveActivityLog(DesktopLoginFilterDTO fileActivityLogDTO);





    }
}
