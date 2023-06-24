using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public interface IRestrictedWebsiteService
    {
        public MessageEnum RestrictedWebsiteCreate(RestrictedWebsiteDTO restrictedWebsiteDTO);
        public List<RestrictedWebsite> GetRestrictedWebsites();
        public RestrictedWebsite GetRestrictedWebsiteByRestrictedWebsiteId(Int64 RestrictedWebsiteId);
        public RestrictedWebsite GetRestrictedWebsiteByRestrictedWebsiteName(string restrictedWebsiteName);
        public MessageEnum RestrictedWebsiteUpdate(RestrictedWebsiteDTO restrictedWebsiteDTO);
        public MessageEnum RestrictedWebsiteDelete(Int64 RestrictedWebsiteId, Int64 DeletedBy);

    }
}
