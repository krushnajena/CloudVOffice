using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Recruitment
{
	public class CandidateDTO
	{
		public Int64? CandidateId { get; set; }
		public string FirstName { get; set; }
		public string? MiddleName { get; set; }
		public string? LastName { get; set; }
		public string? Email { get; set; }
		public string? MobileNo { get; set; }
		public string? StreetAddress { get; set; }
		public string? City { get; set; }
		public double? ExperienceinYears { get; set; }
		public string HighestQualification { get; set; }
		public string? CurrentJob { get; set; }
		public string? CurrentEmployer { get; set; }
		public double? ExpectedSalary { get; set; }

		public double? CurrentSalary { get; set; }
		public string? Cv { get; set; }
		public int? ApplicationSourceId { get; set; }
        public int Status { get; set; } = 1; //1=New, 2=Blacklisted , 3= Hired,4= Rejected,5 = Offered
        public List<int>? Skills { get; set; }
        public Int64 CreatedBy { get; set; }
		public IFormFile? CVDOC { get; set; }
		
      

    }
}
