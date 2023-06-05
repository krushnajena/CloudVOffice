using CloudVOffice.Core.Domain.Accounts;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Accounts;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Accounts
{
    public class FinancialYearService : IFinancialYearService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<FinancialYear> _financialYearRepo;
        public FinancialYearService(ApplicationDBContext Context, ISqlRepository<FinancialYear> financialYearRepo)
        {

            _Context = Context;
            _financialYearRepo = financialYearRepo;
        }
        public MessageEnum CreateFinancialYear(FinancialYearDTO financialYearDTO)
        {

            try
            {
                var brach = _Context.FinancialYears.Where(x => x.FinancialYearName == financialYearDTO.FinancialYearName && x.Deleted == false).FirstOrDefault();
                if (brach == null)
                {
                    _financialYearRepo.Insert(new FinancialYear()
                    {
                        FinancialYearName = financialYearDTO.FinancialYearName,
                        StartDate = financialYearDTO.StartDate,
                        EndDate = financialYearDTO.EndDate,
                        CreatedBy = financialYearDTO.CreatedBy,
                        CreatedDate = DateTime.Now,
                        Deleted = false
                    });
                    return MessageEnum.Success;
                }
                else
                    return MessageEnum.Duplicate;
            }
            catch
            {
                throw;
            }
        }

        public MessageEnum FinancialYearDelete(Int64 financialYearId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.FinancialYears.Where(x => x.FinancialYearId == financialYearId).FirstOrDefault();
                if (a != null)
                {
                    a.Deleted = true;
                    a.UpdatedBy = DeletedBy;
                    a.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();
                    return MessageEnum.Deleted;
                }
                else
                    return MessageEnum.Invalid;
            }
            catch
            {
                throw;
            }

        }

		public MessageEnum FinancialYearDelete(int financialYearId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.FinancialYears.Where(x => x.FinancialYearId == financialYearId).FirstOrDefault();
				if (a != null)
				{
					a.Deleted = true;
					a.UpdatedBy = DeletedBy;
					a.UpdatedDate = DateTime.Now;
					_Context.SaveChanges();
					return MessageEnum.Deleted;
				}
				else
					return MessageEnum.Invalid;
			}
			catch
			{
				throw;
			}
		}

		public MessageEnum FinancialYearUpdate(FinancialYearDTO financialYearDTO)
		{
			try
			{
				var FinancialYear = _Context.FinancialYears.Where(x => x.FinancialYearId != financialYearDTO.FinancialYearId && x.FinancialYearName == financialYearDTO.FinancialYearName && x.Deleted == false).FirstOrDefault();
				if (FinancialYear == null)
				{
					var a = _Context.FinancialYears.Where(x => x.FinancialYearId == financialYearDTO.FinancialYearId).FirstOrDefault();
					if (a != null)
					{
						a.FinancialYearName = financialYearDTO.FinancialYearName;
						a.StartDate = financialYearDTO.StartDate;
						a.EndDate = financialYearDTO.EndDate;
						a.UpdatedBy = financialYearDTO.CreatedBy;
						a.UpdatedDate = DateTime.Now;
						
						_Context.SaveChanges();
						return MessageEnum.Updated;
					}
					else
						return MessageEnum.Invalid;
				}
				else
				{
					return MessageEnum.Duplicate;
				}

			}
			catch
			{
				throw;
			}
		}

		public FinancialYear GetFinancialYearByFinancialYearId(int financialYearId)
		{
			try
			{
				return _Context.FinancialYears.Where(x => x.FinancialYearId == financialYearId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public FinancialYear GetFinancialYearByName(string financialYearName)
        {
            try
            {
                return _Context.FinancialYears.Where(x => x.FinancialYearName == financialYearName && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

       
        public List<FinancialYear> GetFinancialYearList()
        {

            try
            {
                return _Context.FinancialYears.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }
    }
   
}
