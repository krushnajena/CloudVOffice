using CloudVOffice.Services.HR.Master;
using CloudVOffice.Services.Users;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult BranchView()
        {
            ViewBag.branches = _branchService.GetBranches();

            return View("~/Plugins/Hr.Base/Views/Branch/BranchView.cshtml");
        }

    }
}
