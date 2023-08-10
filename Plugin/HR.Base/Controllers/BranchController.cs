using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace HR.Base.Controllers
{
    [Area(AreaNames.HR)]
    public class BranchController : BasePluginController
    {
        private readonly IBranchService _branchService;
        public BranchController(IBranchService branchService)
        {

            _branchService = branchService;
        }
        [HttpGet]
        [Authorize(Roles = "HR Manager")]
        public IActionResult BranchCreate(int? branchId)
        {
            BranchDTO branchDTO = new BranchDTO();
            //ViewBag.ParentDepartmentList = new SelectList(_branchService.GetBranches(), "BranchId", "BranchName");
            if (branchId != null)
            {

                Branch d = _branchService.GetBranchByBranchId(int.Parse(branchId.ToString()));

                branchDTO.BranchName = d.BranchName;

            }

            return View("~/Plugins/HR.Base/Views/Branch/BranchCreate.cshtml", branchDTO);

        }

        [HttpPost]
        [Authorize(Roles = "HR Manager")]
        public IActionResult BranchCreate(BranchDTO branchDTO)
        {
            branchDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (branchDTO.BranchId == null)
                {
                    var a = _branchService.BranchCreate(branchDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/HR/Branch/BranchView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "Branch Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _branchService.BranchUpdate(branchDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/HR/Branch/BranchView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "Branch Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
            return View("~/Plugins/HR.Base/Views/Branch/BranchCreate.cshtml", branchDTO);
        }

        [Authorize(Roles = "HR Manager")]
        public IActionResult BranchView()
        {
            ViewBag.branches = _branchService.GetBranches();

            return View("~/Plugins/Hr.Base/Views/Branch/BranchView.cshtml");
        }

        [HttpGet]
        [Authorize(Roles = "HR Manager")]
        public IActionResult DeleteBranch(Int64 branchId)
        {
            Int64 DeletedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _branchService.BranchDelete(branchId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/HR/Branch/BranchView");
        }
    }
}
