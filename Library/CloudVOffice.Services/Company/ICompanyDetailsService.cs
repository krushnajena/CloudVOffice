using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Company;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.Company;
using CloudVOffice.Data.DTO.Comunication;
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
		public MessageEnum CompanyDetailsCreate(CompanyDetailsDTO companyDetailsDTO);
		public CompanyDetails GetCompanyDetailsByCompanyDetailsId(int companyDetailsId);
		public List<CompanyDetails> GetCompanyDetailsList();
		public CompanyDetails GetCompanyDetails();
		public MessageEnum CompanyDetailsUpdate(CompanyDetailsDTO companyDetailsDTO);
		public MessageEnum CompanyDetailsDelete(int companyDetailsId, int DeletedBy);
	}
}
