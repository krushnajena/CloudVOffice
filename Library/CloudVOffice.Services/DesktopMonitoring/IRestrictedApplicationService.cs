using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public interface IRestrictedApplicationService
    {
        public MessageEnum RestrictedApplicationCreate(RestrictedApplicationDTO restrictedApplicationDTO);
        public List<RestrictedApplication> GetRestrictedApplication();
        public RestrictedApplication GetRestrictedApplicationById(Int64 RestrictedApplicationId);
        public MessageEnum RestrictedApplicationUpdate(RestrictedApplicationDTO restrictedApplicationDTO);
        public MessageEnum RestrictedApplicationDelete(Int64 RestrictedApplicationId, Int64 DeletedBy);
    }
}
