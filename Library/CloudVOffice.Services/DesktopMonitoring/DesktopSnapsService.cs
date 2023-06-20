using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.DesktopMonitoring
{
    public class DesktopSnapsService : IDesktopSnapsService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<DesktopSnapshot> _desktopSnapShotRepo;
        public DesktopSnapsService(ApplicationDBContext Context, ISqlRepository<DesktopSnapshot> desktopSnapRepo)
        {

            _Context = Context;
            _desktopSnapShotRepo = desktopSnapRepo;
        }
        public MessageEnum CreateDesktopSnaps()
        {
            throw new NotImplementedException();
        }
    }
}
