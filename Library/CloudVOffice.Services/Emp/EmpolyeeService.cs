using Azure.Security.KeyVault.Keys;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Emp;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Core.Security;
using CloudVOffice.Data.DTO.Emp;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.DTO.Users;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using CloudVOffice.Services.Permissions;
using CloudVOffice.Services.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Emp
{
	public class EmployeeService : IEmployeeService
	{
		private readonly ApplicationDBContext _Dbcontext;
		private readonly ISqlRepository<Employee> _employeeRepo;
		public EmployeeService(ApplicationDBContext Dbcontext, ISqlRepository<Employee> employeeRepo)
		{
			_Dbcontext = Dbcontext;
			_employeeRepo = employeeRepo;
		}
		public  MennsageEnum CreateEmployee(EmployeeCreateDTO employeeCreateDTO)
		{
			var objCheck = _Dbcontext.Employees.SingleOrDefault(opt => opt.EmployeeId == employeeCreateDTO.EmployeeId && opt.ErpUser == employeeCreateDTO.ErpUser && opt.Deleted == false);
			try
			{
				if (objCheck == null)
				{

					Employee employee = new Employee();
					employee.EmployeeCode = employeeCreateDTO.EmployeeCode;
					employee.Salutation = employeeCreateDTO.Salutation;
					employee.FirstName = employeeCreateDTO.FirstName;
					employee.MiddleName = employeeCreateDTO.MiddleName;
					employee.LastName = employeeCreateDTO.LastName;
					employee.Gender = employeeCreateDTO.Gender;
					employee.DateOfBirth = employeeCreateDTO.DateOfBirth;
					employee.DateOfJoining = employeeCreateDTO.DateOfJoining;
					employee.ErpUser = employeeCreateDTO.ErpUser;
					employee.Status = true;
					employee.DepartmentId = employeeCreateDTO.DepartmentId;
					employee.DesignationId = employeeCreateDTO.DesignationId;
					employee.BranchId = employeeCreateDTO.BranchId;
					employee.EmploymentTypeId = employeeCreateDTO.EmploymentTypeId;
					employee.JobApplicantId = employeeCreateDTO.JobApplicantId;
					employee.OfferDate = employeeCreateDTO.OfferDate;
					employee.ConfirmationDate = employeeCreateDTO.ConfirmationDate;
					employee.ContractEndDate = employeeCreateDTO.ContractEndDate;
					employee.NoticePeriodDays = employeeCreateDTO.NoticePeriodDays;
					employee.RetirementDate = employeeCreateDTO.RetirementDate;
					employee.MobileNo = employeeCreateDTO.MobileNo;
					employee.PersonalEmail = employeeCreateDTO.PersonalEmail;
					employee.CompanyEmail = employeeCreateDTO.CompanyEmail;
					employee.CurrentAddress = employeeCreateDTO.CurrentAddress;
					employee.PermanentAddress = employeeCreateDTO.PermanentAddress;
					employee.EmergencyContactName = employeeCreateDTO.EmergencyContactName;
					employee.EmergencyPhone = employeeCreateDTO.EmergencyPhone;
					employee.RelationWithEmergencyContactPerson = employeeCreateDTO.RelationWithEmergencyContactPerson;
					employee.BiometricOrRfIdDeviceId = employeeCreateDTO.BiometricOrRfIdDeviceId;
					employee.CTC = employeeCreateDTO.CTC;
					employee.PanNo = employeeCreateDTO.PanNo;
					employee.ProvidentFundAccountNo = employeeCreateDTO.ProvidentFundAccountNo;
					employee.MaritalStatus = employeeCreateDTO.MaritalStatus;
					employee.MarraigeDate = employeeCreateDTO.MarraigeDate;
					employee.BloodGroup = employeeCreateDTO.BloodGroup;
					employee.PassportNumber = employeeCreateDTO.PassportNumber;
					employee.PassportDateOfIssue = employeeCreateDTO.PassportDateOfIssue;
					employee.PassportValidUpto = employeeCreateDTO.PassportValidUpto;
					employee.PassportPlaceOfIssue = employeeCreateDTO.PassportPlaceOfIssue;
					employee.Photo = employeeCreateDTO.Photo;
					employee.CreatedBy = employeeCreateDTO.CreatedBy;
					employee.Deleted = false;
					var obj = _employeeRepo.Insert(employee);

					return MennsageEnum.Success;
				}
				else if (objCheck != null)
				{
					return MennsageEnum.Duplicate;
				}

				return MennsageEnum.UnExpectedError;
			}
			catch
			{
				throw;
			}
		}

		public MennsageEnum DeleteEmployee(Int64 employeeid, Int64 DeletedBy)
		{
			try
			{
				var a = _Dbcontext.Employees.Where(x => x.EmployeeId == employeeid).FirstOrDefault();
				if (a != null)
				{
					a.Deleted = true;
					a.UpdatedBy = DeletedBy;
					a.UpdatedDate = DateTime.Now;
					_Dbcontext.SaveChanges();
					return MennsageEnum.Deleted;
				}
				else
					return MennsageEnum.Invalid;
			}
			catch
			{
				throw;
			}
		}

		

		public Employee GetEmployeeByCode(string employeecode)
		{
			try
			{
				return _Dbcontext.Employees.Where(x => x.EmployeeCode == employeecode && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		

		public Employee GetEmployeeById(Int64 employeeid)
		{
			try
			{
				return _Dbcontext.Employees.Where(x => x.EmployeeId == employeeid && x.Deleted == false).SingleOrDefault();
			}
			catch
			{
				throw;
			}
		}

		public List<Employee> GetEmployees()
		{
			try
			{
				return _Dbcontext.Employees.Where(x => x.Deleted == false).ToList();
			}
			catch
			{
				throw;
			}
		}


		public MennsageEnum UpdateEmployee(EmployeeCreateDTO employeeCreateDTO)
		{
			try
			{
				var employee = _Dbcontext.Employees.Where(x => x.EmployeeCode == employeeCreateDTO.EmployeeCode && x.ErpUser == employeeCreateDTO.ErpUser && x.EmployeeId==employeeCreateDTO.EmployeeId && x.Deleted == false).FirstOrDefault();
				if (employee == null)
				{
					var a = _Dbcontext.Employees.Where(x => x.EmployeeId == employeeCreateDTO.EmployeeId).FirstOrDefault();
					if (a != null)
					{
						a.EmployeeCode = employeeCreateDTO.EmployeeCode;
						a.Salutation = employeeCreateDTO.Salutation;
						a.FirstName = employeeCreateDTO.FirstName;
						a.MiddleName = employeeCreateDTO.MiddleName;
						a.LastName = employeeCreateDTO.LastName;
						a.Gender = employeeCreateDTO.Gender;
						a.DateOfBirth = employeeCreateDTO.DateOfBirth;
						a.DateOfJoining = employeeCreateDTO.DateOfJoining;
						a.ErpUser = employeeCreateDTO.ErpUser;
						a.Status = employeeCreateDTO.Status;
						a.DepartmentId = employeeCreateDTO.DepartmentId;
						a.DesignationId = employeeCreateDTO.DesignationId;
						a.BranchId = employeeCreateDTO.BranchId;
						a.EmploymentTypeId = employeeCreateDTO.EmploymentTypeId;
						a.JobApplicantId = employeeCreateDTO.JobApplicantId;
						a.OfferDate = employeeCreateDTO.OfferDate;
						a.ConfirmationDate = employeeCreateDTO.ConfirmationDate;
						a.ContractEndDate = employeeCreateDTO.ContractEndDate;
						a.NoticePeriodDays = employeeCreateDTO.NoticePeriodDays;
						a.RetirementDate = employeeCreateDTO.RetirementDate;
						a.MobileNo = employeeCreateDTO.MobileNo;
						a.PersonalEmail = employeeCreateDTO.PersonalEmail;
						a.CompanyEmail = employeeCreateDTO.CompanyEmail;
						a.CurrentAddress = employeeCreateDTO.CurrentAddress;
						a.PermanentAddress = employeeCreateDTO.PermanentAddress;
						a.EmergencyContactName = employeeCreateDTO.EmergencyContactName;
						a.EmergencyPhone = employeeCreateDTO.EmergencyPhone;
						a.RelationWithEmergencyContactPerson = employeeCreateDTO.RelationWithEmergencyContactPerson;
						a.BiometricOrRfIdDeviceId = employeeCreateDTO.BiometricOrRfIdDeviceId;
						a.CTC = employeeCreateDTO.CTC;
						a.PanNo = employeeCreateDTO.PanNo;
						a.ProvidentFundAccountNo = employeeCreateDTO.ProvidentFundAccountNo;
						a.MaritalStatus = employeeCreateDTO.MaritalStatus;
						a.MarraigeDate = employeeCreateDTO.MarraigeDate;
						a.BloodGroup = employeeCreateDTO.BloodGroup;
						a.PassportNumber = employeeCreateDTO.PassportNumber;
						a.PassportDateOfIssue = employeeCreateDTO.PassportDateOfIssue;
						a.PassportValidUpto = employeeCreateDTO.PassportValidUpto;
						a.PassportPlaceOfIssue = employeeCreateDTO.PassportPlaceOfIssue;
						a.Photo = employeeCreateDTO.Photo;
						a.UpdatedDate = DateTime.Now;
						_Dbcontext.SaveChanges();
						return MennsageEnum.Updated;
					}
					else
						return MennsageEnum.Invalid;
				}
				else
				{
					return MennsageEnum.Duplicate;
				}

			}
			catch
			{
				throw;
			}

		}
	}
}
