using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Data.DTO.DesktopMonitoring;

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
