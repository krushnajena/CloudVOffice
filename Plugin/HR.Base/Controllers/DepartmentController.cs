using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Base.Controllers
{
    [Area(AreaNames.HR)]
    public class DepartmentController : BasePluginController
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public IActionResult DepartmentCreate(int? DepartmentId)
        {
            DepartmentDTO departmentDTO = new DepartmentDTO();
            ViewBag.ParentDepartmentList = new SelectList(_departmentService.GetAllDepartmentGroups(), "DepartmentId", "DepartmentName");
            if (DepartmentId != null)
            {

                Department d = _departmentService.GetDepartmentById(int.Parse(DepartmentId.ToString()));
              
                departmentDTO.DepartmentName = d.DepartmentName;
                departmentDTO.IsGroup = d.IsGroup;
                departmentDTO.Parent = d.Parent;
            }
            
            return View("~/Plugins/HR.Base/Views/Department/DepartmentCreate.cshtml", departmentDTO);

        }

        [HttpPost]
        public IActionResult DepartmentCreate(DepartmentDTO departmentDTO)
        {
            if (ModelState.IsValid)
            {
				if (departmentDTO.DepartmentId == null)
				{
                    var a = _departmentService.CreateDepartment(departmentDTO);
                    if (a == "success")
                    {
                        return Redirect("/HR/Department/DepartmentList");
                    }
                    else if (a == "duplicate")
                    {
						ModelState.AddModelError("", "Department Already Exists");
					}
					else 
					{
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
                else
                {
					var a = _departmentService.DepartmentUpdate(departmentDTO);
					if (a == "success")
					{

					}
					else if (a == "duplicate")
					{
						ModelState.AddModelError("", "Department Already Exists");
					}
					else
					{
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}
			ViewBag.ParentDepartmentList = new SelectList((System.Collections.IEnumerable)_departmentService.GetAllDepartmentGroups(), "DepartmentId", "DepartmentName");

			return View("~/Plugins/HR.Base/Views/Department/DepartmentCreate.cshtml", departmentDTO);
        }

        public IActionResult DepartmentView()
        {
            ViewBag.Departments = _departmentService.GetDepartmentList();

            return View("~/Plugins/Hr.Base/Views/Department/DepartmentView.cshtml");
        }
    }
}
