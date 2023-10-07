using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.Emp;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Services.Recruitment.JA;
using CloudVOffice.Services.Recruitment.JO;
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
    public class JobApplicationController : BasePluginController
    {
        private readonly IJobApplicationService _jobApplicationService;
        private readonly IJobOpeningService _jobOpeningService;
        private readonly ICandidateService _candidateService;
        private readonly IJobApplicationStatusService _jobApplicationStatusService;
        private readonly IEmployeeService _employeeService;
        public JobApplicationController(IJobApplicationService jobApplicationService, IJobOpeningService jobOpeningService,
            ICandidateService candidateService, IJobApplicationStatusService jobApplicationStatusService, IEmployeeService employeeService)
        {
            _jobApplicationService = jobApplicationService;
            _jobOpeningService = jobOpeningService;
            _candidateService = candidateService;
            _jobApplicationStatusService = jobApplicationStatusService;
            _employeeService = employeeService;
        }
        public IActionResult JobApplication(int JobId)
        {
            var job = _jobOpeningService.GetJobOpeningByJobOpeningId(JobId);
           
             List<int> skills = new List<int>();
            var skil = job.JobOpeningSkills.ToList();
             for(int i=0;i< skil.Count; i++)
             {
                 skills.Add(skil[i].SkillId);
             }
             int exp = 0;
             if(job.WorkExperience == "Fresher")
             {
                 exp = 0;
             }
             else if (job.WorkExperience == "0-1 year")
             {
                 exp = 0;
             }
             else if (job.WorkExperience == "1-3 years")
             {
                 exp = 1;
             }
             else if (job.WorkExperience == "4-5 years")
             {
                 exp = 4;
             }
             else if (job.WorkExperience == "5+ years")
             {
                 exp = 5;
             }


             var canddate = _candidateService.GetCandidateListBySkillSetAndExpLevel(skills, exp);

             ViewBag.Candidate = canddate;
             ViewBag.Jobid = JobId;

            return View("~/Plugins/HR.Recruitment/Views/JobApplication/JobApplication.cshtml");
        }
        public JsonResult JobApplicationCreate(JobApplicationDTO jobApplicationDTO)
        {
            Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _employeeService.GetEmployeeDetailsByUserId(UserId);
            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;
            }
            else
            {
                EmployeeId = 0;
            }

            jobApplicationDTO.TagId = EmployeeId;
            jobApplicationDTO.CreatedBy = UserId;
            jobApplicationDTO.Created  = DateTime.Now;
            Guid obj = Guid.NewGuid();
            jobApplicationDTO.ApplicationViewToken = obj.ToString();
            var a = _jobApplicationService.JobApplicationCreate(jobApplicationDTO);

            return Json(a);
        }

        public IActionResult SubmitForScreeningStatus(int JobId)
        {
            var a = _jobApplicationService.GetCandidateByJobApplication(JobId);
            ViewBag.candidateApplications = a;
            ViewBag.Jobid = JobId;
            
            return View("~/Plugins/HR.Recruitment/Views/JobApplication/SubmitForScreeningStatus.cshtml");
        }

    }
}

