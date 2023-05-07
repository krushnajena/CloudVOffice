using CloudVOffice.Data.DTO.DesktopMonitoring;
using CloudVOffice.Services.DesktopMonitoring;
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
    public class DesktopActivityLogController : Controller
    {

        private readonly IDesktopActivityLogService _desktopActivityLogService;

        public DesktopActivityLogController(
            IDesktopActivityLogService desktopActivityLogService
        )
        {
            _desktopActivityLogService = desktopActivityLogService;

        }

        [HttpPost]
        public IActionResult ActivityLogWithFilter(DesktopLoginFilterDTO desktopLoginDTO)
        {
            try
            {
                var list = _desktopActivityLogService.GetAcivityLogsWithFilter(desktopLoginDTO);



                int totalRecords = list.Count();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return Accepted(new { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
