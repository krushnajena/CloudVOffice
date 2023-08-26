using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.Persistence;
using CloudVOffice.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Pipelines.Sockets.Unofficial.Arenas;

namespace CloudVOffice.Services.Projects
{
    public class ProjectEmployeeService : IProjectEmployeeService
    {

        private readonly ApplicationDBContext _Context;
        private readonly ISqlRepository<ProjectEmployee> _projectEmployeeRepo;
        public ProjectEmployeeService(ApplicationDBContext Context, ISqlRepository<ProjectEmployee> projectEmployeeRepo)
        {

            _Context = Context;
            _projectEmployeeRepo = projectEmployeeRepo;
        }

        public ProjectEmployee GetProjectEmployeeByFullName(string fullName)
        {
            throw new NotImplementedException();
        }

        public ProjectEmployee GetProjectEmployeeByProjectEmployeeId(Int64 projectEmployeeId)
        {
            try
            {
                return _Context.ProjectEmployees.Where(x => x.ProjectEmployeeId == projectEmployeeId && x.Deleted == false).SingleOrDefault();

            }
            catch
            {
                throw;
            }
        }

        public List<ProjectEmployee> GetProjectEmployeeByProjectId(int projectId)
        {
            try
            {
                return _Context.ProjectEmployees
                .Include(c => c.Employee)
                        .Where(x => x.ProjectId == projectId && x.Deleted == false).ToList();
            }
            catch
            {
                throw;
            }
        }


        public List<ProjectEmployee> GetProjectEmployees()
        {
            try
            {
                return _Context.ProjectEmployees.Where(x => x.Deleted == false).ToList();

            }
            catch
            {
                throw;
            }
        }

        public List<ProjectEmployee> ProjectEmployeeByProjectId(int ProjectId)
        {
            try
            {
                return _Context.ProjectEmployees.Include(c => c.Employee).Where(x => x.ProjectId == ProjectId && x.Deleted == false).ToList();
            }
            catch
            {
                throw;
            }
        }

        public MessageEnum ProjectEmployeeCreate(ProjectEmployeeDTO projectEmployeeDTO)
        {

            var objCheck = _Context.ProjectEmployees.SingleOrDefault(opt => opt.EmployeeId == projectEmployeeDTO.EmployeeId && opt.Deleted == false && opt.ProjectId == projectEmployeeDTO.ProjectId);
            try
            {
                if (objCheck == null)
                {

                    ProjectEmployee projectEmployee = new ProjectEmployee();
                    projectEmployee.EmployeeId = Int64.Parse(projectEmployeeDTO.EmployeeId.ToString());
                    projectEmployee.ProjectId = int.Parse(projectEmployeeDTO.ProjectId.ToString());
                    projectEmployee.CreatedBy = Int64.Parse(projectEmployeeDTO.CreatedBy.ToString());

                    projectEmployee.CreatedDate = System.DateTime.Now;
                    var obj = _projectEmployeeRepo.Insert(projectEmployee);

                    return MessageEnum.Success;
                }
                else if (objCheck != null)
                {
                    return MessageEnum.Duplicate;
                }

                return MessageEnum.UnExpectedError;
            }
            catch
            {
                throw;
            }
        }

        public MessageEnum ProjectEmployeeDelete(Int64 projectEmployeeId, Int64 DeletedBy)
        {

            try
            {
                var a = _Context.ProjectEmployees.Where(x => x.ProjectEmployeeId == projectEmployeeId).FirstOrDefault();
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

        public MessageEnum ProjectEmployeeUpdate(ProjectEmployeeDTO projectEmployeeDTO)
        {
            try
            {

                var a = _Context.ProjectEmployees.Where(x => x.EmployeeId == projectEmployeeDTO.EmployeeId).FirstOrDefault();
                if (a != null)
                {

                    a.ProjectId = int.Parse(projectEmployeeDTO.ProjectId.ToString());
                    a.UpdatedBy = projectEmployeeDTO.CreatedBy;
                    a.UpdatedDate = DateTime.Now;
                    _Context.SaveChanges();
                    return MessageEnum.Updated;
                }
                else
                    return MessageEnum.Invalid;


            }
            catch
            {
                throw;
            }
        }

        public MessageEnum ReleaseResource(ReleaseResourceDTO releaseResourceDTO)
        {
            throw new NotImplementedException();
        }
    }
}