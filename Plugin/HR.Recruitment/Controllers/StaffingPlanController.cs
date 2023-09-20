using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.Emp;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;

namespace HR.Recruitment.Controllers
{
	[Area(AreaNames.Recruitment)]
    public class StaffingPlanController : BasePluginController
    {
        private readonly IStaffingPlanService _staffingPlanService;
		private readonly IDepartmentService _departmentService;
		private readonly IStaffingPlanDetailsService _staffingPlanDetailsService;
		private readonly IEmployeeService _employeeService;

        private readonly IDesignationService _designationService;
		public StaffingPlanController(IStaffingPlanService staffingPlanService, IDepartmentService departmentService,
           IDesignationService designationService, IStaffingPlanDetailsService staffingPlanDetailsService, IEmployeeService employeeService

			)
        {

            _staffingPlanService = staffingPlanService;
            _departmentService = departmentService;
            _designationService = designationService;
            _staffingPlanDetailsService = staffingPlanDetailsService;
            _employeeService = employeeService;

        }
        [HttpGet]
        public IActionResult StaffingPlanCreate(int? staffingPlanId)
        {
            StaffingPlanDTO staffingPlanDTO = new StaffingPlanDTO();

			var department = _departmentService.GetDepartmentList();
			ViewBag.Department = department;

			var employees = _employeeService.GetEmployees();
			ViewBag.Employees = employees;

			if (staffingPlanId != null)
            {

                StaffingPlan d = _staffingPlanService.GetStaffingPlanByStaffingPlanId(int.Parse(staffingPlanId.ToString()));

                staffingPlanDTO.PlanName = d.PlanName;
                staffingPlanDTO.FromDate = d.FromDate;
                staffingPlanDTO.ToDate = d.ToDate;
                staffingPlanDTO.DepartmentId = d.DepartmentId;


                var StaffingPlanDetails = _staffingPlanDetailsService.StaffingPlanDetailsByStaffingPlanId(int.Parse(staffingPlanId.ToString()));
                staffingPlanDTO.StaffingPlanDetails = new List<StaffingPlanDetailsDTO>();
                for (int i = 0; i < StaffingPlanDetails.Count; i++)
                {
                    staffingPlanDTO.StaffingPlanDetails.Add(new StaffingPlanDetailsDTO
                    {
                        DesignationId = StaffingPlanDetails[i].DesignationId,
                        NoOfVacancies = StaffingPlanDetails[i].NoOfVacancies,
                        EstimatedCostPerPosition = StaffingPlanDetails[i].EstimatedCostPerPosition,
                        StaffingPlanId = StaffingPlanDetails[i].StaffingPlanId,

                    });
                }



                staffingPlanDTO.StaffingPlanDetailsString = JsonConvert.SerializeObject(staffingPlanDTO.StaffingPlanDetails);

            }
            else
            {
                staffingPlanDTO.StaffingPlanDetails = new List<StaffingPlanDetailsDTO>();
              
            }
            ViewBag.desgnations = _designationService.GetDesignationList();
			return View("~/Plugins/HR.Recruitment/Views/StaffingPlan/StaffingPlanCreate.cshtml", staffingPlanDTO);

        }
        [HttpPost]
        public IActionResult StaffingPlanCreate(StaffingPlanDTO staffingPlanDTO)
        {
            staffingPlanDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (staffingPlanDTO.StaffingPlanId == null)
                {
                    var a = _staffingPlanService.StaffingPlanCreate(staffingPlanDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Recruitment/StaffingPlan/StaffingPlanView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "StaffingPlan Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _staffingPlanService.StaffingPlanUpdate(staffingPlanDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Recruitment/StaffingPlan/StaffingPlanView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "StaffingPlan Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }

			var employees = _employeeService.GetEmployees();
			ViewBag.Employees = employees;

			var department = _departmentService.GetDepartmentList();
			ViewBag.Department = department;
			return View("~/Plugins/HR.Recruitment/Views/StaffingPlan/StaffingPlanCreate.cshtml", staffingPlanDTO);
        }
        public IActionResult StaffingPlanView()
        {
            ViewBag.staffingPlans = _staffingPlanService.GetStaffingPlans();

            return View("~/Plugins/HR.Recruitment/Views/StaffingPlan/StaffingPlanView.cshtml");
        }

        [HttpGet]
        public IActionResult StaffingPlanDelete(int staffingPlanId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _staffingPlanService.StaffingPlanDelete(staffingPlanId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Recruitment/StaffingPlan/StaffingPlanView");
        }

    }
}
