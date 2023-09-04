using CloudVOffice.Services.Recruitment;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Recruitment.Controllers
{
	[Area(AreaNames.Recruitment)]
	public class ScheduleInterviewController : BasePluginController
	{
		private readonly IJobOpeningService _jobOpeningService;
		public ScheduleInterviewController(IJobOpeningService jobOpeningService)
		{
			_jobOpeningService= jobOpeningService;
		}

		public IActionResult ScheduleInterView()
		{
			ViewBag.JobOpenings = _jobOpeningService.GetJobOpeningsList();
			return View("~/Plugins/HR.Recruitment/Views/ScheduleInterview/ScheduleInterview.cshtml");
		}
	}
}
