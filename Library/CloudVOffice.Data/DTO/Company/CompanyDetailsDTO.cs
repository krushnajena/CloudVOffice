using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Data.DTO.Company
{
	public class CompanyDetailsDTO
	{
		public int? CompanyDetailsId { get; set; }
		public string CompanyName { get; set; }
		public string ABBR { get; set; }
		public string? CompanyLogo { get; set; }
		public string? TaxId { get; set; }
		public string? Domain { get; set; }
		public DateTime? DateOfEstablishment { get; set; }
		public DateTime? DateOfIncorporation { get; set; }
		public string? AddressLine1 { get; set; }
		public string? AddressLine2 { get; set; }
		public string? City { get; set; }
		public string? State { get; set; }
		public string? Country { get; set; }
		public string? PostalCode { get; set; }
		public string? EmailAddress { get; set; }
		public string? PhoneNumber { get; set; }
		public string? Fax { get; set; }
		public string? Website { get; set; }


		public Int64 CreatedBy { get; set; }
		public IFormFile? CompanyLogoUp { get; set; }
	}
}
