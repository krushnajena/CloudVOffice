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
        private readonly ISqlRepository<FinancialYear> _FinancialYearRepo;
        public FinancialYearService(ApplicationDBContext Context, ISqlRepository<FinancialYear> FinancialYearRepo)
        {

            _Context = Context;
            _FinancialYearRepo = FinancialYearRepo;
        }
        public MessageEnum CreateFinancialYear(FinancialYearDTO FinancialYearDTO)
        {

            try
            {
                var brach = _Context.FinancialYears.Where(x => x.FinancialYearName == FinancialYearDTO.FinancialYearName && x.Deleted == false).FirstOrDefault();
                if (brach == null)
                {
                    _FinancialYearRepo.Insert(new FinancialYear()
                    {
                        FinancialYearName = FinancialYearDTO.FinancialYearName,
                        StartDate = FinancialYearDTO.StartDate,
                        EndDate = FinancialYearDTO.EndDate,
                        CreatedBy = FinancialYearDTO.CreatedBy,
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

        public MessageEnum FinancialYearDelete(Int64 FinancialYearId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.FinancialYears.Where(x => x.FinancialYearId == FinancialYearId).FirstOrDefault();
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

		public MessageEnum FinancialYearDelete(int FinancialYearId, Int64 DeletedBy)
		{
			try
			{
				var a = _Context.FinancialYears.Where(x => x.FinancialYearId == FinancialYearId).FirstOrDefault();
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

		public MessageEnum FinancialYearUpdate(FinancialYearDTO FinancialYearDTO)
		{
			try
			{
				var FinancialYear = _Context.FinancialYears.Where(x => x.FinancialYearId != FinancialYearDTO.FinancialYearId && x.FinancialYearName == FinancialYearDTO.FinancialYearName && x.Deleted == false).FirstOrDefault();
				if (FinancialYear == null)
				{
					var a = _Context.FinancialYears.Where(x => x.FinancialYearId == FinancialYearDTO.FinancialYearId).FirstOrDefault();
					if (a != null)
					{
						a.FinancialYearName = FinancialYearDTO.FinancialYearName;
						a.StartDate = FinancialYearDTO.StartDate;
						a.EndDate = FinancialYearDTO.EndDate;
						a.UpdatedBy = FinancialYearDTO.CreatedBy;
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

		public FinancialYear GetFinancialYearByFinancialYearId(int FinancialYearId)
		{
			try
			{
				return _Context.FinancialYears.Where(x => x.FinancialYearId == FinancialYearId && x.Deleted == false).SingleOrDefault();

			}
			catch
			{
				throw;
			}
		}

		public FinancialYear GetFinancialYearByName(string FinancialYearName)
        {
            try
            {
                return _Context.FinancialYears.Where(x => x.FinancialYearName == FinancialYearName && x.Deleted == false).SingleOrDefault();

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
