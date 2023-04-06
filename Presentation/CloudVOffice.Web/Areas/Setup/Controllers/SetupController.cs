using CloudVOffice.Web.Framework;
using Microsoft.AspNetCore.Mvc;

namespace CloudVOffice.Web.Areas.Setup.Controllers
{
    [Area(AreaNames.Setup)]
    public class SetupController : Controller
    {
        public IActionResult DashBoard()
        {
            return View();
        }
    }
}
