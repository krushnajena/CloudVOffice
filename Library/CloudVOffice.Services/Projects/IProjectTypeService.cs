using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.HR.Master;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.HR.Master;
using CloudVOffice.Data.DTO.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
