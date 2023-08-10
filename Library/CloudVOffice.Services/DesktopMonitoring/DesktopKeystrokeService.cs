using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Data.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public class DesktopKeystrokeService : IDesktopKeystrokeService
    {
        private readonly ApplicationDBContext _Context;
        public DesktopKeystrokeService(ApplicationDBContext Context)
        {
            _Context = Context;
        }
        public List<DesktopKeyStroke> DesktopKeystrokeLogsWithFilter(DesktopLoginFilterDTO desktopLoginFilterDTO)
        {
            return _Context.DesktopKeyStrokes.Include(x => x.DesktopActivityLog).ThenInclude(X => X.DesktopSnapshots)
                .Where(x => x.Deleted == false && x.DesktopActivityLog.EmployeeId == desktopLoginFilterDTO.EmployeeId
                && (x.KeyStrokeDateTime >= desktopLoginFilterDTO.FromDate && x.KeyStrokeDateTime <= desktopLoginFilterDTO.ToDate)

                ).OrderByDescending(l => l.KeyStrokeDateTime).ToList();
        }
    }
}
