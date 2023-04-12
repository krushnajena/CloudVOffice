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
    public class DesignationService : IDesignationService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly ISqlRepository<Designation> _designationRepo;
        public DesignationService(ApplicationDBContext dbContext, ISqlRepository<Designation> designationRepo)
        {

            _dbContext = dbContext;
            _designationRepo = designationRepo;
        }
        public MennsageEnum CreateDesignation(DesignationDTO designationDTO)
        {

            try
            {
                var brach = _dbContext.Designations.Where(x => x.DesignationName == designationDTO.DesignationName && x.Deleted == false).FirstOrDefault();
                if (brach == null)
                {
                    _designationRepo.Insert(new Designation()
                    {
                        DesignationName = designationDTO.DesignationName,
                        Description = designationDTO.Description,
                        CreatedBy = designationDTO.CreatedBy,
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

        public MennsageEnum DesignationDelete(int designationId, int DeletedBy)
        {
            try
            {
                var a = _dbContext.Designations.Where(x => x.DesignationId == designationId).FirstOrDefault();
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

        public MennsageEnum DesignationUpdate(DesignationDTO designationDTO)
        {
            try
            {
                var branch = _dbContext.Designations.Where(x => x.DesignationId != designationDTO.DesignationId && x.DesignationName == designationDTO.DesignationName && x.Deleted == false).FirstOrDefault();
                if (branch == null)
                {
                    var a = _dbContext.Designations.Where(x => x.DesignationId == designationDTO.DesignationId).FirstOrDefault();
                    if (a != null)
                    {
                        a.DesignationName = designationDTO.DesignationName;
                        a.Description = designationDTO.Description;
                        a.UpdatedBy = designationDTO.CreatedBy;
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

        public Designation GetDesignationById(int designationId)
        {
            try
            {
                return _dbContext.Designations.Where(x => x.DesignationId == designationId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<Designation> GetDesignationList()
        {
            try
            {
                return _dbContext.Designations.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        MennsageEnum IDesignationService.DesignationUpdate(DesignationDTO designationDTO)
        {
            throw new NotImplementedException();
        }
    }
}
