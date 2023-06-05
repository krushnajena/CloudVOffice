using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Accounts;
using CloudVOffice.Data.DTO.Accounts;
using CloudVOffice.Services.Accounts;
using CloudVOffice.Services.Users;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Accounts.Base.Controllers
{
    [Area(AreaNames.Accounts)]
    public class FinancialYearController : BasePluginController
    {
        private readonly IFinancialYearService _FinancialYearService;
        public FinancialYearController(IFinancialYearService FinancialYearService)
        {

            _FinancialYearService = FinancialYearService;
        }
        [HttpGet]

        public IActionResult FinancialYearCreate(int? FinancialYearId)
        {
            FinancialYearDTO FinancialYearDTO = new FinancialYearDTO();
            
            if (FinancialYearId != null)
            {

                FinancialYear d = _FinancialYearService.GetFinancialYearByFinancialYearId(int.Parse(FinancialYearId.ToString()));

                FinancialYearDTO.FinancialYearName = d.FinancialYearName;

            }

            return View("~/Plugins/Accounts.Base/Views/FinancialYear/FinancialYearCreate.cshtml", FinancialYearDTO);

        }

        [HttpPost]
     
        public IActionResult FinancialYearCreate(FinancialYearDTO FinancialYearDTO)
        {
            FinancialYearDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (FinancialYearDTO.FinancialYearName == null)
                {
                    var a = _FinancialYearService.CreateFinancialYear(FinancialYearDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Accounts/FinancialYear/FinancialYearView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "FinancialYear Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _FinancialYearService.FinancialYearUpdate(FinancialYearDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Accounts/FinancialYear/FinancialYearView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "FinancialYear Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
            return View("~/Plugins/Accounts.Base/Views/FinancialYear/FinancialYearCreate.cshtml", FinancialYearDTO);
        }

       
        public IActionResult FinancialYearView()
        {
            ViewBag.FinancialYears = _FinancialYearService.GetFinancialYearList();

            return View("~/Plugins/Accounts.Base/Views/FinancialYear/FinancialYearView.cshtml");
        }

        [HttpGet]
     
        public IActionResult FinancialYearDelete(int FinancialYearId)
        {
            Int64 DeletedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _FinancialYearService.FinancialYearDelete(FinancialYearId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Accounts/FinancialYear/FinancialYearView");
        }

    }
}
