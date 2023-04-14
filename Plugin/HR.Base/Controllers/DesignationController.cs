using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
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
		public IActionResult DesignationCreate(DesignationDTO designationDTO)
		{
			designationDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


			if (ModelState.IsValid)
			{
				if (designationDTO.DesignationId == null)
				{
					var a = _designationService.CreateDesignation(designationDTO);
					if (a == MennsageEnum.Success)
					{
						return Redirect("/HR/Designation/DesignationView");
					}
					else if (a == MennsageEnum.Duplicate)
					{
						ModelState.AddModelError("", "Designation Already Exists");
					}
					else
					{
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _designationService.DesignationUpdate(designationDTO);
					if (a == MennsageEnum.Updated)
					{
						return Redirect("/HR/Designation/DesignationView");
					}
					else if (a == MennsageEnum.Duplicate)
					{
						ModelState.AddModelError("", "Designation Already Exists");
					}
					else
					{
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}
			//ViewBag.ParentDepartmentList = new SelectList((System.Collections.IEnumerable)_departmentService.GetAllDepartmentGroups(), "DepartmentId", "DepartmentName");

			return View("~/Plugins/HR.Base/Views/Designation/DesignationCreate.cshtml", designationDTO);
		}
		public IActionResult DesignationView()
		{
			ViewBag.designations = _designationService.GetDesignationList();

			return View("~/Plugins/Hr.Base/Views/Designation/DesignationView.cshtml");
		}

        [HttpGet]
        public IActionResult DeleteDesignation(Int64 designationId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _designationService.DesignationDelete(designationId, DeletedBy);
            return Redirect("/HR/Designation/DesignationView");
        }
    }
}
