using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Core.Domain.HR.Emp
{
	public class Employee
	{
		public Int64 EmployeeId { get; set; }
		public string EmployeeCode { get; set; }
		public string Salutation { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }	
		public string LastName { get; set; }
		public string Gender { get; set; }	
		public DateTime? DateOfBirth { get; set; }
		public DateTime? DateOfJoining { get; set; }
		public int ErpUser { get; set; }
		public bool Status { get; set; }

		public int? DepartmentId { get; set; }
		public int? DesignationId { get; set; }
		public int? BranchId { get; set; }
		public int? EmploymentTypeId { get; set;}
		public int ? ReportToEmployeeId { get; set; }

		public int? JobApplicantId { get; set; }
		public DateTime? OfferDate { get; set; }
		public DateTime? ConfirmationDate { get; set; }
		public DateTime? ContractEndDate { get; set; }
		public int? NoticePeriodDays { get; set; }
		public DateTime? RetirementDate { get; set; }


		public string MobileNo { get; set; }
		public string PersonalEmail { get; set; }
		public string CompanyEmail { get; set; }
		public string CurrentAddress { get; set; }
		public string PermanentAddress { get; set; }
		public string EmergencyContactName { get; set; }
		public string EmergencyPhone { get; set; }

		public string RelationWithEmergencyContactPerson { get; set; }
		public string BiometricOrRfIdDeviceId { get; set; }

		public double? CTC { get; set; }
		public string PanNo { get; set; }
		public string ProvidentFundAccountNo { get; set; }

		public string MaritalStatus { get; set; }
		public DateTime? MarraigeDate { get; set; }
		public string BloodGroup { get; set; }
		public string PassportNumber { get; set; }
		public DateTime? PassportDateOfIssue { get; set; }
		public DateTime? PassportValidUpto { get; set; }
		public string PassportPlaceOfIssue { get; set; }


	}
}
