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
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Web.Framework;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.AspNetCore.Authorization;

namespace HR.Base.Controllers
{
	[Area(AreaNames.HR)]
	public class EmployeeController : BasePluginController
	{
		private readonly IEmployeeService _empolyeeService;
		private readonly IDepartmentService _departmentService;
		private readonly IDesignationService _designationService;
		private readonly IBranchService _branchService;
		private readonly IEmploymentTypeService _employmentTypeService;

		public EmployeeController(IEmployeeService empolyeeService, IDepartmentService departmentService, IDesignationService designationService, IBranchService branchService, IEmploymentTypeService employmentTypeService)
		{
			_empolyeeService = empolyeeService;
			_departmentService = departmentService;
			_designationService = designationService;
			_branchService = branchService;
			_employmentTypeService = employmentTypeService;
		}

		[HttpGet]
		public IActionResult EmployeeCreate(int? employeeid)
		{
			EmployeeCreateDTO employeeCreateDTO = new EmployeeCreateDTO();
			
			var department = _departmentService.GetAllDepartmentGroups();
			var desgination = _designationService.GetDesignationList();
			var branch = _branchService.GetBranches();
			var employmentType = _employmentTypeService.GetEmploymentTypes();
		
			ViewBag.Department = department;
			ViewBag.Designation = desgination;
			ViewBag.Branch = branch;
			ViewBag.EmploymentType = employmentType;

			if (employeeid != null)
			{

				Employee d = _empolyeeService.GetEmployeeById(int.Parse(employeeid.ToString()));

				employeeCreateDTO.EmployeeCode = d.EmployeeCode;
				employeeCreateDTO.Salutation = d.Salutation;
				employeeCreateDTO.FirstName = d.FirstName;
				employeeCreateDTO.MiddleName = d.MiddleName;
				employeeCreateDTO.LastName = d.LastName;
				employeeCreateDTO.Gender = d.Gender;
				employeeCreateDTO.DateOfJoining = d.DateOfJoining;
				employeeCreateDTO.DateOfBirth = d.DateOfBirth;
				employeeCreateDTO.ErpUser = d.ErpUser;
				employeeCreateDTO.Status = d.Status;
				employeeCreateDTO.DepartmentId = d.DepartmentId;
				employeeCreateDTO.DesignationId = d.DesignationId;
				employeeCreateDTO.BranchId = d.BranchId;
				employeeCreateDTO.EmploymentTypeId = d.EmploymentTypeId;
				employeeCreateDTO.JobApplicantId = d.JobApplicantId;
				employeeCreateDTO.OfferDate = d.OfferDate;
				employeeCreateDTO.ConfirmationDate = d.ConfirmationDate;
				employeeCreateDTO.ContractEndDate = d.ContractEndDate;
				employeeCreateDTO.NoticePeriodDays = d.NoticePeriodDays;
				employeeCreateDTO.RetirementDate = d.RetirementDate;
				employeeCreateDTO.MobileNo = d.MobileNo;
				employeeCreateDTO.PersonalEmail = d.PersonalEmail;
				employeeCreateDTO.CompanyEmail = d.CompanyEmail;
				employeeCreateDTO.CurrentAddress = d.CurrentAddress;
				employeeCreateDTO.PermanentAddress = d.PermanentAddress;
				employeeCreateDTO.EmergencyContactName = d.EmergencyContactName;
				employeeCreateDTO.EmergencyPhone = d.EmergencyPhone;
				employeeCreateDTO.RelationWithEmergencyContactPerson = d.RelationWithEmergencyContactPerson;
				employeeCreateDTO.BiometricOrRfIdDeviceId = d.BiometricOrRfIdDeviceId;
				employeeCreateDTO.CTC = d.CTC;
				employeeCreateDTO.PanNo = d.PanNo;
				employeeCreateDTO.ProvidentFundAccountNo = d.ProvidentFundAccountNo;
				employeeCreateDTO.MaritalStatus = d.MaritalStatus;
				employeeCreateDTO.MarraigeDate = d.MarraigeDate;
				employeeCreateDTO.BloodGroup = d.BloodGroup;
				employeeCreateDTO.PassportNumber = d.PassportNumber;
				employeeCreateDTO.PassportDateOfIssue = d.PassportDateOfIssue;
				employeeCreateDTO.PassportValidUpto = d.PassportValidUpto;
				employeeCreateDTO.PassportPlaceOfIssue = d.PassportPlaceOfIssue;
				employeeCreateDTO.Photo = d.Photo;


			}

			return View("~/Plugins/HR.Base/Views/Employee/EmployeeCreate.cshtml", employeeCreateDTO);

		}

		[HttpPost]
		public IActionResult EmployeeCreate(EmployeeCreateDTO employeeCreateDTO)
		{
			employeeCreateDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
			if (ModelState.IsValid)
			{
				if (employeeCreateDTO.EmployeeId == null)
				{
					var a = _empolyeeService.CreateEmployee(employeeCreateDTO);

					if (a == MennsageEnum.Success)
					{
						return Redirect("/HR/Emplyoee/EmployeeView");
					}
					else if (a == MennsageEnum.Duplicate)
					{
						ModelState.AddModelError("", "Emplyoee Already Exists");
					}
					else
					{
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _empolyeeService.UpdateEmployee(employeeCreateDTO);
					if (a == MennsageEnum.Success)
					{
						return Redirect("/HR/Emplyoee/EmployeeView");
					}
					else if (a == MennsageEnum.Duplicate)
					{
						ModelState.AddModelError("", "Emplyoee Already Exists");
					}
					else
					{
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}

			ViewBag.Employee = new SelectList((System.Collections.IEnumerable)_empolyeeService.GetEmployees(), "EmployeeId", "EmployeeName");
			var department = _departmentService.GetAllDepartmentGroups();
			var desgination = _designationService.GetDesignationList();
			var branch = _branchService.GetBranches();
			var employmentType = _employmentTypeService.GetEmploymentTypes();

			ViewBag.Department = department;
			ViewBag.Designation = desgination;
			ViewBag.Branch = branch;
			ViewBag.EmploymentType = employmentType;
			return View("~/Plugins/HR.Base/Views/Employee/EmployeeCreate.cshtml", employeeCreateDTO);
		}

		public IActionResult employeeView()
		{
			ViewBag.Department = _departmentService.GetDepartmentList();
			ViewBag.Designation = _designationService.GetDesignationList();
			ViewBag.Branch = _branchService.GetBranches();
			ViewBag.EmploymentType = _employmentTypeService.GetEmploymentTypes();
			return View("~/Plugins/Hr.Base/Views/Employee/EmployeeView.cshtml");
		}

		[HttpGet]
		public IActionResult DeleteEmployee(int employeeid)
		{
			Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			var a = _empolyeeService.DeleteEmployee(employeeid, DeletedBy);
			return Redirect("/HR/Emplyoee/EmployeeView");
		}
	}
}
