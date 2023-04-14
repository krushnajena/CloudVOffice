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

namespace HR.Base.Controllers
{
    [Area(AreaNames.HR)]
    public class EmployeeController : BasePluginController
	{
		private readonly IEmployeeService _empolyeeService;
		public EmployeeController(IEmployeeService empolyeeService)
		{
			_empolyeeService = empolyeeService;
		}

		[HttpGet]
		public IActionResult EmployeeCreate(int? EmployeeCode)
		{
			EmployeeCreateDTO employeeCreateDTO = new EmployeeCreateDTO();
			ViewBag.employee = new SelectList(_empolyeeService.GetEmps(), "EmployeeId", "EmployeeName");
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
				employeeCreateDTO.Status = d.Status;
				employeeCreateDTO.DepartmentId = d.DepartmentId;
				employeeCreateDTO.DesignationId = d.DesignationId;
				employeeCreateDTO.BranchId = d.BranchId;
				employeeCreateDTO.EmploymentTypeId = d.EmploymentTypeId;
				employeeCreateDTO.ReportToEmployeeId = d.ReportToEmployeeId;
				employeeCreateDTO.JobApplicantId= d.JobApplicantId;
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
			employeeCreateDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "EmployeeId").Value.ToString());

			if (ModelState.IsValid)
			{
				if (employeeCreateDTO.EmployeeCode == null)
				{
					var a = _empolyeeService.CreateEmployee(employeeCreateDTO);
					if (a == MennsageEnum.Success)
					{
						return Redirect("/HR/Emplyoee/BranchList");
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
					if (a == MennsageEnum.Updated)
					{
						return Redirect("/HR/Emplyoee/EmplyoeeList");
					}
					else if (a == MennsageEnum.Duplicate)
					{
						ModelState.AddModelError("", "Branch Already Exists");
					}
					else
					{
						ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}

			//ViewBag.ParentEmployeeList = new SelectList((System.Collections.IEnumerable)_empolyeeService.GetEmps(), "EmployeeCode", "EmployeeName");

			return View("~/Plugins/HR.Base/Views/Employee/EmployeeCreate.cshtml", employeeCreateDTO);
		}

		public IActionResult employeeView()
		{
			ViewBag.Employees = _empolyeeService.GetEmps();

			return View("~/Plugins/Hr.Base/Views/Employee/EmployeeView.cshtml");
		}
	}
}
