using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.DesktopMonitoring;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Monitoring.Controllers
{
    [Area(AreaNames.DesktopMonitoring)]
    public class RestrictedWebsiteController : BasePluginController
    {

        private readonly IRestrictedWebsiteService _restrictedWebsiteService;
       

        public RestrictedWebsiteController(IRestrictedWebsiteService restrictedWebsiteService)
        {

            _restrictedWebsiteService = restrictedWebsiteService;
           
        }
        [HttpGet]
        public IActionResult RestrictedWebsiteCreate(Int64? RestrictedWebsiteId)
        {
            RestrictedWebsiteDTO restrictedWebsiteDTO = new RestrictedWebsiteDTO();

            if (RestrictedWebsiteId != null)
            {

                RestrictedWebsite d = _restrictedWebsiteService.GetRestrictedWebsiteByRestrictedWebsiteId(int.Parse(RestrictedWebsiteId.ToString()));

                restrictedWebsiteDTO.RestrictedWebsiteName = d.RestrictedWebsiteName;
                restrictedWebsiteDTO.DepartmentId = d.DepartmentId;
              
            }

            return View("~/Plugins/Desktop.Monitoring/Views/RestrictedWebsite/RestrictedWebsiteCreate.cshtml", restrictedWebsiteDTO);

        }
        [HttpPost]
        public IActionResult RestrictedWebsiteCreate(RestrictedWebsiteDTO restrictedWebsiteDTO)
        {
            restrictedWebsiteDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (restrictedWebsiteDTO.RestrictedWebsiteId == null)
                {
                    var a = _restrictedWebsiteService.RestrictedWebsiteCreate(restrictedWebsiteDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/DesktopMonitoring/RestrictedWebsite/RestrictedWebsiteView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "RestrictedWebsite Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _restrictedWebsiteService.RestrictedWebsiteUpdate(restrictedWebsiteDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/DesktopMonitoring/RestrictedWebsite/RestrictedWebsiteView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "RestrictedWebsite Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }

            
            return View("~/Plugins/Desktop.Monitoring/Views/RestrictedWebsite/RestrictedWebsiteCreate.cshtml", restrictedWebsiteDTO);
        }
        public IActionResult RestrictedWebsiteView()
        {
            ViewBag.restrictedWebsites = _restrictedWebsiteService.GetRestrictedWebsites();

            return View("~/Plugins/Desktop.MonitoringViews/RestrictedWebsite/RestrictedWebsiteView.cshtml");
        }

        [HttpGet]
        public IActionResult RestrictedWebsiteDelete(Int64 RestrictedWebsiteId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _restrictedWebsiteService.RestrictedWebsiteDelete(RestrictedWebsiteId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/DesktopMonitoring/StaffingPlan/RestrictedWebsiteView");
        }
    }
}
