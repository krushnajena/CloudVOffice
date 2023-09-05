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

		private readonly IScheduleInterviewService _scheduleInterviewService;
		public ScheduleInterviewController(IJobOpeningService jobOpeningService,

			IScheduleInterviewService scheduleInterviewService
			)
		{
			_jobOpeningService= jobOpeningService;
			_scheduleInterviewService = scheduleInterviewService;
		}

		public IActionResult ScheduleInterView()
		{
			ViewBag.JobOpenings = _jobOpeningService.GetJobOpeningsList();
			return View("~/Plugins/HR.Recruitment/Views/ScheduleInterview/ScheduleInterview.cshtml");
		}

		public IActionResult ScheduleInterviewCreate(Int64 RoundId, Int64 JobId, Int64 ApplicationId)
		{
			ViewBag.RoundId = RoundId;
			ViewBag.JobId = JobId;
			ViewBag.ApplicationId = ApplicationId;
			return View("~/Plugins/HR.Recruitment/Views/ScheduleInterview/ScheduleInterviewCreate.cshtml");
		}
		public JsonResult GetInterViewRoundsForSchedule(int JobId, long ApplicationId)
		{
			return Json(_scheduleInterviewService.GetInterViewRoundsForSchedule(JobId, ApplicationId));
		}
	}
}
