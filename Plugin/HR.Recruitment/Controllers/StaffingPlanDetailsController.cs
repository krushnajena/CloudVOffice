using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Recruitment;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Services.Recruitment;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HR.Recruitment.Controllers
{
    [Area(AreaNames.Recruitment)]
    public class StaffingPlanDetailsController : BasePluginController
    {
        private readonly IStaffingPlanDetailsService _StaffingPlanDetailsService;
        private readonly IDesignationService _designationService;
		public StaffingPlanDetailsController (IStaffingPlanDetailsService StaffingPlanDetailsService, IDesignationService designationService)
        {

			_StaffingPlanDetailsService = StaffingPlanDetailsService;
            _designationService = designationService;

		}

        [HttpGet]
        public IActionResult CreateStaffingPlanDetails(int? StaffingPlanDetailsId)
        {
            StaffingPlanDetailsDTO staffingPlanDetailsDTO = new StaffingPlanDetailsDTO();
			var desgination = _designationService.GetDesignationList();
			ViewBag.Designation = desgination;
			if (StaffingPlanDetailsId != null)
            {

                var d = _StaffingPlanDetailsService.GetStaffingPlanDetailsById(int.Parse(StaffingPlanDetailsId.ToString()));

                staffingPlanDetailsDTO.DesignationId = d.DesignationId;
                staffingPlanDetailsDTO.NoOfVacancies = d.NoOfVacancies;
                staffingPlanDetailsDTO.EstimatedCostPerPosition = d.EstimatedCostPerPosition;

            }

            return View("~/Plugins/HR.Recruitment/Views/StaffingPlanDetails/CreateStaffingPlanDetails.cshtml", staffingPlanDetailsDTO);

        }

        [HttpPost]
        public IActionResult CreateStaffingPlanDetails(StaffingPlanDetailsDTO staffingPlanDetailsDTO)
        {
            staffingPlanDetailsDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (staffingPlanDetailsDTO.StaffingPlanDetailsId == null)
                {
                    var a = _StaffingPlanDetailsService.CreateStaffingPlanDetails(staffingPlanDetailsDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Recruitment/StaffingPlanDetails/StaffingPlanDetailsView");
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
                    var a = _StaffingPlanDetailsService.StaffingPlanDetailsUpdate(staffingPlanDetailsDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Recruitment/StaffingPlanDetails/StaffingPlanDetailsView");
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
			return View("~/Plugins/HR.Recruitment/Views/StaffingPlanDetails/CreateStaffingPlanDetails.cshtml", staffingPlanDetailsDTO);
        }

        [Authorize(Roles = "HR Manager")]
        public IActionResult StaffingPlanDetailsView()
        {
            ViewBag.StaffingPlanDetails = _StaffingPlanDetailsService.GetStaffingPlanDetailsList();

            return View("~/Plugins/HR.Recruitment/Views/StaffingPlanDetails/StaffingPlanDetailsView.cshtml");
        }

        [HttpGet]
        public IActionResult DeleteStaffingPlanDetails(int staffingPlanDetailsId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _StaffingPlanDetailsService.StaffingPlanDetailsDelete(staffingPlanDetailsId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Recruitment/StaffingPlanDetails/StaffingPlanDetailsView");
        }

    }
}
