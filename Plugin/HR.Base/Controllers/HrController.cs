using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Base.Controllers
{
    [Area(AreaNames.HR)]
    public class HrController : BasePluginController
    {
        public HrController()
        {

        }
        [HttpGet]
        [Authorize(Roles = "HR Manager, HR User")]
        public IActionResult Dashboard()
        {
            return View("~/Plugins/HR.Base/Views/Hr/Dashboard.cshtml");
        }
    }
}
