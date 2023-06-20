using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public interface IDesktopSnapsService
    {
        public MessageEnum CreateDesktopSnaps(DesktopSnapsDTO desktopSnapsDTO);
    }
}
