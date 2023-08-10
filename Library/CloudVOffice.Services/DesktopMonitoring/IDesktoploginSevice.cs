using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Data.DTO.DesktopMonitoring;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public interface IDesktoploginSevice
    {
        public DesktopLogin DesktoploginCreate(DesktopLoginDTO desktoploginDTO);
        public List<DesktopLogin> GetDesktoploginsWithDateRange(DesktopLoginFilterDTO desktopLoginFilterDTO);
        public DesktopLogin GetDesktoploginByDesktoploginId(Int64 DesktopLoginId);

        public MessageEnum DesktopLoginDelete(Int64 DesktopLoginId, Int64 DeletedBy);
        public MessageEnum DesktopLoginUpdateIdelTime(DesktopLoginIdelTimeUpdateDTO desktopLoginIdelTimeUpdateDTO);

        public List<DesktopLogin> GetTodayLoginData(Int64 EmployeeId);


    }
}
