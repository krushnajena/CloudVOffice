using CloudVOffice.Core.Domain.Pemission;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Applications
{
    public class ApplicationInstallationService : IApplicationInstallationService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly ISqlRepository<InstalledApplication> _installedApplicationRepo;
        public ApplicationInstallationService(ApplicationDBContext dbContext, ISqlRepository<InstalledApplication> installedApplicationRepo)
        {
            _dbContext = dbContext;
            _installedApplicationRepo = installedApplicationRepo;
        }
        public List<InstalledApplication> GetInstalledApplications()
        {
            return _dbContext.InstalledApplications.Where(x=>x.Deleted == false).ToList();
        }

        public InstalledApplication InstallApplication(string PackageName,Int64 CreatedBy)
        {
            var obj = _dbContext.InstalledApplications.Where(x => x.PackageName == PackageName && x.Deleted == false).FirstOrDefault();
            if(obj == null)
            {
                InstalledApplication installedApplication = new InstalledApplication();
                installedApplication.PackageName = PackageName;
                installedApplication.Deleted = false;
                installedApplication.CreatedDate = DateTime.Now;
                installedApplication.CreatedBy = CreatedBy;
                var o =  _installedApplicationRepo.Insert(installedApplication);
                return o;
            }
            else
            {
                return obj;
            }
        }

        public InstalledApplication UnInstallApplication(string PackageName, long UpdatedBy)
        {
            var obj = _dbContext.InstalledApplications.Where(x => x.PackageName == PackageName && x.Deleted == false).FirstOrDefault();
            obj.Deleted = true;
            obj.UpdatedDate = DateTime.Now;
            obj.UpdatedBy = UpdatedBy;
            _dbContext.SaveChanges();
            return obj;
        }
    }
}
