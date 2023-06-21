using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.ViewModel.DesktopMonitering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public interface IDesktoploginSevice
    {
        public DesktopLogin DesktoploginCreate(DesktopLoginDTO desktoploginDTO);
        public List<DesktopLogin> GetDesktoploginsWithDateRange(DesktopLoginFilterDTO desktopLoginFilterDTO);
        public DesktopLogin GetDesktoploginByDesktoploginId(Int64 DesktopLoginId);       
       
        public MessageEnum DesktopLoginDelete(Int64 DesktopLoginId, Int64 DeletedBy);
        public MessageEnum DesktopLoginUpdateIdelTime(DesktopLoginIdelTimeUpdateDTO desktopLoginIdelTimeUpdateDTO);

    }
}
