using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.HR;

namespace CloudVOffice.Services.HR
{
    public interface IHRSettingsService
    {

        public HRSettingsDTO GetHrSettings();

        public MessageEnum HRSettingsUpdate(HRSettingsDTO hrSettingsDTO);

    }
}
