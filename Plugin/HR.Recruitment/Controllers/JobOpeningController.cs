using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.Emp;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Services.Recruitment.JO;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HR.Recruitment.Controllers
{
    [Area(AreaNames.Recruitment)]
    public class JobOpeningController : BasePluginController
    {
        private readonly IJobOpeningService _jobOpeningService;
		private readonly IEmployeeService _employeeService;
		private readonly IRecruitClientContactService _recruitClientContactService;
        private readonly IRecruitClientService _recruitClientService;
        private readonly ISkillSetService _skillSetService;



        public JobOpeningController(IJobOpeningService jobOpeningService, IEmployeeService employeeService, IRecruitClientContactService recruitClientContactService, IRecruitClientService recruitClientService, ISkillSetService skillSetService)
        {

            _jobOpeningService = jobOpeningService;
			_employeeService = employeeService;
            _recruitClientContactService = recruitClientContactService;
            _recruitClientService = recruitClientService;
            _skillSetService = skillSetService;

        }
		[HttpGet]
         public IActionResult JobOpeningCreate(int? jobOpeningId)
          {
            JobOpeningDTO jobOpeningDTO = new JobOpeningDTO();
			var employee = _employeeService.GetEmployees();
			ViewBag.Employee = employee;

		
            var recruitClient = _recruitClientService.GetRecruitClientList();
            ViewBag.RecruitClient = recruitClient;
            ViewBag.Skills = _skillSetService.GetSkillSetList();

            if (jobOpeningId != null)
            {

                var d = _jobOpeningService.GetJobOpeningByJobOpeningId(int.Parse(jobOpeningId.ToString()));
				jobOpeningDTO.JobOpType = d.JobOpType;
				jobOpeningDTO.ClientID = d.ClientID;
				jobOpeningDTO.ContactId = d.ContactId;
				jobOpeningDTO.HiringManagerId = d.HiringManagerId;
				jobOpeningDTO.JobTitle = d.JobTitle;
				jobOpeningDTO.DateOpened = d.DateOpened;
				jobOpeningDTO.TargetDate = d.TargetDate;
				jobOpeningDTO.JobType = d.JobType;
				jobOpeningDTO.WorkExperience = d.WorkExperience;
				jobOpeningDTO.City = d.City;
				jobOpeningDTO.RevenuePerPosition = d.RevenuePerPosition;
				jobOpeningDTO.NumberofPositions = d.NumberofPositions;
				jobOpeningDTO.ExpectedRevenue = d.ExpectedRevenue;
				jobOpeningDTO.ActualRevenue = d.ActualRevenue;
				jobOpeningDTO.Status = d.Status;
				jobOpeningDTO.JobDescription = d.JobDescription;
				jobOpeningDTO.Requirements = d.Requirements;
				jobOpeningDTO.Benefits = d.Benefits;
				jobOpeningDTO.PublishOnWebsite = d.PublishOnWebsite;
                var skills = d.JobOpeningSkills.ToList();
                jobOpeningDTO.Skills = new List<int>();
               for (int i = 0; i < skills.Count; i++)
                {
                    jobOpeningDTO.Skills.Add(skills[i].SkillId);
                }
                var tags = d.JobOpeningTags.ToList();
                jobOpeningDTO.Tags = new List<Int64>();
                for (int i = 0; i < tags.Count; i++)
                {
                    jobOpeningDTO.Tags.Add(tags[i].TagId);
                }

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
			var employee = _employeeService.GetEmployees();
			ViewBag.Employee = employee;
            var recruitClientContact = _recruitClientContactService.GetRecruitClientContactList();
            ViewBag.RecruitClientContact = recruitClientContact;
            var recruitClient = _recruitClientService.GetRecruitClientList();
            ViewBag.RecruitClient = recruitClient;


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


		public IActionResult JobOpeningViewDetails(int jobOpeningId)
        {
            var d = _jobOpeningService.GetJobOpeningByJobOpeningId(int.Parse(jobOpeningId.ToString()));
            return View("~/Plugins/HR.Recruitment/Views/JobOpening/JobOpeningViewDetails.cshtml", d);
        }

	}
}
