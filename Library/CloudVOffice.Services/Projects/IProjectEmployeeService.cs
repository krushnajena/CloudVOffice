using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;

namespace CloudVOffice.Services.Projects
{
    public interface IProjectEmployeeService
    {
        public MessageEnum ProjectEmployeeCreate(ProjectEmployeeDTO projectEmployeeDTO);
        public List<ProjectEmployee> GetProjectEmployees();
        public ProjectEmployee GetProjectEmployeeByProjectEmployeeId(Int64 projectEmployeeId);
        public List<ProjectEmployee> GetProjectEmployeeByProjectId(int projectId);

        public MessageEnum ProjectEmployeeUpdate(ProjectEmployeeDTO projectEmployeeDTO);
        public MessageEnum ProjectEmployeeDelete(Int64 projectEmployeeId, Int64 DeletedBy);

        public List<ProjectEmployee> ProjectEmployeeByProjectId(int ProjectId);

     //   public MessageEnum ReleaseResource(ReleaseResourceDTO releaseResourceDTO);



    }
}
