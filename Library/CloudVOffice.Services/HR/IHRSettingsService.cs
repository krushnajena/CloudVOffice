using CloudVOffice.Core.Domain.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.HR
{
    public interface IHRSettingsService
    {
        public HRSettings GetHrSettings();
    }
}
