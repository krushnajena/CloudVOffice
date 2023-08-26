using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Core.Domain.Projects;
using CloudVOffice.Data.DTO.Projects;
using CloudVOffice.Data.ViewModel.Projects;
using System.Data;

namespace CloudVOffice.Services.Projects
{
    public interface IProjectService
    {
        public MessageEnum ProjectCreate(ProjectDTO projectDTO);
        public List<Project> GetProjects();
        public Project GetProjectByProjectId(Int64 projectId);
        public Project GetProjectByProjectName(string projectName);
        public MessageEnum ProjectUpdate(ProjectDTO projectDTO);
        public MessageEnum ProjectDelete(Int64 projectId, Int64 DeletedBy);

        public List<Project> GetMyAssignedProject(Int64 EmployeeId, Int64 UserId);

        public List<Project> GetMyAssignedProjectByEmployee(Int64 EmployeeId);
        public List<ProjectTaskColumnChartModel> GetProjectTaskColumnChart(Int64 EmployeeId, Int64 UserId);
    



        public List<ProjectTaskSummeryReportViewModel> ProjectTaskSummeryReport(Int64 EmployeeId, Int64 UserId);



    }
}
