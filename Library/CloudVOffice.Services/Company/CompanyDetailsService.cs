using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Company;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.Company;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Company
{
	public class CompanyDetailsService : ICompanyDetailsService
	{
		private readonly ApplicationDBContext _dbContext;
		private readonly ISqlRepository<CompanyDetails> _companyDetailsRepo;
		public CompanyDetailsService(ApplicationDBContext dbContext, ISqlRepository<CompanyDetails> companyDetailsRepo)
		{

			_dbContext = dbContext;
			_companyDetailsRepo = companyDetailsRepo;
		}
		public MennsageEnum CompanyDetailsCreate(CompanyDetailsDTO companyDetailsDTO)
		{
			var ObjCheck = _dbContext.CompanyDetails.Where(x => x.CompanyName == companyDetailsDTO.CompanyName && x.Deleted == false).FirstOrDefault();
			try
			{
				
				if (ObjCheck == null)
				{
					
					
						CompanyDetails companyDetails = new CompanyDetails();
						companyDetails.CompanyName = companyDetailsDTO.CompanyName;
						companyDetails.ABBR = companyDetailsDTO.ABBR;
						companyDetails.CompanyLogo = companyDetailsDTO.CompanyLogo;
						companyDetails.TaxId = companyDetailsDTO.TaxId;
						companyDetails.Domain = companyDetailsDTO.Domain;
						companyDetails.DateOfEstablishment = companyDetailsDTO.DateOfEstablishment;
						companyDetails.DateOfIncorporation = companyDetailsDTO.DateOfIncorporation;
						companyDetails.AddressLine1 = companyDetailsDTO.AddressLine1;
						companyDetails.AddressLine2 = companyDetailsDTO.AddressLine2;
						companyDetails.City = companyDetailsDTO.City;
						companyDetails.State = companyDetailsDTO.State;
						companyDetails.Country = companyDetailsDTO.Country;
						companyDetails.PostalCode = companyDetailsDTO.PostalCode;
						companyDetails.EmailAddress = companyDetailsDTO.EmailAddress;
						companyDetails.PhoneNumber = companyDetailsDTO.PhoneNumber;
						companyDetails.Fax = companyDetailsDTO.Fax;
						companyDetails.Website = companyDetailsDTO.Website;
						companyDetails.CreatedBy = companyDetailsDTO.CreatedBy;
						var obj = _companyDetailsRepo.Insert(companyDetails);

						return MennsageEnum.Success;
				}
				else if (ObjCheck != null)
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

		public CompanyDetails GetCompanyDetails()
		{
			try
			{
				return _dbContext.CompanyDetails.Where(c => c.Deleted == false).FirstOrDefault();
			}
			catch
			{
				throw;
			}
		}

		public List<CompanyDetails> GetCompanyDetailsList()
		{
			try
			{
				return _dbContext.CompanyDetails.Where(x => x.Deleted == false).ToList();
			}
			catch
			{
				throw;
			}
		}
	}

}
