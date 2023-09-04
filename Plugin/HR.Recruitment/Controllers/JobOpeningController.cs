using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HR.Recruitment.Controllers
{
	[Area(AreaNames.Recruitment)]
    public class JobOpeningController : BasePluginController
    {
        private readonly IJobOpeningService _jobOpeningService;
        private readonly IDepartmentService _departmentService;
        private readonly IDesignationService _designationService;
        private readonly ISkillSetService _skillSetService;
        public JobOpeningController(IJobOpeningService jobOpeningService, IDepartmentService departmentService , IDesignationService designationService, ISkillSetService skillSetService)
        {

            _jobOpeningService = jobOpeningService;
            _departmentService = departmentService;
            _designationService = designationService;
            _skillSetService = skillSetService;
        }
        [HttpGet]
         public IActionResult JobOpeningCreate(int? jobOpeningId)
          {
            JobOpeningDTO jobOpeningDTO = new JobOpeningDTO();
			var department = _departmentService.GetDepartmentList();
			ViewBag.Department = department;
			var desgination = _designationService.GetDesignationList();
			ViewBag.Designation = desgination;
            var skillSet = _skillSetService.GetSkillSetList();
            ViewBag.skillSet = skillSet;

            if (jobOpeningId != null)
            {

                var d = _jobOpeningService.GetJobOpeningByJobOpeningId(int.Parse(jobOpeningId.ToString()));

                jobOpeningDTO.JobTitle = d.JobTitle; 
                jobOpeningDTO.DepartmentId = d.DepartmentId;
                jobOpeningDTO.DesignationId = d.DesignationId;
                jobOpeningDTO.SkillSetId = d.SkillSetId;
                jobOpeningDTO.Status = d.Status;
                jobOpeningDTO.Description = d.Description;
                jobOpeningDTO.SalaryLowerRange = d.SalaryLowerRange;
                jobOpeningDTO.SalaryUpperRange = d.SalaryUpperRange;
               

            }
			
			return View("~/Plugins/HR.Recruitment/Views/JobOpening/JobOpeningCreate.cshtml", jobOpeningDTO);

         }

        [HttpPost]
        public IActionResult JobOpeningCreate(JobOpeningDTO jobOpeningDTO)
        {
            jobOpeningDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (jobOpeningDTO.JobOpeningId == null)
                {
                    var a = _jobOpeningService.JobOpeningCreate(jobOpeningDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("~/Recruitment/JobOpening/JobOpeningView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "JobOpening Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _jobOpeningService.JobOpeningUpdate(jobOpeningDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Recruitment/JobOpening/JobOpeningView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "JobOpening Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }
			var department = _departmentService.GetDepartmentList();
			ViewBag.Department = department;
			var desgination = _designationService.GetDesignationList();
			ViewBag.Designation = desgination;
            var skillSet = _skillSetService.GetSkillSetList();
            ViewBag.skillSet = skillSet;
            return View("~/Plugins/HR.Recruitment/Views/JobOpening/JobOpeningCreate.cshtml", jobOpeningDTO);
        }
        public IActionResult JobOpeningView()
        {
            ViewBag.JobOpening = _jobOpeningService.GetJobOpeningsList();

            return View("~/Plugins/HR.Recruitment/Views/JobOpening/JobOpeningView.cshtml");
        }

        [HttpGet]
        public IActionResult JobOpeningDelete(int jobOpeningId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _jobOpeningService.JobOpeningDelete(jobOpeningId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Recruitment/JobOpening/JobOpeningView");
        }

    }
}
