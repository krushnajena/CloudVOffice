using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Base.Controllers
{
	[Area(AreaNames.HR)]
	public class DesignationController : BasePluginController
	{
		private readonly IDesignationService _designationService;
		public DesignationController(IDesignationService designationService)
		{

			_designationService = designationService;
		}
		[HttpGet]
        [Authorize(Roles = "HR Manager")]
        public IActionResult DesignationCreate(int? designationId)
		{
			DesignationDTO designationDTO = new DesignationDTO();
			//ViewBag.ParentDepartmentList = new SelectList(_branchService.GetBranches(), "BranchId", "BranchName");
			if (designationId != null)
			{

				Designation d = _designationService.GetDesignationById(int.Parse(designationId.ToString()));

				designationDTO.DesignationName = d.DesignationName;
				designationDTO.Description = d.Description;

			}

			return View("~/Plugins/HR.Base/Views/Designation/DesignationCreate.cshtml", designationDTO);

		}
		[HttpPost]
        [Authorize(Roles = "HR Manager")]
        public IActionResult DesignationCreate(DesignationDTO designationDTO)
		{
			designationDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
			{
				if (designationDTO.DesignationId == null)
				{
					var a = _designationService.CreateDesignation(designationDTO);
					if (a == MessageEnum.Success)
					{
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/HR/Designation/DesignationView");
					}
					else if (a == MessageEnum.Duplicate)
					{
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "Designation Already Exists");
					}
					else
					{
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _designationService.DesignationUpdate(designationDTO);
					if (a == MessageEnum.Updated)
					{
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/HR/Designation/DesignationView");
					}
					else if (a == MessageEnum.Duplicate)
					{
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "Designation Already Exists");
					}
					else
					{
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}
			//ViewBag.ParentDepartmentList = new SelectList((System.Collections.IEnumerable)_departmentService.GetAllDepartmentGroups(), "DepartmentId", "DepartmentName");

			return View("~/Plugins/HR.Base/Views/Designation/DesignationCreate.cshtml", designationDTO);
		}
        [Authorize(Roles = "HR Manager")]
        public IActionResult DesignationView()
		{
			ViewBag.designations = _designationService.GetDesignationList();

			return View("~/Plugins/Hr.Base/Views/Designation/DesignationView.cshtml");
		}

        [HttpGet]
        [Authorize(Roles = "HR Manager")]
        public IActionResult DeleteDesignation(Int64 designationId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _designationService.DesignationDelete(designationId, DeletedBy);
			TempData["msg"] = a;
            return Redirect("/HR/Designation/DesignationView");
        }
    }
}
