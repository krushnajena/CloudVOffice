using Microsoft.AspNetCore.Mvc;

namespace CloudVOffice.Web.Controllers
{
    public class HomeWController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
