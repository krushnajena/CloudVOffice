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
using CloudVOffice.Services.Users;
using Microsoft.AspNetCore.Hosting;

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
		private readonly IUserService _userService;
		private readonly IWebHostEnvironment _hostingEnvironment;
		public EmployeeController(IWebHostEnvironment hostingEnvironment, IEmployeeService empolyeeService, IDepartmentService departmentService, IDesignationService designationService, IBranchService branchService, IEmploymentTypeService employmentTypeService, IUserService userService)
		{
			_empolyeeService = empolyeeService;
			_departmentService = departmentService;
			_designationService = designationService;
			_branchService = branchService;
			_employmentTypeService = employmentTypeService;
			_userService = userService;
			_hostingEnvironment = hostingEnvironment;
		}

		[HttpGet]
        [Authorize(Roles = "HR Manager, HR User")]
        public IActionResult EmployeeCreate(Int64? employeeid)
		{
			EmployeeCreateDTO employeeCreateDTO = new EmployeeCreateDTO();
			
			var department = _departmentService.GetDepartmentList();
			var desgination = _designationService.GetDesignationList();
			var branch = _branchService.GetBranches();
			var employmentType = _employmentTypeService.GetEmploymentTypes();
			var erpUsers = _userService.GetAllUsers();
			var ra = _empolyeeService.GetEmployees();
			ViewBag.Department = department;
			ViewBag.Designation = desgination;
			ViewBag.Branch = branch;
			ViewBag.EmploymentType = employmentType;
			ViewBag.ErpUsers = erpUsers;
			ViewBag.Ra = ra;
			if (employeeid != null)
			{

				Employee d = _empolyeeService.GetEmployeeById(Int64.Parse(employeeid.ToString()));

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
        [Authorize(Roles = "HR Manager, HR User")]
        public IActionResult EmployeeCreate(EmployeeCreateDTO employeeCreateDTO)
		{
			employeeCreateDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
			if (ModelState.IsValid)
			{
				if (employeeCreateDTO.imageUpload != null)
				{
					FileInfo fileInfo = new FileInfo(employeeCreateDTO.imageUpload.FileName);
					string extn = fileInfo.Extension.ToLower();
					Guid id = Guid.NewGuid();
					string filename = id.ToString() + extn;

					string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "uploads/employee");
					if (!Directory.Exists(uploadsFolder))
					{
						Directory.CreateDirectory(uploadsFolder);
					}
					string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
					string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
					employeeCreateDTO.imageUpload.CopyTo(new FileStream(imagePath, FileMode.Create));
					employeeCreateDTO.Photo = uniqueFileName;
				}
				if (employeeCreateDTO.EmployeeId == null)
				{
					var a = _empolyeeService.CreateEmployee(employeeCreateDTO);

					if (a == MessageEnum.Success)
					{
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/HR/Employee/EmployeeView");
					}
					else if (a == MessageEnum.AlreadyCreate)
					{
                        TempData["msg"] = MessageEnum.AlreadyCreate;
                        ModelState.AddModelError("", "Emplyoee Already Exists");
					}
					else
					{
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
					}
				}
				else
				{
					var a = _empolyeeService.UpdateEmployee(employeeCreateDTO);
					if (a == MessageEnum.Updated)
					{
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/HR/Employee/EmployeeView");
					}
					else if (a == MessageEnum.Duplicate)
					{
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "Emplyoee Already Exists");
					}
					else
					{
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
					}
				}
			}

			ViewBag.Employee = new SelectList((System.Collections.IEnumerable)_empolyeeService.GetEmployees(), "EmployeeId", "EmployeeName");
			var department = _departmentService.GetDepartmentList();
			var desgination = _designationService.GetDesignationList();
			var branch = _branchService.GetBranches();
			var employmentType = _employmentTypeService.GetEmploymentTypes();
			var erpUsers = _userService.GetAllUsers();
			var ra = _empolyeeService.GetEmployees();
			ViewBag.Department = department;
			ViewBag.Designation = desgination;
			ViewBag.Branch = branch;
			ViewBag.EmploymentType = employmentType;
			ViewBag.ErpUsers = erpUsers;
			ViewBag.Ra = ra;
			return View("~/Plugins/HR.Base/Views/Employee/EmployeeCreate.cshtml", employeeCreateDTO);
		}
        [Authorize(Roles = "HR Manager, HR User")]
        public IActionResult EmployeeView()
		{
			
			ViewBag.Employees = _empolyeeService.GetEmployees();
			return View("~/Plugins/Hr.Base/Views/Employee/EmployeeView.cshtml");
		}

		[HttpGet]
        [Authorize(Roles = "HR Manager, HR User")]
        public IActionResult DeleteEmployee(int employeeid)
		{
			Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

			var a = _empolyeeService.DeleteEmployee(employeeid, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/HR/Employee/EmployeeView");
		}
	}
}
