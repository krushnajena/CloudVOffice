using CloudVOffice.Core.Domain.HR;
using CloudVOffice.Data.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.HR
{
    public class HRSettingsService : IHRSettingsService
    {
        private readonly ApplicationDBContext _Context;
        public HRSettingsService(ApplicationDBContext Context) {
            _Context = Context;
        }
        public HRSettings GetHrSettings()
        {
            try
            {
                return _Context.HRSettings.Where(X => X.Deleted == false).FirstOrDefault();
            }
            catch {
                throw;
            }
        }
    }
}
