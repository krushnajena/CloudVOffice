using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.DesktopMonitoring;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Services.DesktopMonitoring;
using CloudVOffice.Services.HR.Master;

using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Desktop.Monitoring.Controllers
{
    [Area(AreaNames.DesktopMonitoring)]
    public class RestrictedApplicationController : BasePluginController
    {

        private readonly IRestrictedApplicationService _restrictedApplicationService;
        private readonly IDepartmentService _departmentService;

        public RestrictedApplicationController(IRestrictedApplicationService restrictedApplicationService, IDepartmentService departmentService)
        {

            _restrictedApplicationService = restrictedApplicationService;
            _departmentService = departmentService;
        }
        [HttpGet]
        [Authorize(Roles = "Desktop Monitoring Manager")]
        public IActionResult RestrictedApplicationCreate(Int64? RestrictedApplicationId)
        {
            RestrictedApplicationDTO restrictedApplicationDTO = new RestrictedApplicationDTO();

            var department = _departmentService.GetDepartmentList();
            ViewBag.Department = department;
            if (RestrictedApplicationId != null)
            {

                RestrictedApplication d = _restrictedApplicationService.GetRestrictedApplicationById(int.Parse(RestrictedApplicationId.ToString()));

                restrictedApplicationDTO.RestrictedApplicationName = d.RestrictedApplicationName;
                restrictedApplicationDTO.DepartmentId = d.DepartmentId;

            }

            return View("~/Plugins/Desktop.Monitoring/Views/RestrictedApplication/RestrictedApplicationCreate.cshtml", restrictedApplicationDTO);

        }
        [HttpPost]
        [Authorize(Roles = "Desktop Monitoring Manager")]
        public IActionResult RestrictedApplicationCreate(RestrictedApplicationDTO restrictedApplicationDTO)
        {
            restrictedApplicationDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (restrictedApplicationDTO.RestrictedApplicationId == null)
                {
                    var a = _restrictedApplicationService.RestrictedApplicationCreate(restrictedApplicationDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/DesktopMonitoring/RestrictedApplication/RestrictedApplicationView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "RestrictedApplication Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _restrictedApplicationService.RestrictedApplicationUpdate(restrictedApplicationDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/DesktopMonitoring/RestrictedApplication/RestrictedApplicationView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "RestrictedApplication Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }

            var department = _departmentService.GetDepartmentList();
            ViewBag.Department = department;
            return View("~/Plugins/Desktop.Monitoring/Views/RestrictedApplication/RestrictedApplicationCreate.cshtml", restrictedApplicationDTO);
        }
        public IActionResult RestrictedApplicationView()
        {
            ViewBag.RestrictedApplication = _restrictedApplicationService.GetRestrictedApplication();

            return View("~/Plugins/Desktop.Monitoring/Views/RestrictedApplication/RestrictedApplicationView.cshtml");
        }

        [HttpGet]
        [Authorize(Roles = "Desktop Monitoring Manager")]
        public IActionResult RestrictedApplicationDelete(Int64 RestrictedApplicationId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _restrictedApplicationService.RestrictedApplicationDelete(RestrictedApplicationId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/DesktopMonitoring/RestrictedApplication/RestrictedApplicationView");
        }
    }
}
