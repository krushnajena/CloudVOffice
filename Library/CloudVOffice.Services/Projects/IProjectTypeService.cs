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
        public MennsageEnum ProjectTypeCreate(ProjectTypeDTO projectTypeDTO);
        public List<ProjectType> GetProjectTypes();
        public ProjectType GetProjectTypeByProjectTypeId(Int64 projecttypeId);
        public ProjectType GetProjectTypeByProjectName(string projectName);
        public MennsageEnum ProjectTypeUpdate(ProjectTypeDTO projectTypeDTO);
        public MennsageEnum ProjectTypeDelete(Int64 projectTypeId, Int64 DeletedBy);
    }
}
