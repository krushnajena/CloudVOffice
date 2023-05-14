using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Management.Controllers
{
    [Area(AreaNames.Projects)]
    public class TaskController : BasePluginController
    {
        public TaskController() { }
        public IActionResult Tasks(int ProjectId)
        {
            return View("~/Plugins/Project.Management/Views/Task/Tasks.cshtml");
        }
    }
}
