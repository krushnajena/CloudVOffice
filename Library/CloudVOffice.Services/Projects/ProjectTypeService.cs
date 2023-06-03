using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.CodeAnalysis.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudVOffice.Services.Projects
{
    public class ProjectTypeService : IProjectTypeService
    {
        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<ProjectType> _projecttypeRepo;
        public ProjectTypeService(ApplicationDBContext Context, ISqlRepository<ProjectType> projecttypeRepo)
        {

            _Context = Context;
            _projecttypeRepo = projecttypeRepo;
        }
        public ProjectType GetProjectTypeByProjectName(string projectName)
        {
            try
            {
                return _Context.ProjectTypes.Where(x => x.ProjectTypeName == projectName && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public ProjectType GetProjectTypeByProjectTypeId(int projecttypeId)
        {
            try
            {
                return _Context.ProjectTypes.Where(x => x.ProjectTypeId == projecttypeId && x.Deleted == false).SingleOrDefault();

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
                return _Context.ProjectTypes.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public MessageEnum ProjectTypeCreate(ProjectTypeDTO projecttypeDTO)
        {
            try
            {
                var projecttype = _Context.ProjectTypes.Where(x => x.ProjectTypeName == projecttypeDTO.ProjectTypeName && x.Deleted == false).FirstOrDefault();
                if (projecttype == null)
                {
                    _projecttypeRepo.Insert(new ProjectType()
                    {
						ProjectTypeName = projecttypeDTO.ProjectTypeName,
                        CreatedBy = projecttypeDTO.CreatedBy,
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

        public MessageEnum ProjectTypeDelete(int projecttypeId, Int64 DeletedBy)
        {
            try
            {
                var a = _Context.ProjectTypes.Where(x => x.ProjectTypeId == projecttypeId).FirstOrDefault();
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

        public MessageEnum ProjectTypeUpdate(ProjectTypeDTO projecttypeDTO)
        {
            try
            {
                var projecttype = _Context.ProjectTypes.Where(x => x.ProjectTypeId != projecttypeDTO.ProjectTypeId && x.ProjectTypeName == projecttypeDTO.ProjectTypeName && x.Deleted == false).FirstOrDefault();
                if (projecttype == null)
                {
                    var a = _Context.ProjectTypes.Where(x => x.ProjectTypeId == projecttypeDTO.ProjectTypeId).FirstOrDefault();
                    if (a != null)
                    {
                        a.ProjectTypeName = projecttypeDTO.ProjectTypeName;
                        a.UpdatedBy = projecttypeDTO.CreatedBy;
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
    }
}
