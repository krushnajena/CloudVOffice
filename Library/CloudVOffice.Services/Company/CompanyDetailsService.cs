using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Company;
using CloudVOffice.Core.Domain.Comunication;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.Company;
using CloudVOffice.Data.DTO.Comunication;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.CodeAnalysis.Operations;
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
			var ObjCheck = _dbContext.CompanyDetails.SingleOrDefault(opt => opt.CompanyDetailsId == companyDetailsDTO.CompanyDetailsId && opt.Deleted == false);
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

		public MennsageEnum CompanyDetailsDelete(int companyDetailsId, int DeletedBy)
		{
			try
			{
				var a = _dbContext.CompanyDetails.Where(x => x.CompanyDetailsId == companyDetailsId).FirstOrDefault();
				if (a != null)
				{
					a.Deleted = true;
					a.UpdatedBy = DeletedBy;
					a.UpdatedDate = DateTime.Now;
					_dbContext.SaveChanges();
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

		public MennsageEnum CompanyDetailsUpdate(CompanyDetailsDTO companyDetailsDTO)
		{
			try
			{
				var CompanyDetails = _dbContext.CompanyDetails.Where(x => x.CompanyDetailsId == companyDetailsDTO.CompanyDetailsId && x.Deleted == false).FirstOrDefault();
				if (CompanyDetails == null)
				{
					var a = _dbContext.CompanyDetails.Where(x => x.CompanyDetailsId == companyDetailsDTO.CompanyDetailsId).FirstOrDefault();
					if (a != null)
					{
						a.CompanyName = companyDetailsDTO.CompanyName;
						a.ABBR = companyDetailsDTO.ABBR;
						a.CompanyLogo = companyDetailsDTO.CompanyLogo;
						a.TaxId = companyDetailsDTO.TaxId;
						a.Domain = companyDetailsDTO.Domain;
						a.DateOfEstablishment = companyDetailsDTO.DateOfEstablishment;
						a.DateOfIncorporation = companyDetailsDTO.DateOfIncorporation;
						a.AddressLine1 = companyDetailsDTO.AddressLine1;
						a.AddressLine2 = companyDetailsDTO.AddressLine2;
						a.City = companyDetailsDTO.City;
						a.State = companyDetailsDTO.State;
						a.Country = companyDetailsDTO.Country;
						a.PostalCode = companyDetailsDTO.PostalCode;
						a.EmailAddress = companyDetailsDTO.EmailAddress;
						a.CompanyName = companyDetailsDTO.CompanyName;
						a.Fax = companyDetailsDTO.Fax;
						a.Website = companyDetailsDTO.Website;						
						a.UpdatedDate = DateTime.Now;
						_dbContext.SaveChanges();
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

		public CompanyDetails GetCompanyDetailsByCompanyDetailsId(int companyDetailsId)
		{
			try
			{
				return _dbContext.CompanyDetails.Where(x => x.CompanyDetailsId == companyDetailsId && x.Deleted == false).SingleOrDefault();

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
