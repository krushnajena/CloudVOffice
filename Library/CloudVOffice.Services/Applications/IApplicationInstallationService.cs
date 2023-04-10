using CloudVOffice.Core.Domain.Pemission;
using CloudVOffice.Data.DTO.Permission;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Applications
{
    public interface IApplicationInstallationService
    {
        public InstalledApplication InstallApplication(string PackageName,  Int64 CreatedBy, double Version);
        public List<InstalledApplication> GetInstalledApplications();

        public InstalledApplication UnInstallApplication(string PackageName, Int64 UpdatedBy);

        public Task<Application> CreateApplication(ApplicationDTO applicationDTO);

        public Task<RoleAndApplicationWisePermission> CreateRoleAndApplicationWisePermission(int RoleId ,int ApplicationId, Int64 CreatedBy);
    }
}
