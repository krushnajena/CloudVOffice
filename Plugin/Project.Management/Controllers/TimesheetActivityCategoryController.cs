using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Services.Projects;
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
    public class TimesheetActivityCategoryController : BasePluginController
    {
        private readonly ITimesheetActivityCategoryService _timesheetActivityCategoryService;
        public TimesheetActivityCategoryController(ITimesheetActivityCategoryService timesheetActivityCategoryService)
        {
            _timesheetActivityCategoryService = timesheetActivityCategoryService;
        }

        public IActionResult TimesheetActivityCategoryCreate(int? TimesheetActivityCategoryId)
        {
            TimesheetActivityCategoryDTO timesheetActivityCategory = new TimesheetActivityCategoryDTO();
            if (TimesheetActivityCategoryId != null)
            {
                var a = _timesheetActivityCategoryService.GetTimesheetActivityCategoryByTimesheetActivityCategoryId(int.Parse(TimesheetActivityCategoryId.ToString()));
                timesheetActivityCategory.TimesheetActivityCategoryName = a.TimesheetActivityCategoryName;
            }
            return View("~/Plugins/Project.Management/Views/TimesheetActivityCategory/TimesheetActivityCategoryCreate.cshtml", timesheetActivityCategory);
        }
    }
}
