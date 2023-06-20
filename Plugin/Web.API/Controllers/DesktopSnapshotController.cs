using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Data.DTO.Emp;
using CloudVOffice.Services.DesktopMonitoring;
using CloudVOffice.Services.Emp;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public  class DesktopSnapshotController : Controller {

        private readonly IDesktopSnapsService _desktopSnapService;
        private readonly IEmployeeService _empolyeeService;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public DesktopSnapshotController(
            IDesktopSnapsService desktopSnapService,
            IEmployeeService empolyeeService,
             IWebHostEnvironment hostingEnvironment
        )
        {
            _desktopSnapService = desktopSnapService;
            _empolyeeService = empolyeeService;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        [Authorize]
        public IActionResult CreateDesktopSnaps([FromForm] DesktopSnapsDTO desktopSnapsDTO)
        {
            desktopSnapsDTO.CreatedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _empolyeeService.GetEmployeeDetailsByUserId(desktopSnapsDTO.CreatedBy);

            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;

            }
            else
            {
                EmployeeId = 0;
            }
            desktopSnapsDTO.EmployeeId = EmployeeId;
            if (desktopSnapsDTO.imageUpload != null)
            {
                FileInfo fileInfo = new FileInfo(desktopSnapsDTO.imageUpload.FileName);
                string extn = fileInfo.Extension.ToLower();
                Guid id = Guid.NewGuid();
                string filename = id.ToString() + extn;

                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, @"uploads\desktopsnaps\"+ EmployeeId+@"\"+ DateTime.Today.Date.ToString("dd-MMM-yyyy"));
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
                string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
                desktopSnapsDTO.imageUpload.CopyTo(new FileStream(imagePath, FileMode.Create));
                desktopSnapsDTO.SnapShot = uploadsFolder + uniqueFileName;
                if(fileInfo.Exists)
                {
                    desktopSnapsDTO.FileSize = fileInfo.Length;
                }
               
            }
            var a = _desktopSnapService.CreateDesktopSnaps(desktopSnapsDTO);


            return Ok(a);
        }
    }
}
