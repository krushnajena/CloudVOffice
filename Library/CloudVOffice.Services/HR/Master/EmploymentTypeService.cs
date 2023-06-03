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
        public MessageEnum EmployementTypeCreate(EmploymentTypeDTO employmenttypeDTO)
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

        public MessageEnum EmploymentTypeDelete(Int64 employmenttypeId, Int64 DeletedBy)
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

       
        public MessageEnum EmploymentTypeUpdate(EmploymentTypeDTO employmenttypeDTO)
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

       

        public EmploymentType GetEmploymentTypeByEmploymentTypeId(Int64 employmenttypeId)
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
