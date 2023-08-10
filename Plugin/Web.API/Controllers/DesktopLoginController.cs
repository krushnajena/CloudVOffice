using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Services.DesktopMonitoring;
using CloudVOffice.Services.Emp;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class DesktopLoginController : Controller
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

        [HttpPost]
        [Authorize]

        public IActionResult UpdateIdelTime(DesktopLoginIdelTimeUpdateDTO idelTimeUpdateDTO)
        {
            try
            {
                var a = _desktopLoginService.DesktopLoginUpdateIdelTime(idelTimeUpdateDTO);
                return Ok(a);
            }
            catch (Exception ex)
            {
                return Accepted(new { Status = "error", ResponseMsg = ex.Message });
            }
        }




    }
}
