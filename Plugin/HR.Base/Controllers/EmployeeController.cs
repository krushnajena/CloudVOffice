using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Services.HR.Master;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudVOffice.Services.Emp;
using CloudVOffice.Data.DTO.Emp;
using CloudVOffice.Core.Domain.HR.Emp;

namespace HR.Base.Controllers
{
	public class EmployeeController : BasePluginController
	{
		private readonly IEmpolyeeService _empolyeeService;
		public EmployeeController(IEmpolyeeService empolyeeService)
		{
			_empolyeeService = empolyeeService;
		}

		[HttpGet]
		public IActionResult EmployeeCreat(int? EmployeeCode)
		{
			EmployeeCreateDTO employeeCreateDTO = new EmployeeCreateDTO();
			ViewBag.ParentDepartmentList = new SelectList(_empolyeeService.GetBranches(), "BranchId", "BranchName");
			if (EmployeeCode != null)
			{

				Employee d = _empolyeeService.GetEmployeeByCode(string.Concat(EmployeeCode.ToString()));

				employeeCreateDTO.EmployeeCode = d.EmployeeCode;
				employeeCreateDTO.Salutation = d.Salutation;
				employeeCreateDTO.FirstName = d.FirstName;
				employeeCreateDTO.MiddleName = d.MiddleName;
				employeeCreateDTO.LastName = d.LastName;
				employeeCreateDTO.Gender = d.Gender;
				employeeCreateDTO.DateOfJoining = d.DateOfJoining;
				employeeCreateDTO.DateOfBirth = d.DateOfBirth;
				employeeCreateDTO.ErpUser = d.ErpUser;
				employeeCreateDTO.MobileNo = d.MobileNo;
				employeeCreateDTO.PersonalEmail = d.PersonalEmail;
				employeeCreateDTO.CompanyEmail = d.CompanyEmail;
				employeeCreateDTO.CurrentAddress = d.CurrentAddress;
				employeeCreateDTO.PermanentAddress = d.PermanentAddress;
				employeeCreateDTO.EmergencyContactName = d.EmergencyContactName;
				employeeCreateDTO.EmergencyPhone = d.EmergencyPhone;
				employeeCreateDTO.Status = d.Status;

			}

			return View("~/Plugins/HR.Base/Views/Employee/EmployeeCreate.cshtml", employeeCreateDTO);

		}

		[HttpPost]
		public IActionResult EmployeeCreate(EmployeeCreateDTO employeeCreateDTO)
		{
			if (ModelState.IsValid)
			{
				if (employeeCreateDTO.EmployeeCode == null)
				{
					var a = _empolyeeService.CreateEmployee(employeeCreateDTO);
					if (a == null)
					{
						return Redirect("/HR/Employee/EmployeeList");
					}
					else if (a != null)
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
					var a = _empolyeeService.UpdateEmployee(employeeCreateDTO);
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
			ViewBag.ParentEmployeeList = new SelectList((System.Collections.IEnumerable)_empolyeeService.GetEmps(), "EmployeeCode", "EmployeeName");

			return View("~/Plugins/HR.Base/Views/Employee/EmployeeCreate.cshtml", employeeCreateDTO);
		}
	}
}
