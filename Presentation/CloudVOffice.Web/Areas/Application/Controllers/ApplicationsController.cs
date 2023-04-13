using Autofac.Core;
using CloudVOffice.Core.Infrastructure.JSON;
using CloudVOffice.Services.Applications;
using CloudVOffice.Services.Plugins;
using CloudVOffice.Web.Framework;
using CloudVOffice.Core.Infrastructure.Applications;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using System.Reflection;
using System.Runtime.CompilerServices;
using CloudVOffice.Core.Infrastructure.Http;

namespace CloudVOffice.Web.Areas.Application.Controllers
{
    [Area(AreaNames.Application)]
    [Authorize(Roles ="Administrator")]
    public class ApplicationsController : Controller
    {
        private readonly IApplicationInstallationService _applicationInstallationService;
		private readonly IHttpWebClients _httpWebClient;
		public ApplicationsController(IApplicationInstallationService applicationInstallationService, IHttpWebClients httpWebClient) {
            _applicationInstallationService= applicationInstallationService;
			_httpWebClient= httpWebClient;

		}
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> InstalledApps()
        {
            var applications = _applicationInstallationService.GetInstalledApplications();
            string[] subdirs = Directory.GetDirectories(@".\"+CloudVOfficePluginDefaults.PathName);
            List<PluginConfig> pluginConfigs = new List<PluginConfig>(); 
            foreach (string folder in Directory.GetDirectories(CloudVOfficePluginDefaults.PathName))
            {
                string jsonPath = @".\" + CloudVOfficePluginDefaults.PathName + @"\" + folder.Split(@"\")[1].ToString() + @"\plugin.json";
                PluginConfig item = await JsonFileReader.ReadAsync<PluginConfig>(jsonPath);
                if(applications.Where(x=>x.PackageName == item.SystemName).Count() > 0)
                {
                    item.IsInstalled = true;
					if (applications.Where(x => x.Version < item.Version).Count() > 0)
					{
						item.IsNewVersion = true;
					}
					else
					{
						item.IsNewVersion = false;
					}
				}
                else
                {
                    item.IsInstalled = false;
                }


                pluginConfigs.Add(item);
            }
            ViewBag.apps = pluginConfigs;
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> InstallApplication(string InstallationUrl)
        {
            _httpWebClient.GetRequest(InstallationUrl + "?CreatedBy=" + Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString()));


            return Redirect("/Application/Applications/InstalledApps");
        }
    }
}
