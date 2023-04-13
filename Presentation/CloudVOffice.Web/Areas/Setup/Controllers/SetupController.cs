using CloudVOffice.Web.Framework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CloudVOffice.Web.Areas.Setup.Controllers
{
    [Area(AreaNames.Setup)]
    public class SetupController : Controller
    {
        [Authorize(Roles = "Administrator")]
        public IActionResult DashBoard()
        {
            return View();
        }
    }
}
