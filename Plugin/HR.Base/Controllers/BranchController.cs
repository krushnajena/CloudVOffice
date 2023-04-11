using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Services.Users;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HR.Base.Controllers
{
    [Area(AreaNames.HR)]
    public class BranchController : BasePluginController
    {
        private readonly IBranchService _branchService;
        public BranchController(IBranchService branchService) {
        
            _branchService= branchService;
        }
        [HttpGet]
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
        public IActionResult BranchCreate(BranchDTO branchDTO)
        {
			branchDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
            {
                if (branchDTO.BranchId == null)
                {
                    var a = _branchService.BranchCreate(branchDTO);
                    if (a == "Success")
                    {
                        return Redirect("/HR/Branch/BranchList");
                    }
                    else if (a == "duplicate")
                    {
                        ModelState.AddModelError("", "Branch Already Exists");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _branchService.BranchUpdate(branchDTO);
                    if (a == "success")
                    {

                    }
                    else if (a == "duplicate")
                    {
                        ModelState.AddModelError("", "Branch Already Exists");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
            //ViewBag.ParentDepartmentList = new SelectList((System.Collections.IEnumerable)_departmentService.GetAllDepartmentGroups(), "DepartmentId", "DepartmentName");

            return View("~/Plugins/HR.Base/Views/Branch/BranchCreate.cshtml", branchDTO);
        }

        public IActionResult BranchView()
        {
            ViewBag.branches = _branchService.GetBranches();

            return View("~/Plugins/Hr.Base/Views/Branch/BranchView.cshtml");
        }

    }
}
