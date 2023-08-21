using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Data.DTO.DesktopMonitoring;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public interface IDesktopKeystrokeService
    {
        public List<DesktopKeyStroke> DesktopKeystrokeLogsWithFilter(DesktopLoginFilterDTO desktopLoginFilterDTO);
        public MessageEnum AddDesktopKeystrokes(DesktopKeyStrokesDTO desktopKeyStrokesDTO);
    }
}
