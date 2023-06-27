using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Recruitment.Controllers
{
	[Area(AreaNames.Recruitment)]
	public class InterviewRoundController : BasePluginController
	{
		private readonly IInterviewRoundService _interviewRoundService;
		private readonly IDesignationService _designationService;
		public InterviewRoundController(IInterviewRoundService interviewRoundService, IDesignationService designationService)
		{

			_interviewRoundService = interviewRoundService;
			_designationService = designationService;

		}

		[HttpGet]
		public IActionResult CreateInterviewRound(int? InterFeedBackQuestionsId)
		{
			InterFeedBackQuestionsDTO interFeedBackQuestionsDTO = new InterFeedBackQuestionsDTO();
			var desgination = _designationService.GetDesignationList();
			ViewBag.Designation = desgination;
			if (InterFeedBackQuestionsId != null)
			{

				var d = _interviewRoundService.GetInterviewRoundById(int.Parse(InterFeedBackQuestionsId.ToString()));

				interFeedBackQuestionsDTO.DesignationId = d.DesignationId;
				interFeedBackQuestionsDTO.Question = d.Question;
				interFeedBackQuestionsDTO.Mark = d.Mark;

			}

			return View("~/Plugins/HR.Recruitment/Views/InterviewRound/CreateInterviewRound.cshtml", interFeedBackQuestionsDTO);

		}

		[HttpPost]
		public IActionResult CreateInterviewRound(InterFeedBackQuestionsDTO interFeedBackQuestionsDTO)
		{
			interFeedBackQuestionsDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
			{
				if (interFeedBackQuestionsDTO.InterFeedBackQuestionsId == null)
				{
					var a = _interviewRoundService.CreateInterviewRound(interFeedBackQuestionsDTO);
					if (a == MessageEnum.Success)
					{
						TempData["msg"] = MessageEnum.Success;
						return Redirect("/Recruitment/InterviewRound/InterviewRoundView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "Staffing Plan Details Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _interviewRoundService.InterviewRoundUpdate(interFeedBackQuestionsDTO);
					if (a == MessageEnum.Updated)
					{
						TempData["msg"] = MessageEnum.Updated;
						return Redirect("/Recruitment/InterviewRound/InterviewRoundView");
					}
					else if (a == MessageEnum.Duplicate)
					{
						TempData["msg"] = MessageEnum.Duplicate;
						ModelState.AddModelError("", "StaffingPlanDetails Already Exists");
					}
					else
					{
						TempData["msg"] = MessageEnum.UnExpectedError;
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}

			ViewBag.Designation = _designationService.GetDesignationList();
            return View("~/Plugins/HR.Recruitment/Views/InterviewRound/CreateInterviewRound.cshtml", interFeedBackQuestionsDTO);
		}

		[Authorize(Roles = "HR Manager")]
		public IActionResult InterviewRoundView()
		{
			ViewBag.InterviewRound = _interviewRoundService.GetInterviewRoundList();

			return View("~/Plugins/HR.Recruitment/Views/InterviewRound/InterviewRoundView.cshtml");
		}

		[HttpGet]
		public IActionResult DeleteInterviewRound(int InterFeedBackQuestionsId)
		{
			Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			var a = _interviewRoundService.InterviewRoundDelete(InterFeedBackQuestionsId, DeletedBy);
			TempData["msg"] = a;
			return Redirect("/Recruitment/InterviewRound/InterviewRoundView");
		}
	}
}
