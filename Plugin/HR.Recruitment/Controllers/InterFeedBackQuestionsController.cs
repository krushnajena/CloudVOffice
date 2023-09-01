using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.HR.Master;
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
    public class InterFeedBackQuestionsController : BasePluginController
    {
        private readonly IInterFeedBackQuestionsService _interFeedBackQuestionsService;
        private readonly IDesignationService _designationService;
        private readonly IInterviewRoundService _interviewRoundService;

        public InterFeedBackQuestionsController(IInterFeedBackQuestionsService interFeedBackQuestionsService, IDesignationService designationService, IInterviewRoundService interviewRoundService)
        {
            _interFeedBackQuestionsService = interFeedBackQuestionsService;
            _designationService = designationService;
            _interviewRoundService = interviewRoundService;
        }

        [HttpGet]
        public IActionResult InterFeedBackQuestionsCreate(int? interFeedBackQuestionsId)
        {
            InterFeedBackQuestionsDTO interFeedBackQuestionsDTO = new InterFeedBackQuestionsDTO();

            var interviewRound = _interviewRoundService.GetInterviewRoundsList();
            ViewBag.InterviewRound = interviewRound;

            var desgination = _designationService.GetDesignationList();
            ViewBag.Designation = desgination;


            if (interFeedBackQuestionsId != null)
            {

                var d = _interFeedBackQuestionsService.GetInterFeedBackQuestionsById(int.Parse(interFeedBackQuestionsId.ToString()));

                interFeedBackQuestionsDTO.DesignationId = d.DesignationId;
                interFeedBackQuestionsDTO.InterviewRoundId = d.InterviewRoundId;
                interFeedBackQuestionsDTO.Question = d.Question;
                interFeedBackQuestionsDTO.Mark = d.Mark;

            }

            return View("~/Plugins/HR.Recruitment/Views/InterFeedBackQuestions/InterFeedBackQuestionsCreate.cshtml", interFeedBackQuestionsDTO);

        }


        [HttpPost]
        public IActionResult InterFeedBackQuestionsCreate(InterFeedBackQuestionsDTO interFeedBackQuestionsDTO)
        {
            interFeedBackQuestionsDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (interFeedBackQuestionsDTO.InterFeedBackQuestionsId == null)
                {
                    var a = _interFeedBackQuestionsService.InterFeedBackQuestionsCreate(interFeedBackQuestionsDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Recruitment/InterFeedBackQuestions/InterFeedBackQuestionsView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "InterFeedBackQuestions Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _interFeedBackQuestionsService.InterFeedBackQuestionsUpdate(interFeedBackQuestionsDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Recruitment/InterFeedBackQuestions/InterFeedBackQuestionsView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "InterFeedBackQuestions Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }

            var interviewRound = _interviewRoundService.GetInterviewRoundsList();
            ViewBag.InterviewRound = interviewRound;

            var desgination = _designationService.GetDesignationList();
            ViewBag.Designation = desgination;

            return View("~/Plugins/HR.Recruitment/Views/InterFeedBackQuestions/InterFeedBackQuestionsCreate.cshtml", interFeedBackQuestionsDTO);
        }

        public IActionResult InterFeedBackQuestionsView()
        {
            ViewBag.interFeedBackQuestions = _interFeedBackQuestionsService.GetInterFeedBackQuestionsList();

            return View("~/Plugins/HR.Recruitment/Views/InterFeedBackQuestions/InterFeedBackQuestionsView.cshtml");
        }



        [HttpGet]
        public IActionResult InterFeedBackQuestionsDelete(int interFeedBackQuestionsId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _interFeedBackQuestionsService.InterFeedBackQuestionsDelete(interFeedBackQuestionsId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Recruitment/InterFeedBackQuestions/InterFeedBackQuestionsView");
        }


    }
}
