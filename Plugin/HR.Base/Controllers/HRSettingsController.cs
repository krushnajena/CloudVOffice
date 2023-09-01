using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.HR;
using CloudVOffice.Services.HR;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
    
namespace HR.Base.Controllers
{
    [Area(AreaNames.HR)]
    public class HRSettingsController : BasePluginController
    {
        private readonly IHRSettingsService _hrSettingsService;

        public HRSettingsController(IHRSettingsService hrSettingsService)
        {

            _hrSettingsService = hrSettingsService;

        }
        [Authorize(Roles = "HR Manager")]
        public IActionResult HRSettings(HRSettingsDTO hrSettingsDTO)
        {
            if (hrSettingsDTO.HRSettingsId != null)
            {


                var a = _hrSettingsService.HRSettingsUpdate(hrSettingsDTO);
                if (a == MessageEnum.Updated)
                {

                    return Redirect("/HR/HRSettings/HRSettings");
                }

                else
                {

                    ModelState.AddModelError("", "Un-Expected Error");
                }
                return View("~/Plugins/HR.Base/Views/HRSettings/HRSettings.cshtml", hrSettingsDTO);
            }

            HRSettingsDTO d = new HRSettingsDTO();
            d = _hrSettingsService.GetHrSettings();


            return View("~/Plugins/HR.Base/Views/HRSettings/HRSettings.cshtml", d);
        }



    }
}
