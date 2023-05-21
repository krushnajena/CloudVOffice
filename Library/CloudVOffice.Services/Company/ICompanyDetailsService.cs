using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Company;
using CloudVOffice.Data.DTO.Company;
using CloudVOffice.Data.DTO.HR.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Company
{
	public interface ICompanyDetailsService
	{
		public MennsageEnum CompanyDetailsCreate(CompanyDetailsDTO companyDetailsDTO);
		public List<CompanyDetails> GetCompanyDetailsList();
		public CompanyDetails GetCompanyDetails();
	}
}
