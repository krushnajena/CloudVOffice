using CloudVOffice.Core.Domain.Attendance;
using CloudVOffice.Core.Domain.Common;
using CloudVOffice.Data.DTO.Attendance;
using CloudVOffice.Services.Attendance;
using CloudVOffice.Web.Framework;
using CloudVOffice.Web.Framework.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace HR.Attendance.Controllers
{
    [Area(AreaNames.Attendance)]
    public class AttendanceDeviceController : BasePluginController
    {
        private readonly IAttendanceDeviceService _attendanceDeviceService;
        public AttendanceDeviceController(IAttendanceDeviceService attendanceDeviceService)
        {

            _attendanceDeviceService = attendanceDeviceService;
        }
        [HttpGet]
        public IActionResult CreateAttendanceDevice(int? attendanceDeviceId)
        {
            AttendanceDeviceDTO attendanceDeviceDTO = new AttendanceDeviceDTO();

            if (attendanceDeviceId != null)
            {

                AttendanceDevice d = _attendanceDeviceService.GetAttendanceDeviceById(int.Parse(attendanceDeviceId.ToString()));

                attendanceDeviceDTO.DeviceName = d.DeviceName;
                attendanceDeviceDTO.DeviceSlNo = d.DeviceSlNo;


            }

            return View("~/Plugins/HR.Attendance/Views/AttendanceDevice/CreateAttendanceDevice.cshtml", attendanceDeviceDTO);

        }
        [HttpPost]

        public IActionResult CreateAttendanceDevice(AttendanceDeviceDTO attendanceDeviceDTO)
        {
            attendanceDeviceDTO.CreatedBy = (int)Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());


            if (ModelState.IsValid)
            {
                if (attendanceDeviceDTO.AttendanceDeviceId == null)
                {
                    var a = _attendanceDeviceService.CreateAttendanceDevice(attendanceDeviceDTO);
                    if (a == MessageEnum.Success)
                    {
                        TempData["msg"] = MessageEnum.Success;
                        return Redirect("/Attendance/AttendanceDevice/AttendanceDeviceView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "AttendanceDevice Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
                else
                {
                    var a = _attendanceDeviceService.AttendanceDeviceUpdate(attendanceDeviceDTO);
                    if (a == MessageEnum.Updated)
                    {
                        TempData["msg"] = MessageEnum.Updated;
                        return Redirect("/Attendance/AttendanceDevice/AttendanceDeviceView");
                    }
                    else if (a == MessageEnum.Duplicate)
                    {
                        TempData["msg"] = MessageEnum.Duplicate;
                        ModelState.AddModelError("", "AttendanceDevice Already Exists");
                    }
                    else
                    {
                        TempData["msg"] = MessageEnum.UnExpectedError;
                        ModelState.AddModelError("", "Un-Expected Error");
                    }
                }
            }


            return View("~/Plugins/HR.Attendance/Views/AttendanceDevice/CreateAttendanceDevice.cshtml", attendanceDeviceDTO);
        }
        public IActionResult AttendanceDeviceView()
        {
            ViewBag.AttendanceDevices = _attendanceDeviceService.GetAttendanceDeviceList();

            return View("~/Plugins/HR.Attendance/Views/AttendanceDevice/AttendanceDeviceView.cshtml");
        }

        [HttpGet]

        public IActionResult AttendanceDeviceDelete(int attendanceDeviceId)
        {
            Int64 DeletedBy = Int64.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserId").Value.ToString());

            var a = _attendanceDeviceService.AttendanceDeviceDelete(attendanceDeviceId, DeletedBy);
            TempData["msg"] = a;
            return Redirect("/Attendance/AttendanceDevice/AttendanceDeviceView");
        }

    }
}

