using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Recruitment;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HR.Recruitment.Controllers
{
	[Area(AreaNames.Recruitment)]
    public class StaffingPlanController : BasePluginController
    {
        private readonly IStaffingPlanService _staffingPlanService;
		private readonly IDepartmentService _departmentService;

		public StaffingPlanController(IStaffingPlanService staffingPlanService, IDepartmentService departmentService)
        {

            _staffingPlanService = staffingPlanService;
            _departmentService = departmentService;

		}
        [HttpGet]
        public IActionResult StaffingPlanCreate(int? staffingPlanId)
        {
            StaffingPlanDTO staffingPlanDTO = new StaffingPlanDTO();

			var department = _departmentService.GetDepartmentList();
			ViewBag.Department = department;

			if (staffingPlanId != null)
            {

                StaffingPlan d = _staffingPlanService.GetStaffingPlanByStaffingPlanId(int.Parse(staffingPlanId.ToString()));

                staffingPlanDTO.PlanName = d.PlanName;
                staffingPlanDTO.FromDate = d.FromDate;
                staffingPlanDTO.ToDate = d.ToDate;
                staffingPlanDTO.DepartmentId = d.DepartmentId;
               

            }
			
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
