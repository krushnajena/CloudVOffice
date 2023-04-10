using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Core.Infrastructure.Applications;
using CloudVOffice.Core.Infrastructure.JSON;
using CloudVOffice.Services.Applications;
using CloudVOffice.Services.Plugins;
using CloudVOffice.Services.Roles;
using CloudVOffice.Web.Framework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Base.Controllers
{
    [Area(AreaNames.HR)]
    public class HRBASEController:Controller
    {
        private readonly IApplicationInstallationService _applicationInstallationService;
        private readonly IRoleService _roleService;
        public HRBASEController(IApplicationInstallationService applicationInstallationService, IRoleService roleService) {
            _applicationInstallationService = applicationInstallationService;
            _roleService = roleService;
        }
        public async Task<IActionResult> Install(Int64 CreatedBy)
        {
            string jsonPath = @".\" + CloudVOfficePluginDefaults.PathName + @"\Hr.Base\";
            string pluginDetails = jsonPath + "plugin.json";
            PluginConfig item = await JsonFileReader.ReadAsync<PluginConfig>(jsonPath);
            _applicationInstallationService.InstallApplication(item.SystemName, CreatedBy);


            string rolesJsonpath = jsonPath + "roles.json";
            RoleConfig roleJson = await JsonFileReader.ReadAsync<RoleConfig>(rolesJsonpath);
            List<Role> roles = new List<Role>();
            for(int i = 0; i < roleJson.Roles.Count; i++)
            {
                Role role =  _roleService.CreateRole(roleJson.Roles[i], CreatedBy);
                roles.Add(role);
            }
            return Ok(item);    
        }
    }
}
