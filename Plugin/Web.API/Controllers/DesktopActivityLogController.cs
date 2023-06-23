using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Services.DesktopMonitoring;
using CloudVOffice.Services.Emp;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    public class DesktopActivityLogController : Controller
    {

        private readonly IDesktopActivityLogService _desktopActivityLogService;
        private readonly IEmployeeService _empolyeeService;
        public DesktopActivityLogController(
            IDesktopActivityLogService desktopActivityLogService,
              IEmployeeService empolyeeService
        )
        {
            _desktopActivityLogService = desktopActivityLogService;
            _empolyeeService = empolyeeService;

        }

        [HttpPost]
        [Authorize]
        public IActionResult CreateActivityLog(DesktopActivityLogDTO desktopActivityLogDTO)
        {
            desktopActivityLogDTO.CreatedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _empolyeeService.GetEmployeeDetailsByUserId(desktopActivityLogDTO.CreatedBy);

            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;

            }
            else
            {
                EmployeeId = 0;
            }
            desktopActivityLogDTO.EmployeeId = EmployeeId;
            var a = _desktopActivityLogService.DesktopActivityLogCreate(desktopActivityLogDTO);


            return Ok(a);
        }

        [HttpPost]
        [Authorize]
        public IActionResult ActivityLogWithFilter(DesktopLoginFilterDTO desktopLoginDTO)
        {
            try
            {
                Int64 UserId = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

                Int64 EmployeeId;
                var employee = _empolyeeService.GetEmployeeDetailsByUserId(UserId);

                if (employee != null)
                {
                    EmployeeId = employee.EmployeeId;

                }
                else
                {
                    EmployeeId = 0;
                }
                desktopLoginDTO.EmployeeId = EmployeeId;
                var list = _desktopActivityLogService.GetAcivityLogsWithFilter(desktopLoginDTO);



         
                return Ok(list);
            }
            catch (Exception ex)
            {
                return Accepted(new { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
