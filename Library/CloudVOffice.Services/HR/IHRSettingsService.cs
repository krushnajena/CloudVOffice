using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Company;
using CloudVOffice.Core.Domain.HR;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.HR
{
    public interface IHRSettingsService
    {
        
        public HRSettingsDTO GetHrSettings();
		
		public MessageEnum HRSettingsUpdate(HRSettingsDTO hrSettingsDTO);
        
    }
}
