using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Projects
{
    public class ProjectTypeService : IProjectTypeService
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly ISqlRepository<ProjectType> _projecttypeRepo;
        public ProjectTypeService(ApplicationDBContext dbContext, ISqlRepository<ProjectType> projecttypeRepo)
        {

            _dbContext = dbContext;
            _projecttypeRepo = projecttypeRepo;
        }
        public ProjectType GetProjectTypeByProjectName(string projectName)
        {
            try
            {
                return _dbContext.ProjectTypes.Where(x => x.ProjectName == projectName && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public ProjectType GetProjectTypeByProjectTypeId(Int64 projecttypeId)
        {
            try
            {
                return _dbContext.ProjectTypes.Where(x => x.ProjectTypeId == projecttypeId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<ProjectType> GetProjectTypes()
        {
            try
            {
                return _dbContext.ProjectTypes.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public MennsageEnum ProjectTypeCreate(ProjectTypeDTO projectTypeDTO)
        {
            try
            {
                var projecttype = _dbContext.ProjectTypes.Where(x => x.ProjectName == projectTypeDTO.ProjectName && x.Deleted == false).FirstOrDefault();
                if (projecttype == null)
                {
                    _projecttypeRepo.Insert(new ProjectType()
                    {
                        ProjectName = projectTypeDTO.ProjectName,
                        CreatedBy = projectTypeDTO.CreatedBy,
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

        public MennsageEnum ProjectTypeDelete(Int64 projectTypeId, Int64 DeletedBy)
        {
            try
            {
                var a = _dbContext.ProjectTypes.Where(x => x.ProjectTypeId == projectTypeId).FirstOrDefault();
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

        public MennsageEnum ProjectTypeUpdate(ProjectTypeDTO projectTypeDTO)
        {
            try
            {
                var employmenttype = _dbContext.ProjectTypes.Where(x => x.ProjectTypeId != projectTypeDTO.ProjectTypeId && x.ProjectName == projectTypeDTO.ProjectName && x.Deleted == false).FirstOrDefault();
                if (employmenttype == null)
                {
                    var a = _dbContext.ProjectTypes.Where(x => x.ProjectTypeId == projectTypeDTO.ProjectTypeId).FirstOrDefault();
                    if (a != null)
                    {
                        a.ProjectName = projectTypeDTO.ProjectName;
                        a.UpdatedBy = projectTypeDTO.CreatedBy;
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
    }
}
