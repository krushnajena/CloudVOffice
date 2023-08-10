using CloudVOffice.Services.Applications;
using CloudVOffice.Services.Projects;

namespace CloudVOffice.BackgroundJobs
{
    public class ScheduledService
    {
        private readonly IApplicationInstallationService _applicationInstallationService;
        private readonly IProjectTaskService _projectTaskService;
        private readonly ITimesheetService _timesheetService;
        public ScheduledService(IApplicationInstallationService applicationInstallationService,
            IProjectTaskService projectTaskService,
            ITimesheetService timesheetService)
        {
            _applicationInstallationService = applicationInstallationService;
            _projectTaskService = projectTaskService;
            _timesheetService = timesheetService;
        }
        public async Task RunDaily1015AmISTJob()
        {
            var applications = _applicationInstallationService.GetInstalledApplications();
            if (applications.Where(x => x.PackageName == "Project.Management").ToList().Count > 0)
            {
                await _projectTaskService.TodayDueProjectTasksSendNotification();
                await _timesheetService.TimesheetUpdateRemiderSendNotification();

            }
            // Your logic to run daily at 10 AM
            // This method will be executed as a recurring job
        }
        public async Task RunDaily8AmISTJob()
        {
            var applications = _applicationInstallationService.GetInstalledApplications();
            if (applications.Where(x => x.PackageName == "Project.Management").ToList().Count > 0)
            {
                _projectTaskService.MarkTaskOverDueAndSendNotification();


            }
        }
    }
}
