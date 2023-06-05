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
    public class FinacialYearControllers : BasePluginController
    {
        private readonly IFinancialYearService _financialYearService;
        public FinacialYearControllers(IFinancialYearService financialYearService)
        {

            _financialYearService = financialYearService;
        }
        [HttpGet]

        public IActionResult FinancialYearCreate(int? financialYearId)
        {
            FinancialYearDTO financialYearDTO = new FinancialYearDTO();
            
            if (financialYearId != null)
            {

                FinancialYear d = _financialYearService.GetFinancialYearByFinancialYearId(int.Parse(financialYearId.ToString()));

                financialYearDTO.FinancialYearName = d.FinancialYearName;

            }

            return View("~/Plugins/Accounts.Base/Views/FinancialYear/FinancialYearCreate.cshtml", financialYearDTO);

        }

        [HttpPost]
     
        public IActionResult FinancialYearCreate(FinancialYearDTO financialYearDTO)
        {
            financialYearDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (financialYearDTO.FinancialYearName == null)
                {
                    var a = _financialYearService.CreateFinancialYear(financialYearDTO);
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
                    var a = _financialYearService.FinancialYearUpdate(financialYearDTO);
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
            return View("~/Plugins/Accounts.Base/Views/FinancialYear/FinancialYearCreate.cshtml", financialYearDTO);
        }

       
        public IActionResult financialYearView()
        {
            ViewBag.financialYears = _financialYearService.GetFinancialYearList();

            return View("~/Plugins/Accounts.Base/Views/FinancialYear/FinancialYearView.cshtml");
        }

        [HttpGet]
     
        public IActionResult FinancialYearDelete(int financialYearId)
        {
            Int64 DeletedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _financialYearService.FinancialYearDelete(financialYearId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Accounts/FinancialYear/FinancialYearView");
        }

    }
}
