using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HR.Recruitment.Controllers
{
    [Area(AreaNames.Recruitment)]
    public class InterviewTypeController : BasePluginController
    {
        private readonly IInterviewTypeService _interviewTypeService;
        public InterviewTypeController (IInterviewTypeService interviewTypeService)
        {

            _interviewTypeService = interviewTypeService;
        }
        [HttpGet]
        public IActionResult CreateInterviewType(int? InterviewTypeId)
        {
            InterviewTypeDTO interviewTypeDTO = new InterviewTypeDTO();
            if (InterviewTypeId != null)
            {

                var d = _interviewTypeService.GetInterviewTypeById(int.Parse(InterviewTypeId.ToString()));

                interviewTypeDTO.InterviewTypeName = d.InterviewTypeName;

            }

            return View("~/Plugins/HR.Recruitment/Views/InterviewType/CreateInterviewType.cshtml", interviewTypeDTO);



        }
        [HttpPost]
        public IActionResult CreateInterviewType(InterviewTypeDTO interviewTypeDTO)
        {
            interviewTypeDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (interviewTypeDTO.InterviewTypeId == null)
                {
                    var a = _interviewTypeService.CreateInterviewType(interviewTypeDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Recruitment/InterviewType/InterviewTypeView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "InterviewType Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _interviewTypeService.InterviewTypeUpdate(interviewTypeDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Recruitment/InterviewType/InterviewTypeView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "ShiftType Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
            return View("~/Plugins/HR.Recruitment/Views/InterviewType/CreateInterviewType.cshtml", interviewTypeDTO);
        }
       
        public IActionResult InterviewTypeView()
        {
            ViewBag.interviewType = _interviewTypeService.GetInterviewTypeList();

            return View("~/Plugins/HR.Recruitment/Views/InterviewType/InterviewTypeView.cshtml");
        }
        [HttpGet]
        public IActionResult DeleteInterviewType(int InterviewTypeId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _interviewTypeService.InterviewTypeDelete(InterviewTypeId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Recruitment/InterviewType/InterviewTypeView");
        }
    }
}
