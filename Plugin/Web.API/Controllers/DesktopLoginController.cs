using CloudVOffice.Core.Domain.Users;
using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Services.DesktopMonitoring;
using CloudVOffice.Services.Emp;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Web.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class DesktopLoginController: Controller
    {


        private readonly IDesktoploginSevice _desktopLoginService;
        private readonly IEmployeeService _empolyeeService;

        public DesktopLoginController(
            IDesktoploginSevice desktopLoginService,
            IEmployeeService empolyeeService
        )
        {
            _desktopLoginService = desktopLoginService;
            _empolyeeService = empolyeeService;

        }

        [HttpPost]
        [Authorize]
        public IActionResult CreateDesktopLoginLog(DesktopLoginDTO desktopLoginDTO)
        {
            desktopLoginDTO.CreatedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());
            Int64 EmployeeId;
            var employee = _empolyeeService.GetEmployeeDetailsByUserId(desktopLoginDTO.CreatedBy);

            if (employee != null)
            {
                EmployeeId = employee.EmployeeId;

            }
            else
            {
                EmployeeId = 0;
            }
            desktopLoginDTO.EmployeeId = EmployeeId;
            var a = _desktopLoginService.DesktoploginCreate(desktopLoginDTO);


            return Ok(a);
        }

        [HttpPost]
        [Authorize]
        public IActionResult LoginSessionsWithFilter(DesktopLoginFilterDTO desktopLoginDTO)
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

                var list = _desktopLoginService.GetDesktoploginsWithDateRange(desktopLoginDTO);



                return Ok(list);
            }
            catch (Exception ex)
            {
                return Accepted(new { Status = "error", ResponseMsg = ex.Message });
            }
        }
       


    }
}
