using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Services.DesktopMonitoring;
using CloudVOffice.Services.Emp;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
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
    public class DesktopLoginController: Controller
    {


        private readonly IDesktoploginSevice _desktopLoginService;

        public DesktopLoginController(
            IDesktoploginSevice desktopLoginService
        )
        {
            _desktopLoginService = desktopLoginService;

        }

        [HttpPost]
        public IActionResult LoginSessionsWithFilter(DesktopLoginFilterDTO desktopLoginDTO)
        {
            try
            {
                var list = _desktopLoginService.GetDesktoplogins(desktopLoginDTO);



                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new { Status = "error", ResponseMsg = ex.Message });
            }
        }

    }
}
