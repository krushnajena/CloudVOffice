using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.CodeAnalysis.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.HR.Master
{
    public class EmploymentTypeService : IEmploymentTypeService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly ISqlRepository<EmploymentType> _employmenttypeRepo;
        public EmploymentTypeService(ApplicationDBContext dbContext, ISqlRepository<EmploymentType> employmenttypeRepo)
        {

            _dbContext = dbContext;
            _employmenttypeRepo = employmenttypeRepo;
        }
        public MennsageEnum EmployementTypeCreate(EmploymentTypeDTO employmenttypeDTO)
        {
            try
            {
                var employmenttype = _dbContext.EmploymentTypes.Where(x => x.EmploymentTypeName == employmenttypeDTO.EmploymentTypeName && x.Deleted == false).FirstOrDefault();
                if (employmenttype == null)
                {
                    _employmenttypeRepo.Insert(new EmploymentType()
                    {
                        EmploymentTypeName = employmenttypeDTO.EmploymentTypeName,
                        CreatedBy = employmenttypeDTO.CreatedBy,
                        CreatedDate = DateTime.Now,
                        Deleted = false
                    });
                    return MennsageEnum.Success;
                }
                else
                    return MennsageEnum.Duplicate;
            }
            catch
            {
                throw;
            }
        }

        public MennsageEnum EmploymentTypeDelete(int employmenttypeId, int DeletedBy)
        {
            try
            {
                var a = _dbContext.EmploymentTypes.Where(x => x.EmploymentTypeId == employmenttypeId).FirstOrDefault();
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

        public MennsageEnum EmploymentTypeDelete(long employmenttypeId, long DeletedBy)
        {
            throw new NotImplementedException();
        }

        public MennsageEnum EmploymentTypeUpdate(EmploymentTypeDTO employmenttypeDTO)
        {
            try
            {
                var employmenttype = _dbContext.EmploymentTypes.Where(x => x.EmploymentTypeId != employmenttypeDTO.EmploymentTypeId && x.EmploymentTypeName == employmenttypeDTO.EmploymentTypeName && x.Deleted == false).FirstOrDefault();
                if (employmenttype == null)
                {
                    var a = _dbContext.EmploymentTypes.Where(x => x.EmploymentTypeId == employmenttypeDTO.EmploymentTypeId).FirstOrDefault();
                    if (a != null)
                    {
                        a.EmploymentTypeName = employmenttypeDTO.EmploymentTypeName;
                        a.UpdatedBy = employmenttypeDTO.CreatedBy;
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

       

        public EmploymentType GetEmploymentTypeByEmploymentTypeId(int employmenttypeId)
        {
            try
            {
                return _dbContext.EmploymentTypes.Where(x => x.EmploymentTypeId == employmenttypeId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public EmploymentType GetEmploymentTypeByEmploymentTypeId(long employmenttypeId)
        {
            throw new NotImplementedException();
        }

        public EmploymentType GetEmploymentTypeByEmploymentTypeName(string employmentTypeName)
        {
            try
            {
                return _dbContext.EmploymentTypes.Where(x => x.EmploymentTypeName == employmentTypeName && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<EmploymentType> GetEmploymentTypes()
        {
            try
            {
                return _dbContext.EmploymentTypes.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }
    }
    
}
