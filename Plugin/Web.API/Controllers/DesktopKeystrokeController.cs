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
    public class DesktopKeystrokeController : Controller
    {
        private readonly IDesktopKeystrokeService _desktopActivityLogService;
        private readonly IEmployeeService _empolyeeService;
        public DesktopKeystrokeController(
            IDesktopKeystrokeService desktopActivityLogService,
              IEmployeeService empolyeeService
        )
        {
            _desktopActivityLogService = desktopActivityLogService;
            _empolyeeService = empolyeeService;

        }

        [HttpPost]
        [Authorize]
        public IActionResult CreateDesktopKeystroke(DesktopKeyStrokesDTO desktopActivityLogDTO)
        {
            desktopActivityLogDTO.CreatedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
         
            var a = _desktopActivityLogService.AddDesktopKeystrokes(desktopActivityLogDTO);


            return Ok(a);
        }
    }
}
