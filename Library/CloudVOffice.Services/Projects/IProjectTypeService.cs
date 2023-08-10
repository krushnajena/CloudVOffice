using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;

namespace CloudVOffice.Services.Projects
{
    public interface IProjectTypeService
    {
        public MessageEnum ProjectTypeCreate(ProjectTypeDTO projecttypeDTO);
        public List<ProjectType> GetProjectTypes();
        public ProjectType GetProjectTypeByProjectTypeId(int projecttypeId);
        public ProjectType GetProjectTypeByProjectName(string projectName);
        public MessageEnum ProjectTypeUpdate(ProjectTypeDTO projecttypeDTO);
        public MessageEnum ProjectTypeDelete(int projecttypeId, Int64 DeletedBy);
    }
}
