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
        private readonly IUserService _userService;
        public BranchController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult BranchView()
        {
            ViewBag.Branches = _userService.GetAllUsers();
            return View("~/Plugins/HR.Base/Views/Branch/BranchView.cshtml");
        }
    
    }
}
