using CloudVOffice.Services.Applications;
using CloudVOffice.Services.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void RunDaily1015AmISTJob()
        {
            var applications = _applicationInstallationService.GetInstalledApplications();
            if(applications.Where(x=>x.PackageName == "Project.Management").ToList().Count > 0)
            {
                _projectTaskService.TodayDueProjectTasksSendNotification();
               _timesheetService.TimesheetUpdateRemiderSendNotification();

            }
            // Your logic to run daily at 10 AM
            // This method will be executed as a recurring job
        }
        public void RunDaily8AmISTJob()
        {
            var applications = _applicationInstallationService.GetInstalledApplications();
            if (applications.Where(x => x.PackageName == "Project.Management").ToList().Count > 0)
            {
                _projectTaskService.MarkTaskOverDueAndSendNotification();
               

            }
        }
    }
}
